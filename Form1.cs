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
    public partial class FormActivitati : Form
    {
        List<Activitate> listaActivitati = new List<Activitate>();

        public List<Activitate> ListaActivitati { get => listaActivitati; set => listaActivitati = value; }

        public FormActivitati()
        {
            InitializeComponent();
            this.KeyPreview = true; // enable form to handle KeyDown event
        }

       

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnAdaugaActivitate_Click(object sender, EventArgs e)
        {
            if (tbIdActivitate.Text == "")
                errorProvider1.SetError(tbIdActivitate, "Introduceti id activitate!");
            else
                if (cbPrioritate.Text == "")
                errorProvider1.SetError(cbPrioritate, "Selectati prioritatea!");
            else
                if (tbNumeActivitate.Text == "")
                errorProvider1.SetError(tbNumeActivitate, "Introduceti nume activitate!");
            else
                if (tbDescriere.Text == "")
                errorProvider1.SetError(tbDescriere, "Introduceti descriere!");
            else
                if (tbLocatie.Text == "")
                errorProvider1.SetError(tbLocatie, "Introduceti locatia!");
            else
                if (tbDataInceput.Text == "")
                errorProvider1.SetError(tbDataInceput, "Introduceti data inceput!");
            else
                if (tbDataSfarsit.Text == "")
                errorProvider1.SetError(tbDataSfarsit, "Introduceti data sfarsit!");

            
            else
            {
                errorProvider1.Clear();
                try
                {
                    int idActivitate = Convert.ToInt32(tbIdActivitate.Text);
                    string numeActivitate = tbNumeActivitate.Text;
                    string descriere = tbDescriere.Text;
                    string locatie = tbLocatie.Text;
                    int prioritate = Convert.ToInt32(cbPrioritate.Text);
                    DateTime dataInceput = Convert.ToDateTime(tbDataInceput.Text);
                    DateTime dataSfarsit= Convert.ToDateTime(tbDataSfarsit.Text);
                    if (dataInceput > dataSfarsit)
                    {
                        errorProvider1.SetError(tbDataInceput, "Data inceput trebuie sa fie mai mica sau egala cu data sfarsit!");
                    }
                    else
                    {
                        Activitate a = new Activitate(idActivitate, numeActivitate, dataInceput, dataSfarsit, descriere, locatie, prioritate);
                        listaActivitati.Add(a);
                        MessageBox.Show("Activitate adaugata cu succes!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbIdActivitate.Clear();
                    cbPrioritate.Text = "";
                    tbNumeActivitate.Clear();
                    tbDescriere.Clear();
                    tbLocatie.Clear();
                    tbDataInceput.Clear();
                    tbDataSfarsit.Clear();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbIdActivitate.Clear();
            cbPrioritate.Text = "";
            tbNumeActivitate.Clear();
            tbDescriere.Clear();
            tbLocatie.Clear();
            tbDataInceput.Clear();
            tbDataSfarsit.Clear();
        }

        private void btnVizActivit_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2(listaActivitati);
            form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 form = new Form3(listaActivitati);
            form.Show();
        }

        private void btnAdaugaActivitate_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void FormActivitati_Load(object sender, EventArgs e)
        {

        }

        private void FormActivitati_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Control && e.KeyCode.ToString()=="A")
            {
                btnAdaugaActivitate_Click(sender, e);
            }
            if(e.Control && e.KeyCode.ToString()=="X")
            {
                btnClear_Click(sender, e);
            }
        }
    }
}
