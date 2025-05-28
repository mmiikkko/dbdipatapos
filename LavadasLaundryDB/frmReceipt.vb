Imports System.Drawing.Printing
Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Public Class frmReceipt
    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        Dim downloadsPath As String = System.IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile), "Downloads")
        Dim filePath As String = System.IO.Path.Combine(downloadsPath, "Sample.pdf")


        Dim pdfDoc As New Document()
        Dim pdfWrite As PdfWriter = PdfWriter.GetInstance(pdfDoc, New FileStream(filePath, FileMode.Create))

        pdfDoc.Open()
        pdfDoc.Add(New Paragraph("Lavada's Laundry Receipt"))
        pdfDoc.Add(New Paragraph("Date: " & DateTime.Now.ToString("MM/dd/yyyy")))
        pdfDoc.NewPage()
        pdfDoc.Add(New Paragraph("Items:"))
        pdfDoc.Close()

        MessageBox.Show("PDF saved to Downloads folder: " & filePath, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class