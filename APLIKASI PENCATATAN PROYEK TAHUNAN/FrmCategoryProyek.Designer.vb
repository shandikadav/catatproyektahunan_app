<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCategoryProyek
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.APP_CATATAN_PROYEK_TAHUNANDataSet = New APLIKASI_PENCATATAN_PROYEK_TAHUNAN.APP_CATATAN_PROYEK_TAHUNANDataSet()
        Me.KategoriproyekBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kategori_proyekTableAdapter = New APLIKASI_PENCATATAN_PROYEK_TAHUNAN.APP_CATATAN_PROYEK_TAHUNANDataSetTableAdapters.Kategori_proyekTableAdapter()
        Me.KdkategoriDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.APP_CATATAN_PROYEK_TAHUNANDataSet1 = New APLIKASI_PENCATATAN_PROYEK_TAHUNAN.APP_CATATAN_PROYEK_TAHUNANDataSet1()
        Me.KategoriproyekBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Kategori_proyekTableAdapter1 = New APLIKASI_PENCATATAN_PROYEK_TAHUNAN.APP_CATATAN_PROYEK_TAHUNANDataSet1TableAdapters.Kategori_proyekTableAdapter()
        Me.Nama_kategori = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_CATATAN_PROYEK_TAHUNANDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KategoriproyekBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.APP_CATATAN_PROYEK_TAHUNANDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KategoriproyekBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(129, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(269, 24)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "FORM KATEGORI PROYEK"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.KdkategoriDataGridViewTextBoxColumn, Me.Nama_kategori})
        Me.DataGridView1.DataSource = Me.KategoriproyekBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(13, 78)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(506, 134)
        Me.DataGridView1.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(106, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Kode Kategori"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 281)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Nama Kategori"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(211, 252)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(166, 20)
        Me.TextBox1.TabIndex = 9
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(211, 281)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(166, 20)
        Me.TextBox2.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 347)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "TAMBAH"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(239, 347)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 12
        Me.Button2.Text = "EDIT"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(444, 347)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 13
        Me.Button3.Text = "HAPUS"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(383, 250)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(40, 25)
        Me.Button4.TabIndex = 14
        Me.Button4.Text = "Cari"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'APP_CATATAN_PROYEK_TAHUNANDataSet
        '
        Me.APP_CATATAN_PROYEK_TAHUNANDataSet.DataSetName = "APP_CATATAN_PROYEK_TAHUNANDataSet"
        Me.APP_CATATAN_PROYEK_TAHUNANDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KategoriproyekBindingSource
        '
        Me.KategoriproyekBindingSource.DataMember = "Kategori_proyek"
        Me.KategoriproyekBindingSource.DataSource = Me.APP_CATATAN_PROYEK_TAHUNANDataSet
        '
        'Kategori_proyekTableAdapter
        '
        Me.Kategori_proyekTableAdapter.ClearBeforeFill = True
        '
        'KdkategoriDataGridViewTextBoxColumn
        '
        Me.KdkategoriDataGridViewTextBoxColumn.DataPropertyName = "Kdkategori"
        Me.KdkategoriDataGridViewTextBoxColumn.HeaderText = "Kdkategori"
        Me.KdkategoriDataGridViewTextBoxColumn.Name = "KdkategoriDataGridViewTextBoxColumn"
        '
        'APP_CATATAN_PROYEK_TAHUNANDataSet1
        '
        Me.APP_CATATAN_PROYEK_TAHUNANDataSet1.DataSetName = "APP_CATATAN_PROYEK_TAHUNANDataSet1"
        Me.APP_CATATAN_PROYEK_TAHUNANDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KategoriproyekBindingSource1
        '
        Me.KategoriproyekBindingSource1.DataMember = "Kategori_proyek"
        Me.KategoriproyekBindingSource1.DataSource = Me.APP_CATATAN_PROYEK_TAHUNANDataSet1
        '
        'Kategori_proyekTableAdapter1
        '
        Me.Kategori_proyekTableAdapter1.ClearBeforeFill = True
        '
        'Nama_kategori
        '
        Me.Nama_kategori.DataPropertyName = "Nama_kategori"
        Me.Nama_kategori.HeaderText = "Nama_kategori"
        Me.Nama_kategori.Name = "Nama_kategori"
        '
        'FrmCategoryProyek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 382)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Name = "FrmCategoryProyek"
        Me.Text = "Category Proyek"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_CATATAN_PROYEK_TAHUNANDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KategoriproyekBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.APP_CATATAN_PROYEK_TAHUNANDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KategoriproyekBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents APP_CATATAN_PROYEK_TAHUNANDataSet As APP_CATATAN_PROYEK_TAHUNANDataSet
    Friend WithEvents KategoriproyekBindingSource As BindingSource
    Friend WithEvents Kategori_proyekTableAdapter As APP_CATATAN_PROYEK_TAHUNANDataSetTableAdapters.Kategori_proyekTableAdapter
    Friend WithEvents KdkategoriDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents APP_CATATAN_PROYEK_TAHUNANDataSet1 As APP_CATATAN_PROYEK_TAHUNANDataSet1
    Friend WithEvents KategoriproyekBindingSource1 As BindingSource
    Friend WithEvents Kategori_proyekTableAdapter1 As APP_CATATAN_PROYEK_TAHUNANDataSet1TableAdapters.Kategori_proyekTableAdapter
    Friend WithEvents Nama_kategori As DataGridViewTextBoxColumn
End Class
