
namespace quartaApp
{
    public class Libro
    {
        public int idLibro { get; set; } = 0;
        public string titolo { get; set; } = "";
        public int anno { get; set; } = 0;
        public string autore { get; set; } = "";
        public string ISBN { get; set; } = "";
        public bool primaEdizione { get; set; } = false;
        public float prezzo { get; set; } = 0;
        public string collezione { get; set; } = "";
        public int idUtente { get; set; } = 0;
    }

    public class Catalogo
    {
        public string nome { get; set; } = "";
        public int anno { get; set; } = 0;
        public List<Libro> libri { get; set; } = new List<Libro>();
        public List<Utente> utenti { get; set; } = new List<Utente>();
    }

    public class Utente
    {
        public int idUtente { get; set; } = 0;
        public string nome { get; set; } = "";
        public string cognome { get; set; } = "";
    }


}
