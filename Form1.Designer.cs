namespace AgendaActivitati
{
    partial class FormActivitati
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbNumeActivitate = new System.Windows.Forms.TextBox();
            this.tbDescriere = new System.Windows.Forms.TextBox();
            this.tbLocatie = new System.Windows.Forms.TextBox();
            this.tbDataInceput = new System.Windows.Forms.TextBox();
            this.tbDataSfarsit = new System.Windows.Forms.TextBox();
            this.btnAdaugaActivitate = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.tbIdActivitate = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.cbPrioritate = new System.Windows.Forms.ComboBox();
            this.btnVizActivit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nume Activitate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 226);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descriere";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Locatie";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Prioritate";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 523);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Data Inceput";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(316, 523);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Data Sfarsit";
            // 
            // tbNumeActivitate
            // 
            this.tbNumeActivitate.Location = new System.Drawing.Point(34, 167);
            this.tbNumeActivitate.Name = "tbNumeActivitate";
            this.tbNumeActivitate.Size = new System.Drawing.Size(225, 26);
            this.tbNumeActivitate.TabIndex = 6;
            // 
            // tbDescriere
            // 
            this.tbDescriere.Location = new System.Drawing.Point(34, 263);
            this.tbDescriere.Name = "tbDescriere";
            this.tbDescriere.Size = new System.Drawing.Size(225, 26);
            this.tbDescriere.TabIndex = 7;
            // 
            // tbLocatie
            // 
            this.tbLocatie.Location = new System.Drawing.Point(34, 353);
            this.tbLocatie.Name = "tbLocatie";
            this.tbLocatie.Size = new System.Drawing.Size(225, 26);
            this.tbLocatie.TabIndex = 8;
            // 
            // tbDataInceput
            // 
            this.tbDataInceput.Location = new System.Drawing.Point(34, 565);
            this.tbDataInceput.Name = "tbDataInceput";
            this.tbDataInceput.Size = new System.Drawing.Size(153, 26);
            this.tbDataInceput.TabIndex = 10;
            // 
            // tbDataSfarsit
            // 
            this.tbDataSfarsit.Location = new System.Drawing.Point(320, 565);
            this.tbDataSfarsit.Name = "tbDataSfarsit";
            this.tbDataSfarsit.Size = new System.Drawing.Size(150, 26);
            this.tbDataSfarsit.TabIndex = 11;
            // 
            // btnAdaugaActivitate
            // 
            this.btnAdaugaActivitate.Location = new System.Drawing.Point(31, 633);
            this.btnAdaugaActivitate.Name = "btnAdaugaActivitate";
            this.btnAdaugaActivitate.Size = new System.Drawing.Size(210, 55);
            this.btnAdaugaActivitate.TabIndex = 12;
            this.btnAdaugaActivitate.Text = "Adauga Activitate";
            this.btnAdaugaActivitate.UseVisualStyleBackColor = true;
            this.btnAdaugaActivitate.Click += new System.EventHandler(this.btnAdaugaActivitate_Click);
            this.btnAdaugaActivitate.KeyDown += new System.Windows.Forms.KeyEventHandler(this.btnAdaugaActivitate_KeyDown);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(277, 633);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(210, 55);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 38);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Id activitate";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbIdActivitate
            // 
            this.tbIdActivitate.Location = new System.Drawing.Point(36, 76);
            this.tbIdActivitate.Name = "tbIdActivitate";
            this.tbIdActivitate.Size = new System.Drawing.Size(100, 26);
            this.tbIdActivitate.TabIndex = 16;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // cbPrioritate
            // 
            this.cbPrioritate.FormattingEnabled = true;
            this.cbPrioritate.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbPrioritate.Location = new System.Drawing.Point(36, 462);
            this.cbPrioritate.Name = "cbPrioritate";
            this.cbPrioritate.Size = new System.Drawing.Size(121, 28);
            this.cbPrioritate.TabIndex = 17;
            // 
            // btnVizActivit
            // 
            this.btnVizActivit.Location = new System.Drawing.Point(530, 633);
            this.btnVizActivit.Name = "btnVizActivit";
            this.btnVizActivit.Size = new System.Drawing.Size(210, 55);
            this.btnVizActivit.TabIndex = 18;
            this.btnVizActivit.Text = "Vizualizare Activitati";
            this.btnVizActivit.UseVisualStyleBackColor = true;
            this.btnVizActivit.Click += new System.EventHandler(this.btnVizActivit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(511, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 77);
            this.button1.TabIndex = 19;
            this.button1.Text = "Spre Creare Domeniu--->>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormActivitati
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 713);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnVizActivit);
            this.Controls.Add(this.cbPrioritate);
            this.Controls.Add(this.tbIdActivitate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdaugaActivitate);
            this.Controls.Add(this.tbDataSfarsit);
            this.Controls.Add(this.tbDataInceput);
            this.Controls.Add(this.tbLocatie);
            this.Controls.Add(this.tbDescriere);
            this.Controls.Add(this.tbNumeActivitate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormActivitati";
            this.Text = "Form Activitati";
            this.Load += new System.EventHandler(this.FormActivitati_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormActivitati_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbNumeActivitate;
        private System.Windows.Forms.TextBox tbDescriere;
        private System.Windows.Forms.TextBox tbLocatie;
        private System.Windows.Forms.TextBox tbDataInceput;
        private System.Windows.Forms.TextBox tbDataSfarsit;
        private System.Windows.Forms.Button btnAdaugaActivitate;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbIdActivitate;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox cbPrioritate;
        private System.Windows.Forms.Button btnVizActivit;
        private System.Windows.Forms.Button button1;
    }
}