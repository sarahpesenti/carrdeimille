namespace CarrDeiMille
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            menuStrip1 = new MenuStrip();
            DIEGO = new ToolStripMenuItem();
            FRANCO = new ToolStripMenuItem();
            MATTEO = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            RIEPILOGO = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            aGGIUNGIVEICOLOToolStripMenuItem = new ToolStripMenuItem();
            pnlDiego = new Panel();
            lblNascosta = new Label();
            cmbAvviati = new ComboBox();
            lblVeicoloSelezionato = new Label();
            btnFine = new Button();
            btnInizio = new Button();
            label2 = new Label();
            cmbVeicoli = new ComboBox();
            label1 = new Label();
            pnlRiepilogo = new Panel();
            pnlAggiungi = new Panel();
            button1 = new Button();
            textBox3 = new TextBox();
            label7 = new Label();
            textBox4 = new TextBox();
            label8 = new Label();
            textBox2 = new TextBox();
            label6 = new Label();
            textBox1 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            dgvRiepilogo = new DataGridView();
            colTarga = new DataGridViewTextBoxColumn();
            colMarca = new DataGridViewTextBoxColumn();
            colModello = new DataGridViewTextBoxColumn();
            colColore = new DataGridViewTextBoxColumn();
            colTempo = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            pnlDiego.SuspendLayout();
            pnlRiepilogo.SuspendLayout();
            pnlAggiungi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiepilogo).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { DIEGO, FRANCO, MATTEO, toolStripMenuItem1, toolStripMenuItem2, RIEPILOGO, toolStripMenuItem3, aGGIUNGIVEICOLOToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1167, 46);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // DIEGO
            // 
            DIEGO.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            DIEGO.Name = "DIEGO";
            DIEGO.Size = new Size(114, 42);
            DIEGO.Text = "DIEGO";
            DIEGO.Click += DIEGO_Click;
            // 
            // FRANCO
            // 
            FRANCO.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            FRANCO.Name = "FRANCO";
            FRANCO.Size = new Size(140, 42);
            FRANCO.Text = "FRANCO";
            // 
            // MATTEO
            // 
            MATTEO.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            MATTEO.Name = "MATTEO";
            MATTEO.Size = new Size(140, 42);
            MATTEO.Text = "MATTEO";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(138, 42);
            toolStripMenuItem1.Text = "                      ";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(33, 42);
            toolStripMenuItem2.Text = " ";
            // 
            // RIEPILOGO
            // 
            RIEPILOGO.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            RIEPILOGO.Name = "RIEPILOGO";
            RIEPILOGO.Size = new Size(167, 42);
            RIEPILOGO.Text = "RIEPILOGO";
            RIEPILOGO.Click += RIEPILOGO_Click;
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(16, 42);
            // 
            // aGGIUNGIVEICOLOToolStripMenuItem
            // 
            aGGIUNGIVEICOLOToolStripMenuItem.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            aGGIUNGIVEICOLOToolStripMenuItem.Name = "aGGIUNGIVEICOLOToolStripMenuItem";
            aGGIUNGIVEICOLOToolStripMenuItem.Size = new Size(277, 42);
            aGGIUNGIVEICOLOToolStripMenuItem.Text = "AGGIUNGI VEICOLO";
            aGGIUNGIVEICOLOToolStripMenuItem.Click += aGGIUNGIVEICOLOToolStripMenuItem_Click;
            // 
            // pnlDiego
            // 
            pnlDiego.BackColor = Color.Thistle;
            pnlDiego.Controls.Add(lblNascosta);
            pnlDiego.Controls.Add(cmbAvviati);
            pnlDiego.Controls.Add(lblVeicoloSelezionato);
            pnlDiego.Controls.Add(btnFine);
            pnlDiego.Controls.Add(btnInizio);
            pnlDiego.Controls.Add(label2);
            pnlDiego.Controls.Add(cmbVeicoli);
            pnlDiego.Controls.Add(label1);
            pnlDiego.Location = new Point(13, 53);
            pnlDiego.Name = "pnlDiego";
            pnlDiego.Size = new Size(975, 471);
            pnlDiego.TabIndex = 1;
            pnlDiego.Visible = false;
            // 
            // lblNascosta
            // 
            lblNascosta.AutoSize = true;
            lblNascosta.Location = new Point(902, 20);
            lblNascosta.Name = "lblNascosta";
            lblNascosta.Size = new Size(60, 25);
            lblNascosta.TabIndex = 7;
            lblNascosta.Text = "Diego";
            lblNascosta.Visible = false;
            // 
            // cmbAvviati
            // 
            cmbAvviati.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cmbAvviati.FormattingEnabled = true;
            cmbAvviati.Location = new Point(64, 316);
            cmbAvviati.Name = "cmbAvviati";
            cmbAvviati.Size = new Size(540, 46);
            cmbAvviati.TabIndex = 6;
            cmbAvviati.SelectedIndexChanged += cmbAvviati_SelectedIndexChanged;
            // 
            // lblVeicoloSelezionato
            // 
            lblVeicoloSelezionato.AutoSize = true;
            lblVeicoloSelezionato.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblVeicoloSelezionato.Location = new Point(40, 257);
            lblVeicoloSelezionato.Name = "lblVeicoloSelezionato";
            lblVeicoloSelezionato.Size = new Size(604, 38);
            lblVeicoloSelezionato.TabIndex = 5;
            lblVeicoloSelezionato.Text = "Hai avviato una lavorazione sui seguenti veicoli:";
            // 
            // btnFine
            // 
            btnFine.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnFine.Location = new Point(650, 288);
            btnFine.Name = "btnFine";
            btnFine.Size = new Size(215, 97);
            btnFine.TabIndex = 4;
            btnFine.Text = "FINE";
            btnFine.UseVisualStyleBackColor = true;
            btnFine.Click += btnFine_Click;
            // 
            // btnInizio
            // 
            btnInizio.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            btnInizio.Location = new Point(650, 109);
            btnInizio.Name = "btnInizio";
            btnInizio.Size = new Size(215, 97);
            btnInizio.TabIndex = 3;
            btnInizio.Text = "INIZIO";
            btnInizio.UseVisualStyleBackColor = true;
            btnInizio.Click += btnInizio_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(40, 84);
            label2.Name = "label2";
            label2.Size = new Size(112, 38);
            label2.TabIndex = 2;
            label2.Text = "Veicolo:";
            // 
            // cmbVeicoli
            // 
            cmbVeicoli.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            cmbVeicoli.FormattingEnabled = true;
            cmbVeicoli.Items.AddRange(new object[] { "AB123CD;Fiat;Punto;Rosso;120", "EF456GH;Ford;Focus;Blu;90", "IJ789KL;Toyota;Corolla;Nero;100", "MN012OP;Volkswagen;Golf;Bianco;110", "QR345ST;Renault;Clio;Grigio;80", "UV678WX;BMW;Serie 3;Argento;130", "YZ901AB;Audi;A4;Blu scuro;140", "CD234EF;Mercedes;Classe C;Nero;150", "GH567IJ;Peugeot;308;Rosso;95", "KL890MN;Honda;Civic;Bianco;105" });
            cmbVeicoli.Location = new Point(64, 137);
            cmbVeicoli.Name = "cmbVeicoli";
            cmbVeicoli.Size = new Size(540, 46);
            cmbVeicoli.TabIndex = 1;
            cmbVeicoli.SelectedIndexChanged += cmbVeicoli_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.Location = new Point(15, 20);
            label1.Name = "label1";
            label1.Size = new Size(192, 38);
            label1.TabIndex = 0;
            label1.Text = "MENU DIEGO";
            // 
            // pnlRiepilogo
            // 
            pnlRiepilogo.AutoScroll = true;
            pnlRiepilogo.BackColor = SystemColors.GradientInactiveCaption;
            pnlRiepilogo.Controls.Add(label3);
            pnlRiepilogo.Controls.Add(dgvRiepilogo);
            pnlRiepilogo.Location = new Point(12, 541);
            pnlRiepilogo.Name = "pnlRiepilogo";
            pnlRiepilogo.Size = new Size(1028, 453);
            pnlRiepilogo.TabIndex = 8;
            pnlRiepilogo.Visible = false;
            // 
            // pnlAggiungi
            // 
            pnlAggiungi.Controls.Add(button1);
            pnlAggiungi.Controls.Add(textBox3);
            pnlAggiungi.Controls.Add(label7);
            pnlAggiungi.Controls.Add(textBox4);
            pnlAggiungi.Controls.Add(label8);
            pnlAggiungi.Controls.Add(textBox2);
            pnlAggiungi.Controls.Add(label6);
            pnlAggiungi.Controls.Add(textBox1);
            pnlAggiungi.Controls.Add(label5);
            pnlAggiungi.Controls.Add(label4);
            pnlAggiungi.Location = new Point(1007, 73);
            pnlAggiungi.Name = "pnlAggiungi";
            pnlAggiungi.Size = new Size(747, 292);
            pnlAggiungi.TabIndex = 2;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(520, 140);
            button1.Name = "button1";
            button1.Size = new Size(196, 62);
            button1.TabIndex = 9;
            button1.Text = "AGGIUNGI";
            button1.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(232, 229);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(250, 45);
            textBox3.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(83, 229);
            label7.Name = "label7";
            label7.Size = new Size(118, 38);
            label7.TabIndex = 7;
            label7.Text = "COLORE";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(232, 179);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(250, 45);
            textBox4.TabIndex = 6;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(83, 179);
            label8.Name = "label8";
            label8.Size = new Size(143, 38);
            label8.TabIndex = 5;
            label8.Text = "MODELLO";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(232, 127);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 45);
            textBox2.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(83, 127);
            label6.Name = "label6";
            label6.Size = new Size(112, 38);
            label6.TabIndex = 3;
            label6.Text = "MARCA";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(232, 77);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 45);
            textBox1.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(83, 77);
            label5.Name = "label5";
            label5.Size = new Size(102, 38);
            label5.TabIndex = 1;
            label5.Text = "TARGA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(15, 15);
            label4.Name = "label4";
            label4.Size = new Size(340, 38);
            label4.TabIndex = 0;
            label4.Text = "MENU AGGIUNTA VEICOLI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label3.Location = new Point(27, 20);
            label3.Name = "label3";
            label3.Size = new Size(494, 38);
            label3.TabIndex = 1;
            label3.Text = "RIEPILOGO TEMPI DI LAVORAZIONE";
            // 
            // dgvRiepilogo
            // 
            dgvRiepilogo.AllowUserToAddRows = false;
            dgvRiepilogo.AllowUserToDeleteRows = false;
            dgvRiepilogo.AllowUserToResizeColumns = false;
            dgvRiepilogo.AllowUserToResizeRows = false;
            dgvRiepilogo.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dgvRiepilogo.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dgvRiepilogo.BackgroundColor = SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRiepilogo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRiepilogo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvRiepilogo.Columns.AddRange(new DataGridViewColumn[] { colTarga, colMarca, colModello, colColore, colTempo });
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.GradientActiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            dgvRiepilogo.DefaultCellStyle = dataGridViewCellStyle4;
            dgvRiepilogo.GridColor = SystemColors.ActiveCaption;
            dgvRiepilogo.Location = new Point(61, 84);
            dgvRiepilogo.Name = "dgvRiepilogo";
            dgvRiepilogo.ReadOnly = true;
            dgvRiepilogo.RowHeadersVisible = false;
            dgvRiepilogo.RowHeadersWidth = 62;
            dgvRiepilogo.RowTemplate.Height = 33;
            dgvRiepilogo.Size = new Size(868, 346);
            dgvRiepilogo.TabIndex = 0;
            // 
            // colTarga
            // 
            colTarga.HeaderText = "TARGA";
            colTarga.MinimumWidth = 8;
            colTarga.Name = "colTarga";
            colTarga.ReadOnly = true;
            colTarga.Width = 138;
            // 
            // colMarca
            // 
            colMarca.HeaderText = "MARCA";
            colMarca.MinimumWidth = 8;
            colMarca.Name = "colMarca";
            colMarca.ReadOnly = true;
            colMarca.Width = 148;
            // 
            // colModello
            // 
            colModello.HeaderText = "MODELLO";
            colModello.MinimumWidth = 8;
            colModello.Name = "colModello";
            colModello.ReadOnly = true;
            colModello.Width = 179;
            // 
            // colColore
            // 
            colColore.HeaderText = "COLORE";
            colColore.MinimumWidth = 8;
            colColore.Name = "colColore";
            colColore.ReadOnly = true;
            colColore.Width = 154;
            // 
            // colTempo
            // 
            colTempo.HeaderText = "TEMPO";
            colTempo.MinimumWidth = 8;
            colTempo.Name = "colTempo";
            colTempo.ReadOnly = true;
            colTempo.Width = 144;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1167, 1050);
            Controls.Add(pnlAggiungi);
            Controls.Add(pnlRiepilogo);
            Controls.Add(menuStrip1);
            Controls.Add(pnlDiego);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDiego.ResumeLayout(false);
            pnlDiego.PerformLayout();
            pnlRiepilogo.ResumeLayout(false);
            pnlRiepilogo.PerformLayout();
            pnlAggiungi.ResumeLayout(false);
            pnlAggiungi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRiepilogo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem DIEGO;
        private ToolStripMenuItem FRANCO;
        private ToolStripMenuItem MATTEO;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem RIEPILOGO;
        private Panel pnlDiego;
        private ComboBox cmbVeicoli;
        private Label label1;
        private Label label2;
        private Button btnFine;
        private Button btnInizio;
        private Label lblVeicoloSelezionato;
        private ToolStripMenuItem toolStripMenuItem3;
        private ComboBox cmbAvviati;
        private Label lblNascosta;
        private Panel pnlRiepilogo;
        private DataGridView dgvRiepilogo;
        private DataGridViewTextBoxColumn colTarga;
        private DataGridViewTextBoxColumn colMarca;
        private DataGridViewTextBoxColumn colModello;
        private DataGridViewTextBoxColumn colTempo;
        private Label label3;
        private DataGridViewTextBoxColumn colColore;
        private ToolStripMenuItem aGGIUNGIVEICOLOToolStripMenuItem;
        private Panel pnlAggiungi;
        private Button button1;
        private TextBox textBox3;
        private Label label7;
        private TextBox textBox4;
        private Label label8;
        private TextBox textBox2;
        private Label label6;
        private TextBox textBox1;
        private Label label5;
        private Label label4;
    }
}