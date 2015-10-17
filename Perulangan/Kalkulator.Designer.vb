<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Kalkulator
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
        Me.Lbl_matrik1 = New System.Windows.Forms.Label()
        Me.Lbl_operasi = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Lbl_hasil = New System.Windows.Forms.Label()
        Me.text_matrik1 = New System.Windows.Forms.TextBox()
        Me.text_matrik2 = New System.Windows.Forms.TextBox()
        Me.text_hasil = New System.Windows.Forms.TextBox()
        Me.Combo_operasi = New System.Windows.Forms.ComboBox()
        Me.btn_proses = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Lbl_matrik1
        '
        Me.Lbl_matrik1.AutoSize = True
        Me.Lbl_matrik1.Location = New System.Drawing.Point(16, 16)
        Me.Lbl_matrik1.Name = "Lbl_matrik1"
        Me.Lbl_matrik1.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_matrik1.TabIndex = 0
        Me.Lbl_matrik1.Text = "Matrik 1"
        '
        'Lbl_operasi
        '
        Me.Lbl_operasi.AutoSize = True
        Me.Lbl_operasi.Location = New System.Drawing.Point(18, 118)
        Me.Lbl_operasi.Name = "Lbl_operasi"
        Me.Lbl_operasi.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_operasi.TabIndex = 1
        Me.Lbl_operasi.Text = "Operasi"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 157)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Matrik 2"
        '
        'Lbl_hasil
        '
        Me.Lbl_hasil.AutoSize = True
        Me.Lbl_hasil.Location = New System.Drawing.Point(18, 254)
        Me.Lbl_hasil.Name = "Lbl_hasil"
        Me.Lbl_hasil.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_hasil.TabIndex = 3
        Me.Lbl_hasil.Text = "Hasil"
        '
        'text_matrik1
        '
        Me.text_matrik1.Location = New System.Drawing.Point(77, 12)
        Me.text_matrik1.Multiline = True
        Me.text_matrik1.Name = "text_matrik1"
        Me.text_matrik1.Size = New System.Drawing.Size(327, 92)
        Me.text_matrik1.TabIndex = 4
        '
        'text_matrik2
        '
        Me.text_matrik2.Location = New System.Drawing.Point(77, 157)
        Me.text_matrik2.Multiline = True
        Me.text_matrik2.Name = "text_matrik2"
        Me.text_matrik2.Size = New System.Drawing.Size(327, 79)
        Me.text_matrik2.TabIndex = 5
        '
        'text_hasil
        '
        Me.text_hasil.Location = New System.Drawing.Point(77, 254)
        Me.text_hasil.Multiline = True
        Me.text_hasil.Name = "text_hasil"
        Me.text_hasil.Size = New System.Drawing.Size(327, 112)
        Me.text_hasil.TabIndex = 6
        '
        'Combo_operasi
        '
        Me.Combo_operasi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Combo_operasi.DropDownWidth = 368
        Me.Combo_operasi.FormattingEnabled = True
        Me.Combo_operasi.Items.AddRange(New Object() {"Tambah", "Kurang"})
        Me.Combo_operasi.Location = New System.Drawing.Point(77, 110)
        Me.Combo_operasi.Name = "Combo_operasi"
        Me.Combo_operasi.Size = New System.Drawing.Size(327, 21)
        Me.Combo_operasi.TabIndex = 7
        '
        'btn_proses
        '
        Me.btn_proses.Location = New System.Drawing.Point(329, 372)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(75, 23)
        Me.btn_proses.TabIndex = 8
        Me.btn_proses.Text = "Proses"
        Me.btn_proses.UseVisualStyleBackColor = True
        '
        'Kalkulator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 402)
        Me.Controls.Add(Me.btn_proses)
        Me.Controls.Add(Me.Combo_operasi)
        Me.Controls.Add(Me.text_hasil)
        Me.Controls.Add(Me.text_matrik2)
        Me.Controls.Add(Me.text_matrik1)
        Me.Controls.Add(Me.Lbl_hasil)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Lbl_operasi)
        Me.Controls.Add(Me.Lbl_matrik1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Kalkulator"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Matriks Kalkulator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Lbl_matrik1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_operasi As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Lbl_hasil As System.Windows.Forms.Label
    Friend WithEvents text_matrik1 As System.Windows.Forms.TextBox
    Friend WithEvents text_matrik2 As System.Windows.Forms.TextBox
    Friend WithEvents text_hasil As System.Windows.Forms.TextBox
    Friend WithEvents Combo_operasi As System.Windows.Forms.ComboBox
    Friend WithEvents btn_proses As System.Windows.Forms.Button
End Class
