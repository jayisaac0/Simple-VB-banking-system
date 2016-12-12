<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.RegisterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KenyaCommercialBankDataSet1 = New kcb.KenyaCommercialBankDataSet1()
        Me.Splitter1 = New System.Windows.Forms.Splitter()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KenyaCommercialBankDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.Left
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegisterToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(259, 638)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'RegisterToolStripMenuItem
        '
        Me.RegisterToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.RegisterToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.RegisterToolStripMenuItem.Name = "RegisterToolStripMenuItem"
        Me.RegisterToolStripMenuItem.Padding = New System.Windows.Forms.Padding(100, 20, 100, 20)
        Me.RegisterToolStripMenuItem.Size = New System.Drawing.Size(246, 59)
        Me.RegisterToolStripMenuItem.Text = "Register"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.LoginToolStripMenuItem.Margin = New System.Windows.Forms.Padding(0, 0, 0, 5)
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Padding = New System.Windows.Forms.Padding(30, 20, 30, 20)
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(246, 59)
        Me.LoginToolStripMenuItem.Text = "Login"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.BackColor = System.Drawing.Color.Blue
        Me.ToolStripMenuItem1.Margin = New System.Windows.Forms.Padding(0, 10, 0, 10)
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Padding = New System.Windows.Forms.Padding(15, 20, 15, 20)
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(142, 59)
        Me.ToolStripMenuItem1.Text = "Register"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.BackColor = System.Drawing.Color.Blue
        Me.ToolStripMenuItem2.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Padding = New System.Windows.Forms.Padding(15, 20, 15, 20)
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(142, 59)
        Me.ToolStripMenuItem2.Text = "Log in"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.BackColor = System.Drawing.Color.Blue
        Me.ToolStripMenuItem3.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Padding = New System.Windows.Forms.Padding(15, 20, 15, 20)
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(142, 59)
        Me.ToolStripMenuItem3.Text = "Administrator"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.BackColor = System.Drawing.Color.Blue
        Me.ToolStripMenuItem4.Margin = New System.Windows.Forms.Padding(0, 0, 0, 10)
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Padding = New System.Windows.Forms.Padding(15, 20, 15, 20)
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(142, 59)
        Me.ToolStripMenuItem4.Text = "ToolStripMenuItem4"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.KenyaCommercialBankDataSet1
        Me.BindingSource1.Position = 0
        '
        'KenyaCommercialBankDataSet1
        '
        Me.KenyaCommercialBankDataSet1.DataSetName = "KenyaCommercialBankDataSet1"
        Me.KenyaCommercialBankDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Splitter1
        '
        Me.Splitter1.Location = New System.Drawing.Point(259, 0)
        Me.Splitter1.Name = "Splitter1"
        Me.Splitter1.Size = New System.Drawing.Size(3, 638)
        Me.Splitter1.TabIndex = 2
        Me.Splitter1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Lime
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(995, 638)
        Me.Controls.Add(Me.Splitter1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KenyaCommercialBankDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents KenyaCommercialBankDataSet1 As kcb.KenyaCommercialBankDataSet1
    Friend WithEvents Splitter1 As System.Windows.Forms.Splitter
    Friend WithEvents RegisterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class
