<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CardListDisplay
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
        Me.btnDE = New System.Windows.Forms.Button()
        Me.btnDS = New System.Windows.Forms.Button()
        Me.btnKS = New System.Windows.Forms.Button()
        Me.btnStoi = New System.Windows.Forms.Button()
        Me.btnBG = New System.Windows.Forms.Button()
        Me.btnLM = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnG0 = New System.Windows.Forms.Button()
        Me.btnG1 = New System.Windows.Forms.Button()
        Me.btnG2 = New System.Windows.Forms.Button()
        Me.btnG3 = New System.Windows.Forms.Button()
        Me.btnG4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CardNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GradeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RarityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CardListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.COMP4400DataSet = New COMP4400TrabajoFinal.COMP4400DataSet()
        Me.CardListTableAdapter = New COMP4400TrabajoFinal.COMP4400DataSetTableAdapters.CardListTableAdapter()
        Me.btnReset = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CardListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COMP4400DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnDE
        '
        Me.btnDE.Location = New System.Drawing.Point(24, 407)
        Me.btnDE.Name = "btnDE"
        Me.btnDE.Size = New System.Drawing.Size(95, 35)
        Me.btnDE.TabIndex = 0
        Me.btnDE.Text = "DE"
        Me.btnDE.UseVisualStyleBackColor = True
        '
        'btnDS
        '
        Me.btnDS.Location = New System.Drawing.Point(172, 407)
        Me.btnDS.Name = "btnDS"
        Me.btnDS.Size = New System.Drawing.Size(95, 35)
        Me.btnDS.TabIndex = 1
        Me.btnDS.Text = "DS"
        Me.btnDS.UseVisualStyleBackColor = True
        '
        'btnKS
        '
        Me.btnKS.Location = New System.Drawing.Point(330, 407)
        Me.btnKS.Name = "btnKS"
        Me.btnKS.Size = New System.Drawing.Size(95, 35)
        Me.btnKS.TabIndex = 2
        Me.btnKS.Text = "KS"
        Me.btnKS.UseVisualStyleBackColor = True
        '
        'btnStoi
        '
        Me.btnStoi.Location = New System.Drawing.Point(24, 461)
        Me.btnStoi.Name = "btnStoi"
        Me.btnStoi.Size = New System.Drawing.Size(95, 35)
        Me.btnStoi.TabIndex = 3
        Me.btnStoi.Text = "Stoi"
        Me.btnStoi.UseVisualStyleBackColor = True
        '
        'btnBG
        '
        Me.btnBG.Location = New System.Drawing.Point(172, 461)
        Me.btnBG.Name = "btnBG"
        Me.btnBG.Size = New System.Drawing.Size(95, 35)
        Me.btnBG.TabIndex = 4
        Me.btnBG.Text = "BG"
        Me.btnBG.UseVisualStyleBackColor = True
        '
        'btnLM
        '
        Me.btnLM.Location = New System.Drawing.Point(330, 461)
        Me.btnLM.Name = "btnLM"
        Me.btnLM.Size = New System.Drawing.Size(95, 35)
        Me.btnLM.TabIndex = 5
        Me.btnLM.Text = "LM"
        Me.btnLM.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(176, 378)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 16)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Sort by Nation"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(177, 519)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Sort by Grade"
        '
        'btnG0
        '
        Me.btnG0.Location = New System.Drawing.Point(27, 555)
        Me.btnG0.Name = "btnG0"
        Me.btnG0.Size = New System.Drawing.Size(47, 35)
        Me.btnG0.TabIndex = 8
        Me.btnG0.Text = "0"
        Me.btnG0.UseVisualStyleBackColor = True
        '
        'btnG1
        '
        Me.btnG1.Location = New System.Drawing.Point(111, 555)
        Me.btnG1.Name = "btnG1"
        Me.btnG1.Size = New System.Drawing.Size(47, 35)
        Me.btnG1.TabIndex = 9
        Me.btnG1.Text = "1"
        Me.btnG1.UseVisualStyleBackColor = True
        '
        'btnG2
        '
        Me.btnG2.Location = New System.Drawing.Point(200, 555)
        Me.btnG2.Name = "btnG2"
        Me.btnG2.Size = New System.Drawing.Size(47, 35)
        Me.btnG2.TabIndex = 10
        Me.btnG2.Text = "2"
        Me.btnG2.UseVisualStyleBackColor = True
        '
        'btnG3
        '
        Me.btnG3.Location = New System.Drawing.Point(283, 555)
        Me.btnG3.Name = "btnG3"
        Me.btnG3.Size = New System.Drawing.Size(47, 35)
        Me.btnG3.TabIndex = 11
        Me.btnG3.Text = "3"
        Me.btnG3.UseVisualStyleBackColor = True
        '
        'btnG4
        '
        Me.btnG4.Location = New System.Drawing.Point(366, 555)
        Me.btnG4.Name = "btnG4"
        Me.btnG4.Size = New System.Drawing.Size(47, 35)
        Me.btnG4.TabIndex = 12
        Me.btnG4.Text = "4"
        Me.btnG4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CardNumberDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.GradeDataGridViewTextBoxColumn, Me.NationDataGridViewTextBoxColumn, Me.TypeDataGridViewTextBoxColumn, Me.RarityDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CardListBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(441, 346)
        Me.DataGridView1.TabIndex = 13
        '
        'CardNumberDataGridViewTextBoxColumn
        '
        Me.CardNumberDataGridViewTextBoxColumn.DataPropertyName = "CardNumber"
        Me.CardNumberDataGridViewTextBoxColumn.HeaderText = "CardNumber"
        Me.CardNumberDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.CardNumberDataGridViewTextBoxColumn.Name = "CardNumberDataGridViewTextBoxColumn"
        Me.CardNumberDataGridViewTextBoxColumn.Width = 125
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 125
        '
        'GradeDataGridViewTextBoxColumn
        '
        Me.GradeDataGridViewTextBoxColumn.DataPropertyName = "Grade"
        Me.GradeDataGridViewTextBoxColumn.HeaderText = "Grade"
        Me.GradeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.GradeDataGridViewTextBoxColumn.Name = "GradeDataGridViewTextBoxColumn"
        Me.GradeDataGridViewTextBoxColumn.Width = 125
        '
        'NationDataGridViewTextBoxColumn
        '
        Me.NationDataGridViewTextBoxColumn.DataPropertyName = "Nation"
        Me.NationDataGridViewTextBoxColumn.HeaderText = "Nation"
        Me.NationDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.NationDataGridViewTextBoxColumn.Name = "NationDataGridViewTextBoxColumn"
        Me.NationDataGridViewTextBoxColumn.Width = 125
        '
        'TypeDataGridViewTextBoxColumn
        '
        Me.TypeDataGridViewTextBoxColumn.DataPropertyName = "Type"
        Me.TypeDataGridViewTextBoxColumn.HeaderText = "Type"
        Me.TypeDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.TypeDataGridViewTextBoxColumn.Name = "TypeDataGridViewTextBoxColumn"
        Me.TypeDataGridViewTextBoxColumn.Width = 125
        '
        'RarityDataGridViewTextBoxColumn
        '
        Me.RarityDataGridViewTextBoxColumn.DataPropertyName = "Rarity"
        Me.RarityDataGridViewTextBoxColumn.HeaderText = "Rarity"
        Me.RarityDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.RarityDataGridViewTextBoxColumn.Name = "RarityDataGridViewTextBoxColumn"
        Me.RarityDataGridViewTextBoxColumn.Width = 125
        '
        'CardListBindingSource
        '
        Me.CardListBindingSource.DataMember = "CardList"
        Me.CardListBindingSource.DataSource = Me.COMP4400DataSet
        '
        'COMP4400DataSet
        '
        Me.COMP4400DataSet.DataSetName = "COMP4400DataSet"
        Me.COMP4400DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CardListTableAdapter
        '
        Me.CardListTableAdapter.ClearBeforeFill = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(164, 653)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(126, 51)
        Me.btnReset.TabIndex = 14
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'CardListDisplay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 749)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.btnG4)
        Me.Controls.Add(Me.btnG3)
        Me.Controls.Add(Me.btnG2)
        Me.Controls.Add(Me.btnG1)
        Me.Controls.Add(Me.btnG0)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLM)
        Me.Controls.Add(Me.btnBG)
        Me.Controls.Add(Me.btnStoi)
        Me.Controls.Add(Me.btnKS)
        Me.Controls.Add(Me.btnDS)
        Me.Controls.Add(Me.btnDE)
        Me.Name = "CardListDisplay"
        Me.Text = "Card List"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CardListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COMP4400DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnDE As Button
    Friend WithEvents btnDS As Button
    Friend WithEvents btnKS As Button
    Friend WithEvents btnStoi As Button
    Friend WithEvents btnBG As Button
    Friend WithEvents btnLM As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnG0 As Button
    Friend WithEvents btnG1 As Button
    Friend WithEvents btnG2 As Button
    Friend WithEvents btnG3 As Button
    Friend WithEvents btnG4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents COMP4400DataSet As COMP4400DataSet
    Friend WithEvents CardListBindingSource As BindingSource
    Friend WithEvents CardListTableAdapter As COMP4400DataSetTableAdapters.CardListTableAdapter
    Friend WithEvents CardNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents GradeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NationDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RarityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnReset As Button
End Class
