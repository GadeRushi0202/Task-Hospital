<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPtTypewiseDisc
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmPtTypewiseDisc))
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnSearchPtType = New System.Windows.Forms.Button()
        Me.txtSearchPtType = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvPtTypeWiseDiscount = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.chkIsDeactive = New System.Windows.Forms.CheckBox()
        Me.chkIsActive = New System.Windows.Forms.CheckBox()
        Me.txtDiscount = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmbPtTypeWiseDiscount = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rbtnIPD = New System.Windows.Forms.RadioButton()
        Me.rbtnOPD = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnUpdateActiveStatus = New System.Windows.Forms.Button()
        Me.Panel2.SuspendLayout()
        CType(Me.dgvPtTypeWiseDiscount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btnSearchPtType)
        Me.Panel2.Controls.Add(Me.txtSearchPtType)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.dgvPtTypeWiseDiscount)
        Me.Panel2.Location = New System.Drawing.Point(334, 77)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(971, 648)
        Me.Panel2.TabIndex = 2
        '
        'btnSearchPtType
        '
        Me.btnSearchPtType.BackColor = System.Drawing.Color.DarkOrange
        Me.btnSearchPtType.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnSearchPtType.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnSearchPtType.Location = New System.Drawing.Point(697, 52)
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
        'dgvPtTypeWiseDiscount
        '
        Me.dgvPtTypeWiseDiscount.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.dgvPtTypeWiseDiscount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPtTypeWiseDiscount.Location = New System.Drawing.Point(21, 96)
        Me.dgvPtTypeWiseDiscount.Name = "dgvPtTypeWiseDiscount"
        Me.dgvPtTypeWiseDiscount.RowHeadersWidth = 51
        Me.dgvPtTypeWiseDiscount.RowTemplate.Height = 24
        Me.dgvPtTypeWiseDiscount.Size = New System.Drawing.Size(824, 515)
        Me.dgvPtTypeWiseDiscount.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(186, Byte), Integer), CType(CType(231, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.Panel1.Controls.Add(Me.btnUpdateActiveStatus)
        Me.Panel1.Controls.Add(Me.chkIsDeactive)
        Me.Panel1.Controls.Add(Me.chkIsActive)
        Me.Panel1.Controls.Add(Me.txtDiscount)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.cmbPtTypeWiseDiscount)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.rbtnIPD)
        Me.Panel1.Controls.Add(Me.rbtnOPD)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.btnClose)
        Me.Panel1.Controls.Add(Me.btnSave)
        Me.Panel1.Controls.Add(Me.btnUpdate)
        Me.Panel1.Controls.Add(Me.btnNew)
        Me.Panel1.Location = New System.Drawing.Point(0, 77)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(328, 648)
        Me.Panel1.TabIndex = 3
        '
        'chkIsDeactive
        '
        Me.chkIsDeactive.AutoSize = True
        Me.chkIsDeactive.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.chkIsDeactive.ForeColor = System.Drawing.Color.DarkMagenta
        Me.chkIsDeactive.Location = New System.Drawing.Point(145, 295)
        Me.chkIsDeactive.Name = "chkIsDeactive"
        Me.chkIsDeactive.Size = New System.Drawing.Size(95, 23)
        Me.chkIsDeactive.TabIndex = 16
        Me.chkIsDeactive.Text = "Deactive"
        Me.chkIsDeactive.UseVisualStyleBackColor = True
        '
        'chkIsActive
        '
        Me.chkIsActive.AutoSize = True
        Me.chkIsActive.Font = New System.Drawing.Font("Times New Roman", 10.2!, System.Drawing.FontStyle.Bold)
        Me.chkIsActive.ForeColor = System.Drawing.Color.DarkMagenta
        Me.chkIsActive.Location = New System.Drawing.Point(19, 295)
        Me.chkIsActive.Name = "chkIsActive"
        Me.chkIsActive.Size = New System.Drawing.Size(78, 23)
        Me.chkIsActive.TabIndex = 15
        Me.chkIsActive.Text = "Active"
        Me.chkIsActive.UseVisualStyleBackColor = True
        '
        'txtDiscount
        '
        Me.txtDiscount.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold)
        Me.txtDiscount.Location = New System.Drawing.Point(12, 230)
        Me.txtDiscount.Name = "txtDiscount"
        Me.txtDiscount.Size = New System.Drawing.Size(284, 25)
        Me.txtDiscount.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.Navy
        Me.Label5.Location = New System.Drawing.Point(14, 198)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(95, 20)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "Discount%"
        '
        'cmbPtTypeWiseDiscount
        '
        Me.cmbPtTypeWiseDiscount.FormattingEnabled = True
        Me.cmbPtTypeWiseDiscount.Location = New System.Drawing.Point(19, 148)
        Me.cmbPtTypeWiseDiscount.Name = "cmbPtTypeWiseDiscount"
        Me.cmbPtTypeWiseDiscount.Size = New System.Drawing.Size(277, 24)
        Me.cmbPtTypeWiseDiscount.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label4.ForeColor = System.Drawing.Color.Navy
        Me.Label4.Location = New System.Drawing.Point(15, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 20)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Patient Type"
        '
        'rbtnIPD
        '
        Me.rbtnIPD.AutoSize = True
        Me.rbtnIPD.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.rbtnIPD.ForeColor = System.Drawing.Color.Navy
        Me.rbtnIPD.Location = New System.Drawing.Point(167, 52)
        Me.rbtnIPD.Name = "rbtnIPD"
        Me.rbtnIPD.Size = New System.Drawing.Size(59, 23)
        Me.rbtnIPD.TabIndex = 12
        Me.rbtnIPD.TabStop = True
        Me.rbtnIPD.Text = "IPD"
        Me.rbtnIPD.UseVisualStyleBackColor = True
        '
        'rbtnOPD
        '
        Me.rbtnOPD.AutoSize = True
        Me.rbtnOPD.Font = New System.Drawing.Font("Times New Roman", 10.0!, System.Drawing.FontStyle.Bold)
        Me.rbtnOPD.ForeColor = System.Drawing.Color.Navy
        Me.rbtnOPD.Location = New System.Drawing.Point(54, 52)
        Me.rbtnOPD.Name = "rbtnOPD"
        Me.rbtnOPD.Size = New System.Drawing.Size(66, 23)
        Me.rbtnOPD.TabIndex = 7
        Me.rbtnOPD.TabStop = True
        Me.rbtnOPD.Text = "OPD"
        Me.rbtnOPD.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.Navy
        Me.Label3.Location = New System.Drawing.Point(15, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(125, 20)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "OPD/IPD Type"
        '
        'btnClose
        '
        Me.btnClose.BackColor = System.Drawing.Color.DarkOrange
        Me.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnClose.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnClose.Image = CType(resources.GetObject("btnClose.Image"), System.Drawing.Image)
        Me.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnClose.Location = New System.Drawing.Point(167, 566)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(149, 61)
        Me.btnClose.TabIndex = 9
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
        Me.btnSave.Location = New System.Drawing.Point(12, 566)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(149, 61)
        Me.btnSave.TabIndex = 11
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
        Me.btnUpdate.Location = New System.Drawing.Point(167, 499)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(149, 61)
        Me.btnUpdate.TabIndex = 10
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
        Me.btnNew.Location = New System.Drawing.Point(12, 499)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(149, 61)
        Me.btnNew.TabIndex = 8
        Me.btnNew.Text = "New"
        Me.btnNew.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnNew.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 22.2!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(448, 42)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Patient Type Wise Discount"
        '
        'btnUpdateActiveStatus
        '
        Me.btnUpdateActiveStatus.BackColor = System.Drawing.Color.DarkOrange
        Me.btnUpdateActiveStatus.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdateActiveStatus.Font = New System.Drawing.Font("Times New Roman", 10.8!, System.Drawing.FontStyle.Bold)
        Me.btnUpdateActiveStatus.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnUpdateActiveStatus.Image = CType(resources.GetObject("btnUpdateActiveStatus.Image"), System.Drawing.Image)
        Me.btnUpdateActiveStatus.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnUpdateActiveStatus.Location = New System.Drawing.Point(12, 414)
        Me.btnUpdateActiveStatus.Name = "btnUpdateActiveStatus"
        Me.btnUpdateActiveStatus.Size = New System.Drawing.Size(304, 61)
        Me.btnUpdateActiveStatus.TabIndex = 17
        Me.btnUpdateActiveStatus.Text = "Update Active Deactive "
        Me.btnUpdateActiveStatus.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnUpdateActiveStatus.UseVisualStyleBackColor = False
        '
        'FrmPtTypewiseDisc
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(102, Byte), Integer), CType(CType(102, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1317, 737)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "FrmPtTypewiseDisc"
        Me.Text = "FrmPtTypewiseDisc"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.dgvPtTypeWiseDiscount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnSearchPtType As Button
    Friend WithEvents txtSearchPtType As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvPtTypeWiseDiscount As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnClose As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnUpdate As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents rbtnIPD As RadioButton
    Friend WithEvents rbtnOPD As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbPtTypeWiseDiscount As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDiscount As TextBox
    Friend WithEvents chkIsDeactive As CheckBox
    Friend WithEvents chkIsActive As CheckBox
    Friend WithEvents btnUpdateActiveStatus As Button
End Class
