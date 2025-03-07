Imports DevExpress.Spreadsheet
Imports DevExpress.XtraBars
Imports DevExpress.XtraSpreadsheet
Imports System
Imports System.Windows.Forms

Namespace WindowsFormsApplication1

    Public Class FormatPainterProvider

        Private spreadsheetControl As SpreadsheetControl

        Private biFormatPainter As BarCheckItem

        Private sourceCell As CellRange = Nothing

        Private formatPainterMode As FormatPainterModeType = FormatPainterModeType.None

        Friend Enum FormatPainterModeType
            SingleAction
            MultipleActions
            None
        End Enum

        Public Sub RegisterFormatPainter(ByVal spreadsheet As SpreadsheetControl, ByVal biFormatPainter As BarCheckItem)
            spreadsheetControl = spreadsheet
            Me.biFormatPainter = biFormatPainter
            AddHandler spreadsheet.MouseUp, AddressOf spreadsheetControl1_MouseUp
            AddHandler spreadsheet.PreviewKeyDown, AddressOf spreadsheetControl1_PreviewKeyDown
            AddHandler spreadsheet.SelectionChanged, AddressOf spreadsheetControl1_SelectionChanged
            AddHandler spreadsheet.CellBeginEdit, AddressOf spreadsheetControl1_CellBeginEdit
            AddHandler spreadsheet.SheetRemoving, AddressOf Spreadsheet_SheetRemoving
            AddHandler biFormatPainter.CheckedChanged, AddressOf barCheckItem1_CheckedChanged
            AddHandler biFormatPainter.ItemDoubleClick, AddressOf barCheckItem1_ItemDoubleClick
        End Sub

        Private Sub Spreadsheet_SheetRemoving(ByVal sender As Object, ByVal e As SheetRemovingEventArgs)
            If sourceCell IsNot Nothing AndAlso Equals(e.SheetName, sourceCell.Worksheet.Name) Then biFormatPainter.Checked = False
        End Sub

        Private Sub barCheckItem1_CheckedChanged(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            Dim shouldCopyFormat As Boolean = biFormatPainter.Checked
            sourceCell = If(shouldCopyFormat, spreadsheetControl.SelectedCell, Nothing)
            formatPainterMode = If(shouldCopyFormat, FormatPainterModeType.SingleAction, FormatPainterModeType.None)
        End Sub

        Private Sub spreadsheetControl1_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)
            If IsFormatPainterActivated() Then ApplyFormat()
        End Sub

        Private Function IsFormatPainterActivated() As Boolean
            If formatPainterMode = FormatPainterModeType.None OrElse sourceCell Is Nothing Then Return False
            Return True
        End Function

        Private Sub ApplyFormat()
            spreadsheetControl.Selection.CopyFrom(sourceCell, PasteSpecial.Formats)
            If formatPainterMode = FormatPainterModeType.SingleAction Then biFormatPainter.Checked = False
        End Sub

        Private Sub barCheckItem1_ItemDoubleClick(ByVal sender As Object, ByVal e As ItemClickEventArgs)
            biFormatPainter.Checked = True
            formatPainterMode = FormatPainterModeType.MultipleActions
        End Sub

        Private Sub spreadsheetControl1_PreviewKeyDown(ByVal sender As Object, ByVal e As PreviewKeyDownEventArgs)
            If Not IsFormatPainterActivated() Then Return
            If e.KeyCode = Keys.Escape Then
                biFormatPainter.Checked = False
            End If
        End Sub

        Private Sub spreadsheetControl1_SelectionChanged(ByVal sender As Object, ByVal e As EventArgs)
            If spreadsheetControl.SelectedShape IsNot Nothing OrElse spreadsheetControl.SelectedComment IsNot Nothing Then
                biFormatPainter.Enabled = False
                biFormatPainter.Checked = False
            Else
                biFormatPainter.Enabled = True
            End If
        End Sub

        Private Sub spreadsheetControl1_CellBeginEdit(ByVal sender As Object, ByVal e As SpreadsheetCellCancelEventArgs)
            If IsFormatPainterActivated() Then
                ApplyFormat()
                e.Cancel = True
            Else
                biFormatPainter.Enabled = False
            End If
        End Sub
    End Class
End Namespace
