Public Class Shell2
    Private Sub Shell2_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Inisiasi Input
        Dim Sd1 = Val(txtSd1.Text)
        Dim Sd2 = Val(txtSd2.Text)
        Dim Sd3 = Val(txtSd3.Text)
        Dim Sd4 = Val(txtSd4.Text)
        Dim Sd5 = Val(txtSd5.Text)
        Dim Sd6 = Val(txtSd6.Text)
        Dim St1 = Val(txtSt1.Text)
        Dim St2 = Val(txtSt2.Text)
        Dim St3 = Val(txtSt3.Text)
        Dim St4 = Val(txtSt4.Text)
        Dim St5 = Val(txtSt5.Text)
        Dim St6 = Val(txtSt6.Text)
        Dim Width1 = Val(txtWidth1.Text)
        Dim Width2 = Val(txtWidth2.Text)
        Dim Width3 = Val(txtWidth3.Text)
        Dim Width4 = Val(txtWidth4.Text)
        Dim Width5 = Val(txtWidth5.Text)
        Dim Width6 = Val(txtWidth6.Text)


        'Kalkulasi Width1
        Dim iWidth1 As Single = Width1 / 1000
        lblWidth1.Text = iWidth1.ToString

        'Kalkulasi Width2
        Dim iWidth2 As Single = Width2 / 1000
        lblWidth2.Text = iWidth2.ToString

        'Kalkulasi Width3
        Dim iWidth3 As Single = Width3 / 1000
        lblWidth3.Text = iWidth3.ToString

        'Kalkulasi Width4
        Dim iWidth4 As Single = Width4 / 1000
        lblWidth4.Text = iWidth4.ToString

        'Kalkulasi Width5
        Dim iWidth5 As Single = Width5 / 1000
        lblWidth5.Text = iWidth5.ToString

        'Kalkulasi Width6
        Dim iWidth6 As Single = Width6 / 1000
        lblWidth6.Text = iWidth6.ToString

        'Kalkulasi MaxWidthMM
        Dim iMaxWidthMM As Single = Width1 + Width2 + Width3 + Width4 + Width5 + Width6
        lblMaxWidthMM.Text = iMaxWidthMM.ToString

        'Kalkulasi MaxWidthM
        Dim iMaxWidthM As Single = iWidth1 + iWidth2 + iWidth3 + iWidth4 + iWidth5 + iWidth6
        lblMaxWidthM.Text = iMaxWidthM.ToString


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Shell.Show()
    End Sub
End Class