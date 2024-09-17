// 1) mi faccio dire il nome del mio utente
Console.WriteLine("Come ti chiami?");
var nomeUtente = "";
nomeUtente = Console.ReadLine();
// 2) attacco il nome del mio utente ad un saluto
var messaggio = "Ciao " + nomeUtente;
// 3) saluto il mio utente
Console.WriteLine(messaggio);