namespace FileHandling
{
    internal class Program
    {
        static string path1 = @"C:\Users\DELL\Desktop\Sufyan\Visual Studio stuff\.vscode\html.html";
        static string path2 = @"C:\Users\DELL\Desktop\Sufyan\Visual Studio stuff\.vscode\text.txt";
        static string path3 = @"C:\\Users\\DELL\\Desktop\\Sufyan\\Visual Studio stuff\\.vscode\\LOL.json";
        static void Main(string[] args)
        {

            if (!File.Exists(path1))
            {
                File.Create(path1).Close();
            }
            if (!File.Exists(path2))
            {
                File.Create(path2).Close();
            }

            Console.WriteLine(File.ReadAllText(@"C:\Users\DELL\Desktop\Sufyan\Visual Studio stuff\.vscode\html.html"));
            Console.WriteLine("==================================");
            Console.WriteLine(File.ReadAllText(@"C:\Users\DELL\Desktop\Sufyan\Visual Studio stuff\.vscode\text.txt"));

            string appendText = "\nAppend Text to text file";
            File.AppendAllText(path2, appendText);
            
            Console.WriteLine("==================USERNAMES================");
            SaveUserName(path2);



        }


        static void SaveUserName(string path)
        {

            Console.Write("Enter a username: ");
            string userName = Console.ReadLine() + "\n";
            File.WriteAllText(path2, userName);
            Console.WriteLine(File.ReadAllText(path2));
        }
    }
}
