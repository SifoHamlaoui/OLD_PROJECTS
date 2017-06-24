<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.DarkMatterTheme1 = New NotePad_By_Sifo_Hamlaoui.DarkMatterTheme()
        Me.DarkMatterButton2 = New NotePad_By_Sifo_Hamlaoui.DarkMatterButton()
        Me.DarkMatterButton1 = New NotePad_By_Sifo_Hamlaoui.DarkMatterButton()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DarkMatterTheme1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DarkMatterTheme1
        '
        Me.DarkMatterTheme1.BorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.DarkMatterTheme1.Colors = New NotePad_By_Sifo_Hamlaoui.Bloom(-1) {}
        Me.DarkMatterTheme1.Controls.Add(Me.DarkMatterButton2)
        Me.DarkMatterTheme1.Controls.Add(Me.DarkMatterButton1)
        Me.DarkMatterTheme1.Controls.Add(Me.TextBox1)
        Me.DarkMatterTheme1.Customization = ""
        Me.DarkMatterTheme1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DarkMatterTheme1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DarkMatterTheme1.Image = CType(resources.GetObject("DarkMatterTheme1.Image"), System.Drawing.Image)
        Me.DarkMatterTheme1.Location = New System.Drawing.Point(0, 0)
        Me.DarkMatterTheme1.Movable = True
        Me.DarkMatterTheme1.Name = "DarkMatterTheme1"
        Me.DarkMatterTheme1.NoRounding = False
        Me.DarkMatterTheme1.Sizable = False
        Me.DarkMatterTheme1.Size = New System.Drawing.Size(955, 647)
        Me.DarkMatterTheme1.SmartBounds = True
        Me.DarkMatterTheme1.TabIndex = 0
        Me.DarkMatterTheme1.Text = "                                                                                 " & _
            "                  <[.:NotePad By SHP:.]>"
        Me.DarkMatterTheme1.ThemeStyle = NotePad_By_Sifo_Hamlaoui.DarkMatterTheme.ColorTheme.GammaRay
        Me.DarkMatterTheme1.TransparencyKey = System.Drawing.Color.Cyan
        '
        'DarkMatterButton2
        '
        Me.DarkMatterButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.DarkMatterButton2.Colors = New NotePad_By_Sifo_Hamlaoui.Bloom(-1) {}
        Me.DarkMatterButton2.Customization = ""
        Me.DarkMatterButton2.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DarkMatterButton2.Image = Nothing
        Me.DarkMatterButton2.Location = New System.Drawing.Point(884, 3)
        Me.DarkMatterButton2.Name = "DarkMatterButton2"
        Me.DarkMatterButton2.NoRounding = False
        Me.DarkMatterButton2.Size = New System.Drawing.Size(28, 21)
        Me.DarkMatterButton2.TabIndex = 2
        Me.DarkMatterButton2.Text = "-"
        Me.DarkMatterButton2.ThemeStyle = NotePad_By_Sifo_Hamlaoui.DarkMatterButton.ColorTheme.GammaRay
        Me.DarkMatterButton2.Transparent = False
        '
        'DarkMatterButton1
        '
        Me.DarkMatterButton1.BackColor = System.Drawing.Color.FromArgb(CType(CType(59, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(61, Byte), Integer))
        Me.DarkMatterButton1.Colors = New NotePad_By_Sifo_Hamlaoui.Bloom(-1) {}
        Me.DarkMatterButton1.Customization = ""
        Me.DarkMatterButton1.Font = New System.Drawing.Font("Verdana", 8.0!)
        Me.DarkMatterButton1.Image = Nothing
        Me.DarkMatterButton1.Location = New System.Drawing.Point(918, 3)
        Me.DarkMatterButton1.Name = "DarkMatterButton1"
        Me.DarkMatterButton1.NoRounding = False
        Me.DarkMatterButton1.Size = New System.Drawing.Size(34, 21)
        Me.DarkMatterButton1.TabIndex = 1
        Me.DarkMatterButton1.Text = "X"
        Me.DarkMatterButton1.ThemeStyle = NotePad_By_Sifo_Hamlaoui.DarkMatterButton.ColorTheme.GammaRay
        Me.DarkMatterButton1.Transparent = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer), CType(CType(58, Byte), Integer))
        Me.TextBox1.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Lime
        Me.TextBox1.Location = New System.Drawing.Point(0, 25)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(955, 595)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(955, 647)
        Me.Controls.Add(Me.DarkMatterTheme1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.Opacity = 0.7R
        Me.Text = "Form1"
        Me.TransparencyKey = System.Drawing.Color.Cyan
        Me.DarkMatterTheme1.ResumeLayout(False)
        Me.DarkMatterTheme1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DarkMatterTheme1 As NotePad_By_Sifo_Hamlaoui.DarkMatterTheme
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DarkMatterButton1 As NotePad_By_Sifo_Hamlaoui.DarkMatterButton
    Friend WithEvents DarkMatterButton2 As NotePad_By_Sifo_Hamlaoui.DarkMatterButton

End Class
