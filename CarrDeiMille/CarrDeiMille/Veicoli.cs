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
    public partial class Veicoli : Form
    {
        public Veicoli()
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
        public void aggiornaDGV()
        {
            int dimVeicoli = dimFile("veicoli");
            string[] veic = new string[dimVeicoli];
            caricadafile("veicoli", veic);

            for (int r = 0; r < dimVeicoli; r++)
            {
                dgv.Rows.Add();
                string[] v = veic[r].Split(";");

                for (int c = 0; c < v.Length - 1; c++)
                {
                    int ore = 0;
                    int min = 0;
                    if (c == 4)
                    {
                        if (Convert.ToInt32(v[c]) > 60)
                        {
                            ore = Convert.ToInt32(v[c]) / 60;
                            min = Convert.ToInt32(v[c]) - ore * 60;
                        }
                        if (ore == 1)
                        {
                            dgv.Rows[r].Cells[c].Value = ore + " ora e " + min + " minuti";
                        }
                        else
                        {
                            dgv.Rows[r].Cells[c].Value = ore + " ore e " + min + " minuti";
                        }
                    }
                    else
                    {
                        dgv.Rows[r].Cells[c].Value = v[c];
                    }

                }
            }
        }

        private void Veicoli_Load(object sender, EventArgs e)
        {
            aggiornaDGV();
        }
    }
}
