using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class ProgrammaEventi
    {
        //ATTRIBUTI
        private string titolo;
        List<Evento> eventi;
        List<Evento> eventiCercatiPerData;

        public string Titolo { get; set; }
        public List<Evento> Eventi { get; set; }

        //COSTRUTTORE
        public ProgrammaEventi(string titolo)
        {
            Titolo = titolo;
            Eventi = new List<Evento>();
        }

        public void aggiungiEvento(Evento evento)
        {
            Eventi.Add(evento);
            Console.WriteLine("Evento aggiunto alla lista");
        }
        public void eventoPerData(DateTime ricercaDellaData)
        {
            foreach (Evento evento in Eventi)
            {
                if (ricercaDellaData == evento.data)
                {
                    Console.WriteLine(evento.ToString());
                }
            }

        }
        public static string EventiInStringa(List<Evento> eventi)
        {
            string eventoStringa = "";
            foreach (Evento evento in eventi)
            {
                eventoStringa += $"Evento: {evento.GetTitolo}. Data: {evento.GetData}. Capienza Massima: {evento.GetCapienzaMassimaEvento} posti. Posti Prenotati: {evento.GetNumeroPostiPrenotati} posti. Posti liberi: {evento.GetNumeroPostiLiberi} posti \n";
            }
            return eventoStringa;
        }
        public int ContaEventi()
        {
            return Eventi.Count;
        }
        public void SvuotaEventi()
        {
            Console.WriteLine("Lista eventi svuotata");
            Eventi.Clear();
        }
        public override string ToString()
        {
            string programmaInStringa = "";
            foreach (Evento evento in Eventi)
            {
                programmaInStringa += $"Titolo: {evento.GetTitolo}. Data: {evento.GetData} \n";
            }
            return programmaInStringa;
        }

    }
}