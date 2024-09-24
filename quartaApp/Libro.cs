
namespace quartaApp
{
    internal class Libro
    {
        public int idLibro = 0;
        public string titolo = "";
        public int anno = 0;
        public string autore = "";
        public string ISBN = "";
        public bool primaEdizione = false;
        public float prezzo = 0;
        public string collezione = "";
        public int idUtente = 0;
    }

    internal class Catalogo
    {
        public string nome = "";
        public int anno = 0;
        public List<Libro> libri = new List<Libro>();
        public List<Utente> utenti = new List<Utente>();
    }

    internal class Utente
    {
        public int idUtente = 0;
        public string nome = "";
        public string cognome = "";
    }


}
