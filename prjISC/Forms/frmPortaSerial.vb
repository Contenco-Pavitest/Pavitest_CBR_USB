Imports System.Management

Public Class frmPortaSerial
    Inherits System.Windows.Forms.Form

#Region "DECLARAÇÕES"

    Dim strPortas(500) As String
    Dim strMatriz As String


    'Variável que carregara apenas o numero da porta serial
    Dim strPortaSerial As String


#End Region
    '////////////////////////////////////////////////////////////////
    '/////////////// CARREGANDO E DESCARRENDO FORMS /////////////////

#Region "CARREGANDO E DESCARRENDO FORMS"

    Private Sub frmPortaSerial_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            'Desabilita os comandos
            usrLayout.HabilitarComandos(False)

            lblPortaConectada.Text = "COM" & usrInicializacao.PORTA

            'Buscar portas COM do Gerenciador de Dispositivos
            Call BuscarPortasCOM()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("Evento_Load" & Chr(13) & ex.Message)
        End Try

    End Sub

    Public Sub BuscarPortasCOM()

        Dim mo As ManagementObject
        Dim ar As New ArrayList
        Dim ms As ManagementObjectSearcher
        Dim moReturn As ManagementObjectCollection
        Dim intcont As Integer

        Try
            'Reinicia a variável
            intcont = 0

            '--------------------------------------------------------------------------------------
            'Comando para filtrar todos os dispositivos no Windows (32 ou 64 bits)
            ms = New ManagementObjectSearcher("select * from Win32_PnPEntity")

            moReturn = ms.Get()

            For Each mo In moReturn
                ar.Add(mo("Name"))

                'Salva na matriz string cada valor encontrado
                strPortas(intcont) = ar.Item(intcont)

                If Not (mo.Properties.Item("Name").Value) = "" Then

                    'Filtra as portas 'COM XX'
                    If CStr(mo.Properties.Item("Name").Value).Contains("(COM") Then
                        ListBox1.Items.Add((CStr(mo.Properties.Item("Name").Value)))
                    End If
                End If

                'Contador
                intcont = intcont + 1
            Next
            '---------------------------------------------------------------------------------------

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("BuscarPortasCOM()" & Chr(13) & ex.Message)
        End Try

    End Sub

    Private Sub frmPortaSerial_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Try
            'Habilitar os comandos
            usrLayout.HabilitarComandos(True)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmPortaSerial_Load" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

    '////////////////////////////////////////////////////////////////
    '///////////////////// COMANDOS DE EXECUÇÃO /////////////////////

#Region "COMANDOS DE EXECUÇÃO - BUTTON"

    Private Sub btnCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancelar.Click

        Try
            'Habilita os comandos
            usrLayout.HabilitarComandos(True)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnCancelar_Click" & Chr(13) & ex.Message)

        Finally
            Me.Close()

        End Try

    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        

        Try
            'Porta
            If ListBox1.Text = "" Then Exit Sub

            'Atualizar comando
            usrInicializacao.PORTA = CInt(strPortaSerial)
            Call usrInicializacao.AtualizaDisco()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnOk_Click" & Chr(13) & ex.Message)

        Finally
            'Habilitar os comandos
            usrLayout.HabilitarComandos(True)
            Me.Close()

        End Try

    End Sub

    Private Sub btnAtualizarLista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAtualizarLista.Click
        ListBox1.Items.Clear()
        Call BuscarPortasCOM()
    End Sub

    Private Sub cmbPorta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim intTamanho As Integer = 0
        Dim intTamanho2 As Integer = 0
        Dim strCortaDescricao As String = ""

        strMatriz = ListBox1.Text

        'Evitar erro de clicar em uma parte vazia do listbox
        If strMatriz = Nothing Then Exit Sub

        intTamanho = strMatriz.Length

        Dim intPosicaoCorte As Integer = 0
        Dim intPosicaoParentesis As Integer = 0

        'BLOCO PARA TESTE - PEGA SOMENTE OS NUMEROS DENTRO DA STRING
        '------------------------------------------------------------------------------------------------------
        'Pega somente parte numérica da string 
        'Resultado = String.Join(Nothing, System.Text.RegularExpressions.Regex.Split(strMatriz, "[^\d]"))
        '------------------------------------------------------------------------------------------------------


        'BLOCO PARA TESTE - VARRE CARACTERE POR CARACTERE DA STRING E SEPARA DE ACORDO COM A CONDIÇÃO DO IF
        '------------------------------------------------------------------------------------------------------
        'Dim Resultado As String = ""

        'Dim myChars() As Char = strMatriz.ToCharArray()
        'For Each ch As Char In myChars
        '    If Char.IsNumber(ch) Or ch.ToString.Contains("(") Or ch.ToString.Contains(")") Then
        '        Resultado += ch
        '    End If
        'Next
        '-------------------------------------------------------------------------------------------------------

        Dim mychar1() As Char = strMatriz.ToCharArray()
        For i = 0 To (intTamanho - 1)
            If mychar1(i).ToString.Contains("(") Then
                'Pega posição do '(' abre parêntesis
                intPosicaoParentesis = i
            End If
        Next

        'Conta a posição para acrescentar ao corte caracteres '(COM '
        intPosicaoCorte = intPosicaoParentesis + 4

        'Corta a descrição da porta + os caracteres '(COM '
        strCortaDescricao = strMatriz.Substring(intPosicaoCorte, (intTamanho - intPosicaoCorte))

        'Pega o tamanho dessa substring nova
        intTamanho2 = strCortaDescricao.Length

        'Pega o número exato da porta selecionada
        strPortaSerial = strCortaDescricao.Remove(intTamanho2 - 1, 1)

        '-----------------------------------------------------------
        lblPortaConectada.Text = "COM" & strPortaSerial
        '-----------------------------------------------------------

    End Sub

#End Region

End Class