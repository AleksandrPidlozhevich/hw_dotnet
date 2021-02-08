using System;
using System.IO;
namespace Task_01
{
    class Program
    {
        static void Main(string[] args)
        {
            //Считывает весь текст
            StreamReader textReader = new StreamReader(@"C:\Users\Алксандр\Downloads\homework_.Net\HW-2\Task1\image.txt", true);
            //Считывает все символы от текущей позиции до конца средства чтения текста и возвращает их как одну строку
            string textReaderResult = textReader.ReadToEnd();
            //Считывает в массив строки,одно слово = элемент массива, расщепления строки на массив строк.
            string[] arrayOfTextResult = textReaderResult.Split(' ');
            //создаем массив на 1 меньше 
            byte[] imageBytes = new byte[arrayOfTextResult.Length - 1];
            //цикл счетсчик операций 
            for (int i = 0; i < arrayOfTextResult.Length - 1; i++)
            {
                //коневертируем
                byte binary = Convert.ToByte(arrayOfTextResult[i], 2);
                //записывает данные в память
                imageBytes[i] = binary;
            }
            //создает новый файл, записывает в него указанный массив байтов, а затем закрывает файл. Если целевой файл уже существует, он перезаписывается.
            File.WriteAllBytes(@"C:\Users\Алксандр\Downloads\homework_.Net\HW-2\Task1\image.png", imageBytes);
            //освобождает все ссылки TextReader чтоб освободить память 
            textReader.Dispose();
        }
    }
}
