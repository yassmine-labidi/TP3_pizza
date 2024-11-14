<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class TP3
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lst_taille = New ComboBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        rd_1 = New RadioButton()
        rd_2 = New RadioButton()
        rd_3 = New RadioButton()
        chk_1 = New CheckBox()
        chk_2 = New CheckBox()
        chk_3 = New CheckBox()
        chk_4 = New CheckBox()
        btn = New Button()
        SuspendLayout()
        ' 
        ' lst_taille
        ' 
        lst_taille.Font = New Font("Cambria", 10.2F)
        lst_taille.FormattingEnabled = True
        lst_taille.Items.AddRange(New Object() {"petite", "moyenne", "grande"})
        lst_taille.Location = New Point(325, 83)
        lst_taille.Margin = New Padding(4, 3, 4, 3)
        lst_taille.Name = "lst_taille"
        lst_taille.Size = New Size(362, 28)
        lst_taille.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.AntiqueWhite
        Label1.Location = New Point(28, 83)
        Label1.Margin = New Padding(4, 0, 4, 0)
        Label1.Name = "Label1"
        Label1.Size = New Size(120, 22)
        Label1.TabIndex = 1
        Label1.Text = "Taille de pizza"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.AntiqueWhite
        Label2.Location = New Point(28, 263)
        Label2.Margin = New Padding(4, 0, 4, 0)
        Label2.Name = "Label2"
        Label2.Size = New Size(226, 22)
        Label2.TabIndex = 2
        Label2.Text = "Igrédiants supplémentaires"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.AntiqueWhite
        Label3.Location = New Point(28, 186)
        Label3.Margin = New Padding(4, 0, 4, 0)
        Label3.Name = "Label3"
        Label3.Size = New Size(131, 22)
        Label3.TabIndex = 3
        Label3.Text = "Type de croûte"
        ' 
        ' rd_1
        ' 
        rd_1.AutoSize = True
        rd_1.BackColor = Color.PeachPuff
        rd_1.Font = New Font("Cambria", 10.2F)
        rd_1.Location = New Point(325, 182)
        rd_1.Margin = New Padding(4, 3, 4, 3)
        rd_1.Name = "rd_1"
        rd_1.Size = New Size(110, 24)
        rd_1.TabIndex = 4
        rd_1.TabStop = True
        rd_1.Text = "Croûte fine"
        rd_1.UseVisualStyleBackColor = False
        ' 
        ' rd_2
        ' 
        rd_2.AutoSize = True
        rd_2.BackColor = Color.PeachPuff
        rd_2.Font = New Font("Cambria", 10.2F)
        rd_2.Location = New Point(570, 182)
        rd_2.Margin = New Padding(4, 3, 4, 3)
        rd_2.Name = "rd_2"
        rd_2.Size = New Size(149, 24)
        rd_2.TabIndex = 5
        rd_2.TabStop = True
        rd_2.Text = "Croûte classique"
        rd_2.UseVisualStyleBackColor = False
        ' 
        ' rd_3
        ' 
        rd_3.AutoSize = True
        rd_3.BackColor = Color.PeachPuff
        rd_3.Font = New Font("Cambria", 10.2F)
        rd_3.Location = New Point(800, 182)
        rd_3.Margin = New Padding(4, 3, 4, 3)
        rd_3.Name = "rd_3"
        rd_3.Size = New Size(135, 24)
        rd_3.TabIndex = 6
        rd_3.TabStop = True
        rd_3.Text = "Croûte épaisse"
        rd_3.UseVisualStyleBackColor = False
        ' 
        ' chk_1
        ' 
        chk_1.AutoSize = True
        chk_1.BackColor = Color.PeachPuff
        chk_1.Font = New Font("Cambria", 10.2F)
        chk_1.Location = New Point(325, 258)
        chk_1.Margin = New Padding(4, 3, 4, 3)
        chk_1.Name = "chk_1"
        chk_1.Size = New Size(128, 24)
        chk_1.TabIndex = 7
        chk_1.Text = "Champignons"
        chk_1.UseVisualStyleBackColor = False
        ' 
        ' chk_2
        ' 
        chk_2.AutoSize = True
        chk_2.BackColor = Color.PeachPuff
        chk_2.Font = New Font("Cambria", 10.2F)
        chk_2.Location = New Point(493, 258)
        chk_2.Margin = New Padding(4, 3, 4, 3)
        chk_2.Name = "chk_2"
        chk_2.Size = New Size(76, 24)
        chk_2.TabIndex = 8
        chk_2.Text = "Olives"
        chk_2.UseVisualStyleBackColor = False
        ' 
        ' chk_3
        ' 
        chk_3.AutoSize = True
        chk_3.BackColor = Color.PeachPuff
        chk_3.Font = New Font("Cambria", 10.2F)
        chk_3.Location = New Point(623, 258)
        chk_3.Margin = New Padding(4, 3, 4, 3)
        chk_3.Name = "chk_3"
        chk_3.Size = New Size(96, 24)
        chk_3.TabIndex = 9
        chk_3.Text = "Poivrons"
        chk_3.UseVisualStyleBackColor = False
        ' 
        ' chk_4
        ' 
        chk_4.AutoSize = True
        chk_4.BackColor = Color.PeachPuff
        chk_4.Font = New Font("Cambria", 10.2F)
        chk_4.Location = New Point(778, 258)
        chk_4.Margin = New Padding(4, 3, 4, 3)
        chk_4.Name = "chk_4"
        chk_4.Size = New Size(209, 24)
        chk_4.TabIndex = 10
        chk_4.Text = "Formage supplémentaire"
        chk_4.UseVisualStyleBackColor = False
        ' 
        ' btn
        ' 
        btn.BackColor = Color.Chocolate
        btn.Location = New Point(325, 348)
        btn.Margin = New Padding(4, 3, 4, 3)
        btn.Name = "btn"
        btn.Size = New Size(254, 62)
        btn.TabIndex = 11
        btn.Text = "Afficher la récapitulatif"
        btn.UseVisualStyleBackColor = False
        ' 
        ' TP3
        ' 
        AutoScaleDimensions = New SizeF(10F, 22F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(224), CByte(224), CByte(224))
        ClientSize = New Size(1000, 495)
        Controls.Add(btn)
        Controls.Add(chk_4)
        Controls.Add(chk_3)
        Controls.Add(chk_2)
        Controls.Add(chk_1)
        Controls.Add(rd_3)
        Controls.Add(rd_2)
        Controls.Add(rd_1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(lst_taille)
        Controls.Add(Label1)
        Font = New Font("Tempus Sans ITC", 10.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Margin = New Padding(4, 3, 4, 3)
        Name = "TP3"
        Text = "TP3"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lst_taille As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents rd_1 As RadioButton
    Friend WithEvents rd_2 As RadioButton
    Friend WithEvents rd_3 As RadioButton
    Friend WithEvents chk_1 As CheckBox
    Friend WithEvents chk_2 As CheckBox
    Friend WithEvents chk_3 As CheckBox
    Friend WithEvents chk_4 As CheckBox
    Friend WithEvents btn As Button

End Class
