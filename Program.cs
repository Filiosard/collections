namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> list = new HashSet<string>();
            list.Add("Umamu");
            list.Add("Cortisol");
            list.Add("FutanariSasuke");
            list.Add("El Condor Pasa");
            foreach (var name in list)
            {
                Console.WriteLine(name);
            }
        }
    }
};

