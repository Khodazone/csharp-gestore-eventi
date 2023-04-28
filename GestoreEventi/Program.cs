using GestoreEventi;

try
{
    Console.WriteLine("ciao a tutti");
    Evento Evento = new Evento("Conferenza sul clima", 20/12/2022, 150, 0, 150);
    Console.WriteLine(Evento);
}
catch (Exception exception)
{
    Console.WriteLine("è successo qualcosa di brutto:" + exception.Message);
}


Console.WriteLine("bene è finito il programma");