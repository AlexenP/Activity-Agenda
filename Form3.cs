using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaActivitati
{
    public partial class Form3 : Form
    {
        List<Activitate> lista2;
        List<Activitate> listaSelectata;
        List<Domeniu> domenii;
        public Form3(List<Activitate> lista)
        {
            InitializeComponent();
            this.KeyPreview = true; // enable form to handle KeyDown event
            lista2 = CloneActivitateList(lista);
            
        }

        public List<Activitate> CloneActivitateList(List<Activitate> originalList)
        {
            List<Activitate> clonedList = new List<Activitate>();
            foreach (Activitate activitate in originalList)
            {
                clonedList.Add(new Activitate(activitate.IdActivitate, activitate.Nume, activitate.DataIncepere, activitate.DataSfarsit,
                    activitate.Descriere, activitate.Locatie, activitate.Prioritate));
            }
            return clonedList;
        }

        private void btnVizualizeazaActivit_Click(object sender, EventArgs e)
        {
            /*
            StreamReader sr = new StreamReader("listaActivitati.txt");
            string s = sr.ReadToEnd();
            textBox1.Text = s;
            sr.Close();
            */
            label1.Text="";
            foreach (Activitate a in lista2)
                label1.Text += a.ToString() + Environment.NewLine;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }




        private void btnAdaugaDomeniu_Click(object sender, EventArgs e)
        {
            if (tbNume.Text == "")
                errorProvider1.SetError(tbNume, "Introduceti nume domeniu!");
            else
                if (tbIduriActivitati.Text == "")
                errorProvider1.SetError(tbIduriActivitati, "Introduceti id-uri activitati");
            else
                if (tbId.Text == "")
                errorProvider1.SetError(tbIduriActivitati, "Introduceti id-ul domeniului");
            else
            {
                errorProvider1.Clear();
                try
                {
                    int id = Convert.ToInt32(tbId.Text);
                    string nume = tbNume.Text;
                    string[] listaIds = tbIduriActivitati.Text.Trim().Split(',');
                    int[] listaId= new int[listaIds.Length];
                    for (int i = 0; i < listaIds.Length; i++)
                        listaId[i] = Convert.ToInt32(listaIds[i]);
                    
                    
                    for(int i = 0;i<listaId.Length;i++)
                    {
                        for(int j = 0;j<lista2.Count;j++)
                        {
                            if (listaId[i] == lista2[j].IdActivitate)
                            {
                                listaSelectata.Add(lista2[j]);
                            }
                        }
                    }

                    if (listaSelectata.Count > 0)
                        Domeniu d = new Domeniu(id,nume, listaSelectata);
                    
                    //MessageBox.Show(s.ToString());
                    domenii.Add(d);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbId.Clear();
                    tbNume.Text = "";
                    tbIduriActivitati.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 form = new Form4(domenii);
            form.Show();
        }
    }
}
