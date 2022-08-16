Public Class Form1
    Function isValid(strPassword As String) As Boolean
        strPassword = strPassword.Trim() 'remove spaces
        strPassword = strPassword.ToUpper() 'convert all characters to upper case 
        Dim intLength As Integer = strPassword.Length
        Dim num As New System.Text.RegularExpressions.Regex("[0-9]")
        Dim alpha As New System.Text.RegularExpressions.Regex("[A-Z]")

        If intLength < 8 Then
            Return False 'if number of characters is < 8 then invalid

        ElseIf num.Matches(strPassword).Count < 1 Then 'no numbers then reutrn false
            Return False

        ElseIf alpha.Matches(strPassword).Count < 1 Then 'no alphabets then return false
            Return False

        Else Return True 'Return true if all conditions meet

        End If

    End Function

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        If isValid(txtPassword.Text) = True Then
            StatusStrip.Text = "Valid Password"

        Else StatusStrip.Text = "Invalid Password"
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtPassword.Text = String.Empty
        StatusStrip.Text = "Status"
        txtPassword.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
