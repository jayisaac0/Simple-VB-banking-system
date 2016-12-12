Public Class frmLogin

    Private Sub lblLogIn_Click(sender As Object, e As EventArgs) Handles lblLogIn.Click
        If (txtEmail.Text = My.Settings.email And txtPassword.Text = My.Settings.password) Then
            MsgBox("Welcome to your account", MsgBoxStyle.Information)

            Dim OBJ As New frmAccount
            OBJ.firstName = My.Settings.firstName
            OBJ.middleName = My.Settings.middleName
            OBJ.lastName = My.Settings.lastName
            OBJ.postalAddress = My.Settings.postalAddress
            OBJ.postalCode = My.Settings.postalCode
            OBJ.town = My.Settings.town
            OBJ.country = My.Settings.country
            OBJ.kraPin = My.Settings.kraPin
            OBJ.idCard = My.Settings.idCard
            OBJ.accounttype = My.Settings.accountType
            OBJ.generatedAccountNumber = My.Settings.generatedAccountNumber
            OBJ.employment = My.Settings.employment
            OBJ.sex = My.Settings.sex
            OBJ.email = My.Settings.email
            OBJ.phoneNumber = My.Settings.phoneNumber
            OBJ.branchName = My.Settings.branchName
            OBJ.companyOfWork = My.Settings.companyOfWork
            OBJ.moneyInBank = My.Settings.moneyInBank
            OBJ.grossSalary = My.Settings.grossSalary
            OBJ.allowance = My.Settings.allowance
            OBJ.employeeSalary = My.Settings.employeeSalary
            OBJ.house = My.Settings.house
            OBJ.travel = My.Settings.travel
            OBJ.medical = My.Settings.medical
            OBJ.total = My.Settings.total
            OBJ.nhif = My.Settings.nhif
            OBJ.nssf = My.Settings.nssf

            OBJ.netSalary = My.Settings.netSalary
            OBJ.Show()
            Me.Hide()

        Else
            MsgBox("Invalid Login details", MsgBoxStyle.Information)

        End If




    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class