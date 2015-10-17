<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Bintang
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
        Me.combo_pola = New System.Windows.Forms.ComboBox()
        Me.btn_proses = New System.Windows.Forms.Button()
        Me.text_baris = New System.Windows.Forms.TextBox()
        Me.text_hasil = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'combo_pola
        '
        Me.combo_pola.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.combo_pola.DropDownWidth = 386
        Me.combo_pola.FormattingEnabled = True
        Me.combo_pola.Items.AddRange(New Object() {"Pyramid", "Hollow Pyramid", "Interverd Pyramid", "Hollow Interverd Pyramid"})
        Me.combo_pola.Location = New System.Drawing.Point(68, 21)
        Me.combo_pola.Name = "combo_pola"
        Me.combo_pola.Size = New System.Drawing.Size(370, 21)
        Me.combo_pola.TabIndex = 2
        '
        'btn_proses
        '
        Me.btn_proses.Location = New System.Drawing.Point(363, 56)
        Me.btn_proses.Name = "btn_proses"
        Me.btn_proses.Size = New System.Drawing.Size(75, 23)
        Me.btn_proses.TabIndex = 1
        Me.btn_proses.Text = "Proses"
        Me.btn_proses.UseVisualStyleBackColor = True
        '
        'text_baris
        '
        Me.text_baris.Location = New System.Drawing.Point(68, 59)
        Me.text_baris.Name = "text_baris"
        Me.text_baris.Size = New System.Drawing.Size(289, 20)
        Me.text_baris.TabIndex = 2
        '
        'text_hasil
        '
        Me.text_hasil.Location = New System.Drawing.Point(26, 94)
        Me.text_hasil.Multiline = True
        Me.text_hasil.Name = "text_hasil"
        Me.text_hasil.Size = New System.Drawing.Size(412, 310)
        Me.text_hasil.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(28, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Pola"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Baris"
        '
        'Bintang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 425)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.text_hasil)
        Me.Controls.Add(Me.text_baris)
        Me.Controls.Add(Me.btn_proses)
        Me.Controls.Add(Me.combo_pola)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Bintang"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Problem Bintang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents combo_pola As System.Windows.Forms.ComboBox
    Friend WithEvents btn_proses As System.Windows.Forms.Button
    Friend WithEvents text_baris As System.Windows.Forms.TextBox
    Friend WithEvents text_hasil As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
