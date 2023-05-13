class TextFileWriter
{
    static void Main(string[] args)
    {
        TextWriter tw = new StreamWriter("date.txt");
        Console.WriteLine("Документ создан");
        tw.WriteLine("Марсель" + " " + "Практика" + " " +  "Task3");
        Console.WriteLine("Дата сегодняшняя записана");
        tw.Close();
        Console.WriteLine("Документ закрыт");
        TextReader tr = new StreamReader("date.txt");
        Console.WriteLine("Документ открыт");
        Console.WriteLine("Содержимое документа");
        Console.WriteLine(tr.ReadLine());
        tr.Close();
        Console.WriteLine("Документ закрыт");
        
    }
}