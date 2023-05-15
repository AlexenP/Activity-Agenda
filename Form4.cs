using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaActivitati
{
    public partial class Form4 : Form
    {
        List<Domeniu> lista2;
        List<Domeniu> listaSelectata;
        List<Proiect> proiecte;

        public Form4(List<Domeniu> lista)
        {
            InitializeComponent();
            this.KeyPreview = true; // enable form to handle KeyDown event
            lista2 = CloneDomeniuList(lista);

        }
        public List<Domeniu> CloneDomeniuList(List<Domeniu> originalList)
        {
            List<Domeniu> clonedList = new List<Domeniu>();
            foreach (Domeniu domeniu in originalList)
            {
                clonedList.Add(new Domeniu(domeniu.IdDomeniu,domeniu.Nume,domeniu.Activitati));
            }
            return clonedList;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdaugaProiect_Click(object sender, EventArgs e)
        {
            if (tbId.Text == "")
                errorProvider1.SetError(tbNume, "Introduceti id-ul proiectului!");
            else
               if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introduceti nume proiect!");
            else
               if (tbDescriere.Text == "")
                errorProvider1.SetError(tbDescriere, "Introduceti descriere!");
            else
               if (tbNumeDezvoltator.Text == "")
                errorProvider1.SetError(tbNumeDezvoltator, "Introduceti nume dezvoltator!");
            else
               if (tbIduriDomenii.Text == "")
                errorProvider1.SetError(tbIduriDomenii, "Introduceti id-uri domenii!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    int idProiect = Convert.ToInt32(tbId.Text);
                    string numeProiect = tbNume.Text;
                    string descriere = tbDescriere.Text;
                    string numeDezvoltator = tbNumeDezvoltator.Text;
                    string[] iduriDomeniis = tbIduriDomenii.Text.Trim().Split(',');
                    int[] listaId = new int[iduriDomeniis.Length];
                    for (int i = 0; i < iduriDomeniis.Length; i++)
                        listaId[i] = Convert.ToInt32(iduriDomeniis[i]);

                    for (int i = 0; i < listaId.Length; i++)
                    {
                        for (int j = 0; j < lista2.Count; j++)
                        {
                            if (listaId[i] == lista2[j].IdDomeniu)
                            {
                                listaSelectata.Add(lista2[j]);
                            }
                        }
                    }

                    if(listaSelectata.Count > 0)
                        Proiect p = new Proiect(idProiect, numeProiect, descriere, numeDezvoltator, listaSelectata);
                    proiecte.Add(p);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbId.Clear();
                    tbNume.Clear();
                    tbDescriere.Clear();
                    tbNumeDezvoltator.Clear();
                    tbIduriDomenii.Clear();
                }
            }
        }
    }
}
