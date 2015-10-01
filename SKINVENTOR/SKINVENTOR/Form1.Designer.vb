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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Button_Run = New System.Windows.Forms.Button()
        Me.ButtonDialog = New System.Windows.Forms.Button()
        Me.TextBox_Path = New System.Windows.Forms.TextBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'Button_Close
        '
        Me.Button_Close.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Close.Location = New System.Drawing.Point(436, 82)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(75, 23)
        Me.Button_Close.TabIndex = 0
        Me.Button_Close.Text = "Close"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Button_Run
        '
        Me.Button_Run.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button_Run.Location = New System.Drawing.Point(355, 82)
        Me.Button_Run.Name = "Button_Run"
        Me.Button_Run.Size = New System.Drawing.Size(75, 23)
        Me.Button_Run.TabIndex = 1
        Me.Button_Run.Text = "Run"
        Me.Button_Run.UseVisualStyleBackColor = True
        '
        'ButtonDialog
        '
        Me.ButtonDialog.Location = New System.Drawing.Point(12, 12)
        Me.ButtonDialog.Name = "ButtonDialog"
        Me.ButtonDialog.Size = New System.Drawing.Size(28, 28)
        Me.ButtonDialog.TabIndex = 2
        Me.ButtonDialog.Text = "..."
        Me.ButtonDialog.UseVisualStyleBackColor = True
        '
        'TextBox_Path
        '
        Me.TextBox_Path.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox_Path.Location = New System.Drawing.Point(46, 20)
        Me.TextBox_Path.Name = "TextBox_Path"
        Me.TextBox_Path.Size = New System.Drawing.Size(465, 20)
        Me.TextBox_Path.TabIndex = 3
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 117)
        Me.Controls.Add(Me.TextBox_Path)
        Me.Controls.Add(Me.ButtonDialog)
        Me.Controls.Add(Me.Button_Run)
        Me.Controls.Add(Me.Button_Close)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.Text = "Select File"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button_Close As Button
    Friend WithEvents Button_Run As Button
    Friend WithEvents ButtonDialog As Button
    Friend WithEvents TextBox_Path As TextBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
