namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> list = new HashSet<string>();
            list.Add("Umamu");
            list.Add("Low Cortisol");
            list.Add("Futanari Sasuke");
            list.Add("El Condor Pisa");
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }
        }
    }
};

