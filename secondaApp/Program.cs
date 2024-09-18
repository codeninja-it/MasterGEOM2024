string risposta;

do {
    // chiedo la base della mia tabellina
    Console.WriteLine("che tabellina vuoi?");
    string baseTabellina = Console.ReadLine();
    int tabellina = int.Parse(baseTabellina);

    // chiedo il numero di ripetizioni
    Console.WriteLine("quante volte ripeto?");
    string ripetizioni = Console.ReadLine();
    int tettoMassimo = int.Parse(ripetizioni);

    // faccio pulito
    Console.Clear();

    // mi preparo un contatore
    int n = 0;

    do
    {
        // eseguo il mio conteggio
        n = n + 1;
        int risultato = n * tabellina;
        // restituisco il risultato
        Console.WriteLine($" {tabellina} X {n} = {risultato}");
        // fino a che sto sotto il tetto massimo
    } while (n < tettoMassimo);

    // controllare se ne vuole un altra
    Console.WriteLine("Ne vuoi un altra?");
    risposta = Console.ReadLine();

} while (risposta == "si");

Console.WriteLine("Buona giornata!");
