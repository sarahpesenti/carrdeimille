using System.Linq.Expressions;
using System.Runtime;

namespace CarrDeiMille
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //SBAGLIATO DA ELIMINARE ANCHE DA DESIGNeeeeeeeeeeER
        }

        private void DIEGO_Click(object sender, EventArgs e)
        {
            pnlDiego.Show();
            btnInizio.Enabled = false;
            btnFine.Enabled = false;
        }

        private void btnInizio_Click(object sender, EventArgs e)
        {
            if (cmbVeicoli.SelectedItem != "")
            {

                string selezionato = cmbVeicoli.SelectedItem.ToString();
                DateTime inizio = DateTime.Now;

                string[] s = selezionato.Split(";");
                string targa = s[0];

                int dimLavorazioni = dimFile("lavorazioni");
                string[] lav = new string[dimLavorazioni];
                caricadafile("lavorazioni", lav);

                string nomefile = @"files\lavorazioni.txt";
                StreamWriter file_out;
                file_out = new StreamWriter(nomefile);
                int cont = 0;
                for (int i = 0; i < dimLavorazioni; i++)
                {
                    string[] elem = lav[i].Split(";");
                    if (elem[0].Equals(targa))
                    {
                        //INserire finestra di dialogo "Vuoi terminare la lavorazione sul veicolo" +  targa + "iniziata alle" + inizio...?"
                        file_out.WriteLine("" + elem[0] + ";DIEGO;" + inizio + ";;");
                        cont += 1;

                    }
                    else
                    {
                        file_out.WriteLine(lav[i]);
                    }

                }

                if (cont == 0)
                {
                    file_out.WriteLine("" + targa + ";" + inizio + ";;");
                }


                file_out.Close();


                cmbVeicoli.Text = "";
                btnInizio.Enabled = false;
                btnFine.Enabled = false;
            }
            else
            {
                MessageBox.Show("SELEZIONA UN VEICOLO!");
            }


            aggiornacmb();

        }


        public void aggiornacmb()
        {
            cmbAvviati.Items.Clear();
            int dimLavorazioni = dimFile("lavorazioni");
            string[] lav = new string[dimLavorazioni];
            caricadafile("lavorazioni", lav);
            for (int i = 0; i < dimLavorazioni; i++)
            {

                string[] s = lav[i].Split(";");
                if (s[1].Equals("DIEGO") && s[3].Equals(""))
                {
                    cmbAvviati.Items.Add(s[0] + ", inizio: " + s[2]);
                }
            }

        }
        private void btnFine_Click(object sender, EventArgs e)
        {
            if (cmbAvviati.SelectedItem != "")
            {

                string selezionato = cmbAvviati.SelectedItem.ToString();
                DateTime fine = DateTime.Now;

                string[] s = selezionato.Split(",");
                string targa = s[0];

                int dimLavorazioni = dimFile("lavorazioni");
                string[] lav = new string[dimLavorazioni];
                caricadafile("lavorazioni", lav);

                string nomefile = @"files\lavorazioni.txt";
                StreamWriter file_out;
                file_out = new StreamWriter(nomefile);
                int cont = 0;
                for (int i = 0; i < dimLavorazioni; i++)
                {
                    string[] elem = lav[i].Split(";");
                    if (elem[0].Equals(targa))
                    {
                        file_out.WriteLine("" + elem[0] + ";DIEGO;" + elem[2] + ";" + fine + ";");
                        cont += 1;
                    }
                    else
                    {
                        file_out.WriteLine(lav[i]);
                    }

                }
                if (cont == 0)
                {
                    MessageBox.Show("NON E' MAI STATA AVVIATA LA LAVORAZIONE PER QUESTO VEICOLO");
                    //possibilità aggiunta manuale delle ore approssimative di lavoro
                }

                //messaggio durata e conferme varie
                cmbVeicoli.Text = "";
                btnInizio.Enabled = false;
                btnFine.Enabled = false;


                file_out.Close();
            }
            else
            {
                MessageBox.Show("SELEZIONA UN VEICOLO!");
            }

            aggiornacmb();
            cmbAvviati.Text = "";
        }






        static int dimFile(string nome)
        {
            int dim = 0;
            string nomefile = @"files\" + nome + ".txt";
            string riga;
            int k = 0, n;
            bool fine = false;
            StreamReader file_in;
            try
            {
                file_in = new StreamReader(nomefile);
                while (!file_in.EndOfStream && !fine)
                {
                    riga = file_in.ReadLine();
                    dim++;
                }
                file_in.Close();

                return dim;
            }
            catch (Exception ex)
            {
                MessageBox.Show("errore " + ex.Message);
                return 0;
            }
        }

        static void caricadafile(string nome, string[] v)
        {
            string nomefile = @"files\" + nome + ".txt";
            string riga;
            int k = 0, n;
            bool fine = false;
            StreamReader file_in;
            try
            {
                file_in = new StreamReader(nomefile);
                // MessageBox.Show("File aperto");
                while (!file_in.EndOfStream && !fine)
                {
                    riga = file_in.ReadLine();
                    v[k] = riga;
                    k++;

                }
                file_in.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("errore " + ex.Message);
            }
        }

        private void cmbVeicoli_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbVeicoli.SelectedItem != "")
            {
                //controllare sia una di quelle iniziate da Diego!
                btnInizio.Enabled = true;
            }
        }

        private void cmbAvviati_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnInizio.Enabled = false;
            btnFine.Enabled = true;
        }

        private void pnlDiego_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            aggiornacmb();
        }
    }
}