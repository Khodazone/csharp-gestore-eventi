using GestoreEventi;

public class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("------ Gestionale Eventi ------");
        Console.WriteLine("1- Crea un programma eventi");
        Console.WriteLine("2- Crea un evento dove si può prenotare o disdire");
        int sceltaPrincipale = Convert.ToInt32(Console.ReadLine());
        switch (sceltaPrincipale)
        {
            case 1:
                Console.WriteLine("Crea il programma eventi:");
                Console.WriteLine("Titolo del programma:");
                string titoloProgramma = Console.ReadLine();

                //PROGRAMMA EVENTI
                ProgrammaEventi programmaEventi = new ProgrammaEventi(titoloProgramma);
                Console.WriteLine("Quanti eventi vuoi aggiungere al programma?");
                int numeroEventi = Convert.ToInt32(Console.ReadLine());

                //CICLO PER CREARE TOT EVENTI
                for (int i = 0; i < numeroEventi; i++)
                {
                    Console.WriteLine("Inserisci il titolo");
                    string titoloEvento = Console.ReadLine();
                    Console.WriteLine("Inserisci la data");
                    DateTime dataEvento = Convert.ToDateTime(Console.ReadLine());
                    Console.WriteLine("Inserisci la capienza massima");
                    int capienzaMaxEvento = Convert.ToInt32(Console.ReadLine());
                }

                Console.WriteLine("Scegli un'opzione");
                Console.WriteLine("1- Ottieni il numero presente di eventi nel programma");
                Console.WriteLine("2- Stampa la lista di eventi del programma");
                Console.WriteLine("3- Cerca gli eventi in una data");
                Console.WriteLine("4- Elimina tutti gli eventi");

                int scelta = Convert.ToInt32(Console.ReadLine());
                switch (scelta)
                {
                    case 1:
                        Console.WriteLine(programmaEventi.ContaEventi());
                        break;
                    case 2:
                        Console.WriteLine(programmaEventi.ToString());
                        break;
                    case 3:
                        Console.WriteLine("Inserisci la data da cercare dd/mm/yyyy");
                        DateTime dataDaCercare = Convert.ToDateTime(Console.ReadLine());
                        programmaEventi.eventoPerData(dataDaCercare);
                        break;
                    case 4:
                        programmaEventi.SvuotaEventi();
                        break;
                }
                break;

            case 2:
                Console.WriteLine("Crea un evento");
                Console.WriteLine("Inserisci il titolo dell'evento:");
                string nomeEvento = Console.ReadLine();
                Console.WriteLine("Inserisci la data dell'evento (dd/mm/yyyy)");
                DateTime data = Convert.ToDateTime(Console.ReadLine());
                Console.WriteLine("Inserisci la capienza massima dell'evento");
                int capienzaMassimaEvento = Convert.ToInt32(Console.ReadLine());

                Evento evento = new Evento(nomeEvento, data, capienzaMassimaEvento);
                Console.WriteLine(evento.ToString());

                Console.WriteLine("Hai bisogno di prenotare? Scegli si o no!");
                string risposta = Console.ReadLine();
                switch (risposta)
                {
                    case "si":
                        Console.WriteLine("Posti da prenotare?");
                        int postiUtente = Convert.ToInt32(Console.ReadLine());
                        evento.PrenotaPosti(postiUtente);

                        break;
                    case "no":
                        Console.WriteLine("no");
                        break;

                }
                bool continua = true;
                while (continua)
                {
                    Console.WriteLine("Vuoi disdire posti? Scegli si o no!");
                    risposta = Console.ReadLine();
                    switch (risposta)
                    {
                        case "si":
                            Console.WriteLine("Posti da disdire?");
                            int postiUtente = Convert.ToInt32(Console.ReadLine());
                            evento.DisdiciPosti(postiUtente);
                            break;
                        case "no":
                            continua = false;
                            break;

                    }
                }
                break;
        }
    }
}
