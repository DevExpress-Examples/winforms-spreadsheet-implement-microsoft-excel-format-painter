
# SpreadsheetControl for WinForms - Implement the Basic Idea of the Microsoft Excel's "Format Painter" Feature

This example demonstrates how to copy all the formatting (font, background, alignment, number formats, and borders) from one cell and apply it to another. Try the **Format Painter** button on the **Ribbon Home** tab. 
  
![winforms spreadsheet format painter](./media/29e99ccc-6db9-449b-9844-a481dd9d17d3.png)

## Implementation Details

To copy cell formatting from one cell range to another, the [Range.CopyFrom(Range, PasteSpecial)](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.CellRange.CopyFrom(DevExpress.Spreadsheet.CellRange-DevExpress.Spreadsheet.PasteSpecial)) method with [Formats](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.PasteSpecial) as the second parameter is used.

## Files to Review

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [FormatPainterProvider.cs](./CS/WindowsFormsApplication1/FormatPainterProvider.cs) (VB: [FormatPainterProvider.vb](./VB/WindowsFormsApplication1/FormatPainterProvider.vb))

