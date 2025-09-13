using OfficeOpenXml;

ExcelPackage.License.SetNonCommercialOrganization("Корпорация Зла");
ExcelPackage newBook = new ExcelPackage(@"C:\Users\Public\Documents\3301.xlsx");
ExcelWorksheet excelWorksheet;
Console.Write(" Напишите по что вы хоиите найти: ");
string чтоНадоНайти = Console.ReadLine();
Console.WriteLine(" Выберите область поиска:  ");
string[] info =
{
    "1) № пп ",
    "2) Наименование дебитора",
    "3) Дебиторская зад-ть, тыс.руб.",
    "4) Дата образования",
    "5) Весь документ"
};

foreach (string name in info) 
{
    Console.WriteLine(name);
}
Console.Write("\n Введите: ");
string userInputCase = Console.ReadLine();
switch (userInputCase) 
{
    case "1)" or "1":
        for (int i = 0; i < newBook.Workbook.Worksheets.Count; i++)
        {
            excelWorksheet = newBook.Workbook.Worksheets[i];
            excelWorksheet.Cells["E1"].Formula = $"VLOOKUP({чтоНадоНайти}, A1:D50, 3, FALSE)";
        }
        break;
    case "2)" or "2":

        break;
    case "3)" or "3":

        break;
    case "4)" or "4":

        break;
    case "5)" or "5":

        break;
    default:
        Console.WriteLine(" НЕ ПОнял ЧТо ТЫ Ввел");
        break;
}
newBook.Save();