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
            string targa;
            if (cmbVeicoli.SelectedItem != "")
            {

                string selezionato = cmbVeicoli.SelectedItem.ToString();
                DateTime inizio = DateTime.Now;
                string[] s = selezionato.Split(";");
                targa = s[0];
                int numlav = contalav(targa) + 1;

                int dimLavorazioni = dimFile("lavorazioni");
                string[] lav = new string[dimLavorazioni];
                caricadafile("lavorazioni", lav);

                string nomefile = @"files\lavorazioni.txt";
                StreamWriter file_out;
                file_out = new StreamWriter(nomefile);
                int cont = 0;

                for (int i = 0; i < dimLavorazioni; i++)
                {
                    file_out.WriteLine(lav[i]);
                }

                
                file_out.WriteLine("" + targa + ";" + numlav + ";" + lblNascosta.Text + ";" + inizio + ";;");

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


        //conta lavorazioni relative ad una certa targa
        public int contalav(string targa)
        {
            int n = 0;
            int dimLavorazioni = dimFile("lavorazioni");
            string[] lav = new string[dimLavorazioni];
            caricadafile("lavorazioni", lav);
            for (int i = 0; i < dimLavorazioni; i++)
            {
                string[] s = lav[i].Split(";");
                if (s[0].Equals(targa))
                {
                    n += 1;
                }
            }
            return n;
        }


        //aggiorna combobox
        public void aggiornacmb()
        {
            cmbAvviati.Items.Clear();
            int dimLavorazioni = dimFile("lavorazioni");
            string[] lav = new string[dimLavorazioni];
            caricadafile("lavorazioni", lav);
            for (int i = 0; i < dimLavorazioni; i++)
            {

                string[] s = lav[i].Split(";");
                if (s[2].Equals(lblNascosta.Text) && s[4].Equals(""))
                {
                    cmbAvviati.Items.Add(s[0] + ", inizio: " + s[3] + " - " + s[1]);
                }
            }

        }

        //riepilogo tempi alla fine di ogni operazione
        public void riepilogotempi()
        {
            int dimLavorazioni = dimFile("lavorazioni");
            string[] lav = new string[dimLavorazioni];
            caricadafile("lavorazioni", lav);

            int dimVeicoli = dimFile("veicoli");
            string[] veic = new string[dimVeicoli];
            caricadafile("veicoli", veic);

            for(int i = 0; i < dimVeicoli; i++)
            {
                string[] v = veic[i].Split(";");
                for (int j = 0; j < dimLavorazioni; j++) {
                    string[] l = lav[j].Split(";");
                    if (v[0].Equals(l[0]))
                    {
                        /*
                        int diff=0;
                        DateTime i = new DateTime(l[3]);
                        DateTime f = new DateTime(l[4]);

                        diff = f - i;
                        //da approssimare con solo i minuti
                        v[4] += diff;
                        */
                    }
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
                string[] n = s[1].Split(" - ");
                string nlav = n[1];

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
                    if (elem[0].Equals(targa) && elem[1]==nlav && elem[2].Equals("Diego"))
                    {
                        file_out.WriteLine("" + elem[0] + ";" + elem[1] +";"+ elem[2]+ ";" + elem[3] + ";" + fine + ";");;
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


        private void Form1_Load(object sender, EventArgs e)
        {
            aggiornacmb();
        }
    }
}