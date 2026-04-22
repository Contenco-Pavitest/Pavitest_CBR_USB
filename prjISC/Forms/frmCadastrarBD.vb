'Cadastrar Base de Dados e as Tabelas

Option Strict Off
Option Explicit On

Imports System.Data.OleDb
Imports System.IO.File

Friend Class frmCadastrarBD

#Region "Declaração de variáveis"

    'Variáveis de Controle
    Dim blnEditar As Boolean
    Dim blnSelecionado As Boolean

#End Region

    '////////////////////////////////////////////////////////////////
    '/////////////// CARREGANDO E DESCARRENDO FORMS /////////////////

#Region "CARREGAR E DESCARREGAR FORMS"

    Private Sub frmCadastrarBD_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim intTamanho1 As Integer
        Dim intTamanho2 As Integer

        Try
            'Setar classe
            usrConexao = New clsConexao
            usrLicença = New clsLicença

            'Desabilitar comandos
            usrLayout.HabilitarComandos(False)

            'Maximizar mdi principal
            mdiPrincipal.WindowState = FormWindowState.Maximized

            'Verifica os tamanhos das partes das strings
            intTamanho1 = usrInicializacao.ENDERECO_P1.Length
            intTamanho2 = usrInicializacao.ENDERECO_P2.Length

            '------------------------------
            'Caminho da Base de Dados
            '------------------------------
            'Verifica se o primeiro caractere da segunda parte da string é uma '?' adicionada propositalmente devido ao espaço " " no nome da pasta que ficou antes
            If usrInicializacao.ENDERECO_P1.Substring(intTamanho1 - 1, 1) = "?" Then
                'Corta o caractere "?" e concatena um espaço " " entre a primeira e a segunda parte da string
                lstDiretorio.Path = usrInicializacao.ENDERECO_P1.Substring(0, 98) & " " & usrInicializacao.ENDERECO_P2
                lstFile.Path = usrInicializacao.ENDERECO_P1.Substring(0, 98) & " " & usrInicializacao.ENDERECO_P2
                strCaminho = usrInicializacao.ENDERECO_P1.Substring(0, 98) & " " & usrInicializacao.ENDERECO_P2
                strBaseDados = ""
            ElseIf (intTamanho2 <> 0) Then 'Verifica se a segunda parte está vazia
                'Verifica se o primeiro caractere da segunda parte da string é uma '?' adicionada propositalmente devido ao espaço no nome da pasta que ficou depois
                If (usrInicializacao.ENDERECO_P2.Substring(0, 1) = "?") Then
                    'Corta o caractere "?" e concatena um espaço " " entre a primeira e a segunda parte da string
                    lstDiretorio.Path = usrInicializacao.ENDERECO_P1 & " " & usrInicializacao.ENDERECO_P2.Substring(1, intTamanho2 - 1)
                    lstFile.Path = usrInicializacao.ENDERECO_P1 & " " & usrInicializacao.ENDERECO_P2.Substring(1, intTamanho2 - 1)
                    strCaminho = usrInicializacao.ENDERECO_P1 & " " & usrInicializacao.ENDERECO_P2.Substring(1, intTamanho2 - 1)
                    strBaseDados = ""
                Else 'Caso o caminho seja MAIOR que 99 caracteres, mas o nome da pasta não tenha nenhum espaço
                    lstDiretorio.Path = usrInicializacao.ENDERECO_P1 & usrInicializacao.ENDERECO_P2
                    lstFile.Path = usrInicializacao.ENDERECO_P1 & usrInicializacao.ENDERECO_P2
                    strCaminho = usrInicializacao.ENDERECO_P1 & usrInicializacao.ENDERECO_P2
                    strBaseDados = ""
                End If
            Else 'Caso o caminho seja MENOR que 99 caracteres (parte 2 da string vazia)
                lstDiretorio.Path = usrInicializacao.ENDERECO_P1 & usrInicializacao.ENDERECO_P2
                lstFile.Path = usrInicializacao.ENDERECO_P1 & usrInicializacao.ENDERECO_P2
                strCaminho = usrInicializacao.ENDERECO_P1 & usrInicializacao.ENDERECO_P2
                strBaseDados = ""
            End If

            'Habilitar os comandos 
            Call HabilitarComandos(True, False, False, False, True)
            'Desabilitar campos
            Call HabilitarCampos(False, False, False, True)

        Catch ex As Exception

            'Mensagem de erro
            MsgBox("frmCadastrarBD_Load" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub frmCadastrarBD_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        Try
            'Habilitar comandos
            usrLayout.HabilitarComandos(True)

            'Verificar banco de dados selecionado
            If strBaseDados <> Nothing Then blnSelecionado = True

            If blnSelecionado = True Then
                'Habilita o recurso de visualização e cadastro de amostras
                usrLayout.HabilitarAmostras(True)

                '------------------------------------
                'Gravar último endereço de acesso
                '------------------------------------

                'Verifica se o tamanho do caminho do diretório é maior que 99
                If (strCaminho.Length) >= 99 Then
                    'Se existe um espaço no último caractere da parte 1 da string, então:
                    If strCaminho.Substring(98, 1) = " " Then
                        'Salva a parte 1 da string concatenada com uma "?" no final, adicionada para simbolizar um espaço " "
                        usrInicializacao.ENDERECO_P1 = strCaminho.Substring(0, 98) & "?"
                        'Salava a parte 2 da string normalmente
                        usrInicializacao.ENDERECO_P2 = strCaminho.Substring(99, (strCaminho.Length - 99))
                    ElseIf strCaminho.Substring(99, 1) = " " Then 'Se a segunda parte da string tiver um espaço no início, então:
                        'Salva a parte 2 da string concatenada com uma '?' no início, adicionada para simbolizar um espaço " "
                        usrInicializacao.ENDERECO_P2 = "?" & strCaminho.Substring(100, (strCaminho.Length - 100))
                        ''Salava a parte 1 da string normalmente
                        usrInicializacao.ENDERECO_P1 = strCaminho.Substring(0, 99)
                    Else
                        'Se não há espaços no nome da pasta que possui mais de  99 caracteres, então: 
                        usrInicializacao.ENDERECO_P1 = strCaminho.Substring(0, 99)
                        usrInicializacao.ENDERECO_P2 = strCaminho.Substring(99, (strCaminho.Length - 99))
                    End If

                Else
                    'Se a pasta possui menos de 99 caracteres, então:
                    usrInicializacao.ENDERECO_P1 = strCaminho
                    usrInicializacao.ENDERECO_P2 = ""
                End If

                'Atualizar o disco
                Call usrInicializacao.AtualizaDisco()
            Else
                'Desabilita o recurso de visualização e cadastro de amostras
                usrLayout.HabilitarAmostras(False)
            End If

            If Not usrLicença.VerificarLicença() Then
                With mdiPrincipal
                    .Text = frmPavitest.lblVersao.Text & " - [VERSÃO DE TESTE]"
                    .tsbBaseDados.Enabled = False
                    .tsbAmostras.Enabled = False
                    .mnuBancoDados1.Enabled = False
                    .mnuEnsaiar.Enabled = False
                End With

            End If

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("frmCadastrarBD_FormClosed" & Chr(13) & ex.Message)

        End Try

    End Sub
   
#End Region

    '////////////////////////////////////////////////////////////////
    '////////////////////// COMANDOS DE EXECUÇÃO ////////////////////

#Region "COMANDOS DE EXECUÇÃO - BUTTON"

    Private Sub btnNovo_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnNovo.Click

        Try
            'Alterar o estado da variável
            blnEditar = False

            'Limpar campo
            Call LimparCampos()
            'Habilitar Campos
            Call HabilitarCampos(True, True, True, True)
            'Habilitar Comandos
            Call HabilitarComandos(False, False, True, True, False)

            'Foco no campo do nome
            txtNome.Focus()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnNovo_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub btnEditar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnEditar.Click

        Try
            'Alterar o estado da variável
            blnEditar = True

            'Foco no coordenador
            txtCoordenador.Focus()
            'Habilitar Campos
            Call HabilitarCampos(True, False, True, False)
            'Habilitar Comandos
            Call HabilitarComandos(False, False, True, True, False)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnEditar_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub btnSalvar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnSalvar.Click

        Try
            'Verificar campo obrigatório
            If txtNome.Text = Nothing Then
                MsgBox("Necessário o preenchimento do campo NOME.", MsgBoxStyle.Exclamation, "Dados Incompletos")
                txtNome.SelectAll()
                Exit Sub
            End If

            If blnEditar = True Then Call SalvarIdentificacao(cmd_UPDATE) Else Call SalvarBD()

            'Habilita Comandos
            Call HabilitarComandos(True, False, False, False, True)
            'Desabilitar Campos
            Call HabilitarCampos(False, False, False, True)

            'Atualiza Lista de Bancos de Dados
            lstFile.Refresh()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnSalvar_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub btnCancelar_Click(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles btnCancelar.Click

        Try
            'Limpar Campos
            Call LimparCampos()
            'Habilitar Campos
            Call HabilitarCampos(False, False, False, True)
            'Habilitar Comandos
            Call HabilitarComandos(True, False, False, False, True)

            'Alterar a variável
            blnEditar = False

            'Atualizar a lista
            lstFile.Refresh()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnCancelar_Click" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click

        Try
            'Desabilitar comandos
            usrLayout.HabilitarComandos(True)

            If blnSelecionado = True Then
                'Habilitar o comando cadastrar 
                mdiPrincipal.tsbAmostras.Enabled = True
                mdiPrincipal.mnuCadastrar.Enabled = True

                'Atribuir nome do banco de dados
                strBaseDados = lstFile.FileName
            Else
                'Desabilitar o comando cadastrar
                mdiPrincipal.tsbAmostras.Enabled = False
                mdiPrincipal.mnuCadastrar.Enabled = False
            End If

            'Setar a variável
            blnSelecionado = False

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("btnOK_Click" & Chr(13) & ex.Message)

        Finally
            'Fechar o formulario corrente
            Me.Close()

        End Try

    End Sub

#End Region

    '////////////////////////////////////////////////////////////////
    '//////////////////////// SELECIONAR ITENS //////////////////////

#Region "DETERMINAR ENDEREÇO BANCO DE DADOS"

    Private Sub lstFile_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstFile.SelectedIndexChanged

        Try
            'Atribuir nome do banco de dados
            strBaseDados = lstFile.FileName

            'Verificar banco existente
            If strBaseDados = Nothing Then Exit Sub

            'Abrir conexão com o banco selecionado
            Call usrConexao.Conectar()

            'Carregar os dados do banco 
            Call CarregarBD()

            'Habilitar comandos
            Call HabilitarComandos(True, True, False, False, True)

            'Alterar variável
            blnSelecionado = True

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("lstFile_SelectedIndexChanged" & Chr(13) & ex.Message)

        End Try
        
    End Sub
    Private Sub CarregarBD()
        Dim strSql As String
        Dim odbReader As OleDbDataReader

        Try
            'Faz a seleção da tabela do banco.
            strSql = "SELECT * from tblIdentificacao"

            'Comando de leitura do banco de dados
            odbReader = usrConexao.ComandoLeitura(strSql)
            'Leitura
            odbReader.Read()

            'Carrega os valores
            If Not IsDBNull(odbReader("Nome".ToString)) Then txtNome.Text = odbReader("Nome")
            If Not IsDBNull(odbReader("Coordenador".ToString)) Then txtCoordenador.Text = odbReader("Coordenador")
            If Not IsDBNull(odbReader("Data".ToString)) Then dtpCriar.Value = odbReader("Data")

            'Liberar os componentes da memória
            odbReader.Dispose()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("CarregarBD" & Chr(13) & ex.Message)

        End Try

    End Sub
    Private Sub lstFile_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstFile.DoubleClick

        Try
            Call btnOK_Click(Nothing, Nothing)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("lstFile_DoubleClick" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub lstDrive_SelectedIndexChanged(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstDrive.SelectedIndexChanged
        'Conexão do diretorio com o drive

        Try
            lstDiretorio.Path = lstDrive.Drive
            strCaminho = lstDrive.Drive

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("lstDrive_SelectedIndexChanged" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub lstDiretorio_Change(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs) Handles lstDiretorio.Change
        'Atribuir caminho

        Try
            lstFile.Path = lstDiretorio.Path
            strCaminho = lstDiretorio.Path

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("lstDiretorio_Change" & Chr(13) & ex.Message)

        End Try
        
    End Sub

#End Region

#Region "Travar form"

    'Permitir travar o formulario na MDI
    Protected Overrides Sub WndProc(ByRef m As System.Windows.Forms.Message)
        If (m.Msg = WM_SYSCOMMAND AndAlso _
           m.WParam.ToInt32() = SC_MOVE) OrElse _
          (m.Msg = WM_NCLBUTTONDOWN AndAlso _
          m.WParam.ToInt32() = HTCAPTION) Then
            Return
        Else
            MyBase.WndProc(m)
        End If
    End Sub

#End Region

    '////////////////////////////////////////////////////////////////////////
    '///////////////////////// FUNÇÕES E PROCEDIMENTOS //////////////////////

#Region "HABILITAR E LIMPAR CAMPOS"

    Private Sub HabilitarComandos(ByRef blnNovo As Boolean, ByRef blnEditar As Boolean, ByRef blnSalvar As Boolean, ByRef blnCancelar As Boolean, ByRef blnOk As Boolean)

        Try
            btnNovo.Enabled = blnNovo
            btnEditar.Enabled = blnEditar
            btnSalvar.Enabled = blnSalvar
            btnCancelar.Enabled = blnCancelar
            btnOk.Enabled = blnOk

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("HabilitarComandos" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub LimparCampos()

        Try
            txtNome.Text = Nothing
            txtCoordenador.Text = Nothing

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("LimparCampos" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub HabilitarCampos(ByRef blnData As Boolean, ByRef blnNome As Boolean, ByRef blnCoordenador As Boolean, ByRef blnlstFile As Boolean)

        Try
            dtpCriar.Enabled = blnData
            txtNome.Enabled = blnNome
            txtCoordenador.Enabled = blnCoordenador

            lstFile.Enabled = blnlstFile
            lstDrive.Enabled = blnlstFile

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("HabilitarCampos" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

    '//////////////////////////////////////////////////////////////
    '/////////////////////// BANCO DE DADOS ///////////////////////

#Region "BANCO DE DADOS - TABELAS"

    '*********************** Tabela de Identificação

    Private Sub TabelaIdentificacao()

        Try
            'Criar os campos
            Call CriarIdentificacao()

            'Salvar os campos
            Call SalvarIdentificacao(cmd_INSERT)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("TabelaIdentificacao" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub CriarIdentificacao()
        'Criar Tabela de Identificação
        Dim strSql As String

        Try
            'Atribuir os valores ás variáveis temporárias
            strStruture_Campo = ""
            strStruture_Valor = ""

            'Criar os campos
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Identificação", "COUNTER CONSTRAINT RestrictCamp PRIMARY KEY")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Nome", "TEXT")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Coordenador", "TEXT")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Data", "DATETIME")

            If strStruture_Campo <> "" Then strStruture_Campo = strStruture_Campo & ")"

            'Comando Sql (Adicionar)
            strSql = "CREATE TABLE [tblIdentificacao] " _
                & strStruture_Campo

            'Comando do banco de dados
            Call usrConexao.ComandoExecucao(strSql)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("CriarIdentificacao" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub SalvarIdentificacao(ByVal strComando As String)
        'Criar Tabela de Identificação
        Dim strSql As String

        Try
            'Atribuir os valores ás variáveis temporárias
            strStruture_Campo = ""
            strStruture_Valor = ""

            'Criar os campos
            If txtNome.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Nome", txtNome.Text)
            If txtCoordenador.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Coordenador", txtCoordenador.Text)
            If dtpCriar.Text <> "" Then Call usrConexao.ConstruirSQL(strComando, "Data", dtpCriar.Text)

            'Comando Sql
            If strComando = cmd_INSERT Then
                If strStruture_Campo <> "" Then strStruture_Campo = strStruture_Campo & ")"
                If strStruture_Valor <> "" Then strStruture_Valor = strStruture_Valor & ")"

                'Comando Sql (Adicionar)
                strSql = "INSERT INTO [tblIdentificacao] " _
                    & strStruture_Campo & strStruture_Valor

            Else
                'Comando Sql (Editar)
                strSql = "UPDATE [tblIdentificacao] SET " _
                        & strStruture_Campo

            End If

            'Comando do banco de dados
            Call usrConexao.ComandoExecucao(strSql)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("TabelaIdentificacao" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

#Region "BANCO DE DADOS - COMANDOS"

    Private Sub SalvarBD()
        'Instancia o objeto de conexão
        Dim adoXCatalog As New ADOX.Catalog

        Try
            'Nome do banco
            strBaseDados = txtNome.Text & ".mdb"

            'Criar o banco de dados access
            adoXCatalog.Create("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & strCaminho & "\" & strBaseDados)

            'Abrir conexão com Banco de dados
            Call usrConexao.Conectar()

            'Criar Tabela de Identificação
            Call TabelaIdentificacao()
            'Criar Tabela de Amostras
            Call TabelaAmostra()
            'Criar Tabela de CP´s
            Call TabelaCPs()
            'Criar Tabela de Cilindro
            Call TabelaCilindro()

            'Limpar Campos
            Call LimparCampos()

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("SalvarBD" & Chr(13) & ex.Message)

        End Try

    End Sub


    '********************** Tabela Amostra, CP, Ensaio

    Private Sub TabelaAmostra()
        Dim strSql As String

        Try
            'Atribuir os valores ás variáveis temporárias
            strStruture_Campo = ""
            strStruture_Valor = ""

            'Criar os campos
            Call usrConexao.ConstruirSQL(cmd_CREATE, "IdAmostra", "COUNTER CONSTRAINT RestrictCamp PRIMARY KEY")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Nome", "TEXT(50)")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Numero", "TEXT(50)")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Programa", "TEXT(50)")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Responsavel", "TEXT(100)")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Data", "DATETIME")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Compactacao", "TEXT(50)")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "QteCPs", "INTEGER")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "TipoEnsaio", "TEXT(100)")

            'add coluna "TipoEnsaio"

            If strStruture_Campo <> "" Then strStruture_Campo = strStruture_Campo & ")"

            'Comando Sql (Adicionar)
            strSql = "CREATE TABLE [tblAmostra] " _
                & strStruture_Campo

            'Comando do banco de dados
            Call usrConexao.ComandoExecucao(strSql)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("TabelaAmostra" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub TabelaCilindro()
        Dim strSql As String

        Try
            'Atribuir os valores ás variáveis temporárias
            strStruture_Campo = ""
            strStruture_Valor = ""

            'Criar os campos
            Call usrConexao.ConstruirSQL(cmd_CREATE, "IdCilindro", "COUNTER CONSTRAINT RestrictCamp PRIMARY KEY")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Nome", "TEXT(50)")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Peso", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Volume", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Altura", "DOUBLE")


            If strStruture_Campo <> "" Then strStruture_Campo = strStruture_Campo & ")"

            'Comando Sql (Adicionar)
            strSql = "CREATE TABLE [tblCilindro] " _
                & strStruture_Campo

            'Comando do banco de dados
            Call usrConexao.ComandoExecucao(strSql)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("TabelaCilindro" & Chr(13) & ex.Message)

        End Try

    End Sub

    Private Sub TabelaCPs()
        Dim strSql As String

        Try
            'Atribuir os valores ás variáveis temporárias
            strStruture_Campo = ""
            strStruture_Valor = ""

            Call usrConexao.ConstruirSQL(cmd_CREATE, "IdAmostra", "INTEGER")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "IdCP", "COUNTER")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Cilindro", "TEXT(100)")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Capsula", "TEXT(100)")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Peso", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Volume", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "UmidoCilindro", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "SoloUmido", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "MassaUmido", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "UmidoTara", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "SecoTara", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Agua", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Tara", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "SoloSeco", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Umidade", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "MassaSeca", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Data1", "DATETIME")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Data2", "DATETIME")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Data3", "DATETIME")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Data4", "DATETIME")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Data5", "DATETIME")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Hora1", "DATETIME")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Hora2", "DATETIME")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Hora3", "DATETIME")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Hora4", "DATETIME")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Hora5", "DATETIME")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Leitura1", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Leitura2", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Leitura3", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Leitura4", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Leitura5", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Diferenca", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Altura", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Expansao", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "MoldeUmidoInicial", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "MoldeUmidoFinal", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "AguaAbsorvida", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "PCalculada1", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "PCalculada2", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "PCorrigida1", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "PCorrigida2", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "ISC1", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "ISC2", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Y1", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "Y2", "DOUBLE")
            Call usrConexao.ConstruirSQL(cmd_CREATE, "EnsaioRealizado", "BIT")

            If strStruture_Campo <> "" Then strStruture_Campo = strStruture_Campo & ")"

            'Comando Sql (Adicionar)
            strSql = "CREATE TABLE [tblCPs] " _
                & strStruture_Campo

            'Comando do banco de dados
            Call usrConexao.ComandoExecucao(strSql)

        Catch ex As Exception
            'Mensagem de erro
            MsgBox("TabelaCPs" & Chr(13) & ex.Message)

        End Try

    End Sub

#End Region

End Class