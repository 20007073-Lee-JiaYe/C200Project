using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


public static class ExcelUtl
{
    public static void createExcelWithContent(string filePath,
        List<String> theHeader, List<dynamic> theContent)
    {
        // Create a spreadsheet document by supplying the filepath.
        // By default, AutoSave = true, Editable = true, and Type = xlsx.
        SpreadsheetDocument spreadsheetDocument = SpreadsheetDocument.
            Create(filePath, SpreadsheetDocumentType.Workbook);

        // Add a WorkbookPart to the document.
        WorkbookPart workbookpart = spreadsheetDocument.AddWorkbookPart();
        workbookpart.Workbook = new Workbook();

        // Add a WorksheetPart to the WorkbookPart.
        WorksheetPart worksheetPart = workbookpart.AddNewPart<WorksheetPart>();
        worksheetPart.Worksheet = new Worksheet(new SheetData());

        // Add Sheets to the Workbook.
        Sheets sheets = spreadsheetDocument.WorkbookPart.Workbook.
            AppendChild<Sheets>(new Sheets());

        // Append a new worksheet and associate it with the workbook.
        Sheet sheet1 = new Sheet()
        {
            Id = spreadsheetDocument.WorkbookPart.
            GetIdOfPart(worksheetPart),
            SheetId = 1,
            Name = "Worksheet 1"
        };
        sheets.Append(sheet1);

        workbookpart.Workbook.Save();

        SheetData sheetData = worksheetPart.Worksheet.GetFirstChild<SheetData>();

               
        foreach (dynamic dataRow in theContent)
        {
            //var newRow = sheet1.GetFirstChild<SheetData>().AppendChild(new Row());

            Row newRow = new Row() { RowIndex = 1 };
            sheetData.Append(newRow);


            foreach (KeyValuePair<string, object> dataCol in dataRow)
            {
                var theValue = dataCol.ToString().Split(",")[1];

                var cell = newRow.AppendChild(new Cell());
                // DocumentFormat.OpenXml.Spreadsheet.Cell cell = new DocumentFormat.OpenXml.Spreadsheet.Cell();
                cell.DataType = DocumentFormat.OpenXml.Spreadsheet.CellValues.String;
                cell.CellValue = new DocumentFormat.OpenXml.Spreadsheet.CellValue(theValue);
                //newRow.AppendChild(cell);
            }

            //sheet.AppendChild(newRow);
            //sheet.Append(newRow);
        }

        workbookpart.Workbook.Save();

        // Close the document.
        spreadsheetDocument.Close();
    }


}

