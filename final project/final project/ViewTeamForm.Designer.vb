﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTeamForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ViewTeamForm))
        Me.dgvteam = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AbilityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Move1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Move2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Move3DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Move4DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PokemonDataSet = New final_project.PokemonDataSet()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbtnShowTeam = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnDeletePokemon = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnAddPokemon = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnDeleteTeam = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbtnCancel = New System.Windows.Forms.ToolStripButton()
        Me.TeamTableAdapter = New final_project.PokemonDataSetTableAdapters.teamTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvteam, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PokemonDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvteam
        '
        Me.dgvteam.AutoGenerateColumns = False
        Me.dgvteam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvteam.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AbilityDataGridViewTextBoxColumn, Me.Move1DataGridViewTextBoxColumn, Me.Move2DataGridViewTextBoxColumn, Me.Move3DataGridViewTextBoxColumn, Me.Move4DataGridViewTextBoxColumn})
        Me.dgvteam.DataSource = Me.TeamBindingSource
        Me.dgvteam.Location = New System.Drawing.Point(12, 73)
        Me.dgvteam.Name = "dgvteam"
        Me.dgvteam.RowTemplate.Height = 24
        Me.dgvteam.Size = New System.Drawing.Size(585, 365)
        Me.dgvteam.TabIndex = 1
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'AbilityDataGridViewTextBoxColumn
        '
        Me.AbilityDataGridViewTextBoxColumn.DataPropertyName = "ability"
        Me.AbilityDataGridViewTextBoxColumn.HeaderText = "ability"
        Me.AbilityDataGridViewTextBoxColumn.Name = "AbilityDataGridViewTextBoxColumn"
        '
        'Move1DataGridViewTextBoxColumn
        '
        Me.Move1DataGridViewTextBoxColumn.DataPropertyName = "move1"
        Me.Move1DataGridViewTextBoxColumn.HeaderText = "move1"
        Me.Move1DataGridViewTextBoxColumn.Name = "Move1DataGridViewTextBoxColumn"
        '
        'Move2DataGridViewTextBoxColumn
        '
        Me.Move2DataGridViewTextBoxColumn.DataPropertyName = "move2"
        Me.Move2DataGridViewTextBoxColumn.HeaderText = "move2"
        Me.Move2DataGridViewTextBoxColumn.Name = "Move2DataGridViewTextBoxColumn"
        '
        'Move3DataGridViewTextBoxColumn
        '
        Me.Move3DataGridViewTextBoxColumn.DataPropertyName = "move3"
        Me.Move3DataGridViewTextBoxColumn.HeaderText = "move3"
        Me.Move3DataGridViewTextBoxColumn.Name = "Move3DataGridViewTextBoxColumn"
        '
        'Move4DataGridViewTextBoxColumn
        '
        Me.Move4DataGridViewTextBoxColumn.DataPropertyName = "move4"
        Me.Move4DataGridViewTextBoxColumn.HeaderText = "move4"
        Me.Move4DataGridViewTextBoxColumn.Name = "Move4DataGridViewTextBoxColumn"
        '
        'TeamBindingSource
        '
        Me.TeamBindingSource.DataMember = "team"
        Me.TeamBindingSource.DataSource = Me.PokemonDataSet
        '
        'PokemonDataSet
        '
        Me.PokemonDataSet.DataSetName = "PokemonDataSet"
        Me.PokemonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbtnShowTeam, Me.ToolStripSeparator1, Me.tsbtnDeletePokemon, Me.ToolStripSeparator2, Me.tsbtnAddPokemon, Me.ToolStripSeparator3, Me.tsbtnDeleteTeam, Me.ToolStripSeparator4, Me.tsbtnCancel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(609, 27)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'tsbtnShowTeam
        '
        Me.tsbtnShowTeam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnShowTeam.Image = CType(resources.GetObject("tsbtnShowTeam.Image"), System.Drawing.Image)
        Me.tsbtnShowTeam.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnShowTeam.Name = "tsbtnShowTeam"
        Me.tsbtnShowTeam.Size = New System.Drawing.Size(85, 24)
        Me.tsbtnShowTeam.Text = "show team"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'tsbtnDeletePokemon
        '
        Me.tsbtnDeletePokemon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDeletePokemon.Image = CType(resources.GetObject("tsbtnDeletePokemon.Image"), System.Drawing.Image)
        Me.tsbtnDeletePokemon.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDeletePokemon.Name = "tsbtnDeletePokemon"
        Me.tsbtnDeletePokemon.Size = New System.Drawing.Size(122, 24)
        Me.tsbtnDeletePokemon.Text = "Delete Pokemon"
        Me.tsbtnDeletePokemon.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'tsbtnAddPokemon
        '
        Me.tsbtnAddPokemon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnAddPokemon.Image = CType(resources.GetObject("tsbtnAddPokemon.Image"), System.Drawing.Image)
        Me.tsbtnAddPokemon.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnAddPokemon.Name = "tsbtnAddPokemon"
        Me.tsbtnAddPokemon.Size = New System.Drawing.Size(106, 24)
        Me.tsbtnAddPokemon.Text = "Add Pokemon"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 27)
        '
        'tsbtnDeleteTeam
        '
        Me.tsbtnDeleteTeam.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnDeleteTeam.Image = CType(resources.GetObject("tsbtnDeleteTeam.Image"), System.Drawing.Image)
        Me.tsbtnDeleteTeam.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnDeleteTeam.Name = "tsbtnDeleteTeam"
        Me.tsbtnDeleteTeam.Size = New System.Drawing.Size(97, 24)
        Me.tsbtnDeleteTeam.Text = "Delete Team"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 27)
        '
        'tsbtnCancel
        '
        Me.tsbtnCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbtnCancel.Image = CType(resources.GetObject("tsbtnCancel.Image"), System.Drawing.Image)
        Me.tsbtnCancel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbtnCancel.Name = "tsbtnCancel"
        Me.tsbtnCancel.Size = New System.Drawing.Size(57, 24)
        Me.tsbtnCancel.Text = "Cancel"
        '
        'TeamTableAdapter
        '
        Me.TeamTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(347, 17)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "if you team does not show up at first click ""show team"""
        '
        'ViewTeamForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(609, 442)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvteam)
        Me.Name = "ViewTeamForm"
        Me.Text = "ViewTeamForm"
        CType(Me.dgvteam, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PokemonDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvteam As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbtnDeletePokemon As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbtnAddPokemon As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbtnDeleteTeam As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbtnCancel As ToolStripButton
    Friend WithEvents PokemonDataSet As PokemonDataSet
    Friend WithEvents TeamBindingSource As BindingSource
    Friend WithEvents TeamTableAdapter As PokemonDataSetTableAdapters.teamTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TypingDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AbilityDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Move1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Move2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Move3DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Move4DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tsbtnShowTeam As ToolStripButton
    Friend WithEvents Label1 As Label
End Class
