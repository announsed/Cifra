using System.Drawing;
using OfficeOpenXml;
using OfficeOpenXml.Style;
ExcelWorksheet excelWorksheet;
string filePath = @"C:\Users\Public\Documents\Этот Документ Создан С Помощью кода на C#.xlsx";
ExcelPackage.License.SetNonCommercialOrganization("Корпорация Зла");
Random random = new Random();
ExcelPackage newBook = new ExcelPackage(filePath);
List<string> listsName = new List<string>() { "Листик 1", "Листик 2", "Листик 3", "Листик 4", "Листик 5" };
foreach (var nameWorksheet in listsName)
{
    if (newBook.Workbook.Worksheets[nameWorksheet] == null)
    {
        newBook.Workbook.Worksheets.Add(nameWorksheet);
    }
}
if (newBook.Workbook.Worksheets["Functions"] == null)
{
    newBook.Workbook.Worksheets.Add("Functions");
}
ExcelWorksheet currentWorksheet =
newBook.Workbook.Worksheets["Functions"];
/**********Стандартные действия создания листа и его выбора***********/
// Заполнение ячеек первых слагаемых

currentWorksheet.Cells["A1:G5"].AutoFitColumns();
currentWorksheet.Cells["A1:G1"].Style.Border.Top.Style = ExcelBorderStyle.Double;
currentWorksheet.Cells["A1:G1"].Style.Border.Bottom.Style = ExcelBorderStyle.Double;
currentWorksheet.Cells["A1:G1"].Style.Border.Right.Style = ExcelBorderStyle.Double;
currentWorksheet.Cells["A1:G1"].Style.Border.Left.Style = ExcelBorderStyle.Double;

currentWorksheet.Cells["A1:G1"].Style.Border.Top.Color.SetColor(Color.BlueViolet);
currentWorksheet.Cells["A1:G1"].Style.Border.Bottom.Color.SetColor(Color.BlueViolet);
currentWorksheet.Cells["A1:G1"].Style.Border.Right.Color.SetColor(Color.BlueViolet);
currentWorksheet.Cells["A1:G1"].Style.Border.Left.Color.SetColor(Color.BlueViolet);

for (int i = 0; i < 4; i++)
{
    for (int j = 0; j < 4; j++)
    {
        currentWorksheet.Cells[i + 1,j + 1].Value = random.Next(0,400);
    }
}
// Заполнение ячеек pervix слагаемых
currentWorksheet.Cells["A1"].Value = "Числа в первом столбце";

// Заполнение ячеек вторых слагаемых
currentWorksheet.Cells["B1"].Value = "Числа во вторм столбце";

// Используем функцию SUM() для суммирования значений
currentWorksheet.Cells["C1"].Value = "SUM() для суммирования значений";
currentWorksheet.Cells["C2"].Formula = "SUM(A2:B2)";
currentWorksheet.Cells["C3"].Formula = "SUM(A3:B3)";
currentWorksheet.Cells["C4"].Formula = "SUM(A4:B4)";
// Функция AVERAGE (Среднее значение).
currentWorksheet.Cells["D1"].Value = "AVERAGE (Среднее значение)";
currentWorksheet.Cells["D2"].Formula = "AVERAGE(A2:B2:C2)";
currentWorksheet.Cells["D3"].Formula = "AVERAGE(A3:B3:C3)";
currentWorksheet.Cells["D4"].Formula = "AVERAGE(A4:B4:C4)";
// MAX (МАКС).
currentWorksheet.Cells["E1"].Value = "MAX (МАКС).";
currentWorksheet.Cells["E2"].Formula = "MAX(A2:B2:C2:D2)";
currentWorksheet.Cells["E3"].Formula = "MAX(A3:B3:C3:D3)";
currentWorksheet.Cells["E4"].Formula = "MAX(A4:B4:C4:D4)";
// MIN (МИН).
currentWorksheet.Cells["F1"].Value = "MIN (МИН).";
currentWorksheet.Cells["F2"].Formula = "MIN(A2:B2:C2:D2:E2)";
currentWorksheet.Cells["F3"].Formula = "MIN(A3:B3:C3:D3:E3)";
currentWorksheet.Cells["F4"].Formula = "MIN(A4:B4:C4:D4:E4)";
//  =SUMIF(A1:F7, ">50")
currentWorksheet.Cells["G1"].Value = "SUMIF (СУММЕСЛИ).";
currentWorksheet.Cells["G2"].Formula = "SUMIF(A2:F2, \">50\")";
currentWorksheet.Cells["G3"].Formula = "SUMIF(A3:F3, \">50\")";
currentWorksheet.Cells["G4"].Formula = "SUMIF(A4:F4, \">50\")";
newBook.Save();

FileInfo fileInfo = new FileInfo(filePath);
newBook.SaveAs(fileInfo);