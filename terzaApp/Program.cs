// chiedo la tabellina
Console.Write("Base della tabellina: ");
string numero = Console.ReadLine();
// chiedo le ripetizioni
Console.Write("Quante ripetizioni: ");
string ripetizioni = Console.ReadLine();
// chiedo conferma dell'operazione
Console.Write("Operazione: ");
string operazione = Console.ReadLine();

// converto in numero i testi di tabellina e ripetizioni
float baseTabellina = float.Parse(numero);
float numeroRipetizioni = float.Parse(ripetizioni);

int n = 0;

do
{
    n = n + 1;
    float risultato;
    if (operazione == "moltiplicazione")
        risultato = baseTabellina * n;
    else if (operazione == "addizione")
            risultato = baseTabellina + n;
    else if (operazione == "divisione")
            risultato = baseTabellina / n;
    else
        risultato = baseTabellina - n;
    
    Console.WriteLine(risultato);

} while (n < numeroRipetizioni);