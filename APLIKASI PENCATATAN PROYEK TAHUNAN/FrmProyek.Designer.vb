﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmProyek
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.APP_CATATAN_PROYEK_TAHUNANDataSet4 = New APLIKASI_PENCATATAN_PROYEK_TAHUNAN.APP_CATATAN_PROYEK_TAHUNANDataSet4()
        Me.ProyekBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProyekTableAdapter = New APLIKASI_PENCATATAN_PROYEK_TAHUNAN.APP_CATATAN_PROYEK_TAHUNANDataSet4TableAdapters.ProyekTableAdapter()
        Me.KdproyekDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KdkategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KdjenisperusahaanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JudulproyekDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeskripsipekerjaanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TahunproyekDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NilaikontrakDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FotoDataGridViewImageColumn = New System.Windows.Forms.DataGridViewImageColumn()
        Me.KdmemberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button6 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_CATATAN_PROYEK_TAHUNANDataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProyekBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdproyekDataGridViewTextBoxColumn, Me.KdkategoriDataGridViewTextBoxColumn, Me.KdjenisperusahaanDataGridViewTextBoxColumn, Me.JudulproyekDataGridViewTextBoxColumn, Me.DeskripsipekerjaanDataGridViewTextBoxColumn, Me.TahunproyekDataGridViewTextBoxColumn, Me.NilaikontrakDataGridViewTextBoxColumn, Me.FotoDataGridViewImageColumn, Me.KdmemberDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ProyekBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 65)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(532, 158)
        Me.DataGridView1.TabIndex = 0
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(189, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(159, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "FORM PROYEK"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 247)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Kode Proyek"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(75, 272)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Kode Kategori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 300)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(119, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Kode Jenis Perusahaan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 325)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Judul Proyek"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(75, 349)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(110, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Deskripsi Perusahaan"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(75, 390)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(74, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Tahun Proyek"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(75, 417)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Nilai Kontrak"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(75, 443)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Kode Member"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(217, 247)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(204, 20)
        Me.TextBox1.TabIndex = 13
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(217, 272)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(204, 20)
        Me.TextBox2.TabIndex = 14
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(217, 300)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(204, 20)
        Me.TextBox3.TabIndex = 15
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(217, 325)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(204, 20)
        Me.TextBox4.TabIndex = 16
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(217, 349)
        Me.TextBox5.Multiline = True
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(204, 36)
        Me.TextBox5.TabIndex = 17
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(217, 390)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(157, 21)
        Me.ComboBox1.TabIndex = 18
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(217, 417)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(157, 20)
        Me.TextBox6.TabIndex = 19
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(217, 443)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(157, 20)
        Me.TextBox7.TabIndex = 20
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(78, 469)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(50, 13)
        Me.Label10.TabIndex = 22
        Me.Label10.Text = "Pilih Foto"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(217, 469)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(113, 20)
        Me.TextBox8.TabIndex = 23
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(469, 507)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 36
        Me.Button3.Text = "HAPUS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(239, 507)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 35
        Me.Button2.Text = "EDIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 507)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "TAMBAH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'APP_CATATAN_PROYEK_TAHUNANDataSet4
        '
        Me.APP_CATATAN_PROYEK_TAHUNANDataSet4.DataSetName = "APP_CATATAN_PROYEK_TAHUNANDataSet4"
        Me.APP_CATATAN_PROYEK_TAHUNANDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProyekBindingSource
        '
        Me.ProyekBindingSource.DataMember = "Proyek"
        Me.ProyekBindingSource.DataSource = Me.APP_CATATAN_PROYEK_TAHUNANDataSet4
        '
        'ProyekTableAdapter
        '
        Me.ProyekTableAdapter.ClearBeforeFill = True
        '
        'KdproyekDataGridViewTextBoxColumn
        '
        Me.KdproyekDataGridViewTextBoxColumn.DataPropertyName = "Kdproyek"
        Me.KdproyekDataGridViewTextBoxColumn.HeaderText = "Kdproyek"
        Me.KdproyekDataGridViewTextBoxColumn.Name = "KdproyekDataGridViewTextBoxColumn"
        '
        'KdkategoriDataGridViewTextBoxColumn
        '
        Me.KdkategoriDataGridViewTextBoxColumn.DataPropertyName = "Kdkategori"
        Me.KdkategoriDataGridViewTextBoxColumn.HeaderText = "Kdkategori"
        Me.KdkategoriDataGridViewTextBoxColumn.Name = "KdkategoriDataGridViewTextBoxColumn"
        '
        'KdjenisperusahaanDataGridViewTextBoxColumn
        '
        Me.KdjenisperusahaanDataGridViewTextBoxColumn.DataPropertyName = "Kdjenisperusahaan"
        Me.KdjenisperusahaanDataGridViewTextBoxColumn.HeaderText = "Kdjenisperusahaan"
        Me.KdjenisperusahaanDataGridViewTextBoxColumn.Name = "KdjenisperusahaanDataGridViewTextBoxColumn"
        '
        'JudulproyekDataGridViewTextBoxColumn
        '
        Me.JudulproyekDataGridViewTextBoxColumn.DataPropertyName = "Judul_proyek"
        Me.JudulproyekDataGridViewTextBoxColumn.HeaderText = "Judul_proyek"
        Me.JudulproyekDataGridViewTextBoxColumn.Name = "JudulproyekDataGridViewTextBoxColumn"
        '
        'DeskripsipekerjaanDataGridViewTextBoxColumn
        '
        Me.DeskripsipekerjaanDataGridViewTextBoxColumn.DataPropertyName = "Deskripsi_pekerjaan"
        Me.DeskripsipekerjaanDataGridViewTextBoxColumn.HeaderText = "Deskripsi_pekerjaan"
        Me.DeskripsipekerjaanDataGridViewTextBoxColumn.Name = "DeskripsipekerjaanDataGridViewTextBoxColumn"
        '
        'TahunproyekDataGridViewTextBoxColumn
        '
        Me.TahunproyekDataGridViewTextBoxColumn.DataPropertyName = "Tahun_proyek"
        Me.TahunproyekDataGridViewTextBoxColumn.HeaderText = "Tahun_proyek"
        Me.TahunproyekDataGridViewTextBoxColumn.Name = "TahunproyekDataGridViewTextBoxColumn"
        '
        'NilaikontrakDataGridViewTextBoxColumn
        '
        Me.NilaikontrakDataGridViewTextBoxColumn.DataPropertyName = "Nilai_kontrak"
        Me.NilaikontrakDataGridViewTextBoxColumn.HeaderText = "Nilai_kontrak"
        Me.NilaikontrakDataGridViewTextBoxColumn.Name = "NilaikontrakDataGridViewTextBoxColumn"
        '
        'FotoDataGridViewImageColumn
        '
        Me.FotoDataGridViewImageColumn.DataPropertyName = "Foto"
        Me.FotoDataGridViewImageColumn.HeaderText = "Foto"
        Me.FotoDataGridViewImageColumn.Name = "FotoDataGridViewImageColumn"
        '
        'KdmemberDataGridViewTextBoxColumn
        '
        Me.KdmemberDataGridViewTextBoxColumn.DataPropertyName = "Kdmember"
        Me.KdmemberDataGridViewTextBoxColumn.HeaderText = "Kdmember"
        Me.KdmemberDataGridViewTextBoxColumn.Name = "KdmemberDataGridViewTextBoxColumn"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(336, 469)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(38, 20)
        Me.Button4.TabIndex = 37
        Me.Button4.Text = "..."
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(427, 247)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(43, 20)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "Cari"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(389, 390)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(141, 97)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 21
        Me.PictureBox1.TabStop = False
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(469, 9)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 39
        Me.Button6.Text = "Kembali"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'FrmProyek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 542)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "FrmProyek"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form Proyek"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_CATATAN_PROYEK_TAHUNANDataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProyekBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents APP_CATATAN_PROYEK_TAHUNANDataSet4 As APP_CATATAN_PROYEK_TAHUNANDataSet4
    Friend WithEvents ProyekBindingSource As BindingSource
    Friend WithEvents ProyekTableAdapter As APP_CATATAN_PROYEK_TAHUNANDataSet4TableAdapters.ProyekTableAdapter
    Friend WithEvents KdproyekDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KdkategoriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KdjenisperusahaanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JudulproyekDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DeskripsipekerjaanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TahunproyekDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NilaikontrakDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FotoDataGridViewImageColumn As DataGridViewImageColumn
    Friend WithEvents KdmemberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button6 As Button
End Class
