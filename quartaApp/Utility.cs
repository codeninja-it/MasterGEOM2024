namespace quartaApp
{
    public class Utility
    {
        public int ChiediNumero(string domanda)
        {
            Console.Write($"{domanda}: "); // 2
            string testo = Console.ReadLine();
            int numero = int.Parse(testo);
            return numero;
        }

        private string ChiediTesto(string domanda)
        {
            Console.Write($"{domanda}: ");
            string testo = Console.ReadLine();
            return testo;
        }

        public bool ChiediConferma(string domanda)
        {
            Console.Write($"{domanda}: ");
            string testo = Console.ReadLine();
            return testo == "sì";
        }
    }
}
