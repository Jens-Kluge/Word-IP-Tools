<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmNumberParagraphs
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNumberParagraphs))
        Me.btnNumberPars = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnRemoveThis = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnFwd = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btnRewind = New System.Windows.Forms.Button()
        Me.btnffwd = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.lblDigits = New System.Windows.Forms.Label()
        Me.lblPreview = New System.Windows.Forms.Label()
        Me.btnAddNumberSel = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNumberPars
        '
        Me.btnNumberPars.Location = New System.Drawing.Point(18, 20)
        Me.btnNumberPars.Name = "btnNumberPars"
        Me.btnNumberPars.Size = New System.Drawing.Size(154, 56)
        Me.btnNumberPars.TabIndex = 0
        Me.btnNumberPars.Text = "Number Paragraphs"
        Me.btnNumberPars.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(350, 20)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(154, 56)
        Me.btnUpdate.TabIndex = 1
        Me.btnUpdate.Text = "Update Fields"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(178, 20)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(166, 56)
        Me.btnRemove.TabIndex = 2
        Me.btnRemove.Text = "Remove all paragraph numbers"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnRemoveThis
        '
        Me.btnRemoveThis.Location = New System.Drawing.Point(178, 82)
        Me.btnRemoveThis.Name = "btnRemoveThis"
        Me.btnRemoveThis.Size = New System.Drawing.Size(166, 56)
        Me.btnRemoveThis.TabIndex = 3
        Me.btnRemoveThis.Text = "Remove numbering in selected paragraphs"
        Me.btnRemoveThis.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Image = Global.iptools.My.Resources.Resources.Arrow_Back_2_icon
        Me.btnBack.Location = New System.Drawing.Point(87, 13)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(60, 64)
        Me.btnBack.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnBack, "Move back to previous paragraph.")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnFwd
        '
        Me.btnFwd.Image = Global.iptools.My.Resources.Resources.Arrow_Next_2_icon
        Me.btnFwd.Location = New System.Drawing.Point(153, 13)
        Me.btnFwd.Name = "btnFwd"
        Me.btnFwd.Size = New System.Drawing.Size(60, 64)
        Me.btnFwd.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnFwd, "Move forward to next paragraph.")
        Me.btnFwd.UseVisualStyleBackColor = True
        '
        'btnRewind
        '
        Me.btnRewind.Image = Global.iptools.My.Resources.Resources.Arrow_Back_icon
        Me.btnRewind.Location = New System.Drawing.Point(21, 13)
        Me.btnRewind.Name = "btnRewind"
        Me.btnRewind.Size = New System.Drawing.Size(60, 64)
        Me.btnRewind.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnRewind, "Move back 5 paragraphs.")
        Me.btnRewind.UseVisualStyleBackColor = True
        '
        'btnffwd
        '
        Me.btnffwd.Image = Global.iptools.My.Resources.Resources.Arrow_Next_icon
        Me.btnffwd.Location = New System.Drawing.Point(219, 13)
        Me.btnffwd.Name = "btnffwd"
        Me.btnffwd.Size = New System.Drawing.Size(60, 64)
        Me.btnffwd.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnffwd, "Move forward 5 paragraphs.")
        Me.btnffwd.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnffwd)
        Me.Panel1.Controls.Add(Me.btnFwd)
        Me.Panel1.Controls.Add(Me.btnRewind)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Location = New System.Drawing.Point(18, 150)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 89)
        Me.Panel1.TabIndex = 7
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(361, 106)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {5, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(47, 22)
        Me.NumericUpDown1.TabIndex = 8
        Me.NumericUpDown1.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'lblDigits
        '
        Me.lblDigits.AutoSize = True
        Me.lblDigits.Location = New System.Drawing.Point(360, 82)
        Me.lblDigits.Name = "lblDigits"
        Me.lblDigits.Size = New System.Drawing.Size(43, 17)
        Me.lblDigits.TabIndex = 9
        Me.lblDigits.Text = "Digits"
        '
        'lblPreview
        '
        Me.lblPreview.AutoSize = True
        Me.lblPreview.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPreview.Location = New System.Drawing.Point(424, 95)
        Me.lblPreview.Name = "lblPreview"
        Me.lblPreview.Size = New System.Drawing.Size(68, 25)
        Me.lblPreview.TabIndex = 10
        Me.lblPreview.Text = "[0001]"
        '
        'btnAddNumberSel
        '
        Me.btnAddNumberSel.Location = New System.Drawing.Point(18, 82)
        Me.btnAddNumberSel.Name = "btnAddNumberSel"
        Me.btnAddNumberSel.Size = New System.Drawing.Size(154, 56)
        Me.btnAddNumberSel.TabIndex = 11
        Me.btnAddNumberSel.Text = "Add numbering in selected paragraphs"
        Me.btnAddNumberSel.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(410, 167)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 56)
        Me.btnClose.TabIndex = 12
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmNumberParagraphs
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(531, 257)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddNumberSel)
        Me.Controls.Add(Me.lblPreview)
        Me.Controls.Add(Me.lblDigits)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.btnRemoveThis)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNumberPars)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimumSize = New System.Drawing.Size(342, 186)
        Me.Name = "frmNumberParagraphs"
        Me.Text = "Number Paragraphs"
        Me.Panel1.ResumeLayout(False)
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNumberPars As Windows.Forms.Button
    Friend WithEvents btnUpdate As Windows.Forms.Button
    Friend WithEvents btnRemove As Windows.Forms.Button
    Friend WithEvents btnRemoveThis As Windows.Forms.Button
    Friend WithEvents btnBack As Windows.Forms.Button
    Friend WithEvents btnFwd As Windows.Forms.Button
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
    Friend WithEvents btnRewind As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents btnffwd As Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As Windows.Forms.NumericUpDown
    Friend WithEvents lblDigits As Windows.Forms.Label
    Friend WithEvents lblPreview As Windows.Forms.Label
    Friend WithEvents btnAddNumberSel As Windows.Forms.Button
    Friend WithEvents btnClose As Windows.Forms.Button
End Class
