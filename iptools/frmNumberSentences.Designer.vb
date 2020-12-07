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
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnAddNumSelStcs
        '
        Me.btnAddNumSelStcs.Location = New System.Drawing.Point(21, 74)
        Me.btnAddNumSelStcs.Name = "btnAddNumSelStcs"
        Me.btnAddNumSelStcs.Size = New System.Drawing.Size(154, 56)
        Me.btnAddNumSelStcs.TabIndex = 20
        Me.btnAddNumSelStcs.Text = "Add numbering in selected sentences"
        Me.btnAddNumSelStcs.UseVisualStyleBackColor = True
        '
        'btnRemoveNumSelStcs
        '
        Me.btnRemoveNumSelStcs.Location = New System.Drawing.Point(181, 74)
        Me.btnRemoveNumSelStcs.Name = "btnRemoveNumSelStcs"
        Me.btnRemoveNumSelStcs.Size = New System.Drawing.Size(166, 56)
        Me.btnRemoveNumSelStcs.TabIndex = 15
        Me.btnRemoveNumSelStcs.Text = "Remove numbering in selected sentences"
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
        Me.Panel1.Location = New System.Drawing.Point(21, 142)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(286, 89)
        Me.Panel1.TabIndex = 16
        '
        'btnffwd
        '
        Me.btnffwd.Image = Global.iptools.My.Resources.Resources.Arrow_Next_icon
        Me.btnffwd.Location = New System.Drawing.Point(219, 13)
        Me.btnffwd.Name = "btnffwd"
        Me.btnffwd.Size = New System.Drawing.Size(60, 64)
        Me.btnffwd.TabIndex = 7
        Me.btnffwd.UseVisualStyleBackColor = True
        '
        'btnFwd
        '
        Me.btnFwd.Image = Global.iptools.My.Resources.Resources.Arrow_Next_2_icon
        Me.btnFwd.Location = New System.Drawing.Point(153, 13)
        Me.btnFwd.Name = "btnFwd"
        Me.btnFwd.Size = New System.Drawing.Size(60, 64)
        Me.btnFwd.TabIndex = 5
        Me.btnFwd.UseVisualStyleBackColor = True
        '
        'btnRewind
        '
        Me.btnRewind.Image = Global.iptools.My.Resources.Resources.Arrow_Back_icon
        Me.btnRewind.Location = New System.Drawing.Point(21, 13)
        Me.btnRewind.Name = "btnRewind"
        Me.btnRewind.Size = New System.Drawing.Size(60, 64)
        Me.btnRewind.TabIndex = 6
        Me.btnRewind.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.Image = Global.iptools.My.Resources.Resources.Arrow_Back_2_icon
        Me.btnBack.Location = New System.Drawing.Point(87, 13)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(60, 64)
        Me.btnBack.TabIndex = 4
        Me.btnBack.UseVisualStyleBackColor = True
        '
        'frmNumberSentences
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(526, 255)
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
        Me.ResumeLayout(False)

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
End Class
