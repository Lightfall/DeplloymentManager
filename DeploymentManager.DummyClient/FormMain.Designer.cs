namespace DeploymentManager.DummyClient
{
    partial class FormMain
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
            this.lstInternalTickets = new System.Windows.Forms.ListBox();
            this.lstExternalTickets = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lstDeploys = new System.Windows.Forms.ListBox();
            this.btnExecuteDeploy = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lstSubjects = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstInternalTickets
            // 
            this.lstInternalTickets.FormattingEnabled = true;
            this.lstInternalTickets.Location = new System.Drawing.Point(262, 41);
            this.lstInternalTickets.Name = "lstInternalTickets";
            this.lstInternalTickets.Size = new System.Drawing.Size(150, 485);
            this.lstInternalTickets.TabIndex = 0;
            this.lstInternalTickets.SelectedIndexChanged += new System.EventHandler(this.lstInternalTickets_SelectedIndexChanged);
            // 
            // lstExternalTickets
            // 
            this.lstExternalTickets.FormattingEnabled = true;
            this.lstExternalTickets.Location = new System.Drawing.Point(418, 41);
            this.lstExternalTickets.Name = "lstExternalTickets";
            this.lstExternalTickets.Size = new System.Drawing.Size(150, 485);
            this.lstExternalTickets.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(263, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 23);
            this.label1.TabIndex = 2;
            this.label1.Text = "Internal Tickets";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(418, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "External Tickets";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Deployments";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstDeploys
            // 
            this.lstDeploys.FormattingEnabled = true;
            this.lstDeploys.Location = new System.Drawing.Point(12, 41);
            this.lstDeploys.Name = "lstDeploys";
            this.lstDeploys.Size = new System.Drawing.Size(243, 459);
            this.lstDeploys.TabIndex = 4;
            this.lstDeploys.SelectedIndexChanged += new System.EventHandler(this.lstDeploys_SelectedIndexChanged);
            // 
            // btnExecuteDeploy
            // 
            this.btnExecuteDeploy.Location = new System.Drawing.Point(12, 503);
            this.btnExecuteDeploy.Name = "btnExecuteDeploy";
            this.btnExecuteDeploy.Size = new System.Drawing.Size(244, 23);
            this.btnExecuteDeploy.TabIndex = 6;
            this.btnExecuteDeploy.Text = "Execute Deployment";
            this.btnExecuteDeploy.UseVisualStyleBackColor = true;
            this.btnExecuteDeploy.Click += new System.EventHandler(this.btnExecuteDeploy_Click);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(574, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(150, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Subject to Deploy";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lstSubjects
            // 
            this.lstSubjects.FormattingEnabled = true;
            this.lstSubjects.Location = new System.Drawing.Point(574, 41);
            this.lstSubjects.Name = "lstSubjects";
            this.lstSubjects.Size = new System.Drawing.Size(150, 485);
            this.lstSubjects.TabIndex = 7;
            this.lstSubjects.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSubjects_MouseDoubleClick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(834, 41);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 20);
            this.textBox1.TabIndex = 9;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(834, 67);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(834, 94);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 21);
            this.comboBox2.TabIndex = 11;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(834, 121);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 12;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(915, 121);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnGuncelle.TabIndex = 13;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 538);
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstSubjects);
            this.Controls.Add(this.btnExecuteDeploy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lstDeploys);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstExternalTickets);
            this.Controls.Add(this.lstInternalTickets);
            this.Name = "FormMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstInternalTickets;
        private System.Windows.Forms.ListBox lstExternalTickets;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstDeploys;
        private System.Windows.Forms.Button btnExecuteDeploy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox lstSubjects;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnGuncelle;
    }
}

