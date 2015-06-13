using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workout_tracker
{
    public partial class WorkoutTracker : Form
    {
        //Bool voor het geselecteerde account
        //Hiermee worden de opgeslagen gegevens bijgeschreven bij de juiste tabel
        bool steve = false;
        bool anllela = false;

        //Connectie database en aanroepen klasse database en enum
        static string bestand = "C:\\Users\\Michael\\Documents\\School\\Maatwerk\\Semester 1\\Software\\Projects\\Workout tracker\\Workout tracker\\bin\\Debug\\DBWorkoutTracker.accdb";
        Database database = new Database(bestand);
        Materiaal materiaal = new Materiaal();

        //Array (ongebruikt)
        public string[] array = new string[50];

        public int gevuldTotEnMet = -1;

        public WorkoutTracker()
        {
            InitializeComponent();

            string pad = Application.StartupPath;
        }

        //Array methode voor tonen inhoud
        public void ToonArrayInhoud()
        {                  
            lbArray.Items.Clear();

            for (int i = 0; i <= gevuldTotEnMet; i++)
            {
                lbArray.Items.Add(array[i]);
            }           
        }

        public void verwijderUitArray()
        {
            string verwijderWoord = txtArray.Text;

            int controleerPositie = 0;

            while (controleerPositie < 50)
            {
                if (array[controleerPositie] == verwijderWoord)
                {
                    for (int j = controleerPositie; j < gevuldTotEnMet; j++)
                    {
                        array[j] = array[j + 1];
                    }

                    array[gevuldTotEnMet] = "";

                    gevuldTotEnMet --;
                }
                else
                {
                    controleerPositie ++;
                }
            }
        }

        //Methode voor aantonen geselecteerde account in de tweede tab
        public void nameAthlete()
        {
            if (steve)
            {
                lblNameAthlete.Text = "Steve";
            }

            if (anllela)
            {
                lblNameAthlete.Text = "Anllela";
            }
        }


        //Inlog van het account Steve
        private void pbLoginSteve_Click(object sender, EventArgs e)
        {
            steve = true;
            anllela = false;

            nameAthlete();

            tabTracker.SelectedIndex = 1;
        }

        //Inlog van het account Anllela
        private void pbLoginAnllela_Click(object sender, EventArgs e)
        {
            anllela = true;
            steve = false;

            nameAthlete();

            tabTracker.SelectedIndex = 1;
        }

        //Via deze knop worden de ingevoerde gegevens van oefening, sets, herhalingen, gewicht en eventuele commentaat uit het form toegevoegt aan de database
        //Eveneens wordt meegegeven welke persoon er ingelogd is, zodat het in de juiste tabel komt
        private void btnSave_Click(object sender, EventArgs e)
        {
            string persoon;

            if (steve)
            {
                persoon = "Steve";
            }
            else
            {
                persoon = "Anllela";
            }

            database.VoegToe(cbOefening.Items[cbOefening.SelectedIndex].ToString(), Convert.ToInt32(nudSets.Value), Convert.ToInt32(nudReps.Value), Convert.ToInt32(nudGewicht.Value), txtBoxCommentaar.Text, persoon);
        }

        //Button voor toevoegen aan array
        private void btnArray_Click(object sender, EventArgs e)
        {
            string woord = txtArray.Text;

            array[gevuldTotEnMet + 1] = woord;

            gevuldTotEnMet++;

            ToonArrayInhoud();

            //Methode van string fucntie
            stringFunctie();
        }

        //Button voor verwijderen woord uit array
        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            verwijderUitArray();

            ToonArrayInhoud();
        }

        //Ophalen van gegevens uit de database en vergelijken met eerdere resultaten
        private void btnCompare_Click(object sender, EventArgs e)
        {
            string persoon;

            if (steve)
            {
                persoon = "Steve";
            }
            else
            {
                persoon = "Anllela";
            }

            List<Resultaten> resultaatLijst = database.GetResultaten(persoon);            

            dgvResults.DataSource = resultaatLijst;
            
            tabTracker.SelectedIndex = 2;
        }

        //reseten van tweede tab bij openen
        private void tabTracker_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cbMateriaal.Enabled = false;
            cbOefening.Enabled = false;
            btnSave.Enabled = false;

            cbSpier.Items.Clear();

            foreach (var item in database.GetSpiergroep())
            {
                cbSpier.Items.Add(item);
            }        
        }

        //Graphics voor de twee rode lijnen in het inlog scherm
        private void tabPage1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            Pen pen = new Pen(Color.DarkRed, 5);

            graphics.DrawLine(pen, 350, 350, 350, 35);
            graphics.DrawLine(pen, 20, 350, 700, 350);
        }

        //Afbeeldingen van de oefening laten zien aan de hand van de gekozen oefening
        public void changeImage()
        {
            string imagePath = Application.StartupPath + @"\WT afbeeldingen\" + cbOefening.SelectedItem.ToString() + ".jpg";
            pbLogoWT.Image = Image.FromFile(imagePath);
        }

        //Als spiergroep gekozen is combobox van materiaal enabled en waardes inladen
        private void cbSpier_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMateriaal.Enabled = true;

            cbMateriaal.Items.Clear();

            foreach (var item in database.GetMateriaal(cbSpier.Items[cbSpier.SelectedIndex].ToString()))
            {
                cbMateriaal.Items.Add(item);
            }
        }

        //Als materiaal gekozen is combobox van oefening enabled en waardes inladen
        private void cbMateriaal_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbOefening.Enabled = true;

            cbOefening.Items.Clear();

            foreach (var item in database.GetOefening(cbMateriaal.Items[cbMateriaal.SelectedIndex].ToString(), cbSpier.Items[cbSpier.SelectedIndex].ToString()))
            {
                cbOefening.Items.Add(item);
            }
        }

        //Als oefening gekozen is save button enabled en afbeelding bijgewerkt
        private void cbOefening_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = true;

            lblNaamOefening.Text = cbOefening.SelectedItem.ToString();
            changeImage(); 
        }

        //String functie stukje
        //Had er geen doel voor dus dit wordt niet gebruikt
        public void stringFunctie()
        {
            const string s = "Dit is een zin";
            
            int i = s.IndexOf('z');

            string d = s.Substring(i);

            lblString.Text = d;
        }
    }
}
