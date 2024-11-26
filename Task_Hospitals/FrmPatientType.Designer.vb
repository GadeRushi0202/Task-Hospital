<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmPatientType
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPatientType))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.chkIsDeactive = New System.Windows.Forms.CheckBox()
        Me.chkIsActive = New System.Windows.Forms.CheckBox()
        Me.txtPtType = New System.Windows.Forms.TextBox()
        Me.lblPtType = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSearchPtType = New System.Windows.Forms.Button()
        Me.txtSearchPtType = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvPtType = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnPtTypeWiseDisc = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvPtType, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnPtTypeWiseDisc)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Controls.Add(Me.chkIsDeactive)
        Me.Panel1.Controls.Add(Me.chkIsActive)
        Me.Panel1.Controls.Add(Me.txtPtType)
        Me.Panel1.Controls.Add(Me.lblPtType)
        Me.Panel1.Location = New System.Drawing.Point(12, 72)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(314, 570)
        Me.Panel1.TabIndex = 0
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DarkOrange
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(158, 495)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(149, 61)
        Me.btnClose.TabIndex = 6
        Me.btnClose.Text = "Close"
        Me.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnClose.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.Color.DarkOrange
        Me.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSave.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnSave.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSave.Image = CType(resources.GetObject("btnSave.Image"), System.Drawing.Image)
        Me.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSave.Location = New System.Drawing.Point(3, 495)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(149, 61)
        Me.btnSave.TabIndex = 7
        Me.btnSave.Text = "Save"
        Me.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'btnUpdate
        '
        Me.btnUpdate.BackColor = System.Drawing.Color.DarkOrange
        Me.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdate.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdate.Image = CType(resources.GetObject("btnUpdate.Image"), System.Drawing.Image)
        Me.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdate.Location = New System.Drawing.Point(158, 428)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(149, 61)
        Me.btnUpdate.TabIndex = 6
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdate.UseVisualStyleBackColor = False
        '
        'btnNew
        '
        Me.btnNew.BackColor = System.Drawing.Color.DarkOrange
        Me.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnNew.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnNew.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnNew.Image = CType(resources.GetObject("btnNew.Image"), System.Drawing.Image)
        Me.btnNew.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnNew.Location = New System.Drawing.Point(3, 428)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(149, 61)
        Me.btnNew.TabIndex = 5
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'chkIsDeactive
        '
        Me.chkIsDeactive.AutoSize = True
        Me.chkIsDeactive.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.chkIsDeactive.ForeColor = System.Drawing.Color.DarkMagenta
        Me.chkIsDeactive.Location = New System.Drawing.Point(152, 103)
        Me.chkIsDeactive.Name = "chkIsDeactive"
        Me.chkIsDeactive.Size = New System.Drawing.Size(95, 23)
        Me.chkIsDeactive.TabIndex = 5
        Me.chkIsDeactive.Text = "Deactive"
        Me.chkIsDeactive.UseVisualStyleBackColor = True
        '
        'chkIsActive
        '
        Me.chkIsActive.AutoSize = True
        Me.chkIsActive.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.chkIsActive.ForeColor = System.Drawing.Color.DarkMagenta
        Me.chkIsActive.Location = New System.Drawing.Point(26, 103)
        Me.chkIsActive.Name = "chkIsActive"
        Me.chkIsActive.Size = New System.Drawing.Size(78, 23)
        Me.chkIsActive.TabIndex = 3
        Me.chkIsActive.Text = "Active"
        Me.chkIsActive.UseVisualStyleBackColor = True
        '
        'txtPtType
        '
        Me.txtPtType.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.txtPtType.ForeColor = System.Drawing.Color.DeepPink
        Me.txtPtType.Location = New System.Drawing.Point(21, 52)
        Me.txtPtType.Name = "txtPtType"
        Me.txtPtType.Size = New System.Drawing.Size(290, 27)
        Me.txtPtType.TabIndex = 4
        '
        'lblPtType
        '
        Me.lblPtType.AutoSize = True
        Me.lblPtType.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.lblPtType.ForeColor = System.Drawing.Color.DarkMagenta
        Me.lblPtType.Location = New System.Drawing.Point(17, 16)
        Me.lblPtType.Name = "lblPtType"
        Me.lblPtType.Size = New System.Drawing.Size(106, 20)
        Me.lblPtType.TabIndex = 3
        Me.lblPtType.Text = "Patient Type"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnSearchPtType)
        Me.Panel2.Controls.Add(Me.txtSearchPtType)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dgvPtType)
        Me.Panel2.Location = New System.Drawing.Point(332, 72)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(868, 570)
        Me.Panel2.TabIndex = 1
        '
        'btnSearchPtType
        '
        Me.btnSearchPtType.BackColor = System.Drawing.Color.DarkOrange
        Me.btnSearchPtType.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnSearchPtType.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearchPtType.Location = New System.Drawing.Point(688, 52)
        Me.btnSearchPtType.Name = "btnSearchPtType"
        Me.btnSearchPtType.Size = New System.Drawing.Size(126, 38)
        Me.btnSearchPtType.TabIndex = 6
        Me.btnSearchPtType.Text = "Search"
        Me.btnSearchPtType.UseVisualStyleBackColor = False
        '
        'txtSearchPtType
        '
        Me.txtSearchPtType.Location = New System.Drawing.Point(151, 16)
        Me.txtSearchPtType.Name = "txtSearchPtType"
        Me.txtSearchPtType.Size = New System.Drawing.Size(672, 22)
        Me.txtSearchPtType.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.DarkMagenta
        Me.Label2.Location = New System.Drawing.Point(17, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Patient Type"
        '
        'dgvPtType
        '
        Me.dgvPtType.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.dgvPtType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPtType.Location = New System.Drawing.Point(21, 96)
        Me.dgvPtType.Name = "dgvPtType"
        Me.dgvPtType.RowHeadersWidth = 51
        Me.dgvPtType.RowTemplate.Height = 24
        Me.dgvPtType.Size = New System.Drawing.Size(824, 460)
        Me.dgvPtType.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(5, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(216, 42)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Patient Type"
        '
        'btnPtTypeWiseDisc
        '
        Me.btnPtTypeWiseDisc.Location = New System.Drawing.Point(26, 367)
        Me.btnPtTypeWiseDisc.Name = "btnPtTypeWiseDisc"
        Me.btnPtTypeWiseDisc.Size = New System.Drawing.Size(208, 23)
        Me.btnPtTypeWiseDisc.TabIndex = 7
        Me.btnPtTypeWiseDisc.Text = "Pt Type Wise Discount"
        Me.btnPtTypeWiseDisc.UseVisualStyleBackColor = True
        '
        'FrmPatientType
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1212, 654)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "FrmPatientType"
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvPtType, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPtType As TextBox
    Friend WithEvents lblPtType As Label
    Friend WithEvents chkIsActive As CheckBox
    Friend WithEvents chkIsDeactive As CheckBox
    Friend WithEvents btnNew As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents dgvPtType As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSearchPtType As TextBox
    Friend WithEvents btnSearchPtType As Button
    Friend WithEvents btnPtTypeWiseDisc As Button
End Class
