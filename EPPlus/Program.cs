using OfficeOpenXml;
ExcelWorksheet excelWorksheet;
string filePath = @"C:\Users\Public\Documents\Этот Документ Создан С Помощью кода на C#.xlsx";
ExcelPackage.License.SetNonCommercialOrganization("Корпорация Зла");
ExcelPackage newBook = new ExcelPackage(filePath);
List<string> listsName = new List<string>() {"Листик 1", "Листик 2", "Листик 3", "Листик 4", "Листик 5" };
List<ExcelWorksheet> excelWorksheets = new List<ExcelWorksheet>();
foreach (var nameWorksheet in listsName) 
{
    if (newBook.Workbook.Worksheets[nameWorksheet] == null)
    {
        excelWorksheets.Add(newBook.Workbook.Worksheets.Add(nameWorksheet));
    }
    else 
    {
        excelWorksheets.Add(newBook.Workbook.Worksheets[nameWorksheet]);
    }
}

FileInfo fileInfo = new FileInfo(filePath);
newBook.SaveAs(fileInfo);