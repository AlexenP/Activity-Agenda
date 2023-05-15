using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaActivitati
{
    public class Domeniu
    {
        private int idDomeniu;
        private string nume;
        private List<Activitate> activitati;

        public string Nume { get => nume; set => nume = value; }
        public List<Activitate> Activitati { get => activitati; set => activitati = value; }
        public int IdDomeniu { get => idDomeniu; set => idDomeniu = value; }

        public Domeniu(string nume)
        {
            this.nume = nume;
            this.activitati = new List<Activitate>();
        }

        public Domeniu(int id,string nume, List<Activitate> activitati)
        {
            this.idDomeniu = id;
            this.activitati = activitati;
            this.nume = nume;
        }

        public void AdaugaActivitate(Activitate activitate)
        {
            activitati.Add(activitate);
        }

        public override string ToString()
        {
            string s= "Id: "+idDomeniu+" - Nume domeniu: " + nume + "\nActivitati:\n ";
            for (int i = 0; i < activitati.Count; i++)
            {
                s+= Activitati[i].ToString();
                s+= ", ";
            }
            return s;
        }
    }
}
