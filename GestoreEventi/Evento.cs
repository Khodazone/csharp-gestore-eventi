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


        //SETTERS
        public void SetTitolo(string newTitolo)
        {
            if (titolo == "")
            {
                throw new Exception("Titolo vuoto");
            }

            this.titolo = newTitolo;
        }

        public void SetData(DateTime data)
        {
            if (data < DateTime.Today)
            {
                throw new Exception("La data è già passata");
            }

            this.data = data;
        }

        public void SetCapienzaMassimaEvento(int capienzaMassimaEvento)
        {
            if (capienzaMassimaEvento <= 0)
            {
                throw new Exception("La capienza dei posti non può essere negativa o zero");
            }
            this.capienzaMassimaEvento = capienzaMassimaEvento;
        }


        //COSTRUTTORE
        public Evento(string titolo, DateTime data, int capienzaMassimaEvento)
        {

        }
    }
}
