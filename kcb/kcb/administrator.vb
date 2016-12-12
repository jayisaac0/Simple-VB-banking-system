Public Class frmAdministrator

    Private Sub btnAdminRegister_Click(sender As Object, e As EventArgs) Handles btnAdminRegister.Click

    End Sub

    Private Sub frmAdministrator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'KenyaCommercialBankDataSet.adminTBL' table. You can move, or remove it, as needed.
        Me.AdminTBLTableAdapter.Fill(Me.KenyaCommercialBankDataSet.adminTBL)

    End Sub
End Class