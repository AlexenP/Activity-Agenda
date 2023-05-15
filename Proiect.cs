using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgendaActivitati
{
    public class Proiect
    {
        private int id;
        private string nume;
        private string descriere;
        private string numeDezvoltatorPrincipal;
        private List<Domeniu> domenii;

        public string Nume { get => nume; set => nume = value; }
        public List<Domeniu> Domenii { get => domenii; set => domenii = value; }
        public string Descriere { get => descriere; set => descriere = value; }
        public string NumeDezvoltatorPrincipal { get => numeDezvoltatorPrincipal; set => numeDezvoltatorPrincipal = value; }

        public Proiect(string nume)
        {
            nume = nume;
            domenii = new List<Domeniu>();
        }
        Proiect(int id, string nume, string descriere, string numeDezvoltatorPrincipal, List<Domeniu> domenii)
        {
            this.id = id;
            this.nume = nume;
            this.descriere = descriere;
            this.numeDezvoltatorPrincipal = numeDezvoltatorPrincipal;
            this.domenii = domenii;
        }

        public void AdaugaDomeniu(Domeniu domeniu)
        {
            domenii.Add(domeniu);
        }

        public override string ToString()
        {
            string s="Nume proiect: "+nume+" - desciere"+descriere+" - nume dezvoltator principal: "+numeDezvoltatorPrincipal+
                "\nLista domenii:\n";
            for(int i = 0; i < domenii.Count; i++)
            {
                s += domenii[i].ToString();
                s += ", ";
            }
            return s;
        }
    }
}
