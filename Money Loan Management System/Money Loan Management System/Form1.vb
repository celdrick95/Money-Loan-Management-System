Imports System.Data.OleDb

Public Class frmMoneyLoan
    Dim numberofYear As Integer
    Dim iMonthlyPayment, iTotalPayment As String
    Dim InterestRate, monthlyInterestRate, loanAmount, MonthlyPayment, TotalPayment As Double
    Sub displayRecordsOnTexboxes() Handles dgvMembers.CellContentClick, dgvMembers.RowStateChanged

        Try
            txtAccountNumber.Text = dgvMembers.SelectedRows(0).Cells(0).Value.ToString()
            txtSurname.Text = dgvMembers.SelectedRows(0).Cells(1).Value.ToString()
            txtFirstname.Text = dgvMembers.SelectedRows(0).Cells(2).Value.ToString()
            txtAddress.Text = dgvMembers.SelectedRows(0).Cells(3).Value.ToString()
            txtLoanAmount.Text = dgvMembers.SelectedRows(0).Cells(4).Value.ToString()
            txtNumberofYear.Text = dgvMembers.SelectedRows(0).Cells(5).Value.ToString()
            txtInterestRate.Text = dgvMembers.SelectedRows(0).Cells(6).Value.ToString()
            txtMonthlyPayment.Text = dgvMembers.SelectedRows(0).Cells(7).Value.ToString()
            txtTotalPayment.Text = dgvMembers.SelectedRows(0).Cells(8).Value.ToString()
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnConnectDB_Click(sender As Object, e As EventArgs) Handles btnConnectDB.Click

        con.Open()

        MessageBox.Show("Database Connected.")

        Dim daMembers As New OleDbDataAdapter("Select * FROM LoanMembers", con)
        Dim dtMembers As New DataTable

        daMembers.Fill(dtMembers)

        dgvMembers.DataSource = dtMembers

        con.Close()
    End Sub

    Private Sub frmMoneyLoan_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgvMembers.AllowUserToAddRows = False
        dgvMembers.EditMode = DataGridViewEditMode.EditProgrammatically
        dgvMembers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgvMembers.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom

        rtfReceipt.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom

        btnConnectDB.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnNewRecord.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnUpdateSelectedRecord.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnDeleteSelectedRecord.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnSearch.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnExit.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnReset.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnLoan.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        btnReceipt.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left

        txtAccountNumber.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        txtSurname.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        txtFirstname.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        txtAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        txtLoanAmount.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        txtNumberofYear.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        txtInterestRate.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        txtMonthlyPayment.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        txtTotalPayment.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        txtSearchRecord.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left

        lblAccountNumber.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblSurname.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblFirstname.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblAddress.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblLoanAmount.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblNumberofYear.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblInterestRate.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblMonthlyPayment.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblTotalPayment.Anchor = AnchorStyles.Top Or AnchorStyles.Left
        lblSearchAccountRecord.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left


    End Sub

    Private Sub btnNewRecord_Click(sender As Object, e As EventArgs) Handles btnNewRecord.Click

        Dim newAccountNumber, newSurname, newFirstname, newAddress, newLoanAmount, newNumberofYear, newInterestRate, newMonthlyPayment, newTotalPayment As String

        newAccountNumber = txtAccountNumber.Text
        newSurname = txtSurname.Text
        newFirstname = txtFirstname.Text
        newAddress = txtAddress.Text
        newLoanAmount = txtLoanAmount.Text
        newNumberofYear = txtNumberofYear.Text
        newInterestRate = txtInterestRate.Text
        newMonthlyPayment = txtMonthlyPayment.Text
        newTotalPayment = txtTotalPayment.Text

        con.Open()

        Dim cmd_AddNewRecord As New OleDbCommand("INSERT INTO LoanMembers (AccountNumber,Surname,Firstname,Address,LoanAmount,NumberofYear,InterestRate,MonthlyPayment,TotalPayment) VALUES ('" & newAccountNumber & "','" & newSurname & "','" & newFirstname & "','" & newAddress & "','" & newLoanAmount & "','" & newNumberofYear & "','" & newInterestRate & "','" & newMonthlyPayment & "','" & newTotalPayment & "')", con)
        cmd_AddNewRecord.ExecuteNonQuery()

        con.Close()
        btnConnectDB.PerformClick()

    End Sub

    Private Sub btnLoan_Click(sender As Object, e As EventArgs) Handles btnLoan.Click
        InterestRate = Convert.ToDouble(txtInterestRate.Text)
        monthlyInterestRate = InterestRate / 1200
        numberofYear = Convert.ToInt32(txtNumberofYear.Text)
        loanAmount = Convert.ToDouble(txtLoanAmount.Text)

        MonthlyPayment = loanAmount * monthlyInterestRate / (1 - 1 / Math.Pow(1 + monthlyInterestRate,
                                                                             numberofYear * 12))
        iMonthlyPayment = Convert.ToString(MonthlyPayment)
        iMonthlyPayment = FormatCurrency(iMonthlyPayment)
        txtMonthlyPayment.Text = iMonthlyPayment.TrimStart("$")

        TotalPayment = MonthlyPayment * numberofYear * 12
        iTotalPayment = FormatCurrency(TotalPayment)
        txtTotalPayment.Text = (iTotalPayment).TrimStart("$")

        txtLoanAmount.Text = FormatCurrency(txtLoanAmount.Text).TrimStart("$")

    End Sub

    Private Sub btnReceipt_Click(sender As Object, e As EventArgs) Handles btnReceipt.Click

        rtfReceipt.AppendText("Money Loan Mangement System" + vbNewLine)
        rtfReceipt.AppendText("Name" + vbTab + vbTab + vbTab + txtFirstname.Text + txtSurname.Text + vbNewLine)
        rtfReceipt.AppendText("Address" + vbTab + vbTab + vbTab + txtAddress.Text + vbNewLine)
        rtfReceipt.AppendText("Account Number" + vbTab + vbTab + txtAccountNumber.Text + vbNewLine)
        rtfReceipt.AppendText("----------------------------------------------------------" + vbNewLine)
        rtfReceipt.AppendText("Enter amount of Loan" + vbTab + txtLoanAmount.Text + vbNewLine)
        rtfReceipt.AppendText("Enter Number of Year" + vbTab + txtNumberofYear.Text + vbNewLine)
        rtfReceipt.AppendText("Enter Interest Rate" + vbTab + vbTab + txtInterestRate.Text + vbNewLine)
        rtfReceipt.AppendText("Monthly Payment" + vbTab + vbTab + txtMonthlyPayment.Text + vbNewLine)
        rtfReceipt.AppendText("Total Payment" + vbTab + vbTab + txtTotalPayment.Text + vbNewLine)
        rtfReceipt.AppendText("----------------------------------------------------------" + vbNewLine)
        rtfReceipt.AppendText("--------------------Thank You--------------------" + vbNewLine)

    End Sub

    Private Sub btnUpdateSelectedRecord_Click(sender As Object, e As EventArgs) Handles btnUpdateSelectedRecord.Click

        Dim strMembersNumber As String

        strMembersNumber = txtAccountNumber.Text

        con.Open()

        Dim cmd_UpdateSelectedRecord As New OleDbCommand("UPDATE LoanMembers SET Surname='" &
                                                         txtSurname.Text & "',Firstname='" &
                                                         txtFirstname.Text & "',Address='" &
                                                         txtAddress.Text & "',LoanAmount='" &
                                                         txtLoanAmount.Text & "',NumberofYear='" &
                                                         txtNumberofYear.Text & "',InterestRate='" &
                                                         txtInterestRate.Text & "',MonthlyPayment='" &
                                                         txtMonthlyPayment.Text & "',TotalPayment='" &
                                                         txtTotalPayment.Text & "' WHERE AccountNumber='" &
                                                         strMembersNumber & "'", con)

        cmd_UpdateSelectedRecord.ExecuteNonQuery()

        con.Close()
        btnConnectDB.PerformClick()

    End Sub

    Private Sub btnDeleteSelectedRecord_Click(sender As Object, e As EventArgs) Handles btnDeleteSelectedRecord.Click

        Dim strMembersNumber As String

        strMembersNumber = txtAccountNumber.Text

        con.Open()

        Dim cmd_UpdateSelectedRecord As New OleDbCommand("DELETE FROM LoanMembers WHERE AccountNumber='" &
                                                         strMembersNumber & "'", con)
        cmd_UpdateSelectedRecord.ExecuteNonQuery()

        con.Close()
        btnConnectDB.PerformClick()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click

        con.Open()

        Dim daSearchMembers As New OleDbDataAdapter("SELECT * FROM LoanMembers WHERE AccountNumber='" &
                                                  txtSearchRecord.Text & "'", con)
        Dim dtSearchMembers As New DataTable

        daSearchMembers.Fill(dtSearchMembers)

        dgvMembers.DataSource = dtSearchMembers

        con.Close()

        dgvMembers.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim iExit As DialogResult
        iExit = MessageBox.Show("Confirm if you want to exit", "Loan System", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question)
        If iExit = DialogResult.Yes Then
            Application.Exit()

        End If

    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtAccountNumber.Clear()
        txtSurname.Clear()
        txtFirstname.Clear()
        txtAddress.Clear()
        txtLoanAmount.Clear()
        txtNumberofYear.Clear()
        txtInterestRate.Clear()
        txtMonthlyPayment.Clear()
        txtTotalPayment.Clear()
        rtfReceipt.Clear()
    End Sub
End Class
