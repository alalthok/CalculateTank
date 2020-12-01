Public Class Capacity

    Private Sub Capacity_Load(sender As Object, e As EventArgs) Handles Me.Load
        nilaid.Text = Spec.TextBox6.Text
        nilaih.Text = Spec.TextBox5.Text
        specnetworking.Text = Spec.TextBox2.Text
        specnetworking.Hide()
    End Sub

    Private Sub Ngitung_Click(sender As Object, e As EventArgs) Handles Ngitung.Click

        'Inisiasi Input

        Dim D As Single = Val(nilaid.Text)
        Dim H As Single = Val(nilaih.Text)
        Dim DLL As Single = Val(nilaidll.Text)
        Dim HHLL As Single = Val(nilaihhll.Text)
        Dim LLL As Single = Val(nilailll.Text)
        Dim LLLL As Single = Val(nilaillll.Text)
        Dim Hb As Single = Val(nilaihb.Text)
        Dim Bottslope As Single = Val(botslope.Text)
        Dim txtmantab As Single = Val(mantab.Text)
        Dim mantabspec As Single = Val(specnetworking.Text)

        'Kalkulasi Hb
        Dim Hbnilai As Single = Bottslope * D / 2
        nilaihb.Text = Hbnilai.ToString

        'Kalkulasi DLL
        Dim dllnilai As Single = HHLL + 20
        nilaidll.Text = dllnilai.ToString

        'Kalkulasi VG
        Dim VGnilai As Single = 3.141592653 / 4 * (D ^ 2) * HHLL * (10 ^ -9)
        vg.Text = ("= ") & VGnilai.ToString & (" m^3")

        'Kalkulasi Vb
        Dim Vbnilai As Single = 1 / 3 * 3.141592653 / 4 * (D ^ 2) * Hb * (10 ^ -9)
        vb.Text = ("= ") & Vbnilai.ToString & (" m^3")

        'Kalkulasi Vs
        Dim Vsnilai As Single = (3.141592653 / 4 * (D ^ 2) * LLLL * (10 ^ -9)) - Vbnilai
        vs.Text = ("= ") & Vsnilai.ToString & (" m^3")

        'Kalkulasi Vnet
        Dim Vnetnilai As Single = 3.141592653 / 4 * (D ^ 2) * (HHLL - LLLL) * (10 ^ -9)
        vnet.Text = ("= ") & Vnetnilai.ToString & (" m^3")

        'Mantab
        If Vnetnilai > mantabspec Then
            mantab.Text = ("Kapasitas mantab")
            mantab.Visible = True

        Else
            mantab.Text = ("Kapasitas kurang mantab")
            mantab.Visible = True
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MainMenu.Show()
        Me.Hide()
    End Sub


End Class