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
            menuStrip1 = new MenuStrip();
            DIEGO = new ToolStripMenuItem();
            FRANCO = new ToolStripMenuItem();
            MATTEO = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            RIEPILOGO = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            pnlDiego = new Panel();
            cmbAvviati = new ComboBox();
            lblVeicoloSelezionato = new Label();
            btnFine = new Button();
            btnInizio = new Button();
            label2 = new Label();
            cmbVeicoli = new ComboBox();
            label1 = new Label();
            menuStrip1.SuspendLayout();
            pnlDiego.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { DIEGO, FRANCO, MATTEO, toolStripMenuItem1, toolStripMenuItem2, RIEPILOGO, toolStripMenuItem3 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1003, 46);
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
            toolStripMenuItem1.Size = new Size(268, 42);
            toolStripMenuItem1.Text = "                                                ";
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
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(16, 42);
            // 
            // pnlDiego
            // 
            pnlDiego.BackColor = Color.Thistle;
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
            pnlDiego.Paint += pnlDiego_Paint;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1003, 575);
            Controls.Add(pnlDiego);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            pnlDiego.ResumeLayout(false);
            pnlDiego.PerformLayout();
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
    }
}