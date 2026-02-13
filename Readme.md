<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128613703/19.2.2%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T590741)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# SpreadsheetControl for WinForms - Implement the Basic Idea of the Microsoft Excel's "Format Painter" Feature

This example demonstrates how to copy all the formatting (font, background, alignment, number formats, and borders) from one cell and apply it to another. Try the **Format Painter** button on the **Ribbon Home** tab. 
  
![winforms spreadsheet format painter](./media/29e99ccc-6db9-449b-9844-a481dd9d17d3.png)

## Implementation Details

To copy cell formatting from one cell range to another, the [Range.CopyFrom(Range, PasteSpecial)](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.CellRange.CopyFrom(DevExpress.Spreadsheet.CellRange-DevExpress.Spreadsheet.PasteSpecial)) method with [Formats](https://docs.devexpress.com/OfficeFileAPI/DevExpress.Spreadsheet.PasteSpecial) as the second parameter is used.

## Files to Review

* [Form1.cs](./CS/WindowsFormsApplication1/Form1.cs) (VB: [Form1.vb](./VB/WindowsFormsApplication1/Form1.vb))
* [FormatPainterProvider.cs](./CS/WindowsFormsApplication1/FormatPainterProvider.cs) (VB: [FormatPainterProvider.vb](./VB/WindowsFormsApplication1/FormatPainterProvider.vb))

<!-- feedback -->
## Does This Example Address Your Development Requirements/Objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-spreadsheet-implement-microsoft-excel-format-painter&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=winforms-spreadsheet-implement-microsoft-excel-format-painter&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
