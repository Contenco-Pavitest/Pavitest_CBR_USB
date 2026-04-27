Imports System.Data.OleDb
Imports System.IO

Public Class frmRelatorio

#Region "Declaração de objetos"

    'Criar objeto Report
    Dim cryEnsaios As New rptEnsaios
    Dim cryListagem As New rptListagem
    Dim cryResultados As New rptResultados


    Public dblTensao As Double
    Public strCondicao As String

#End Region

    '//////////////////////////////////////////////////////////////////
    '////////////////// CARREGANDO E DESCARRENDO FORMS ////////////////

#Region "CARREGANDO E DESCARRENDO FORMS"

    Private Sub CrystalReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cryViewer.Load

        Try
            Call AjusteUnidadeMedida()

            'Chamar a rotina para carregar os valores dos campos
            Select Case intRelatorio
                Case rpt_ENSAIOS
                    'Carregar imagens
                    cryEnsaios.SetDataSource(CarregarImagem(True, True))
                    'Carregar dados da amostra
                    Call CarregarDadosAmostra()
                    'Carregar dados do c.p.
                    Call CarregarDadosCP()
                    'Fazer o vínculo com o "Relatório.rpt"
                    cryViewer.ReportSource = cryEnsaios

                Case rpt_LISTAGEM
                    'Carregar imagens
                    cryListagem.SetDataSource(CarregarImagem(True, False))
                    'Carregar os dados da listagem
                    Call ListarDadosAmostra()
                    'Fazer o vínculo com o "Relatório.rpt"
                    cryViewer.ReportSource = cryListagem


                Case rpt_RESULTADOS
                    'Carregar imagens
                    cryResultados.SetDataSource(CarregarImagem(True, True))
                    'Carregar os dados da listagem
                    Call ListarDadosCP()
                    'Carregar dados da amostra
                    Call CarregarDadosAmostra()

                    'Fazer o vínculo com o "Relatório.rpt"
                    cryViewer.ReportSource = cryResultados

            End Select

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("CrystalReport_Load" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

    '//////////////////////////////////////////////////////////////////
    '/////////////////// FUNÇÕES E PROCEDIMENTOS //////////////////////

#Region "FUNÇÕES E PROCEDIMENTOS - IMAGEM"

    Public Function CarregarImagem(ByVal blnLogotipo As Boolean, ByVal blnGrafico As Boolean) As dtsTabelas
        'Criar uma nova instância do Dataset
        Dim dstObjeto As New dtsTabelas
        'Criar uma nova linha do Dataset
        Dim dstRow As dtsTabelas.dttImagensRow = dstObjeto.dttImagens.NewdttImagensRow
        Dim strEndereco As String

        Try

            strEndereco = My.Application.Info.DirectoryPath

            If blnLogotipo Then dstRow.Logotipo = AbrirImagem(strEndereco & "\Imagens\Logotipo.jpg")
            If intRelatorio = rpt_ENSAIOS Then
                If blnGrafico Then dstRow.Grafico = AbrirImagem(strEndereco & "\Imagens\Grafico.bmp")
            ElseIf intRelatorio = rpt_RESULTADOS Then
                If blnGrafico Then dstRow.Grafico = AbrirImagem(strEndereco & "\Imagens\Grafico.bmp")
                If blnGrafico Then dstRow.Grafico1 = AbrirImagem(strEndereco & "\Imagens\Grafico1.bmp")
                If blnGrafico Then dstRow.Grafico2 = AbrirImagem(strEndereco & "\Imagens\Grafico2.bmp")
                If blnGrafico Then dstRow.Grafico3 = AbrirImagem(strEndereco & "\Imagens\Grafico3.bmp")
            End If

            'Incluir a nova linha
            dstObjeto.dttImagens.Rows.Add(dstRow)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("CarregarImagens" & Chr(13) & ex.Message)

        Finally
            'Usar o dataset como fonte de dados para o relatório
            CarregarImagem = dstObjeto

        End Try

    End Function

    Private Function AbrirImagem(ByVal strEndereco As String) As Byte()

        Dim flStream As FileStream = New FileStream(strEndereco, FileMode.Open, FileAccess.Read)
        Dim bnrReader As BinaryReader = New BinaryReader(flStream)

        Return (bnrReader.ReadBytes(Convert.ToInt32(bnrReader.BaseStream.Length)))

    End Function

#End Region

#Region "FUNÇÕES E PROCEDIMENTOS -  DADOS DA AMOSTRA"

    Public Sub CarregarDadosAmostra()
        Dim strSql As String
        Dim odbReader As OleDbDataReader
        Dim strTitulo As String
        Dim strTipo As String

        strTitulo = ""
        strTipo = ""

        Try
            'Selecionar os dados da amostra 
            strSql = "SELECT * FROM [tblAmostra] WHERE IdAmostra = " & intIdAmostra

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)
            'Leitura
            Call odbReader.Read()

            'Atribuir os valores para os respectivos campos via parâmetro

            If intRelatorio = rpt_ENSAIOS Then
                With cryEnsaios
                    'Dados cadastrais da amostra
                    If Not IsDBNull(odbReader("Nome".ToString)) Then .SetParameterValue("NomeAmostra", odbReader("Nome".ToString)) Else .SetParameterValue("NomeAmostra", "")
                    If Not IsDBNull(odbReader("Cliente")) Then .SetParameterValue("Cliente", odbReader("Cliente")) Else .SetParameterValue("Cliente", "")
                    If Not IsDBNull(odbReader("Obra")) Then .SetParameterValue("Obra", odbReader("Obra")) Else .SetParameterValue("Obra", "")
                    If Not IsDBNull(odbReader("LocalAmostra")) Then .SetParameterValue("Local", odbReader("LocalAmostra")) Else .SetParameterValue("Local", "")
                    If Not IsDBNull(odbReader("TipoMaterial")) Then .SetParameterValue("TipoMaterial", odbReader("TipoMaterial")) Else .SetParameterValue("TipoMaterial", "")
                    If Not IsDBNull(odbReader("Operador")) Then .SetParameterValue("Operador", odbReader("Operador")) Else .SetParameterValue("Operador", "")
                    If Not IsDBNull(odbReader("Responsavel")) Then .SetParameterValue("Responsavel", odbReader("Responsavel")) Else .SetParameterValue("Responsavel", "")

                    If Not IsDBNull(odbReader("TituloCampoExtra")) Then .SetParameterValue("TituloExtra1", odbReader("TituloCampoExtra")) Else .SetParameterValue("TituloExtra1", "")
                    If Not IsDBNull(odbReader("ValorCampoExtra")) Then .SetParameterValue("ValorExtra1", odbReader("ValorCampoExtra")) Else .SetParameterValue("ValorExtra1", "")

                    If Not IsDBNull(odbReader("TituloCampoExtra2")) Then .SetParameterValue("TituloExtra2", odbReader("TituloCampoExtra2")) Else .SetParameterValue("TituloExtra2", "")
                    If Not IsDBNull(odbReader("ValorCampoExtra2")) Then .SetParameterValue("ValorExtra2", odbReader("ValorCampoExtra2")) Else .SetParameterValue("ValorExtra2", "")

                    If Not IsDBNull(odbReader("Data")) Then .SetParameterValue("Data", odbReader("Data")) Else .SetParameterValue("Data", "")
                    If Not IsDBNull(odbReader("Compactacao")) Then .SetParameterValue("Compactacao", odbReader("Compactacao")) Else .SetParameterValue("Compactacao", "")
                End With
            End If

            If intRelatorio = rpt_RESULTADOS Then
                With cryResultados
                    'Dados cadstrais da amostra
                    If Not IsDBNull(odbReader("Nome".ToString)) Then .SetParameterValue("NomeAmostra", odbReader("Nome".ToString)) Else .SetParameterValue("NomeAmostra", "")
                    If Not IsDBNull(odbReader("Cliente")) Then .SetParameterValue("Cliente", odbReader("Cliente")) Else .SetParameterValue("Cliente", "")
                    If Not IsDBNull(odbReader("Obra")) Then .SetParameterValue("Obra", odbReader("Obra")) Else .SetParameterValue("Obra", "")
                    If Not IsDBNull(odbReader("LocalAmostra")) Then .SetParameterValue("Local", odbReader("LocalAmostra")) Else .SetParameterValue("Local", "")
                    If Not IsDBNull(odbReader("TipoMaterial")) Then .SetParameterValue("TipoMaterial", odbReader("TipoMaterial")) Else .SetParameterValue("TipoMaterial", "")
                    If Not IsDBNull(odbReader("Operador")) Then .SetParameterValue("Operador", odbReader("Operador")) Else .SetParameterValue("Operador", "")
                    If Not IsDBNull(odbReader("Responsavel")) Then .SetParameterValue("Responsavel", odbReader("Responsavel")) Else .SetParameterValue("Responsavel", "")

                    If Not IsDBNull(odbReader("TituloCampoExtra")) Then .SetParameterValue("TituloExtra1", odbReader("TituloCampoExtra")) Else .SetParameterValue("TituloExtra1", "")
                    If Not IsDBNull(odbReader("ValorCampoExtra")) Then .SetParameterValue("ValorExtra1", odbReader("ValorCampoExtra")) Else .SetParameterValue("ValorExtra1", "")

                    If Not IsDBNull(odbReader("TituloCampoExtra2")) Then .SetParameterValue("TituloExtra2", odbReader("TituloCampoExtra2")) Else .SetParameterValue("TituloExtra2", "")
                    If Not IsDBNull(odbReader("ValorCampoExtra2")) Then .SetParameterValue("ValorExtra2", odbReader("ValorCampoExtra2")) Else .SetParameterValue("ValorExtra2", "")

                    If Not IsDBNull(odbReader("Data")) Then .SetParameterValue("Data", odbReader("Data")) Else .SetParameterValue("Data", "")
                    If Not IsDBNull(odbReader("Compactacao")) Then .SetParameterValue("Compactacao", odbReader("Compactacao")) Else .SetParameterValue("Compactacao", "")
                End With

            End If

            'Fechar leitura
            odbReader.Close()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("CarregarDadosAmostra" & Chr(13) & ex.Message)

        End Try

    End Sub

    Public Sub ListarDadosAmostra()
        Dim strSql As String
        Dim odbAdaptador As OleDbDataAdapter
        Dim tblTable As DataTable

        Try
            'Selecionar os dados da amostra 
            strSql = "SELECT * FROM [tblAmostra] ORDER BY Data DESC"

            'Criar o comando Adaptador
            odbAdaptador = New OleDbDataAdapter(strSql, oConnection)
            tblTable = New DataTable
            odbAdaptador.Fill(tblTable)

            'Link para a barra de ferramentas
            cryListagem.SetDataSource(tblTable)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ListarDadosAmostra" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

#Region "FUNÇÕES E PROCEDIMENTOS - DADOS DO CP"

    Public Sub CarregarDadosCP()
        Dim strSql As String
        Dim odbReader As OleDbDataReader

        Dim strResultado As String
        Dim strFigura As String
        Dim dblModulo As Double

        strResultado = ""
        strFigura = ""
        dblModulo = 0

        Try
            'Selecionar os dados do corpo de prova
            strSql = "SELECT * FROM [tblCPs] " _
                & "WHERE IdAmostra = " & intIdAmostra & " AND IdCP = " & intIdCP

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)
            'Leitura
            Call odbReader.Read()

            If intRelatorio = rpt_ENSAIOS Then
                'Atribuir os valores para os respectivos campos via parâmetro
                With cryEnsaios
                    'Dados cadstrais do corpo de prova
                    If Not IsDBNull(odbReader("Cilindro".ToString)) Then .SetParameterValue("Cilindro", odbReader("Cilindro".ToString)) Else .SetParameterValue("Cilindro", "")
                    If Not IsDBNull(odbReader("Capsula".ToString)) Then .SetParameterValue("Capsula", odbReader("Capsula".ToString)) Else .SetParameterValue("Capsula", "")
                    If Not IsDBNull(odbReader("Peso".ToString)) Then .SetParameterValue("Peso", odbReader("Peso".ToString)) Else .SetParameterValue("Peso", "")
                    If Not IsDBNull(odbReader("Volume".ToString)) Then .SetParameterValue("Volume", odbReader("Volume".ToString)) Else .SetParameterValue("Volume", "")
                    If Not IsDBNull(odbReader("Altura".ToString)) Then .SetParameterValue("Altura", odbReader("Altura".ToString)) Else .SetParameterValue("Altura", "")


                    If Not IsDBNull(odbReader("ISC1".ToString)) Then .SetParameterValue("ISC1", FormatNumber(odbReader("ISC1".ToString), 2)) Else .SetParameterValue("ISC1", "")
                    If Not IsDBNull(odbReader("ISC2".ToString)) Then .SetParameterValue("ISC2", FormatNumber(odbReader("ISC2".ToString), 2)) Else .SetParameterValue("ISC2", "")

                    If blnMudouUnidadeMPa = True Then
                        ' Mudar unidade 'Calculada' (MPa)
                        .SetParameterValue("txtCalculada", "(MPa)")

                        If Not IsDBNull(odbReader("PCalculada1".ToString)) Then .SetParameterValue("PCalculada1", FormatNumber(odbReader("PCalculada1".ToString) * 0.1, 2)) Else .SetParameterValue("PCalculada1", "") 'Admite-se 1 kgf/cm² = 0,1 MPa
                        If Not IsDBNull(odbReader("PCalculada2".ToString)) Then .SetParameterValue("PCalculada2", FormatNumber(odbReader("PCalculada2".ToString) * 0.1, 2)) Else .SetParameterValue("PCalculada2", "")
                        ' Mudar unidade 'Corrigida' (MPa)
                        .SetParameterValue("txtCorrigida", "(MPa)")
                        If Not IsDBNull(odbReader("PCorrigida1".ToString)) Then .SetParameterValue("PCorrigida1", FormatNumber(odbReader("PCorrigida1".ToString) * 0.1, 2)) Else .SetParameterValue("PCorrigida1", "")
                        If Not IsDBNull(odbReader("PCorrigida2".ToString)) Then .SetParameterValue("PCorrigida2", FormatNumber(odbReader("PCorrigida2".ToString) * 0.1, 2)) Else .SetParameterValue("PCorrigida2", "")
                        ' Mudar unidade 'Padrão' (MPa)

                        .SetParameterValue("txtPadrao", "(MPa)")
                        .SetParameterValue("PPadrao1", "6,90")
                        .SetParameterValue("PPadrao2", "10,35")
                    Else
                        ' Mudar unidade 'Calculada' (kgf/cm²)
                        .SetParameterValue("txtCalculada", "(kgf/cm²)")
                        If Not IsDBNull(odbReader("PCalculada1".ToString)) Then .SetParameterValue("PCalculada1", FormatNumber(odbReader("PCalculada1".ToString), 2)) Else .SetParameterValue("PCalculada1", "")
                        If Not IsDBNull(odbReader("PCalculada2".ToString)) Then .SetParameterValue("PCalculada2", FormatNumber(odbReader("PCalculada2".ToString))) Else .SetParameterValue("PCalculada2", "")
                        ' Mudar unidade 'Corrigida' (kgf/cm²)
                        .SetParameterValue("txtCorrigida", "(kgf/cm²)")
                        If Not IsDBNull(odbReader("PCorrigida1".ToString)) Then .SetParameterValue("PCorrigida1", FormatNumber(odbReader("PCorrigida1".ToString), 2)) Else .SetParameterValue("PCorrigida1", "")
                        If Not IsDBNull(odbReader("PCorrigida2".ToString)) Then .SetParameterValue("PCorrigida2", FormatNumber(odbReader("PCorrigida2".ToString), 2)) Else .SetParameterValue("PCorrigida2", "")
                        ' Mudar unidade 'Padrão' (kgf/cm²)
                        .SetParameterValue("txtPadrao", "(kgf/cm²)")
                        .SetParameterValue("PPadrao1", "70,30")
                        .SetParameterValue("PPadrao2", "105,20")
                    End If

                End With
            End If

            If intRelatorio = rpt_RESULTADOS Then
                'Atribuir os valores para os respectivos campos via parâmetro
                With cryResultados
                    'Dados cadstrais do corpo de prova
                    If Not IsDBNull(odbReader("Cilindro".ToString)) Then .SetParameterValue("Cilindro", odbReader("Cilindro".ToString)) Else .SetParameterValue("Cilindro", "")
                    If Not IsDBNull(odbReader("Capsula".ToString)) Then .SetParameterValue("Capsula", odbReader("Capsula".ToString)) Else .SetParameterValue("Capsula", "")
                    If Not IsDBNull(odbReader("Peso".ToString)) Then .SetParameterValue("Peso", odbReader("Peso".ToString)) Else .SetParameterValue("Peso", "")
                    If Not IsDBNull(odbReader("Volume".ToString)) Then .SetParameterValue("Volume", odbReader("Volume".ToString)) Else .SetParameterValue("Volume", "")
                    If Not IsDBNull(odbReader("Altura".ToString)) Then .SetParameterValue("Altura", odbReader("Altura".ToString)) Else .SetParameterValue("Altura", "")

                    'Resultados
                    If Not IsDBNull(odbReader("PCalculada1".ToString)) Then .SetParameterValue("PCalculada1", odbReader("PCalculada1".ToString)) Else .SetParameterValue("PCalculada1", "")
                    If Not IsDBNull(odbReader("PCalculada2".ToString)) Then .SetParameterValue("PCalculada2", odbReader("PCalculada2".ToString)) Else .SetParameterValue("PCalculada2", "")
                    If Not IsDBNull(odbReader("PCorrigida1".ToString)) Then .SetParameterValue("PCorrigida1", odbReader("PCorrigida1".ToString)) Else .SetParameterValue("PCorrigida1", "")
                    If Not IsDBNull(odbReader("PCorrigida2".ToString)) Then .SetParameterValue("PCorrigida2", odbReader("PCorrigida2".ToString)) Else .SetParameterValue("PCorrigida2", "")
                    If Not IsDBNull(odbReader("ISC1".ToString)) Then .SetParameterValue("ISC1", odbReader("ISC1".ToString)) Else .SetParameterValue("ISC1", "")
                    If Not IsDBNull(odbReader("ISC2".ToString)) Then .SetParameterValue("ISC2", odbReader("ISC2".ToString)) Else .SetParameterValue("ISC2", "")

                End With
            End If

            'Fechar leitura
            odbReader.Close()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("CarregarDadosCP" & Chr(13) & ex.Message)

        End Try

    End Sub

    'O problema está aqui
    Public Sub ListarDadosCP()
        Dim strSql As String
        Dim strSql2 As String
        Dim odbAdaptador As OleDbDataAdapter
        Dim tblTable As DataTable
        Dim odbReader As OleDbDataReader

        Try
            'Selecionar os dados do corpo de prova
            strSql2 = "SELECT * FROM [tblCPs] " _
                & "WHERE IdAmostra = " & intIdAmostra & " AND IdCP = " & intIdCP

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql2)
            'Leitura
            Call odbReader.Read()

            If odbReader("ISC1") > odbReader("ISC2") Then
                'Selecionar os dados da amostra 
                strSql = "SELECT IdCP, Cilindro, MassaSeca, Expansao, Umidade, ISC1 " _
                    & " FROM [tblCPs] " _
                    & "WHERE IdAmostra = " & intIdAmostra & " " & strCondicao & " ORDER BY IdCP"
            Else
                'Selecionar os dados da amostra 
                strSql = "SELECT IdCP, Cilindro, MassaSeca, Expansao, Umidade, ISC2 " _
                    & " FROM [tblCPs] " _
                    & "WHERE IdAmostra = " & intIdAmostra & " " & strCondicao & " ORDER BY IdCP"
            End If

            'Criar o comando Adaptador
            odbAdaptador = New OleDbDataAdapter(strSql, oConnection)
            tblTable = New DataTable
            odbAdaptador.Fill(tblTable)

            'Link para a barra de ferramentas
            cryResultados.SetDataSource(tblTable)

            'Verificação para caso a coluna não tiver nenhum valor, não apresentar o título dela no relatório
            SetTituloSeColunaTemValor(tblTable, "MassaSeca", "TituloMassa", "Massa Esp. Ap. S. (g/cm³)")
            SetTituloSeColunaTemValor(tblTable, "Umidade", "TituloTeor", "Teor de Umidade (%)")
            SetTituloSeColunaTemValor(tblTable, "Expansao", "TituloExpansao", "Expansão (%)")
        Catch ex As Exception
            'Mensagem de erro
            MsgBox("ListarDadosCP" & Chr(13) & ex.Message)

        End Try

    End Sub

    'Private Sub frmRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Try
    '        Select Case intRelatorio
    '            Case rpt_ENSAIOS

    '                cryEnsaios.SetDataSource(CarregarImagem(True, True))
    '                Call CarregarDadosCP()
    '                Call CarregarDadosAmostra()
    '                cryViewer.ReportSource = cryEnsaios

    '            Case rpt_LISTAGEM
    '                'Carregar imagens
    '                cryListagem.SetDataSource(CarregarImagem(True, True))
    '                CarregarDadosListagem()
    '                cryViewer.ReportSource = cryListagem

    '            Case rpt_RESULTADOS
    '                'Carregar imagens
    '                cryResultados.SetDataSource(CarregarImagem(True, True))
    '                Call CarregarDadosCpResultados()
    '                Call CarregarDadosAmostra()
    '                Call CalcularResultado()

    '                'Fazer o vínculo com o "Relatório.rpt"
    '                cryViewer.ReportSource = cryResultados

    '        End Select
    '    Catch ex As Exception
    '        'Mensagem de erro
    '        MsgBox("frmRelatorio_Load" & Chr(13) & ex.Message)
    '    End Try
    'End Sub
    Public Sub CarregarDadosCpResultados()
        Dim strSql As String
        Dim tblTable As DataTable
        Dim odbAdaptador As OleDbDataAdapter

        Try

            'Selecionar os dados do corpo de prova
            strSql = "SELECT NomeCP, Area, CargaMax, TensaoMax, DeslocamentoMax FROM tblCPs " _
                & "WHERE idAmostra= " & intIdAmostra & " " & strCondicao & " ORDER BY IdCP"

            odbAdaptador = New OleDbDataAdapter(strSql, oConnection)
            tblTable = New DataTable
            odbAdaptador.Fill(tblTable)

            'Link para a barra de ferramentas
            cryResultados.SetDataSource(tblTable) 'SetDataSource(tblTable)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("CarregarDadosCP" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub CalcularResultado()
        Dim strSql As String
        Dim odbReader As OleDbDataReader
        Dim mediaCargaMax As Double
        Dim mediaTensaoMax As Double
        Dim mediaDeslocamentoMax As Double

        strSql = "SELECT AVG(CargaMax) AS MediaCarga, AVG(TensaoMax) AS MediaTensao, AVG(DeslocamentoMax) As MediaDeslocamento FROM tblCPs WHERE idAmostra=" & intIdAmostra & " " & strCondicao
        odbReader = usrConexao.ComandoLeitura(strSql)
        'Leitura
        While (odbReader.Read())
            mediaCargaMax = odbReader(0)
            mediaTensaoMax = odbReader(1)
            mediaDeslocamentoMax = odbReader(2)
        End While
        With cryResultados
            .SetParameterValue("Media Carga", mediaCargaMax)
            .SetParameterValue("Media Tensao", mediaTensaoMax)
            .SetParameterValue("Media Deslocamento", mediaDeslocamentoMax)
            .SetParameterValue("Titulo", "Relatório de Resultados da Amostra")
        End With

        odbReader.Close()
    End Sub
    Public Sub CarregarDadosListagem()
        Dim strSql As String
        Dim tblTable As DataTable
        Dim odbAdaptador As OleDbDataAdapter

        Try

            'Selecionar os dados do corpo de prova
            strSql = "SELECT IdAmostra, NomeAmostra, Responsavel, Cliente, TipoMaterial, QteCPs " _
                & "FROM tblAmostra ORDER BY NomeAmostra"

            odbAdaptador = New OleDbDataAdapter(strSql, oConnection)
            tblTable = New DataTable
            odbAdaptador.Fill(tblTable)

            'Link para a barra de ferramentas
            cryListagem.SetDataSource(tblTable) 'SetDataSource(tblTable)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("CarregarDadosListagem" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Function ColunaTemValor(tbl As DataTable, nomeColuna As String) As Boolean

        For Each row As DataRow In tbl.Rows
            If Not IsDBNull(row(nomeColuna)) AndAlso row(nomeColuna).ToString.Trim() <> "" Then
                Return True
            End If
        Next

        Return False

    End Function


    Private Sub SetTituloSeColunaTemValor(tbl As DataTable, nomeColuna As String, nomeParametro As String, titulo As String)

        If ColunaTemValor(tbl, nomeColuna) Then
            cryResultados.SetParameterValue(nomeParametro, titulo)
        Else
            cryResultados.SetParameterValue(nomeParametro, "")
        End If

    End Sub

    Private Sub AjusteUnidadeMedida()
        Try
            Dim strSql As String
            Dim odbReader As OleDbDataReader

            strSql = "SELECT TipoEnsaio FROM tblAmostra WHERE idAmostra=" & intIdAmostra
            odbReader = usrConexao.ComandoLeitura(strSql)
            odbReader.Read()

            If Not IsDBNull(odbReader("TipoEnsaio".ToString)) AndAlso odbReader("TipoEnsaio".ToString) = "DNIT 172 - ME" Then
                blnMudouUnidadeMPa = False
                Dim NORMA = odbReader("TipoEnsaio".ToString)
            Else
                blnMudouUnidadeMPa = True
            End If

        Catch ex As Exception
            MsgBox("AjusteUnidadeMedida" & Chr(13) & ex.Message)
        End Try
    End Sub

#End Region

End Class