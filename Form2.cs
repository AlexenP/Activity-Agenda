using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AgendaActivitati
{
    public partial class Form2 : Form
    {
        List<Activitate> lista2;

        public Form2(List<Activitate> lista)
        {
            InitializeComponent();
            lista2 = lista;
            foreach (Activitate a in lista)
                textBox1.Text += a.ToString() + Environment.NewLine;
        }

        private void salvareFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dlg = new SaveFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter sw = new StreamWriter(dlg.FileName);
                sw.WriteLine(textBox1.Text);
                sw.Close();
                textBox1.Clear();
            }
        }

        private void citireFisierTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "(*.txt)|*.txt";
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(dlg.FileName);
                textBox1.Text = sr.ReadToEnd();
                sr.Close();
            }
        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.Create,
                FileAccess.Write);
            //bf.Serialize(fs, textBox1.Text);
            bf.Serialize(fs, lista2);
            fs.Close();
            textBox1.Clear();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BinaryFormatter bf = new BinaryFormatter();
            FileStream fs = new FileStream("fisier.dat", FileMode.Open,
                FileAccess.Read);
            //textBox1.Text = (string)bf.Deserialize(fs);
            List<Activitate> lista3 = (List<Activitate>)bf.Deserialize(fs);
            foreach (Activitate s in lista3)
                textBox1.Text += s.ToString() + Environment.NewLine;
            fs.Close();
        }
    }

}
