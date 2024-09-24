using quartaApp;
using System.Text.Json;
using System.IO;

Utility coltellinoSvizzero = new Utility();

int baseTabellina = coltellinoSvizzero.ChiediNumero("Che tabellina vuoi");
int ripetizioni = coltellinoSvizzero.ChiediNumero("Quante volte ripeto");
bool moltiplicazione = coltellinoSvizzero.ChiediConferma("moltiplico?");

int n = 0;
while (n < ripetizioni)
{
    n = n + 1;
    Console.WriteLine( $"{baseTabellina} X {n} = {baseTabellina * n}" );
}

Catalogo catalogo = new Catalogo();
catalogo.nome = "Libri 2024";
catalogo.anno = 2024;

Libro libro = new Libro();
libro.titolo = "Il Cigno Nero";
libro.autore = "Nicholas Taleb";
libro.collezione = "Statistica";
libro.anno = 2004;

catalogo.libri.Add(libro);

Utente nuovo = new Utente();
nuovo.nome = "Mario";
nuovo.cognome = "Rossi";

catalogo.utenti.Add(nuovo);


string buffer = JsonSerializer.Serialize(catalogo);
File.WriteAllText("c:\\test\\catalogo.json", buffer);