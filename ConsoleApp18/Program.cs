newFileProgram.newFile МойНовенькийФайл = new newFileProgram.newFile("ТУТ ДОЛЖНА БЫТЬ ОШИБКА", "\n Это текст файла, он будет создан в запуске 1");
for (int i = 0; i < 1000; i++)
{
    МойНовенькийФайл.FileCreate(i);
    Thread.Sleep(10);
}

namespace newFileProgram
{
    public class newFile
    {
        private string _fileName;
        private string _fileText;
        public newFile(string FileName, string FileText)
        {
            this._fileName = @"C:\Users\Student\source\repos\Sergey\Cifra\" + FileName + ".txt";
            this._fileText = FileText;
        }
        public void FileCreate(int i)
        {
            using (Mutex fileMutex = new Mutex(false, "Global\\MyApp_FileAccessMutex"))
            {
                try
                {
                    fileMutex.WaitOne();
                    File.AppendAllText(this._fileName, this._fileText + $" - {i}");
                    Console.WriteLine(" Завершили создание файла!");
                    fileMutex.ReleaseMutex();
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine(" +==+");
                }
            }
        }
    }
};



