<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdministrator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.grpAdminLogin = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblAdminLogin = New System.Windows.Forms.Label()
        Me.lblAdminPasswordLogin = New System.Windows.Forms.Label()
        Me.txtAdminLogin = New System.Windows.Forms.TextBox()
        Me.btnAdminLogin = New System.Windows.Forms.Button()
        Me.txtAdminLoginPassword = New System.Windows.Forms.TextBox()
        Me.grpAdminRegister = New System.Windows.Forms.GroupBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblAdmin = New System.Windows.Forms.Label()
        Me.lblAdminPassword = New System.Windows.Forms.Label()
        Me.txtAdminRegister = New System.Windows.Forms.TextBox()
        Me.btnAdminRegister = New System.Windows.Forms.Button()
        Me.txtAdminRegisterPassword = New System.Windows.Forms.TextBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KenyaCommercialBankDataSet = New kcb.KenyaCommercialBankDataSet()
        Me.AdminTBLTableAdapter = New kcb.KenyaCommercialBankDataSetTableAdapters.adminTBLTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.grpAdminLogin.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.grpAdminRegister.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KenyaCommercialBankDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.grpAdminLogin)
        Me.GroupBox1.Controls.Add(Me.grpAdminRegister)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(474, 362)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'grpAdminLogin
        '
        Me.grpAdminLogin.BackColor = System.Drawing.Color.Maroon
        Me.grpAdminLogin.Controls.Add(Me.TableLayoutPanel2)
        Me.grpAdminLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAdminLogin.Location = New System.Drawing.Point(6, 173)
        Me.grpAdminLogin.Name = "grpAdminLogin"
        Me.grpAdminLogin.Size = New System.Drawing.Size(457, 169)
        Me.grpAdminLogin.TabIndex = 0
        Me.grpAdminLogin.TabStop = False
        Me.grpAdminLogin.Text = "Admin login"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Label4, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAdminLogin, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.lblAdminPasswordLogin, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAdminLogin, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.btnAdminLogin, 1, 3)
        Me.TableLayoutPanel2.Controls.Add(Me.txtAdminLoginPassword, 1, 2)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(8, 32)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 4
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(440, 105)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Label4"
        '
        'lblAdminLogin
        '
        Me.lblAdminLogin.AutoSize = True
        Me.lblAdminLogin.Location = New System.Drawing.Point(3, 25)
        Me.lblAdminLogin.Name = "lblAdminLogin"
        Me.lblAdminLogin.Size = New System.Drawing.Size(41, 13)
        Me.lblAdminLogin.TabIndex = 2
        Me.lblAdminLogin.Text = "Admin"
        '
        'lblAdminPasswordLogin
        '
        Me.lblAdminPasswordLogin.AutoSize = True
        Me.lblAdminPasswordLogin.Location = New System.Drawing.Point(3, 50)
        Me.lblAdminPasswordLogin.Name = "lblAdminPasswordLogin"
        Me.lblAdminPasswordLogin.Size = New System.Drawing.Size(98, 13)
        Me.lblAdminPasswordLogin.TabIndex = 1
        Me.lblAdminPasswordLogin.Text = "Admin password"
        '
        'txtAdminLogin
        '
        Me.txtAdminLogin.Location = New System.Drawing.Point(223, 28)
        Me.txtAdminLogin.Name = "txtAdminLogin"
        Me.txtAdminLogin.Size = New System.Drawing.Size(214, 20)
        Me.txtAdminLogin.TabIndex = 5
        '
        'btnAdminLogin
        '
        Me.btnAdminLogin.Location = New System.Drawing.Point(223, 79)
        Me.btnAdminLogin.Name = "btnAdminLogin"
        Me.btnAdminLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnAdminLogin.TabIndex = 4
        Me.btnAdminLogin.Text = "Login"
        Me.btnAdminLogin.UseVisualStyleBackColor = True
        '
        'txtAdminLoginPassword
        '
        Me.txtAdminLoginPassword.Location = New System.Drawing.Point(223, 53)
        Me.txtAdminLoginPassword.Name = "txtAdminLoginPassword"
        Me.txtAdminLoginPassword.Size = New System.Drawing.Size(214, 20)
        Me.txtAdminLoginPassword.TabIndex = 3
        '
        'grpAdminRegister
        '
        Me.grpAdminRegister.BackColor = System.Drawing.Color.Maroon
        Me.grpAdminRegister.Controls.Add(Me.TableLayoutPanel1)
        Me.grpAdminRegister.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpAdminRegister.Location = New System.Drawing.Point(6, 19)
        Me.grpAdminRegister.Name = "grpAdminRegister"
        Me.grpAdminRegister.Size = New System.Drawing.Size(457, 148)
        Me.grpAdminRegister.TabIndex = 0
        Me.grpAdminRegister.TabStop = False
        Me.grpAdminRegister.Text = "Admin Register"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAdmin, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lblAdminPassword, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAdminRegister, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btnAdminRegister, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.txtAdminRegisterPassword, 1, 2)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(6, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(440, 105)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Label1"
        '
        'lblAdmin
        '
        Me.lblAdmin.AutoSize = True
        Me.lblAdmin.Location = New System.Drawing.Point(3, 25)
        Me.lblAdmin.Name = "lblAdmin"
        Me.lblAdmin.Size = New System.Drawing.Size(41, 13)
        Me.lblAdmin.TabIndex = 2
        Me.lblAdmin.Text = "Admin"
        '
        'lblAdminPassword
        '
        Me.lblAdminPassword.AutoSize = True
        Me.lblAdminPassword.Location = New System.Drawing.Point(3, 50)
        Me.lblAdminPassword.Name = "lblAdminPassword"
        Me.lblAdminPassword.Size = New System.Drawing.Size(98, 13)
        Me.lblAdminPassword.TabIndex = 1
        Me.lblAdminPassword.Text = "Admin password"
        '
        'txtAdminRegister
        '
        Me.txtAdminRegister.Location = New System.Drawing.Point(223, 28)
        Me.txtAdminRegister.Name = "txtAdminRegister"
        Me.txtAdminRegister.Size = New System.Drawing.Size(214, 20)
        Me.txtAdminRegister.TabIndex = 5
        '
        'btnAdminRegister
        '
        Me.btnAdminRegister.Location = New System.Drawing.Point(223, 79)
        Me.btnAdminRegister.Name = "btnAdminRegister"
        Me.btnAdminRegister.Size = New System.Drawing.Size(75, 23)
        Me.btnAdminRegister.TabIndex = 4
        Me.btnAdminRegister.Text = "Resgister"
        Me.btnAdminRegister.UseVisualStyleBackColor = True
        '
        'txtAdminRegisterPassword
        '
        Me.txtAdminRegisterPassword.Location = New System.Drawing.Point(223, 53)
        Me.txtAdminRegisterPassword.Name = "txtAdminRegisterPassword"
        Me.txtAdminRegisterPassword.Size = New System.Drawing.Size(214, 20)
        Me.txtAdminRegisterPassword.TabIndex = 3
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "adminTBL"
        Me.BindingSource1.DataSource = Me.KenyaCommercialBankDataSet
        '
        'KenyaCommercialBankDataSet
        '
        Me.KenyaCommercialBankDataSet.DataSetName = "KenyaCommercialBankDataSet"
        Me.KenyaCommercialBankDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AdminTBLTableAdapter
        '
        Me.AdminTBLTableAdapter.ClearBeforeFill = True
        '
        'frmAdministrator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.Lime
        Me.ClientSize = New System.Drawing.Size(494, 384)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "frmAdministrator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "administrator"
        Me.GroupBox1.ResumeLayout(False)
        Me.grpAdminLogin.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        Me.grpAdminRegister.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KenyaCommercialBankDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents grpAdminLogin As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lblAdminLogin As System.Windows.Forms.Label
    Friend WithEvents lblAdminPasswordLogin As System.Windows.Forms.Label
    Friend WithEvents txtAdminLogin As System.Windows.Forms.TextBox
    Friend WithEvents btnAdminLogin As System.Windows.Forms.Button
    Friend WithEvents txtAdminLoginPassword As System.Windows.Forms.TextBox
    Friend WithEvents grpAdminRegister As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblAdmin As System.Windows.Forms.Label
    Friend WithEvents lblAdminPassword As System.Windows.Forms.Label
    Friend WithEvents txtAdminRegister As System.Windows.Forms.TextBox
    Friend WithEvents btnAdminRegister As System.Windows.Forms.Button
    Friend WithEvents txtAdminRegisterPassword As System.Windows.Forms.TextBox
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents KenyaCommercialBankDataSet As kcb.KenyaCommercialBankDataSet
    Friend WithEvents AdminTBLTableAdapter As kcb.KenyaCommercialBankDataSetTableAdapters.adminTBLTableAdapter
End Class
