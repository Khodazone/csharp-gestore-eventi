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
            if (titolo == "")
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
        public Evento(string titolo, DateTime data, int capienzaMassimaEvento, int numeroPostiPrenotati, int numeroPostiLiberi)
        {
            this.titolo = titolo;
            this.data = data;
            this.capienzaMassimaEvento = capienzaMassimaEvento;
            this.numeroPostiPrenotati = 0;
            this.numeroPostiLiberi = capienzaMassimaEvento;
        }


        //METODI
        public void PrenotaPosti(int postiDaAggiungere)
        {
            if ((capienzaMassimaEvento == 0) || (data < DateTime.Today) || ((capienzaMassimaEvento - postiDaAggiungere) <= 0))
            {
                Console.WriteLine("Non si può prenotare");
            }
            else
            {
                numeroPostiPrenotati += postiDaAggiungere;
                numeroPostiLiberi = capienzaMassimaEvento - numeroPostiPrenotati;
                if (numeroPostiPrenotati > 0)
                {
                    if (postiDaAggiungere == 1)
                    {
                        Console.WriteLine("Hai prenotato " + postiDaAggiungere + "posto.");
                        StampaPosti();
                    }
                    else
                    {
                        Console.WriteLine("Hai prenotato " + postiDaAggiungere + "posti.");
                        StampaPosti();
                    }

                }

            }
        }
        public void DisdiciPosti(int postiDaDisdire)
        {
            if ((data < DateTime.Today) || ((numeroPostiPrenotati - postiDaDisdire) < 0))
            {
                Console.WriteLine("Non si può disdire i posti");
            }
            else
            {
                numeroPostiPrenotati -= postiDaDisdire;

                numeroPostiLiberi += postiDaDisdire;

                if (postiDaDisdire == 1)
                {
                    Console.WriteLine("Hai disdetto " + postiDaDisdire + "posto.");
                    StampaPosti();
                }
                else
                {
                    Console.WriteLine("Hai disdetto " + postiDaDisdire + "posti.");
                    StampaPosti();
                }
            }


        }
        public override string ToString()
        {
            return "Titolo evento: " + titolo + " Data: " + data.ToString();
        }

        public void StampaPosti()
        {
            Console.WriteLine("Posti Liberi: " + numeroPostiLiberi + "posti. Posti prenotati: " + numeroPostiPrenotati + "posti");
        }
    }
}