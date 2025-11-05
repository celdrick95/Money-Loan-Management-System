<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMoneyLoan
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
        Me.btnConnectDB = New System.Windows.Forms.Button()
        Me.dgvMembers = New System.Windows.Forms.DataGridView()
        Me.txtAccountNumber = New System.Windows.Forms.TextBox()
        Me.lblAccountNumber = New System.Windows.Forms.Label()
        Me.lblSurname = New System.Windows.Forms.Label()
        Me.txtSurname = New System.Windows.Forms.TextBox()
        Me.lblFirstname = New System.Windows.Forms.Label()
        Me.txtFirstname = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblLoanAmount = New System.Windows.Forms.Label()
        Me.txtLoanAmount = New System.Windows.Forms.TextBox()
        Me.lblNumberofYear = New System.Windows.Forms.Label()
        Me.txtNumberofYear = New System.Windows.Forms.TextBox()
        Me.lblInterestRate = New System.Windows.Forms.Label()
        Me.txtInterestRate = New System.Windows.Forms.TextBox()
        Me.lblMonthlyPayment = New System.Windows.Forms.Label()
        Me.txtMonthlyPayment = New System.Windows.Forms.TextBox()
        Me.lblTotalPayment = New System.Windows.Forms.Label()
        Me.txtTotalPayment = New System.Windows.Forms.TextBox()
        Me.btnNewRecord = New System.Windows.Forms.Button()
        Me.btnUpdateSelectedRecord = New System.Windows.Forms.Button()
        Me.btnDeleteSelectedRecord = New System.Windows.Forms.Button()
        Me.txtSearchRecord = New System.Windows.Forms.TextBox()
        Me.lblSearchAccountRecord = New System.Windows.Forms.Label()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.rtfReceipt = New System.Windows.Forms.RichTextBox()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.btnReceipt = New System.Windows.Forms.Button()
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConnectDB
        '
        Me.btnConnectDB.BackColor = System.Drawing.Color.Red
        Me.btnConnectDB.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConnectDB.ForeColor = System.Drawing.SystemColors.Control
        Me.btnConnectDB.Location = New System.Drawing.Point(719, 419)
        Me.btnConnectDB.Name = "btnConnectDB"
        Me.btnConnectDB.Size = New System.Drawing.Size(87, 54)
        Me.btnConnectDB.TabIndex = 0
        Me.btnConnectDB.Text = "Connect to Database"
        Me.btnConnectDB.UseVisualStyleBackColor = False
        '
        'dgvMembers
        '
        Me.dgvMembers.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMembers.Location = New System.Drawing.Point(339, 12)
        Me.dgvMembers.Name = "dgvMembers"
        Me.dgvMembers.Size = New System.Drawing.Size(548, 187)
        Me.dgvMembers.TabIndex = 1
        '
        'txtAccountNumber
        '
        Me.txtAccountNumber.Location = New System.Drawing.Point(128, 30)
        Me.txtAccountNumber.Name = "txtAccountNumber"
        Me.txtAccountNumber.Size = New System.Drawing.Size(196, 20)
        Me.txtAccountNumber.TabIndex = 2
        '
        'lblAccountNumber
        '
        Me.lblAccountNumber.AutoSize = True
        Me.lblAccountNumber.BackColor = System.Drawing.Color.Gold
        Me.lblAccountNumber.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAccountNumber.ForeColor = System.Drawing.SystemColors.ControlText
        Me.lblAccountNumber.Location = New System.Drawing.Point(12, 33)
        Me.lblAccountNumber.Name = "lblAccountNumber"
        Me.lblAccountNumber.Size = New System.Drawing.Size(103, 13)
        Me.lblAccountNumber.TabIndex = 3
        Me.lblAccountNumber.Text = "Account Number:"
        '
        'lblSurname
        '
        Me.lblSurname.AutoSize = True
        Me.lblSurname.BackColor = System.Drawing.Color.Gold
        Me.lblSurname.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSurname.Location = New System.Drawing.Point(12, 69)
        Me.lblSurname.Name = "lblSurname"
        Me.lblSurname.Size = New System.Drawing.Size(61, 13)
        Me.lblSurname.TabIndex = 5
        Me.lblSurname.Text = "Surname:"
        '
        'txtSurname
        '
        Me.txtSurname.Location = New System.Drawing.Point(128, 66)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(196, 20)
        Me.txtSurname.TabIndex = 4
        '
        'lblFirstname
        '
        Me.lblFirstname.AutoSize = True
        Me.lblFirstname.BackColor = System.Drawing.Color.Gold
        Me.lblFirstname.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstname.Location = New System.Drawing.Point(12, 105)
        Me.lblFirstname.Name = "lblFirstname"
        Me.lblFirstname.Size = New System.Drawing.Size(67, 13)
        Me.lblFirstname.TabIndex = 7
        Me.lblFirstname.Text = "Firstname:"
        '
        'txtFirstname
        '
        Me.txtFirstname.Location = New System.Drawing.Point(128, 102)
        Me.txtFirstname.Name = "txtFirstname"
        Me.txtFirstname.Size = New System.Drawing.Size(196, 20)
        Me.txtFirstname.TabIndex = 6
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Gold
        Me.lblAddress.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(12, 140)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(56, 13)
        Me.lblAddress.TabIndex = 9
        Me.lblAddress.Text = "Address:"
        '
        'txtAddress
        '
        Me.txtAddress.Location = New System.Drawing.Point(128, 137)
        Me.txtAddress.Multiline = True
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(196, 62)
        Me.txtAddress.TabIndex = 8
        '
        'lblLoanAmount
        '
        Me.lblLoanAmount.AutoSize = True
        Me.lblLoanAmount.BackColor = System.Drawing.Color.Gold
        Me.lblLoanAmount.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLoanAmount.Location = New System.Drawing.Point(12, 217)
        Me.lblLoanAmount.Name = "lblLoanAmount"
        Me.lblLoanAmount.Size = New System.Drawing.Size(85, 13)
        Me.lblLoanAmount.TabIndex = 11
        Me.lblLoanAmount.Text = "Loan Amount:"
        '
        'txtLoanAmount
        '
        Me.txtLoanAmount.Location = New System.Drawing.Point(128, 214)
        Me.txtLoanAmount.Name = "txtLoanAmount"
        Me.txtLoanAmount.Size = New System.Drawing.Size(196, 20)
        Me.txtLoanAmount.TabIndex = 10
        '
        'lblNumberofYear
        '
        Me.lblNumberofYear.AutoSize = True
        Me.lblNumberofYear.BackColor = System.Drawing.Color.Gold
        Me.lblNumberofYear.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberofYear.Location = New System.Drawing.Point(12, 254)
        Me.lblNumberofYear.Name = "lblNumberofYear"
        Me.lblNumberofYear.Size = New System.Drawing.Size(97, 13)
        Me.lblNumberofYear.TabIndex = 13
        Me.lblNumberofYear.Text = "Number of Year:"
        '
        'txtNumberofYear
        '
        Me.txtNumberofYear.Location = New System.Drawing.Point(128, 251)
        Me.txtNumberofYear.Name = "txtNumberofYear"
        Me.txtNumberofYear.Size = New System.Drawing.Size(196, 20)
        Me.txtNumberofYear.TabIndex = 12
        '
        'lblInterestRate
        '
        Me.lblInterestRate.AutoSize = True
        Me.lblInterestRate.BackColor = System.Drawing.Color.Gold
        Me.lblInterestRate.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInterestRate.Location = New System.Drawing.Point(12, 289)
        Me.lblInterestRate.Name = "lblInterestRate"
        Me.lblInterestRate.Size = New System.Drawing.Size(87, 13)
        Me.lblInterestRate.TabIndex = 15
        Me.lblInterestRate.Text = "Interest Rate:"
        '
        'txtInterestRate
        '
        Me.txtInterestRate.Location = New System.Drawing.Point(128, 286)
        Me.txtInterestRate.Name = "txtInterestRate"
        Me.txtInterestRate.Size = New System.Drawing.Size(196, 20)
        Me.txtInterestRate.TabIndex = 14
        '
        'lblMonthlyPayment
        '
        Me.lblMonthlyPayment.AutoSize = True
        Me.lblMonthlyPayment.BackColor = System.Drawing.Color.Gold
        Me.lblMonthlyPayment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonthlyPayment.Location = New System.Drawing.Point(12, 327)
        Me.lblMonthlyPayment.Name = "lblMonthlyPayment"
        Me.lblMonthlyPayment.Size = New System.Drawing.Size(110, 13)
        Me.lblMonthlyPayment.TabIndex = 17
        Me.lblMonthlyPayment.Text = "Monthly Payment:"
        '
        'txtMonthlyPayment
        '
        Me.txtMonthlyPayment.Location = New System.Drawing.Point(128, 324)
        Me.txtMonthlyPayment.Name = "txtMonthlyPayment"
        Me.txtMonthlyPayment.ReadOnly = True
        Me.txtMonthlyPayment.Size = New System.Drawing.Size(196, 20)
        Me.txtMonthlyPayment.TabIndex = 16
        '
        'lblTotalPayment
        '
        Me.lblTotalPayment.AutoSize = True
        Me.lblTotalPayment.BackColor = System.Drawing.Color.Gold
        Me.lblTotalPayment.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayment.Location = New System.Drawing.Point(12, 365)
        Me.lblTotalPayment.Name = "lblTotalPayment"
        Me.lblTotalPayment.Size = New System.Drawing.Size(93, 13)
        Me.lblTotalPayment.TabIndex = 19
        Me.lblTotalPayment.Text = "Total Payment:"
        '
        'txtTotalPayment
        '
        Me.txtTotalPayment.Location = New System.Drawing.Point(128, 362)
        Me.txtTotalPayment.Name = "txtTotalPayment"
        Me.txtTotalPayment.ReadOnly = True
        Me.txtTotalPayment.Size = New System.Drawing.Size(196, 20)
        Me.txtTotalPayment.TabIndex = 18
        '
        'btnNewRecord
        '
        Me.btnNewRecord.BackColor = System.Drawing.Color.Green
        Me.btnNewRecord.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNewRecord.ForeColor = System.Drawing.SystemColors.Control
        Me.btnNewRecord.Location = New System.Drawing.Point(339, 419)
        Me.btnNewRecord.Name = "btnNewRecord"
        Me.btnNewRecord.Size = New System.Drawing.Size(87, 54)
        Me.btnNewRecord.TabIndex = 20
        Me.btnNewRecord.Text = "Save New Record"
        Me.btnNewRecord.UseVisualStyleBackColor = False
        '
        'btnUpdateSelectedRecord
        '
        Me.btnUpdateSelectedRecord.BackColor = System.Drawing.Color.Green
        Me.btnUpdateSelectedRecord.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnUpdateSelectedRecord.ForeColor = System.Drawing.SystemColors.Control
        Me.btnUpdateSelectedRecord.Location = New System.Drawing.Point(432, 419)
        Me.btnUpdateSelectedRecord.Name = "btnUpdateSelectedRecord"
        Me.btnUpdateSelectedRecord.Size = New System.Drawing.Size(87, 54)
        Me.btnUpdateSelectedRecord.TabIndex = 21
        Me.btnUpdateSelectedRecord.Text = "Update Selected Record"
        Me.btnUpdateSelectedRecord.UseVisualStyleBackColor = False
        '
        'btnDeleteSelectedRecord
        '
        Me.btnDeleteSelectedRecord.BackColor = System.Drawing.Color.Green
        Me.btnDeleteSelectedRecord.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDeleteSelectedRecord.ForeColor = System.Drawing.SystemColors.Control
        Me.btnDeleteSelectedRecord.Location = New System.Drawing.Point(525, 419)
        Me.btnDeleteSelectedRecord.Name = "btnDeleteSelectedRecord"
        Me.btnDeleteSelectedRecord.Size = New System.Drawing.Size(87, 54)
        Me.btnDeleteSelectedRecord.TabIndex = 22
        Me.btnDeleteSelectedRecord.Text = "Delete Selected Record"
        Me.btnDeleteSelectedRecord.UseVisualStyleBackColor = False
        '
        'txtSearchRecord
        '
        Me.txtSearchRecord.Location = New System.Drawing.Point(496, 386)
        Me.txtSearchRecord.Name = "txtSearchRecord"
        Me.txtSearchRecord.Size = New System.Drawing.Size(127, 20)
        Me.txtSearchRecord.TabIndex = 23
        '
        'lblSearchAccountRecord
        '
        Me.lblSearchAccountRecord.AutoSize = True
        Me.lblSearchAccountRecord.BackColor = System.Drawing.Color.Gold
        Me.lblSearchAccountRecord.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSearchAccountRecord.Location = New System.Drawing.Point(345, 389)
        Me.lblSearchAccountRecord.Name = "lblSearchAccountRecord"
        Me.lblSearchAccountRecord.Size = New System.Drawing.Size(145, 13)
        Me.lblSearchAccountRecord.TabIndex = 24
        Me.lblSearchAccountRecord.Text = "Search Account Number:"
        '
        'btnSearch
        '
        Me.btnSearch.BackColor = System.Drawing.Color.Orange
        Me.btnSearch.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.ForeColor = System.Drawing.SystemColors.Control
        Me.btnSearch.Location = New System.Drawing.Point(629, 384)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(87, 23)
        Me.btnSearch.TabIndex = 25
        Me.btnSearch.Text = "Search"
        Me.btnSearch.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.SystemColors.Control
        Me.btnExit.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.Red
        Me.btnExit.Location = New System.Drawing.Point(812, 419)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 54)
        Me.btnExit.TabIndex = 26
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReset.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReset.Location = New System.Drawing.Point(186, 419)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 54)
        Me.btnReset.TabIndex = 27
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'rtfReceipt
        '
        Me.rtfReceipt.Location = New System.Drawing.Point(339, 214)
        Me.rtfReceipt.Name = "rtfReceipt"
        Me.rtfReceipt.ReadOnly = True
        Me.rtfReceipt.Size = New System.Drawing.Size(548, 161)
        Me.rtfReceipt.TabIndex = 28
        Me.rtfReceipt.Text = ""
        '
        'btnLoan
        '
        Me.btnLoan.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnLoan.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoan.ForeColor = System.Drawing.SystemColors.Control
        Me.btnLoan.Location = New System.Drawing.Point(12, 419)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(83, 54)
        Me.btnLoan.TabIndex = 29
        Me.btnLoan.Text = "Loan Calculator"
        Me.btnLoan.UseVisualStyleBackColor = False
        '
        'btnReceipt
        '
        Me.btnReceipt.BackColor = System.Drawing.Color.RoyalBlue
        Me.btnReceipt.Font = New System.Drawing.Font("MS Reference Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReceipt.ForeColor = System.Drawing.SystemColors.Control
        Me.btnReceipt.Location = New System.Drawing.Point(101, 419)
        Me.btnReceipt.Name = "btnReceipt"
        Me.btnReceipt.Size = New System.Drawing.Size(79, 54)
        Me.btnReceipt.TabIndex = 30
        Me.btnReceipt.Text = "Generate Receipt"
        Me.btnReceipt.UseVisualStyleBackColor = False
        '
        'frmMoneyLoan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Money_Loan_Management_System.My.Resources.Resources.Main_Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(899, 485)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnReceipt)
        Me.Controls.Add(Me.btnLoan)
        Me.Controls.Add(Me.rtfReceipt)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.lblSearchAccountRecord)
        Me.Controls.Add(Me.txtSearchRecord)
        Me.Controls.Add(Me.btnDeleteSelectedRecord)
        Me.Controls.Add(Me.btnUpdateSelectedRecord)
        Me.Controls.Add(Me.btnNewRecord)
        Me.Controls.Add(Me.lblTotalPayment)
        Me.Controls.Add(Me.txtTotalPayment)
        Me.Controls.Add(Me.lblMonthlyPayment)
        Me.Controls.Add(Me.txtMonthlyPayment)
        Me.Controls.Add(Me.lblInterestRate)
        Me.Controls.Add(Me.txtInterestRate)
        Me.Controls.Add(Me.lblNumberofYear)
        Me.Controls.Add(Me.txtNumberofYear)
        Me.Controls.Add(Me.lblLoanAmount)
        Me.Controls.Add(Me.txtLoanAmount)
        Me.Controls.Add(Me.lblAddress)
        Me.Controls.Add(Me.txtAddress)
        Me.Controls.Add(Me.lblFirstname)
        Me.Controls.Add(Me.txtFirstname)
        Me.Controls.Add(Me.lblSurname)
        Me.Controls.Add(Me.txtSurname)
        Me.Controls.Add(Me.lblAccountNumber)
        Me.Controls.Add(Me.txtAccountNumber)
        Me.Controls.Add(Me.dgvMembers)
        Me.Controls.Add(Me.btnConnectDB)
        Me.Name = "frmMoneyLoan"
        Me.Text = "Money Loan Management System"
        CType(Me.dgvMembers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnConnectDB As Button
    Friend WithEvents dgvMembers As DataGridView
    Friend WithEvents txtAccountNumber As TextBox
    Friend WithEvents lblAccountNumber As Label
    Friend WithEvents lblSurname As Label
    Friend WithEvents txtSurname As TextBox
    Friend WithEvents lblFirstname As Label
    Friend WithEvents txtFirstname As TextBox
    Friend WithEvents lblAddress As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblLoanAmount As Label
    Friend WithEvents txtLoanAmount As TextBox
    Friend WithEvents lblNumberofYear As Label
    Friend WithEvents txtNumberofYear As TextBox
    Friend WithEvents lblInterestRate As Label
    Friend WithEvents txtInterestRate As TextBox
    Friend WithEvents lblMonthlyPayment As Label
    Friend WithEvents txtMonthlyPayment As TextBox
    Friend WithEvents lblTotalPayment As Label
    Friend WithEvents txtTotalPayment As TextBox
    Friend WithEvents btnNewRecord As Button
    Friend WithEvents btnUpdateSelectedRecord As Button
    Friend WithEvents btnDeleteSelectedRecord As Button
    Friend WithEvents txtSearchRecord As TextBox
    Friend WithEvents lblSearchAccountRecord As Label
    Friend WithEvents btnSearch As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents rtfReceipt As RichTextBox
    Friend WithEvents btnLoan As Button
    Friend WithEvents btnReceipt As Button
End Class
