using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestoreEventi
{
    public class Evento
    {
        //ATTRIBUTI
        private string titolo;
        private DateTime data;
        private int capienzaMassimaEvento;
        private int numeroPostiPrenotati;
        private int numeroPostiLiberi;

        //GETTERS
        public string GetTitolo()
        {
            return this.titolo;
        }

        public DateTime GetData()
        {
            return this.data;
        }

        public int GetCapienzaMassimaEvento() 
        {
            return this.capienzaMassimaEvento;
        }

        public int GetNumeroPostiPrenotati()
        {
            return this.numeroPostiPrenotati;
        }

        public int GetNumeroPostiLiberi()
        {
            return this.numeroPostiLiberi;
        }


        //SETTERS
        public void SetTitolo(string newTitolo)
        {
            if (value == "")
            {
                throw new Exception("Titolo vuoto");
            }

            this.titolo = newTitolo;
        }

        public void SetData(DateTime newData)
        {
            if (data < DateTime.Today)
            {
                throw new Exception("La data è già passata");
            }

            this.data = newData;
        }

        public void SetCapienzaMassimaEvento(int newCapienzaMassimaEvento)
        {
            if (capienzaMassimaEvento <= 0)
            {
                throw new Exception("La capienza dei posti non può essere negativa o zero");
            }
            this.capienzaMassimaEvento = newCapienzaMassimaEvento;
        }

        public void SetNumeroPostiPrenotati(int newNumeroPostiPrenotati)
        {
            this.numeroPostiPrenotati = newNumeroPostiPrenotati;
        }

        public void SetNumeroPostiLiberi(int newNumeroPostiLiberi)
        {
            if (capienzaMassimaEvento - numeroPostiPrenotati > 0)
            {
                numeroPostiLiberi = capienzaMassimaEvento - numeroPostiPrenotati;
            }
            else
            {
                Console.WriteLine("Nessun posto libero");
            }
        }



        //COSTRUTTORE
        public Evento(string titolo, DateTime data, int capienzaMassimaEvento)
        {
            Titolo = titolo;
            data
        }
    }
}
