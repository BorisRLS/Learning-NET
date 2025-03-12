


internal class Program
{
    internal static void Main(string[] args)
    {
        using (var sw = new StreamWriter("test.txt", false, System.Text.Encoding.UTF8))
        {
            sw.WriteLine("Adding new list of users, format: First Name, Last Name, Balance");
        }
        var list = new List<string>();
        list.Add("Boris Novikov 0");
        list.Add("Yura Burov 0");
        foreach (var item in list)
        {
            using (var sw = new StreamWriter("test.txt", true, System.Text.Encoding.UTF8))
            {
                sw.WriteLine(item);
            }
        }
        using (var sr = new StreamReader("test.txt"))
        {

            var text = sr.ReadToEnd();
            Console.WriteLine(text);
        }



    }
}
