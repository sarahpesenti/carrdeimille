using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarrDeiMille
{
    public partial class Nuovo : Form
    {
        public Nuovo()
        {
            InitializeComponent();
        }
        //METODI VARI
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

        private void btnAggiungi_Click(object sender, EventArgs e)
        {

            string targa = txtTarga.Text;
            string marca = txtMarca.Text;
            string modello = txtModello.Text;
            string colore = txtColore.Text;
            int dimVeicoli = dimFile("veicoli");
            string[] veic = new string[dimVeicoli];
            caricadafile("veicoli", veic);
            string nuovo = "" + targa.ToUpper() + ";" + marca + ";" + modello + ";" + colore + ";0;";
            StreamWriter file_out;
            file_out = new StreamWriter("files/veicoli.txt");
            for (int r = 0; r < dimVeicoli; r++)
            {
                file_out.WriteLine(veic[r]);
            }
            file_out.WriteLine(nuovo);
            file_out.Close();
            MessageBox.Show("Veicolo aggiunto!");
        }
    }
}
