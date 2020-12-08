<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmNumberSentences
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmNumberSentences))
        Me.btnAddNumSelStcs = New System.Windows.Forms.Button()
        Me.btnRemoveNumSelStcs = New System.Windows.Forms.Button()
        Me.btnRemove = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNumberStcs = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnffwd = New System.Windows.Forms.Button()
        Me.btnFwd = New System.Windows.Forms.Button()
        Me.btnRewind = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbStc = New System.Windows.Forms.RadioButton()
        Me.rbfld = New System.Windows.Forms.RadioButton()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Panel1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddNumSelStcs
        '
        Me.btnAddNumSelStcs.Location = New System.Drawing.Point(21, 74)
        Me.btnAddNumSelStcs.Name = "btnAddNumSelStcs"
        Me.btnAddNumSelStcs.Size = New System.Drawing.Size(154, 56)
        Me.btnAddNumSelStcs.TabIndex = 20
        Me.btnAddNumSelStcs.Text = "Add numbering in selection"
        Me.btnAddNumSelStcs.UseVisualStyleBackColor = True
        '
        'btnRemoveNumSelStcs
        '
        Me.btnRemoveNumSelStcs.Location = New System.Drawing.Point(181, 74)
        Me.btnRemoveNumSelStcs.Name = "btnRemoveNumSelStcs"
        Me.btnRemoveNumSelStcs.Size = New System.Drawing.Size(166, 56)
        Me.btnRemoveNumSelStcs.TabIndex = 15
        Me.btnRemoveNumSelStcs.Text = "Remove numbering in selection"
        Me.btnRemoveNumSelStcs.UseVisualStyleBackColor = True
        '
        'btnRemove
        '
        Me.btnRemove.Location = New System.Drawing.Point(181, 12)
        Me.btnRemove.Name = "btnRemove"
        Me.btnRemove.Size = New System.Drawing.Size(166, 56)
        Me.btnRemove.TabIndex = 14
        Me.btnRemove.Text = "Remove all sentence numbers"
        Me.btnRemove.UseVisualStyleBackColor = True
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(353, 12)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(154, 56)
        Me.btnUpdate.TabIndex = 13
        Me.btnUpdate.Text = "Update Fields"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'btnNumberStcs
        '
        Me.btnNumberStcs.Location = New System.Drawing.Point(21, 12)
        Me.btnNumberStcs.Name = "btnNumberStcs"
        Me.btnNumberStcs.Size = New System.Drawing.Size(154, 56)
        Me.btnNumberStcs.TabIndex = 12
        Me.btnNumberStcs.Text = "Number Sentences"
        Me.btnNumberStcs.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnffwd)
        Me.Panel1.Controls.Add(Me.btnFwd)
        Me.Panel1.Controls.Add(Me.btnRewind)
        Me.Panel1.Controls.Add(Me.btnBack)
        Me.Panel1.Location = New System.Drawing.Point(119, 148)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(278, 69)
        Me.Panel1.TabIndex = 16
        '
        'btnffwd
        '
        Me.btnffwd.Image = Global.iptools.My.Resources.Resources.Arrow_Next_icon
        Me.btnffwd.Location = New System.Drawing.Point(211, 5)
        Me.btnffwd.Name = "btnffwd"
        Me.btnffwd.Size = New System.Drawing.Size(60, 64)
        Me.btnffwd.TabIndex = 7
        Me.ToolTip1.SetToolTip(Me.btnffwd, "move forward 5 sentences")
        Me.btnffwd.UseVisualStyleBackColor = True
        '
        'btnFwd
        '
        Me.btnFwd.Image = Global.iptools.My.Resources.Resources.Arrow_Next_2_icon
        Me.btnFwd.Location = New System.Drawing.Point(145, 5)
        Me.btnFwd.Name = "btnFwd"
        Me.btnFwd.Size = New System.Drawing.Size(60, 64)
        Me.btnFwd.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnFwd, "Move forward one sentence")
        Me.btnFwd.UseVisualStyleBackColor = True
        '
        'btnRewind
        '
        Me.btnRewind.Image = Global.iptools.My.Resources.Resources.Arrow_Back_icon
        Me.btnRewind.Location = New System.Drawing.Point(13, 5)
        Me.btnRewind.Name = "btnRewind"
        Me.btnRewind.Size = New System.Drawing.Size(60, 64)
        Me.btnRewind.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btnRewind, "move back five sentences")
        Me.btnRewind.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Image = Global.iptools.My.Resources.Resources.Arrow_Back_2_icon
        Me.btnBack.Location = New System.Drawing.Point(79, 5)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(60, 64)
        Me.btnBack.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnBack, "Move back one sentence")
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(414, 148)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(93, 69)
        Me.btnClose.TabIndex = 21
        Me.btnClose.Text = "&Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1, Me.ToolStripStatusLabel1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 224)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(526, 26)
        Me.StatusStrip1.TabIndex = 22
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(400, 18)
        Me.ToolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbfld)
        Me.GroupBox1.Controls.Add(Me.rbStc)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(101, 79)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "move by"
        '
        'rbStc
        '
        Me.rbStc.AutoSize = True
        Me.rbStc.Location = New System.Drawing.Point(6, 21)
        Me.rbStc.Name = "rbStc"
        Me.rbStc.Size = New System.Drawing.Size(87, 21)
        Me.rbStc.TabIndex = 0
        Me.rbStc.TabStop = True
        Me.rbStc.Text = "sentence"
        Me.rbStc.UseVisualStyleBackColor = True
        '
        'rbfld
        '
        Me.rbfld.AutoSize = True
        Me.rbfld.Location = New System.Drawing.Point(6, 50)
        Me.rbfld.Name = "rbfld"
        Me.rbfld.Size = New System.Drawing.Size(55, 21)
        Me.rbfld.TabIndex = 1
        Me.rbfld.TabStop = True
        Me.rbfld.Text = "field"
        Me.rbfld.UseVisualStyleBackColor = True
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(153, 20)
        Me.ToolStripStatusLabel1.Text = "ToolStripStatusLabel1"
        '
        'frmNumberSentences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 250)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnAddNumSelStcs)
        Me.Controls.Add(Me.btnRemoveNumSelStcs)
        Me.Controls.Add(Me.btnRemove)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.btnNumberStcs)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmNumberSentences"
        Me.Text = "Number Sentences"
        Me.Panel1.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAddNumSelStcs As Windows.Forms.Button
    Friend WithEvents btnRemoveNumSelStcs As Windows.Forms.Button
    Friend WithEvents btnRemove As Windows.Forms.Button
    Friend WithEvents btnUpdate As Windows.Forms.Button
    Friend WithEvents btnNumberStcs As Windows.Forms.Button
    Friend WithEvents Panel1 As Windows.Forms.Panel
    Friend WithEvents btnffwd As Windows.Forms.Button
    Friend WithEvents btnFwd As Windows.Forms.Button
    Friend WithEvents btnRewind As Windows.Forms.Button
    Friend WithEvents btnBack As Windows.Forms.Button
    Friend WithEvents btnClose As Windows.Forms.Button
    Friend WithEvents ToolTip1 As Windows.Forms.ToolTip
    Friend WithEvents StatusStrip1 As Windows.Forms.StatusStrip
    Friend WithEvents ToolStripProgressBar1 As Windows.Forms.ToolStripProgressBar
    Friend WithEvents GroupBox1 As Windows.Forms.GroupBox
    Friend WithEvents rbfld As Windows.Forms.RadioButton
    Friend WithEvents rbStc As Windows.Forms.RadioButton
    Friend WithEvents ToolStripStatusLabel1 As Windows.Forms.ToolStripStatusLabel
End Class
