using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaActivitati
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormActivitati());
        }
    }
    /*
    internal class Program
    {


        static void Main(string[] args)
        {
            /*
            
            // Exemplu de utilizare a claselor
            var proiect = new Proiect("Agenda mea");

            var domeniu1 = new Domeniu("Programare");
            domeniu1.AdaugaActivitate(new Activitate("Scrie cod pentru proiect",
                new DateTime(2023, 3, 28), new DateTime(2023, 4, 4)));

            var domeniu2 = new Domeniu("Design");
            domeniu2.AdaugaActivitate(new Activitate("Creeaza layout pentru pagina principala",
                new DateTime(2023, 3, 29), new DateTime(2023, 4, 1)));
            domeniu2.AdaugaActivitate(new Activitate("Selecteaza culorile pentru tema proiectului",
                new DateTime(2023, 4, 1), new DateTime(2023, 4, 3)));

            proiect.AdaugaDomeniu(domeniu1);
            proiect.AdaugaDomeniu(domeniu2);

            // Afisare activitati pentru fiecare domeniu din proiect
            foreach (var domeniu in proiect.Domenii)
            {
                Console.WriteLine($"Activitati pentru domeniul {domeniu.Nume}:");
                foreach (var activitate in domeniu.Activitati)
                {
                    Console.WriteLine($"{activitate.Nume}" +
                        $" - De la {activitate.DataIncepere.ToShortDateString()}" +
                        $" pana la {activitate.DataSfarsit.ToShortDateString()}");
                }
                Console.WriteLine();
            
        

        
        }
*/

}
