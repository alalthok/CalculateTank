Public Class Shell

    Private Sub Shell_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MainMenu.Show()
        Me.Hide()
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        'Inisiasi Input
        Dim D = Val(txtDiameterData1.Text)
        Dim NC1 = Val(txtNC1.Text)
        Dim H2 = Val(txtH2.Text)
        Dim LLL2 = Val(txtLLL2.Text)
        Dim HTH2 = Val(txtHTH2.Text)
        Dim HLL2 = Val(txtHLL2.Text)
        Dim Gravity = Val(txtGravity.Text)
        Dim CAShell = Val(txtCAShell.Text)
        Dim CARoof = Val(txtCARoof.Text)
        Dim CABottom = Val(txtCABottom.Text)
        Dim CARoofFram = Val(txtCARoofFraming.Text)
        Dim Press = Val(txtPress.Text)
        Dim Temp = Val(txtTemp.Text)
        Dim Wind2 = Val(txtWind2.Text)

        'Kalkulasi lblDiameterData2
        Dim DiameterData2 As Single = D * 1000
        lblDiameterData2.Text = DiameterData2.ToString

        'Kalkulasi lblDiameterData2
        Dim DiameterNew2 As Single = D + 20 'G626
        lblDiameterNew2.Text = DiameterNew2.ToString

        'Kalkulasi DiameterNew1
        Dim DiameterNew1 As Single = DiameterNew2 * 1000
        lblDiameterNew1.Text = DiameterNew1.ToString

        'Kalkulasi DiameterCorroded2
        Dim DiameterCorroded2 As Single = D - (2 * Gravity) + 20 'G626
        lblDiameterCorroded2.Text = DiameterCorroded2.ToString

        'Kalkulasi DiameterNew1
        Dim DiameterCorroded1 As Single = DiameterCorroded2 * 1000
        lblDiameterCorroded1.Text = DiameterCorroded1.ToString

        'Kalkulasi NC2
        Dim NC2 As Single = NC1 * 1000 ^ 3
        lblNC.Text = NC2.ToString

        'Kalkulasi H1
        Dim H1 As Single = H2 / 1000
        lblH1.Text = H1.ToString

        'Kalkulasi LLL1
        Dim LLL1 As Single = LLL2 / 1000
        lblLLL1.Text = LLL1.ToString

        'Kalkulasi HTH1
        Dim HTH1 As Single = HTH2 / 1000
        lblHTH1.Text = HTH1.ToString

        'Kalkulasi HLL1
        Dim HLL1 As Single = HLL2 / 1000
        lblHLL1.Text = HLL1.ToString

        'Kalkulasi Wind1
        Dim Wind1 As Single = Wind2 / 1000
        lblWind1.Text = Wind1.ToString



    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click
        Me.Hide()
        Shell2.Show()
    End Sub
End Class