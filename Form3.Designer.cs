namespace AgendaActivitati
{
    partial class Form3
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
            this.lbNumeDomeniu = new System.Windows.Forms.Label();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.lbIduriActivitati = new System.Windows.Forms.Label();
            this.tbIduriActivitati = new System.Windows.Forms.TextBox();
            this.btnAdaugaDomeniu = new System.Windows.Forms.Button();
            this.btnVizualizeazaActivit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbNumeDomeniu
            // 
            this.lbNumeDomeniu.AutoSize = true;
            this.lbNumeDomeniu.Location = new System.Drawing.Point(35, 127);
            this.lbNumeDomeniu.Name = "lbNumeDomeniu";
            this.lbNumeDomeniu.Size = new System.Drawing.Size(119, 20);
            this.lbNumeDomeniu.TabIndex = 0;
            this.lbNumeDomeniu.Text = "Nume Domeniu";
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(39, 170);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 26);
            this.tbNume.TabIndex = 1;
            // 
            // lbIduriActivitati
            // 
            this.lbIduriActivitati.AutoSize = true;
            this.lbIduriActivitati.Location = new System.Drawing.Point(35, 211);
            this.lbIduriActivitati.Name = "lbIduriActivitati";
            this.lbIduriActivitati.Size = new System.Drawing.Size(144, 20);
            this.lbIduriActivitati.TabIndex = 2;
            this.lbIduriActivitati.Text = "Lista Id-uri activitati";
            // 
            // tbIduriActivitati
            // 
            this.tbIduriActivitati.Location = new System.Drawing.Point(39, 250);
            this.tbIduriActivitati.Name = "tbIduriActivitati";
            this.tbIduriActivitati.Size = new System.Drawing.Size(100, 26);
            this.tbIduriActivitati.TabIndex = 3;
            // 
            // btnAdaugaDomeniu
            // 
            this.btnAdaugaDomeniu.Location = new System.Drawing.Point(39, 315);
            this.btnAdaugaDomeniu.Name = "btnAdaugaDomeniu";
            this.btnAdaugaDomeniu.Size = new System.Drawing.Size(175, 49);
            this.btnAdaugaDomeniu.TabIndex = 4;
            this.btnAdaugaDomeniu.Text = "Adauga domeniu";
            this.btnAdaugaDomeniu.UseVisualStyleBackColor = true;
            this.btnAdaugaDomeniu.Click += new System.EventHandler(this.btnAdaugaDomeniu_Click);
            // 
            // btnVizualizeazaActivit
            // 
            this.btnVizualizeazaActivit.Location = new System.Drawing.Point(267, 197);
            this.btnVizualizeazaActivit.Name = "btnVizualizeazaActivit";
            this.btnVizualizeazaActivit.Size = new System.Drawing.Size(196, 49);
            this.btnVizualizeazaActivit.TabIndex = 5;
            this.btnVizualizeazaActivit.Text = "Vizualizeaza Activitati";
            this.btnVizualizeazaActivit.UseVisualStyleBackColor = true;
            this.btnVizualizeazaActivit.Click += new System.EventHandler(this.btnVizualizeazaActivit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(641, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "label1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id Domeniu";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(39, 79);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 26);
            this.tbId.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(196, 62);
            this.button1.TabIndex = 9;
            this.button1.Text = "Spre creare Proiect --->>>";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVizualizeazaActivit);
            this.Controls.Add(this.btnAdaugaDomeniu);
            this.Controls.Add(this.tbIduriActivitati);
            this.Controls.Add(this.lbIduriActivitati);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.lbNumeDomeniu);
            this.Name = "Form3";
            this.Text = "Form Domenii";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNumeDomeniu;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label lbIduriActivitati;
        private System.Windows.Forms.TextBox tbIduriActivitati;
        private System.Windows.Forms.Button btnAdaugaDomeniu;
        private System.Windows.Forms.Button btnVizualizeazaActivit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}