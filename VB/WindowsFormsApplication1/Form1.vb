Imports System.Windows.Forms

Namespace WindowsFormsApplication1

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
            Dim formatPainterProvider As FormatPainterProvider = New FormatPainterProvider()
            formatPainterProvider.RegisterFormatPainter(spreadsheetControl1, biFormatPainter)
        End Sub
    End Class
End Namespace
