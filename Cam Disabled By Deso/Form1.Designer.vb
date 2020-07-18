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
        Me.TestThemeEditorForm1 = New Cam_Disabled_By_Deso.TestThemeEditorForm()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TestThemeEditorForm1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TestThemeEditorForm1
        '
        Me.TestThemeEditorForm1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.TestThemeEditorForm1.Colors = New Cam_Disabled_By_Deso.Bloom(-1) {}
        Me.TestThemeEditorForm1.Controls.Add(Me.Button1)
        Me.TestThemeEditorForm1.Controls.Add(Me.Label2)
        Me.TestThemeEditorForm1.Controls.Add(Me.Label1)
        Me.TestThemeEditorForm1.Customization = ""
        Me.TestThemeEditorForm1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TestThemeEditorForm1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.TestThemeEditorForm1.Image = Nothing
        Me.TestThemeEditorForm1.Location = New System.Drawing.Point(0, 0)
        Me.TestThemeEditorForm1.MinimumSize = New System.Drawing.Size(50, 50)
        Me.TestThemeEditorForm1.Movable = True
        Me.TestThemeEditorForm1.Name = "TestThemeEditorForm1"
        Me.TestThemeEditorForm1.NoRounding = False
        Me.TestThemeEditorForm1.Sizable = True
        Me.TestThemeEditorForm1.Size = New System.Drawing.Size(265, 102)
        Me.TestThemeEditorForm1.SmartBounds = True
        Me.TestThemeEditorForm1.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation
        Me.TestThemeEditorForm1.TabIndex = 0
        Me.TestThemeEditorForm1.Text = "Disable Cam By Deso"
        Me.TestThemeEditorForm1.TransparencyKey = System.Drawing.Color.Empty
        Me.TestThemeEditorForm1.Transparent = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Black
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Red
        Me.Button1.Location = New System.Drawing.Point(73, 38)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(117, 35)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Hi"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Black
        Me.Label2.ForeColor = System.Drawing.Color.Silver
        Me.Label2.Location = New System.Drawing.Point(12, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Status: ..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Black
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(293, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 17)
        Me.Label1.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(265, 102)
        Me.Controls.Add(Me.TestThemeEditorForm1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MinimumSize = New System.Drawing.Size(50, 50)
        Me.Name = "Form1"
        Me.Text = "Disable Cam By Deso"
        Me.TestThemeEditorForm1.ResumeLayout(False)
        Me.TestThemeEditorForm1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TestThemeEditorForm1 As TestThemeEditorForm
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
