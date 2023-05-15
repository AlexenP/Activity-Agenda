using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaActivitati
{
    public class Activitate
    {
        
        private int idActivitate;
        private string nume;
        private DateTime dataIncepere;
        private DateTime dataSfarsit;
        private string descriere;
        private string locatie;
        private int prioritate;

        public string Nume { get => nume; set => nume = value; }
        public DateTime DataIncepere { get => dataIncepere; set => dataIncepere = value; }
        public DateTime DataSfarsit { get => dataSfarsit; set => dataSfarsit = value; }
        public string Descriere { get => descriere; set => descriere = value; }
        public string Locatie { get => locatie; set => locatie = value; }
        public int Prioritate { get => prioritate; set => prioritate = value; }
        public int IdActivitate { get => idActivitate; set => idActivitate = value; }

        public Activitate(int idActiv,string nume, DateTime dataIncepere, DateTime dataSfarsit, string descriere, string locatie, int prioritate)
        {
            this.idActivitate = idActiv;
            this.nume = nume;
            this.dataIncepere = dataIncepere;
            this.dataSfarsit = dataSfarsit;
            this.descriere = descriere;
            this.locatie = locatie;
            this.prioritate = prioritate;
        }

        public override string ToString()
        {
            return "Id activ: "+idActivitate+"Nume " + nume + " - Data incepere: " + dataIncepere 
                +" - Data sfarsit: " + dataSfarsit + " - Descriere: " 
                + descriere + " - locatie: " + locatie + " - prioritate: " + prioritate;
        }

        public Activitate GetActivitateById(List<Activitate> listaActivitati, int idActivitate)
        {
            foreach (Activitate activitate in listaActivitati)
            {
                if (activitate.idActivitate == idActivitate)
                {
                    return activitate;
                }
            }
            return null;
        }
        



    }
}
