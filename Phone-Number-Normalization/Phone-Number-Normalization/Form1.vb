Public Class Form1

    Private Sub btnPhoneInput_Click(sender As Object, e As EventArgs) Handles btnPhoneInput.Click
        Dim strPhoneInput As String = Me.txtPhoneInput.Text.Trim
        Dim strNewPhone As String = ""

        For intC As Integer = 0 To strPhoneInput.Length - 1
            Select Case strPhoneInput.Chars(intC)
                Case ChrW(48) To ChrW(57)
                    strNewPhone = strNewPhone.Insert(strNewPhone.Length, Val(strPhoneInput.Chars(intC)))
            End Select
        Next intC

        strNewPhone = strNewPhone.Insert(3, ChrW(45))
        strNewPhone = strNewPhone.Insert(7, ChrW(45))

        MsgBox("Your Normalized Phone Number is: " & strNewPhone)

    End Sub
End Class
