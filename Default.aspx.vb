
Partial Class _Default
    Inherits System.Web.UI.Page

    Protected Sub calculate_Click(sender As Object, e As EventArgs) Handles calculate.Click
        ' declear variables
        Dim wages As Decimal
        Dim hours As Decimal
        Dim pretax As Decimal
        Dim aftertax As Decimal
        Dim netpay As String

        wages = hourlywage.Text
        hours = hoursworked.Text
        pretax = pretaxded.Text
        aftertax = aftertaxded.Text


        ' calculate gross pay first
        Dim grosspay As String
        grosspay = wages * hours - pretax

        ' decide which tax rate to use 
        If grosspay < 500 Then
            netpay = grosspay * (1 - 0.18) - aftertax
        Else
            netpay = grosspay * (1 - 0.22) - aftertax

        End If

        ' display the result 
        netpayamt.Text = netpay

    End Sub

    Protected Sub clearall_Click(sender As Object, e As EventArgs) Handles clearall.Click

        ' clear all the textbox 
        hoursworked.Text = ""
        hourlywage.Text = ""
        pretaxded.Text = ""
        aftertaxded.Text = ""
        netpayamt.Text = ""


    End Sub
End Class
