<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmJenisPerusahaan
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.APP_CATATAN_PROYEK_TAHUNANDataSet2 = New APLIKASI_PENCATATAN_PROYEK_TAHUNAN.APP_CATATAN_PROYEK_TAHUNANDataSet2()
        Me.JenisperusahaanBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Jenis_perusahaanTableAdapter = New APLIKASI_PENCATATAN_PROYEK_TAHUNAN.APP_CATATAN_PROYEK_TAHUNANDataSet2TableAdapters.Jenis_perusahaanTableAdapter()
        Me.KdjenisperusahaanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JenisperusahaanDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_CATATAN_PROYEK_TAHUNANDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JenisperusahaanBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(128, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(279, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "FORM JENIS PERUSAHAAN"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdjenisperusahaanDataGridViewTextBoxColumn, Me.JenisperusahaanDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.JenisperusahaanBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 86)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(506, 134)
        Me.DataGridView1.TabIndex = 7
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(402, 248)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 25)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Cari"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(230, 279)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 20)
        Me.TextBox2.TabIndex = 18
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(230, 250)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 20)
        Me.TextBox1.TabIndex = 17
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 279)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Jenis Perusahaan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Kode Jenis Perusahaan"
        '
        'APP_CATATAN_PROYEK_TAHUNANDataSet2
        '
        Me.APP_CATATAN_PROYEK_TAHUNANDataSet2.DataSetName = "APP_CATATAN_PROYEK_TAHUNANDataSet2"
        Me.APP_CATATAN_PROYEK_TAHUNANDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'JenisperusahaanBindingSource
        '
        Me.JenisperusahaanBindingSource.DataMember = "Jenis_perusahaan"
        Me.JenisperusahaanBindingSource.DataSource = Me.APP_CATATAN_PROYEK_TAHUNANDataSet2
        '
        'Jenis_perusahaanTableAdapter
        '
        Me.Jenis_perusahaanTableAdapter.ClearBeforeFill = True
        '
        'KdjenisperusahaanDataGridViewTextBoxColumn
        '
        Me.KdjenisperusahaanDataGridViewTextBoxColumn.DataPropertyName = "Kdjenisperusahaan"
        Me.KdjenisperusahaanDataGridViewTextBoxColumn.HeaderText = "Kdjenisperusahaan"
        Me.KdjenisperusahaanDataGridViewTextBoxColumn.Name = "KdjenisperusahaanDataGridViewTextBoxColumn"
        '
        'JenisperusahaanDataGridViewTextBoxColumn
        '
        Me.JenisperusahaanDataGridViewTextBoxColumn.DataPropertyName = "Jenis_perusahaan"
        Me.JenisperusahaanDataGridViewTextBoxColumn.HeaderText = "Jenis_perusahaan"
        Me.JenisperusahaanDataGridViewTextBoxColumn.Name = "JenisperusahaanDataGridViewTextBoxColumn"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(446, 347)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 22
        Me.Button3.Text = "HAPUS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(241, 347)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "EDIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(14, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "TAMBAH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmJenisPerusahaan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 382)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmJenisPerusahaan"
        Me.Text = "Jenis Perusahaan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_CATATAN_PROYEK_TAHUNANDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JenisperusahaanBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents APP_CATATAN_PROYEK_TAHUNANDataSet2 As APP_CATATAN_PROYEK_TAHUNANDataSet2
    Friend WithEvents JenisperusahaanBindingSource As BindingSource
    Friend WithEvents Jenis_perusahaanTableAdapter As APP_CATATAN_PROYEK_TAHUNANDataSet2TableAdapters.Jenis_perusahaanTableAdapter
    Friend WithEvents KdjenisperusahaanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JenisperusahaanDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
