namespace AgendaActivitati
{
    partial class Form4
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbId = new System.Windows.Forms.TextBox();
            this.tbNume = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbDescriere = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNumeDezvoltator = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tbIduriDomenii = new System.Windows.Forms.TextBox();
            this.btnAdaugaProiect = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(0, 0);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(800, 676);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nume Proiect";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id proiect";
            // 
            // tbId
            // 
            this.tbId.Location = new System.Drawing.Point(32, 86);
            this.tbId.Name = "tbId";
            this.tbId.Size = new System.Drawing.Size(100, 26);
            this.tbId.TabIndex = 3;
            // 
            // tbNume
            // 
            this.tbNume.Location = new System.Drawing.Point(32, 163);
            this.tbNume.Name = "tbNume";
            this.tbNume.Size = new System.Drawing.Size(100, 26);
            this.tbNume.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descriere";
            // 
            // tbDescriere
            // 
            this.tbDescriere.Location = new System.Drawing.Point(36, 263);
            this.tbDescriere.Name = "tbDescriere";
            this.tbDescriere.Size = new System.Drawing.Size(100, 26);
            this.tbDescriere.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 329);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Dezvoltator Principal";
            // 
            // tbNumeDezvoltator
            // 
            this.tbNumeDezvoltator.Location = new System.Drawing.Point(32, 381);
            this.tbNumeDezvoltator.Name = "tbNumeDezvoltator";
            this.tbNumeDezvoltator.Size = new System.Drawing.Size(100, 26);
            this.tbNumeDezvoltator.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 437);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Id-uri domenii";
            // 
            // tbIduriDomenii
            // 
            this.tbIduriDomenii.Location = new System.Drawing.Point(36, 491);
            this.tbIduriDomenii.Name = "tbIduriDomenii";
            this.tbIduriDomenii.Size = new System.Drawing.Size(100, 26);
            this.tbIduriDomenii.TabIndex = 10;
            // 
            // btnAdaugaProiect
            // 
            this.btnAdaugaProiect.Location = new System.Drawing.Point(40, 583);
            this.btnAdaugaProiect.Name = "btnAdaugaProiect";
            this.btnAdaugaProiect.Size = new System.Drawing.Size(172, 47);
            this.btnAdaugaProiect.TabIndex = 11;
            this.btnAdaugaProiect.Text = "Adauga Proiect";
            this.btnAdaugaProiect.UseVisualStyleBackColor = true;
            this.btnAdaugaProiect.Click += new System.EventHandler(this.btnAdaugaProiect_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 676);
            this.Controls.Add(this.btnAdaugaProiect);
            this.Controls.Add(this.tbIduriDomenii);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNumeDezvoltator);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbDescriere);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNume);
            this.Controls.Add(this.tbId);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbId;
        private System.Windows.Forms.TextBox tbNume;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbDescriere;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNumeDezvoltator;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbIduriDomenii;
        private System.Windows.Forms.Button btnAdaugaProiect;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}