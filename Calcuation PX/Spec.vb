Public Class Spec

    Private WithEvents pd As New Printing.PrintDocument
    Private ppd As PrintPreviewDialog

    Private Sub btlCalculate_Click(sender As Object, e As EventArgs) Handles btlCalculate.Click

        'Kalkulasi Design Pressure
        Dim DesignPressure As Single = Val(InDesignPressure.Text)
        Dim kpa As Single = DesignPressure * 6.89473
        Dim psig2 As Single = DesignPressure / 2
        Dim kpa2 As Single = psig2 * 6.89473
        OutDesignPressure.Text = ("Psi g (") & kpa.ToString & ("Kpa) / -") & psig2.ToString & ("Psi g (-") & kpa2.ToString & ("Kpa)")

        'Kalkulasi Design Temperature
        Dim DesignTemp As Single = Val(InDesignTemp.Text)
        Dim celciustemp As Single = (DesignTemp - 32) * 5 / 9
        OutDesignTemp.Text = ("°F (") & celciustemp.ToString & ("°C)")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'shows a PrintPreviewDialog
        'to bypass the dialog and just print, use...
        'pd.Print
        ppd = New PrintPreviewDialog With {.Document = pd, .WindowState = FormWindowState.Maximized}
        ppd.ShowDialog()
    End Sub

    Private Sub pd_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pd.PrintPage
        'prints a textbox with a border, using the size and location of the textbox on the form.
        Dim r As Rectangle = TextBox1.Bounds
        e.Graphics.DrawRectangle(Pens.Black, r)
        r.Inflate(-2, 0)
        Dim sf As New StringFormat(Drawing.StringFormat.GenericTypographic)
        sf.LineAlignment = StringAlignment.Center
        e.Graphics.DrawString(TextBox1.Text, TextBox1.Font, Brushes.Black, r, sf)
        'prints two labels using the  location of the labels on the form. 
        e.Graphics.DrawString(Label1.Text, Label1.Font, Brushes.Black, Label1.Left, Label1.Top)
        e.Graphics.DrawString(InDesignPressure.Text, InDesignPressure.Font, Brushes.Black, InDesignPressure.Left, InDesignPressure.Top)
        e.Graphics.DrawString(OutDesignPressure.Text, OutDesignPressure.Font, Brushes.Black, OutDesignPressure.Left, OutDesignPressure.Top)
        e.Graphics.DrawString(Label2.Text, Label2.Font, Brushes.Black, Label2.Left, Label2.Top)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MainMenu.Show()
        Me.Hide()
    End Sub
End Class