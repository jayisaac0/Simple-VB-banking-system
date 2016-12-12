Public Class frmAccount
    Public Property firstName As String
    Public Property middleName As String
    Public Property lastName As String
    Public Property postalAddress As String
    Public Property postalCode As String
    Public Property town As String
    Public Property country As String
    Public Property accounttype As String
    Public Property employment As String
    Public Property kraPin As String
    Public Property idCard As String
    Public Property generatedAccountNumber As Long
    Public Property sex As String
    Public Property email As String
    Public Property phoneNumber As String
    Public Property branchName As String
    Public Property companyOfWork As String
    Public Property moneyInBank As String
    Public Property grossSalary As String
    Public Property allowance As String
    Public Property tax As String
    Public Property employeeSalary As String
    Public Property house As String
    Public Property travel As String
    Public Property medical As String
    Public Property total As String
    Public Property nhif As String
    Public Property nssf As String
    Public Property netSalary As Double


    Private Sub frmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbl.Text = firstName + " " + middleName + " " + lastName
        lblMyMiddleName.Text = middleName
        lblMyLastName.Text = lastName
        lblMyPostalAddress.Text = postalAddress
        lblMyPostalCode.Text = postalCode
        lblMyTown.Text = town
        lblMyCountry.Text = country
        lblMyAccountType.Text = accounttype
        lblMyEmployment.Text = employment
        lblMyKraPin.Text = kraPin
        lblMyIdCard.Text = idCard
        lblMyAccountNumber.Text = generatedAccountNumber

        lblFullName.Text = firstName + " " + middleName + " " + lastName
        lbll.Text = middleName
        lblFullName.Text = firstName + " " + middleName + " " + lastName
        lblS_name.Text = firstName + " " + middleName + " " + lastName
        lblMyName.Text = firstName + " " + middleName + " " + lastName
        lblMe.Text = firstName + " " + middleName + " " + lastName
        lbl_Name.Text = firstName + " " + middleName + " " + lastName

        txtMyCurrentBalance.Text = netSalary
        txtBalance.Text = netSalary
        txtMyBankBalance.Text = netSalary
        lblMoneyInBank.Text = netSalary


        txtBankStatement.Text = ""
        txtBankStatement.AppendText("==========================================================================================================================" + vbNewLine)
        txtBankStatement.AppendText("THE KENYA COMMERCIAL BANK  BANK STATEMENT" + vbNewLine)
        txtBankStatement.AppendText("==========================================================================================================================" + vbNewLine)
        txtBankStatement.AppendText("Personal Details" + vbNewLine)
        txtBankStatement.AppendText("Name: " + vbTab + vbTab + vbTab & firstName + " " + middleName + " " + lastName + vbNewLine)
        txtBankStatement.AppendText("Gender: " + vbTab + vbTab + vbTab & sex + vbNewLine)
        txtBankStatement.AppendText("ID card: " + vbTab + vbTab + vbTab & idCard + vbNewLine)

        txtBankStatement.AppendText("Personal Contacts" + vbNewLine)
        txtBankStatement.AppendText("" + vbTab + vbTab + vbTab & postalAddress + "-" + postalCode + vbNewLine)
        txtBankStatement.AppendText("" + vbTab + vbTab + vbTab & town + vbNewLine)
        txtBankStatement.AppendText("" + vbTab + vbTab + vbTab & country + vbNewLine)
        txtBankStatement.AppendText("email: " + vbTab + vbTab + vbTab & email + vbNewLine)
        txtBankStatement.AppendText("Phone number: " + vbTab + vbTab & phoneNumber + vbNewLine)

        txtBankStatement.AppendText("Personal Contacts" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + "Confidential" + vbTab + vbNewLine)
        txtBankStatement.AppendText("" + vbTab + vbTab + vbTab & branchName + vbTab + vbTab + vbTab + vbTab + "PIN: " + vbTab + kraPin + vbNewLine)
        txtBankStatement.AppendText("Employment status: " + vbTab + vbTab & employment + vbNewLine)
        txtBankStatement.AppendText("Work place: " + vbTab & companyOfWork + vbNewLine)
        txtBankStatement.AppendText("Account type: " + vbTab + vbTab & accounttype + vbNewLine)
        'txtBankStatement.AppendText("" + vbTab & generatedAccountNumber + vbNewLine)

        'txtBankStatement.AppendText("" + vbTab & netSalary + vbNewLine)
        txtBankStatement.AppendText("Salaries" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + "Confidential" + vbNewLine)
        txtBankStatement.AppendText("Gross salary: " + vbTab + vbTab & grossSalary + vbTab + vbTab + vbTab + vbTab + "House allowance: " + vbTab + house + vbNewLine)
        txtBankStatement.AppendText("Tax: " + vbTab + vbTab & tax + vbTab + vbTab + vbTab + vbTab + vbTab + "Travel allowance: " + vbTab + travel + vbNewLine)
        txtBankStatement.AppendText("Salary: " + vbTab + vbTab + vbTab & employeeSalary + vbTab + vbTab + vbTab + vbTab + "Medical allowance: " + vbTab + medical + vbNewLine)
        txtBankStatement.AppendText("" + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + vbTab + "Total allowances" + vbTab + total + vbNewLine)

        txtBankStatement.AppendText("Nhif: " + vbTab + vbTab + vbTab & nhif + vbNewLine)
        txtBankStatement.AppendText("Nssf: " + vbTab + vbTab + vbTab & nssf + vbNewLine)
        txtBankStatement.AppendText("Bank balance: " + vbTab + vbNewLine)

        txtBankStatement.AppendText("==========================================================================================================================" + vbNewLine)
        txtBankStatement.AppendText("Auto-generated by the Kenya commercial bank systems." + vbNewLine)
        txtBankStatement.AppendText("Thank you for banking with us" + vbNewLine)
        txtBankStatement.AppendText("==========================================================================================================================" + vbNewLine)


    End Sub

    Private Sub ToolStripMenuItem3_Click(sender As Object, e As EventArgs)
        Dim afl As New frmApplyForLoan
        afl.MdiParent = Me
        afl.Show()
        afl.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub LogoutToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles LogoutToolStripMenuItem.Click
        Dim peaceout As String
        peaceout = MsgBox("Please confirm that you want to log out of your account", MsgBoxStyle.Exclamation + MsgBoxStyle.YesNo, "Logout")
        If peaceout = vbYes Then
            MsgBox("Logout", MsgBoxStyle.Information)
            Me.Close()
            frmLogin.Show()
        ElseIf peaceout = vbNo Then
            MsgBox("All systems ready for next instruction", MsgBoxStyle.Information)

        End If
    End Sub

    Private Sub btnReceiptGenerate_Click(sender As Object, e As EventArgs) Handles btnReceiptGenerate.Click
        TextBox1.Text = ""
        TextBox1.AppendText("==================================" + vbNewLine)
        TextBox1.AppendText("THE KENYA COMMERCIAL BANK ACCOUNT STATEMENT" + vbNewLine)
        TextBox1.AppendText("==================================" + vbNewLine)
        TextBox1.AppendText("Name: " + vbTab + vbTab & firstName + " " & middleName + " " & lastName + vbNewLine)
        TextBox1.AppendText("Postal adress: " + vbTab & postalAddress + "-" + postalCode + vbNewLine)
        TextBox1.AppendText("      " + vbTab + vbTab & town + vbNewLine)
        TextBox1.AppendText("      " + vbTab + vbTab & country + vbNewLine)
        TextBox1.AppendText("Account type: " + vbTab & accounttype + vbNewLine)
        TextBox1.AppendText("Employment: " + vbTab & employment + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("" + vbNewLine)
        TextBox1.AppendText("==================================" + vbNewLine)
        TextBox1.AppendText("Auto-generated by the Kenya commercial bank systems." + vbNewLine)
        TextBox1.AppendText("Thank you for banking with us" + vbNewLine)
        TextBox1.AppendText("==================================" + vbNewLine)


    End Sub



    Private Sub btnLoanReceiptGenerate_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnProcessRequest_Click(sender As Object, e As EventArgs) Handles btnProcessRequest.Click
        Dim purpose As String
        Dim amount As String
        Dim kraPin As String
        Dim collateral As String
        Dim loanPaymentDuration As String
        'Dim accountBalancePusLoan As Double

        purpose = (txtPurpose.Text)
        amount = (txtAmount.Text)
        kraPin = (txtKraPin.Text)
        collateral = (txtCollateral.Text)
        loanPaymentDuration = (cboLoanPaymentDuration.Text)
        'accountBalancePusLoan = (txtAccountBalancePusLoan.Text)

        'accountBalancePusLoan = (amount + netSalary)
        'txtAccountBalancePusLoan.Text = accountBalancePusLoan

        ' My.Settings.netSalary = accountBalancePusLoan


        txtLoanApplicationSlip.Text = ""
        txtLoanApplicationSlip.AppendText("THE KENYA COMMERCIAL BANK LOAN APPLICATION SLIP" + vbNewLine)

        txtLoanApplicationSlip.Text = ""
        txtLoanApplicationSlip.AppendText("==================================" + vbNewLine)
        txtLoanApplicationSlip.AppendText("THE KENYA COMMERCIAL BANK ACCOUNT STATEMENT" + vbNewLine)
        txtLoanApplicationSlip.AppendText("==================================" + vbNewLine)
        txtLoanApplicationSlip.AppendText("Name: " + vbTab + vbTab & firstName + " " & middleName + " " & lastName + vbNewLine)
        txtLoanApplicationSlip.AppendText("Postal adress: " + vbTab & postalAddress + "-" + postalCode + vbNewLine)
        txtLoanApplicationSlip.AppendText("      " + vbTab + vbTab & town + vbNewLine)
        txtLoanApplicationSlip.AppendText("      " + vbTab + vbTab & country + vbNewLine)
        txtLoanApplicationSlip.AppendText("Account type: " + vbTab & accounttype + vbNewLine)
        txtLoanApplicationSlip.AppendText("Employment: " + vbTab & employment + vbNewLine)
        txtLoanApplicationSlip.AppendText("" + vbTab + vbTab & purpose + vbNewLine)
        txtLoanApplicationSlip.AppendText("" + vbTab + vbTab & amount + vbNewLine)
        txtLoanApplicationSlip.AppendText("" + vbTab + vbTab & collateral + vbNewLine)
        txtLoanApplicationSlip.AppendText("" + vbTab + vbTab & loanPaymentDuration + vbNewLine)
        txtLoanApplicationSlip.AppendText("==================================" + vbNewLine)
        txtLoanApplicationSlip.AppendText("Auto-generated by the Kenya commercial bank systems." + vbNewLine)
        txtLoanApplicationSlip.AppendText("Your loan request has been received and processed" + vbNewLine)
        txtLoanApplicationSlip.AppendText("Thank you for banking with us" + vbNewLine)
        txtLoanApplicationSlip.AppendText("==================================" + vbNewLine)

    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnDepositMoney.Click

        Dim amountToDeposit As Double
        Dim depositFrom As String
        Dim nhif As Double
        Dim nssf As Double
        Dim tax As Double
        Dim house As Double
        Dim travel As Double
        Dim medical As Double
        Dim total As Double
        Dim employeeSalary As Double
        Dim grossSalary As Double
        Dim netSalary As Double
        Dim myCurrentBalance As Double

        amountToDeposit = Val(txtAmountToDeposit.Text)
        depositFrom = Val(cboDepositFrom.Text)
        myCurrentBalance = Val(txtMyCurrentBalance.Text)
        nhif = Val(txtNhif.Text)
        nssf = Val(txtNssf.Text)
        tax = Val(txtTax.Text)
        employeeSalary = Val(txtEmployeeSalary.Text)
        myCurrentBalance = Val(txtMyCurrentBalance.Text)

        If employment = "Self employed" Then
            nhif = (0.15 * employeeSalary)
            txtNhif.Text = nhif

            nssf = (0.16 * employeeSalary)
            txtNssf.Text = nssf

            If amountToDeposit > 30000 Then
                house = (0.06 * amountToDeposit)
                txtHouse.Text = house

                travel = (0.04 * amountToDeposit)
                txtTravel.Text = travel

                medical = (0.06 * amountToDeposit)
                txtMedical.Text = medical

                total = (house + travel + medical)
                txtTotal.Text = total
            End If
            If amountToDeposit > 25000 Then
                house = (0.03 * amountToDeposit)
                txtHouse.Text = house

                travel = (0.02 * amountToDeposit)
                txtTravel.Text = travel

                medical = (0.05 * amountToDeposit)
                txtMedical.Text = medical

                total = (house + travel + medical)
                txtTotal.Text = total
            End If
            If amountToDeposit > 20000 Then
                house = (0.028 * amountToDeposit)
                txtHouse.Text = house

                travel = (0.02 * amountToDeposit)
                txtTravel.Text = travel

                medical = (0.05 * amountToDeposit)
                txtMedical.Text = medical

                total = (house + travel + medical)
                txtTotal.Text = total
            End If
            If amountToDeposit > 15000 Then
                house = (0.02 * amountToDeposit)
                txtHouse.Text = house

                travel = (0.01 * amountToDeposit)
                txtTravel.Text = travel

                medical = (0.04 * amountToDeposit)
                txtMedical.Text = medical

                total = (house + travel + medical)
                txtTotal.Text = total
            End If
            grossSalary = (amountToDeposit + total)
            txtGrossSalary.Text = grossSalary

            tax = (0.05 * grossSalary)
            txtTax.Text = tax

            netSalary = (grossSalary - (nhif + nssf - tax))
            txtNetSalary.Text = netSalary


            '==============================================================================================

        ElseIf employment = "Employed" Then
            employeeSalary = 35000
            txtEmployeeSalary.Text = employeeSalary

            nhif = (0.15 * employeeSalary)
            txtNhif.Text = nhif

            nssf = (0.16 * employeeSalary)
            txtNssf.Text = nssf

            If employeeSalary > 30000 Then
                house = (0.06 * employeeSalary)
                txtHouse.Text = house

                travel = (0.04 * employeeSalary)
                txtTravel.Text = travel

                medical = (0.06 * employeeSalary)
                txtMedical.Text = medical

                total = (house + travel + medical)
                txtTotal.Text = total
            End If
            If employeeSalary > 25000 Then
                house = (0.03 * employeeSalary)
                txtHouse.Text = house

                travel = (0.02 * employeeSalary)
                txtTravel.Text = travel

                medical = (0.05 * employeeSalary)
                txtMedical.Text = medical

                total = (house + travel + medical)
                txtTotal.Text = total
            End If
            If employeeSalary > 20000 Then
                house = (0.028 * employeeSalary)
                txtHouse.Text = house

                travel = (0.02 * employeeSalary)
                txtTravel.Text = travel

                medical = (0.05 * employeeSalary)
                txtMedical.Text = medical

                total = (house + travel + medical)
                txtTotal.Text = total
            End If
            If employeeSalary > 15000 Then
                house = (0.02 * employeeSalary)
                txtHouse.Text = house

                travel = (0.01 * employeeSalary)
                txtTravel.Text = travel

                medical = (0.04 * employeeSalary)
                txtMedical.Text = medical

                total = (house + travel + medical)
                txtTotal.Text = total
            End If
            grossSalary = (employeeSalary + amountToDeposit + total)
            txtGrossSalary.Text = grossSalary

            tax = (0.05 * grossSalary)
            txtTax.Text = tax

            netSalary = (grossSalary - (nhif + nssf - tax))
            txtNetSalary.Text = netSalary

        End If




        If txtEmployeeSalary.Text = "" Or
            txtHouse.Text = "" Or
            txtTravel.Text = "" Or
            txtMedical.Text = "" Or
            txtTotal.Text = "" Or
            txtNhif.Text = "" Or
            txtNssf.Text = "" Or
            txtTax.Text = "" Or
            txtGrossSalary.Text = "" Or
            txtNetSalary.Text = "" Then


            MsgBox("provide all details", MsgBoxStyle.Information)
        Else
            My.Settings.employeeSalary = txtEmployeeSalary.Text
            My.Settings.house = txtHouse.Text
            My.Settings.travel = txtTravel.Text
            My.Settings.medical = txtMedical.Text
            My.Settings.total = txtTotal.Text
            My.Settings.nhif = txtNhif.Text
            My.Settings.nssf = txtNssf.Text
            My.Settings.tax = txtTax.Text
            My.Settings.grossSalary = txtGrossSalary.Text
            My.Settings.netSalary = txtNetSalary.Text


            My.Settings.Save()


        End If




        txtDepositMoney.Text = ""
        txtDepositMoney.AppendText("==================================" + vbNewLine)
        txtDepositMoney.AppendText("THE KENYA COMMERCIAL BANK ACCOUNT STATEMENT" + vbNewLine)
        txtDepositMoney.AppendText("Name: " + vbTab + vbTab & firstName + " " & middleName + " " & lastName + vbNewLine)
        txtDepositMoney.AppendText("Postal adress: " + vbTab & postalAddress + "-" & postalCode + vbNewLine)
        txtDepositMoney.AppendText("      " + vbTab + vbTab & town + " " & country + vbNewLine)
        txtDepositMoney.AppendText("Account type: " + vbTab & accounttype + vbNewLine)
        txtDepositMoney.AppendText("Employment: " + vbTab & employment + vbNewLine)

        txtDepositMoney.AppendText("Deposit amount: " + vbTab & txtAmountToDeposit.Text + vbNewLine)
        txtDepositMoney.AppendText("Deposit from: " + vbTab + vbTab & cboDepositFrom.Text + vbNewLine)
        txtDepositMoney.AppendText("Allowances: " + vbNewLine)
        txtDepositMoney.AppendText("    House allowance: " + vbTab & txtHouse.Text + vbNewLine)
        txtDepositMoney.AppendText("    Travel allowance: " + vbTab & txtTravel.Text + vbNewLine)
        txtDepositMoney.AppendText("    Medical allowance: " + vbTab & txtMedical.Text + vbNewLine)
        txtDepositMoney.AppendText("    Total allowance: " + vbTab & txtTotal.Text + vbNewLine)
        txtDepositMoney.AppendText("Employee salary: " + vbTab & txtEmployeeSalary.Text + vbNewLine)
        txtDepositMoney.AppendText("Deductions: " + vbNewLine)
        txtDepositMoney.AppendText("    NHIF: " + vbTab & txtNhif.Text + vbNewLine)
        txtDepositMoney.AppendText("    NSSF: " + vbTab & txtNssf.Text + vbNewLine)
        txtDepositMoney.AppendText("Tax: " + vbTab & txtTax.Text + vbNewLine)
        txtDepositMoney.AppendText("Gross salary: " + vbTab & txtGrossSalary.Text + vbNewLine)
        txtDepositMoney.AppendText("Net salary: " + vbTab & txtNetSalary.Text + vbNewLine)
        txtDepositMoney.AppendText("Bank balance: " + vbTab & txtMyCurrentBalance.Text + vbNewLine)


        txtDepositMoney.AppendText("==================================" + vbNewLine)
        txtDepositMoney.AppendText("Auto-generated by the Kenya commercial bank systems." + vbNewLine)
        txtDepositMoney.AppendText("Your loan request has been received and processed" + vbNewLine)
        txtDepositMoney.AppendText("Thank you for banking with us" + vbNewLine)

    End Sub

    Private Sub cboDepositFrom_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboDepositFrom.SelectedIndexChanged

    End Sub

    Private Sub btnWithdramMoney_Click(sender As Object, e As EventArgs) Handles btnWithdramMoney.Click
        Dim amountToWithdraw As String
        Dim withdrawTo As String
        Dim balance As String

        amountToWithdraw = (txtAmountToWithdraw.Text)
        withdrawTo = (cboWithdrawTo.Text)
        balance = (txtBalance.Text)

        balance = (netSalary - amountToWithdraw)
        txtBalance.Text = balance

        My.Settings.netSalary = txtBalance.Text
        My.Settings.Save()



        txtWithdrawMoney.Text = ""
        txtWithdrawMoney.AppendText("==================================" + vbNewLine)
        txtWithdrawMoney.AppendText("THE KENYA COMMERCIAL BANK ACCOUNT STATEMENT" + vbNewLine)
        txtWithdrawMoney.AppendText("==================================" + vbNewLine)
        txtWithdrawMoney.AppendText("Name: " + vbTab + vbTab & firstName + " " & middleName + " " & lastName + vbNewLine)
        txtWithdrawMoney.AppendText("Postal adress: " + vbTab & postalAddress + "-" + postalCode + vbNewLine)
        txtWithdrawMoney.AppendText("      " + vbTab + vbTab & town + vbNewLine)
        txtWithdrawMoney.AppendText("      " + vbTab + vbTab & country + vbNewLine)
        txtWithdrawMoney.AppendText("Account type: " + vbTab & accounttype + vbNewLine)
        txtWithdrawMoney.AppendText("Employment: " + vbTab & employment + vbNewLine)
        txtWithdrawMoney.AppendText("Withdrawal amount: " + vbTab + vbTab & amountToWithdraw + vbNewLine)
        txtWithdrawMoney.AppendText("Withdraw: " + vbTab + vbTab & withdrawTo + vbNewLine)
        txtWithdrawMoney.AppendText("Balance: " + vbTab & balance + vbNewLine)
        txtWithdrawMoney.AppendText("==================================" + vbNewLine)
        txtWithdrawMoney.AppendText("Auto-generated by the Kenya commercial bank systems." + vbNewLine)
        txtWithdrawMoney.AppendText("Your loan request has been received and processed" + vbNewLine)
        txtWithdrawMoney.AppendText("Thank you for banking with us" + vbNewLine)
        txtWithdrawMoney.AppendText("==================================" + vbNewLine)

    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click
        Dim sendeeName As String
        Dim account As String
        Dim amountSent As String
        Dim myBankBalance As String

        sendeeName = (txtSendeeName.Text)
        account = (txtAccount.Text)
        amountSent = (txtAmountSent.Text)
        myBankBalance = (txtMyBankBalance.Text)

        myBankBalance = (netSalary - amountSent)
        txtMyBankBalance.Text = myBankBalance

        My.Settings.netSalary = txtMyBankBalance.Text
        My.Settings.Save()

        lblSentMoneySlip.Text = ""
        lblSentMoneySlip.AppendText("==================================" + vbNewLine)
        lblSentMoneySlip.AppendText("THE KENYA COMMERCIAL BANK ACCOUNT STATEMENT" + vbNewLine)
        lblSentMoneySlip.AppendText("==================================" + vbNewLine)
        lblSentMoneySlip.AppendText("Name: " + vbTab + vbTab & firstName + " " & middleName + " " & lastName + vbNewLine)
        lblSentMoneySlip.AppendText("Postal adress: " + vbTab & postalAddress + "-" + postalCode + vbNewLine)
        lblSentMoneySlip.AppendText("      " + vbTab + vbTab & town + vbNewLine)
        lblSentMoneySlip.AppendText("      " + vbTab + vbTab & country + vbNewLine)
        lblSentMoneySlip.AppendText("Account type: " + vbTab & accounttype + vbNewLine)
        lblSentMoneySlip.AppendText("Employment: " + vbTab & employment + vbNewLine)
        lblSentMoneySlip.AppendText("Send to: " + vbTab + vbTab & sendeeName + vbNewLine)
        lblSentMoneySlip.AppendText("Account: " + vbTab + vbTab & account + vbNewLine)
        lblSentMoneySlip.AppendText("Amount sent: " + vbTab & amountSent + vbNewLine)
        lblSentMoneySlip.AppendText("Balance: " + vbTab + vbTab & myBankBalance + vbNewLine)
        lblSentMoneySlip.AppendText("==================================" + vbNewLine)
        lblSentMoneySlip.AppendText("Auto-generated by the Kenya commercial bank systems." + vbNewLine)
        lblSentMoneySlip.AppendText("Your loan request has been received and processed" + vbNewLine)
        lblSentMoneySlip.AppendText("Thank you for banking with us" + vbNewLine)
        lblSentMoneySlip.AppendText("==================================" + vbNewLine)
    End Sub

    Private Sub lblMoneyInBank_Click(sender As Object, e As EventArgs) Handles lblMoneyInBank.Click

    End Sub
End Class

