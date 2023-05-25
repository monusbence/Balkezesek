namespace Balkezesek
{
    internal class Program
    {
        static List<BalkezesekOsztály> lista = new List<BalkezesekOsztály>();
        static void Main(string[] args)
        {
            Olvasas();
            HarmasFeladat();
        }

        static void Olvasas()
        {
            StreamReader szoveg = new StreamReader("balkezesek.csv");
            lista.Skip(1);
            while (!szoveg.EndOfStream)
            {
                string[] player = szoveg.ReadLine().Split(";");
                
            }

            szoveg.Close();
        }
        static void HarmasFeladat()
        {

            Console.WriteLine(lista.Count);
        }
    }
}