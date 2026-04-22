Option Explicit On
Module OOoTools

    Public OpenOffice As Object, StarDesktop As Object
    Public OOoIntrospection As Object, OOoDisp As Object


    Private Const OOoErrorN = 2000


    Function isNullEmpty(ByVal thisVariant As Object) As Boolean
        isNullEmpty = IsNothing(thisVariant) Or IsDBNull(thisVariant)
    End Function

    Function CreateUnoService(ByVal serviceName As String) As Object
        ' équivalent de la fonction OOoBasic  
        ' equivalent to OOoBasic function
        Dim Result As Object

        Result = OpenOffice.createInstance(serviceName)
        If isNullEmpty(Result) Then
            Err.Raise(vbObjectError + OOoErrorN, "OpenOffice", OOo_serviceKO & serviceName)
        End If
        CreateUnoService = Result
    End Function

    Function IsOpenOfficeConnected() As Boolean
        Dim DeskTopbis As Object

        IsOpenOfficeConnected = False
        If isNullEmpty(OpenOffice) Then Exit Function
        Try
            DeskTopbis = OpenOffice.createInstance("com.sun.star.frame.Desktop")
            DeskTopbis = Nothing
            IsOpenOfficeConnected = True
        Catch
            OpenOffice = Nothing
        End Try
    End Function

    Sub ConnectOpenOffice()
        If IsOpenOfficeConnected() Then Exit Sub
        Try
            OpenOffice = CreateObject("com.sun.star.ServiceManager")
        Catch
            OpenOffice = Nothing
        End Try
        If isNullEmpty(OpenOffice) Then
            Err.Raise(vbObjectError + OOoErrorN, "OpenOffice", OOo_connectKO)
        Else
            StarDesktop = CreateUnoService("com.sun.star.frame.Desktop")
            OOoIntrospection = CreateUnoService("com.sun.star.beans.Introspection")
            OOoDisp = CreateUnoService("com.sun.star.frame.DispatchHelper")
        End If
    End Sub

    Sub DisconnectOpenOffice(Optional ByVal closeOpenOffice As Boolean = False)
        ' release method inspired from http://www.xtremevbtalk.com/showthread.php?t=160433 
        ' this sequence tries to avoid error message R6025 from Visual C++ runtime
        OOoIntrospection = Nothing
        OOoDisp = Nothing
        StarDesktop = Nothing
        OpenOffice = Nothing
        GC.Collect() ' force garbage collection
        GC.WaitForPendingFinalizers() ' Wait for end of garbage collection before continuing
        GC.Collect() ' second pass of cleaning
        GC.WaitForPendingFinalizers()
        ' here no variable should be pointing at an OpenOffice object

        If closeOpenOffice Then
            ' reopen a connection only to close OpenOffice !
            Dim ooo As Object, dtp As Object
            ooo = CreateObject("com.sun.star.ServiceManager")
            dtp = ooo.createInstance("com.sun.star.frame.Desktop")
            ' this code may trigger error R6025 from C++ runtime
            ' this is avoided if you run the released code, not the debug code
            dtp.terminate()
            dtp = Nothing
            ooo = Nothing
        End If
    End Sub

    Function dummyArray() As Object
        ' crée un tableau vide, pour une liste vide 
        ' creates an empty array for an empty list
        Dim Result(-1) As Object
        dummyArray = Result
    End Function

    Function CreateUnoStruct(ByVal structName As String, _
                    Optional ByVal indexMax As Integer = -1) As Object
        ' équivalent de la fonction OOoBasic  
        ' equivalent to OOoBasic function
        '  indexMax = -1 returns one Uno structure
        '  indexMax >= 0 returns an array of Uno structure
        Dim d As Integer, Result As Object

        Try
            If indexMax < 0 Then
                Result = OpenOffice.Bridge_GetStruct(structName)
            Else
                ReDim Result(indexMax)
                For d = 0 To indexMax
                    Result(d) = OpenOffice.Bridge_GetStruct(structName)
                Next
            End If
        Catch
            Result = Nothing
        End Try
        If isNullEmpty(Result) Then Err.Raise(vbObjectError + OOoErrorN, "OpenOffice", OOo_structureKO & structName)
        CreateUnoStruct = Result
    End Function

    Function MakePropertyValue(ByVal PropName As String, ByVal PropValue As Object) As Object
        ' équivalent de la fonction de Danny Brewer
        ' equivalent to Danny Brewer's function
        Dim Result As Object

        Result = OpenOffice.Bridge_GetStruct("com.sun.star.beans.PropertyValue")
        Result.Name = PropName
        Result.Value = PropValue
        MakePropertyValue = Result
    End Function

    Function CreateProperties(ByVal ParamArray propertyList() As Object) As Object
        ' fonction plus puissante que MakePropertyValue  
        ' function more powerful than MakePropertyValue
        Dim x As Integer, xMax As Integer, y As Integer
        Dim Result() As Object

        xMax = UBound(propertyList)
        If ((xMax And 1) = 0) Or (xMax < 1) Then
            Err.Raise(vbObjectError + OOoErrorN, "OpenOffice", OOo_nbrArgsKO)
            CreateProperties = Nothing
        Else
            ReDim Result((xMax - 1) \ 2)
            x = 0
            y = 0
            Do
                Result(y) = OpenOffice.Bridge_GetStruct("com.sun.star.beans.PropertyValue")
                If VarType(propertyList(x)) <> vbString Then
                    Err.Raise(vbObjectError + OOoErrorN, "OpenOffice", OOo_argRank & x & OOo_notString)
                Else
                    Result(y).Name = propertyList(x)
                End If
                Result(y).Value = propertyList(x + 1)
                y = y + 1
                x = x + 2
            Loop Until x > xMax
            CreateProperties = Result
        End If
    End Function

    Function HasUnoInterfaces(ByVal thisObject As Object, _
                        ByVal ParamArray interfaceList() As String) As Boolean
        ' équivalent de la fonction OOoBasic  
        ' equivalent to the OOoBasic function
        Dim x As Integer, xMax As Integer, y As Integer, oneInterf As String
        Dim insp As Object, info1 As Object, info2 As Object, info3 As Object
        Dim intfExists() As Boolean

        HasUnoInterfaces = False
        xMax = UBound(interfaceList)
        ReDim intfExists(xMax) ' initial values : False
        Try
            insp = OOoIntrospection.inspect(thisObject)
            info1 = insp.getMethods(-1)
            For y = 0 To UBound(info1) ' scan all methods of the Uno object
                info2 = info1(y)
                info3 = info2.DeclaringClass
                oneInterf = info3.Name
                For x = 0 To xMax
                    If oneInterf = interfaceList(x) Then
                        intfExists(x) = True
                    End If
                Next
            Next
            For x = 0 To xMax ' check that all interfaces requested are available
                If Not intfExists(x) Then Exit Function
            Next
        Catch
            Err.Raise(vbObjectError + OOoErrorN, "OpenOffice", OOo_inspectionKO)
        End Try
        HasUnoInterfaces = True
    End Function

    Sub execDispatch(ByVal slotName As String, ByRef params() As Object)
        Dim myFrame As Object
        myFrame = StarDesktop.CurrentFrame
        OOoDisp.executeDispatch(myFrame, slotName, "", 0, params)
    End Sub

    Sub copyToClipboard()
        Call execDispatch(".uno:Copy", dummyArray)
    End Sub

    Sub pasteFromClipboard()
        Call execDispatch(".uno:Paste", dummyArray)
    End Sub

    Function ConvertToURL(ByVal winAddr As String) As String
        ' équivalent de la fonction OOoBasic  
        ' equivalent to the OOoBasic function
        Dim slow As String, prefix As String, UTF8Addr As String
        Dim x As Integer, sv As Object
        Dim URLprefix() As String = {"file:///", "ftp://", "news:", "http://", "mailto:", "macro:", "private:"}

        slow = LCase(winAddr)
        prefix = ""
        For x = 0 To UBound(URLprefix)
            If InStr(1, slow, URLprefix(x), vbBinaryCompare) = 1 Then
                winAddr = Mid(winAddr, Len(URLprefix(x)) + 1)
                If x > 0 Then prefix = URLprefix(x) ' prefix file:/// is useless
                Exit For
            End If
        Next
        If (Len(prefix) = 0) And (InStr(1, slow, "@", vbBinaryCompare) > 0) Then
            ConvertToURL = "mailto:" & winAddr
        Else
            sv = CreateUnoService("com.sun.star.ucb.FileContentProvider")
            UTF8Addr = sv.getFileURLFromSystemPath("", winAddr)
            If Len(UTF8Addr) = 0 Then Err.Raise(vbObjectError + OOoErrorN, "OpenOffice", OOo_convertToURLKO)
            ConvertToURL = prefix & UTF8Addr
        End If
    End Function

    Function ConvertFromURL(ByVal URLaddr As String) As String
        ' équivalent de la fonction OOoBasic  
        ' equivalent to the OOoBasic function
        Dim slow As String, prefix As String, winAddr As String
        Dim x As Integer, sv As Object
        Dim URLprefix() As String = {"file:///", "ftp://", "news:", "http://", "mailto:", "macro:", "private:"}

        slow = LCase(URLaddr)
        prefix = ""
        For x = 0 To UBound(URLprefix)
            If InStr(1, slow, URLprefix(x), vbBinaryCompare) = 1 Then
                If x > 0 Then
                    URLaddr = Mid(URLaddr, Len(URLprefix(x)) + 1)
                    prefix = URLprefix(x)
                End If
                Exit For
            End If
        Next
        sv = CreateUnoService("com.sun.star.ucb.FileContentProvider")
        winAddr = sv.getSystemPathFromFileURL(URLaddr)
        If Len(prefix) <> 0 Then ' backslash only with file:///
            winAddr = winAddr.Replace("\", "/")
        End If
        If Len(winAddr) = 0 Then Err.Raise(vbObjectError + OOoErrorN, "OpenOffice", OOo_convertFromURLKO)
        ConvertFromURL = prefix & winAddr
    End Function

    Function OOoRGB(ByVal redV As Integer, ByVal greenV As Integer, ByVal blueV As Integer) As Integer
        ' équivalent de la fonction OOoBasic : RGB() 
        ' ne pas utiliser  la fonction RGB() de VB  

        ' equivalent to the OOoBasic function : RGB()
        '  do not use RGB() function of VB
        OOoRGB = ((redV And 255) * 65536) + ((greenV And 255) * 256) + (blueV And 255)
    End Function

    Function Blue(ByVal colorOOo As Integer) As Integer
        ' équivalent de la fonction OOoBasic  
        ' equivalent to the OOoBasic function
        Blue = colorOOo And 255
    End Function

    Function Green(ByVal colorOOo As Integer) As Integer
        ' équivalent de la fonction OOoBasic  
        ' equivalent to the OOoBasic function
        Green = ((colorOOo And 65535) \ 256) And 255
    End Function

    Function Red(ByVal colorOOo As Integer) As Integer
        ' équivalent de la fonction OOoBasic  
        ' equivalent to the OOoBasic function
        Red = ((colorOOo And 16777215) \ 65536) And 255
    End Function

    Sub runBasicMacro(ByVal macroName As String, _
                    Optional ByVal argsList As String = "", _
                    Optional ByVal docName As String = "")
        ' macroName = Library.Module.Macro
        ' argsList = "" if no arguments
        ' docName = "" if the macro is in My Macros or in OpenOffice.org Macros

        execDispatch("macro://" & docName & "/" & macroName & "(" & argsList & ")", dummyArray)
        ' si la macro n'existe pas la routine s'exécute sans erreur
        ' if the macro does not exist the routine runs without error
    End Sub

    Function runScript(ByVal scriptName As String, ByRef argsList() As Object, _
                       Optional ByVal language As String = "Basic", _
                       Optional ByVal location As String = "user") As Object

        Dim mspf, scriptPro, xScript

        If (language = "Basic") And (location = "user") Then location = "application"
        mspf = CreateUnoService("com.sun.star.script.provider.MasterScriptProviderFactory")
        scriptPro = mspf.createScriptProvider("")
        xScript = scriptPro.getScript("vnd.sun.star.script:" & scriptName & _
                     "?language=" & language & "&location=" & location)
        runScript = xScript.Invoke(argsList, dummyArray, dummyArray)
    End Function

    Sub xray(ByRef myObject)
        ' vous devez avoir installé Xray dans OpenOffice ! 
        ' you must have installed Xray in OpenOffice !
        Dim arg1(0)

        arg1(0) = myObject
        Call runScript("XrayTool._Main.Xray", arg1)
    End Sub

End Module
