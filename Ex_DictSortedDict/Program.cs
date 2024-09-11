class Program
{
    static void Main(string[] args)
    {
        StreamReader stream = null;
        Dictionary<string, int> dict = new Dictionary<string, int>();
        try
        {
            Console.WriteLine("Enter file full path: ");
            string path = Console.ReadLine();
            stream = File.OpenText(path);
            while (!stream.EndOfStream)
            {
                string[] line = stream.ReadLine().Split(",");

                if (dict.ContainsKey(line[0]))
                {
                    dict[line[0]] += int.Parse(line[1]);
                }
                else
                {
                    dict.Add(line[0], int.Parse(line[1]));
                }

            }

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + ": " + item.Value);
            }

        }
        catch (Exception e)
        {
            Console.WriteLine("Error: " + e.Message);
        }
    }
}