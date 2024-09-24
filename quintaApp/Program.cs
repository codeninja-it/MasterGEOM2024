using quartaApp;
using quintaApp;

Utility utility = new Utility();
Rubrica attiva = new Rubrica();
string comando = "";
do
{
    comando = utility.ChiediTesto("cosa devo fare");
    if (comando == "scrivi")
    {
        Contatto nuovo = new Contatto();
        nuovo.nome = utility.ChiediTesto("nome");
        nuovo.cognome = utility.ChiediTesto("cognome");
        nuovo.telefono = utility.ChiediTesto("telefono");
        attiva.contatti.Add(nuovo);
    }
    else if (comando == "leggi")
    {
        int n = 0;
        while (n < attiva.contatti.Count)
        {
            Contatto selezionato = attiva.contatti[n];
            Console.WriteLine($"{n+1}) {selezionato.nome} {selezionato.cognome} {selezionato.telefono}");
            n = n + 1;
        }
    }
    else if(comando == "cancella")
    {
        int daCancellare = utility.ChiediNumero("quale cancello");
        Contatto selezionato = attiva.contatti[daCancellare - 1];
        attiva.contatti.Remove(selezionato);
    } 
    else if(comando == "salva")
    {
        string buffer = System.Text.Json.JsonSerializer.Serialize(attiva);
        string nomeFile = utility.ChiediTesto("nome file");
        File.WriteAllText($"c:\\test\\{nomeFile}.json", buffer);
    }
    else if (comando == "apri")
    {
        string nomeFile = utility.ChiediTesto("nome file");
        string buffer = File.ReadAllText($"c:\\test\\{nomeFile}.json");
        attiva = System.Text.Json.JsonSerializer.Deserialize<Rubrica>(buffer);
    }
    else
    {
        Console.WriteLine("non so che comando sia...");
    }

} while (comando != "esci");