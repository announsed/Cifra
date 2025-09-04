using newFileProgram;

newFile МойНовенькийФайл = new newFile("ТУТ ДОЛЖНА БЫТЬ ОШИБКА", "Это текст файла, он будет создан в запуске 2");

for (int i = 0; i < 1000; i++)
{
    МойНовенькийФайл.FileCreate(i);
    Thread.Sleep(10);
}