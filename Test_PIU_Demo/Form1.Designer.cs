namespace Test_PIU_Demo
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNume = new System.Windows.Forms.Label();
            this.lblOras = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblProgramStudiu = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.cmbOras = new System.Windows.Forms.ComboBox();
            this.dateInscriere = new System.Windows.Forms.DateTimePicker();
            this.radioCalculatoare = new System.Windows.Forms.RadioButton();
            this.radioAutomatica = new System.Windows.Forms.RadioButton();
            this.radioElectronica = new System.Windows.Forms.RadioButton();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.btnAfiseaza = new System.Windows.Forms.Button();
            this.btnFiltreaza = new System.Windows.Forms.Button();
            this.dateStudenti = new System.Windows.Forms.DataGridView();
            this.Nume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Oras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Data = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Program = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grbProgram = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dateStudenti)).BeginInit();
            this.grbProgram.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(52, 33);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(35, 13);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Nume";
            // 
            // lblOras
            // 
            this.lblOras.AutoSize = true;
            this.lblOras.Location = new System.Drawing.Point(55, 77);
            this.lblOras.Name = "lblOras";
            this.lblOras.Size = new System.Drawing.Size(29, 13);
            this.lblOras.TabIndex = 1;
            this.lblOras.Text = "Oras";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Location = new System.Drawing.Point(55, 131);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(73, 13);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data Inscriere";
            // 
            // lblProgramStudiu
            // 
            this.lblProgramStudiu.AutoSize = true;
            this.lblProgramStudiu.Location = new System.Drawing.Point(55, 188);
            this.lblProgramStudiu.Name = "lblProgramStudiu";
            this.lblProgramStudiu.Size = new System.Drawing.Size(77, 13);
            this.lblProgramStudiu.TabIndex = 3;
            this.lblProgramStudiu.Text = "Program studiu";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(152, 33);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(100, 20);
            this.txtNume.TabIndex = 4;
            // 
            // cmbOras
            // 
            this.cmbOras.FormattingEnabled = true;
            this.cmbOras.Items.AddRange(new object[] {
            "Suceava",
            "Botosani",
            "Piatra Neamt"});
            this.cmbOras.Location = new System.Drawing.Point(152, 77);
            this.cmbOras.Name = "cmbOras";
            this.cmbOras.Size = new System.Drawing.Size(121, 21);
            this.cmbOras.TabIndex = 5;
            this.cmbOras.Text = "Selecteaza orasul...";
            // 
            // dateInscriere
            // 
            this.dateInscriere.Location = new System.Drawing.Point(152, 131);
            this.dateInscriere.Name = "dateInscriere";
            this.dateInscriere.Size = new System.Drawing.Size(200, 20);
            this.dateInscriere.TabIndex = 6;
            // 
            // radioCalculatoare
            // 
            this.radioCalculatoare.AutoSize = true;
            this.radioCalculatoare.Location = new System.Drawing.Point(13, 18);
            this.radioCalculatoare.Name = "radioCalculatoare";
            this.radioCalculatoare.Size = new System.Drawing.Size(84, 17);
            this.radioCalculatoare.TabIndex = 7;
            this.radioCalculatoare.TabStop = true;
            this.radioCalculatoare.Text = "Calculatoare";
            this.radioCalculatoare.UseVisualStyleBackColor = true;
            // 
            // radioAutomatica
            // 
            this.radioAutomatica.AutoSize = true;
            this.radioAutomatica.Location = new System.Drawing.Point(134, 18);
            this.radioAutomatica.Name = "radioAutomatica";
            this.radioAutomatica.Size = new System.Drawing.Size(78, 17);
            this.radioAutomatica.TabIndex = 8;
            this.radioAutomatica.TabStop = true;
            this.radioAutomatica.Text = "Automatica";
            this.radioAutomatica.UseVisualStyleBackColor = true;
            // 
            // radioElectronica
            // 
            this.radioElectronica.AutoSize = true;
            this.radioElectronica.Location = new System.Drawing.Point(255, 18);
            this.radioElectronica.Name = "radioElectronica";
            this.radioElectronica.Size = new System.Drawing.Size(78, 17);
            this.radioElectronica.TabIndex = 9;
            this.radioElectronica.TabStop = true;
            this.radioElectronica.Text = "Electronica";
            this.radioElectronica.UseVisualStyleBackColor = true;
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(58, 250);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(75, 23);
            this.btnAdauga.TabIndex = 10;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // btnAfiseaza
            // 
            this.btnAfiseaza.Location = new System.Drawing.Point(176, 249);
            this.btnAfiseaza.Name = "btnAfiseaza";
            this.btnAfiseaza.Size = new System.Drawing.Size(75, 23);
            this.btnAfiseaza.TabIndex = 11;
            this.btnAfiseaza.Text = "Afiseaza";
            this.btnAfiseaza.UseVisualStyleBackColor = true;
            this.btnAfiseaza.Click += new System.EventHandler(this.btnAfiseaza_Click);
            // 
            // btnFiltreaza
            // 
            this.btnFiltreaza.Location = new System.Drawing.Point(291, 249);
            this.btnFiltreaza.Name = "btnFiltreaza";
            this.btnFiltreaza.Size = new System.Drawing.Size(75, 23);
            this.btnFiltreaza.TabIndex = 12;
            this.btnFiltreaza.Text = "Filtreaza";
            this.btnFiltreaza.UseVisualStyleBackColor = true;
            this.btnFiltreaza.Click += new System.EventHandler(this.btnFiltreaza_Click);
            // 
            // dateStudenti
            // 
            this.dateStudenti.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dateStudenti.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nume,
            this.Oras,
            this.Data,
            this.Program});
            this.dateStudenti.Location = new System.Drawing.Point(528, 33);
            this.dateStudenti.Name = "dateStudenti";
            this.dateStudenti.Size = new System.Drawing.Size(443, 201);
            this.dateStudenti.TabIndex = 13;
            this.dateStudenti.Visible = false;
            // 
            // Nume
            // 
            this.Nume.HeaderText = "Nume";
            this.Nume.Name = "Nume";
            // 
            // Oras
            // 
            this.Oras.HeaderText = "Oras";
            this.Oras.Name = "Oras";
            // 
            // Data
            // 
            this.Data.HeaderText = "Date Inscriere";
            this.Data.Name = "Data";
            // 
            // Program
            // 
            this.Program.HeaderText = "Program studiu";
            this.Program.Name = "Program";
            // 
            // grbProgram
            // 
            this.grbProgram.Controls.Add(this.radioElectronica);
            this.grbProgram.Controls.Add(this.radioAutomatica);
            this.grbProgram.Controls.Add(this.radioCalculatoare);
            this.grbProgram.Location = new System.Drawing.Point(139, 170);
            this.grbProgram.Name = "grbProgram";
            this.grbProgram.Size = new System.Drawing.Size(344, 47);
            this.grbProgram.TabIndex = 14;
            this.grbProgram.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 450);
            this.Controls.Add(this.grbProgram);
            this.Controls.Add(this.dateStudenti);
            this.Controls.Add(this.btnFiltreaza);
            this.Controls.Add(this.btnAfiseaza);
            this.Controls.Add(this.btnAdauga);
            this.Controls.Add(this.dateInscriere);
            this.Controls.Add(this.cmbOras);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.lblProgramStudiu);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblOras);
            this.Controls.Add(this.lblNume);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dateStudenti)).EndInit();
            this.grbProgram.ResumeLayout(false);
            this.grbProgram.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblOras;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblProgramStudiu;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.ComboBox cmbOras;
        private System.Windows.Forms.DateTimePicker dateInscriere;
        private System.Windows.Forms.RadioButton radioCalculatoare;
        private System.Windows.Forms.RadioButton radioAutomatica;
        private System.Windows.Forms.RadioButton radioElectronica;
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.Button btnAfiseaza;
        private System.Windows.Forms.Button btnFiltreaza;
        private System.Windows.Forms.DataGridView dateStudenti;
        private System.Windows.Forms.GroupBox grbProgram;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Oras;
        private System.Windows.Forms.DataGridViewTextBoxColumn Data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Program;
    }
}

