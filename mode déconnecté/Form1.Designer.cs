namespace mode_déconnecté
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cbbid = new System.Windows.Forms.ComboBox();
            this.cbbDestinations = new System.Windows.Forms.ComboBox();
            this.btnload = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnrecherche = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cbbClient = new System.Windows.Forms.ComboBox();
            this.cbbDest = new System.Windows.Forms.ComboBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grprecherche = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbbthem = new System.Windows.Forms.ComboBox();
            this.txtprix = new System.Windows.Forms.TextBox();
            this.btnrecherch = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.grprecherche.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.cbbid);
            this.tabPage1.Controls.Add(this.cbbDestinations);
            this.tabPage1.Controls.Add(this.btnload);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 400);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Destinations";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(299, 73);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nombre de voyage select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(299, 46);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Nombre voyages boucle";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbbid
            // 
            this.cbbid.FormattingEnabled = true;
            this.cbbid.Location = new System.Drawing.Point(171, 74);
            this.cbbid.Name = "cbbid";
            this.cbbid.Size = new System.Drawing.Size(121, 21);
            this.cbbid.TabIndex = 2;
            // 
            // cbbDestinations
            // 
            this.cbbDestinations.FormattingEnabled = true;
            this.cbbDestinations.Location = new System.Drawing.Point(171, 47);
            this.cbbDestinations.Name = "cbbDestinations";
            this.cbbDestinations.Size = new System.Drawing.Size(121, 21);
            this.cbbDestinations.TabIndex = 1;
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(171, 17);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(269, 23);
            this.btnload.TabIndex = 0;
            this.btnload.Text = "Charger base de données";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(768, 400);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Reservations";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(7, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(755, 166);
            this.dataGridView1.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnrecherche);
            this.groupBox1.Controls.Add(this.btnadd);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.cbbClient);
            this.groupBox1.Controls.Add(this.cbbDest);
            this.groupBox1.Controls.Add(this.checkBox3);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(756, 153);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Recherche par criteres";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnrecherche
            // 
            this.btnrecherche.Location = new System.Drawing.Point(464, 95);
            this.btnrecherche.Name = "btnrecherche";
            this.btnrecherche.Size = new System.Drawing.Size(189, 23);
            this.btnrecherche.TabIndex = 8;
            this.btnrecherche.Text = "Lancer recherche";
            this.btnrecherche.UseVisualStyleBackColor = true;
            this.btnrecherche.Click += new System.EventHandler(this.btnrecherche_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(464, 40);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(189, 23);
            this.btnadd.TabIndex = 7;
            this.btnadd.Text = "Nouveau voyage";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(77, 43);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(100, 17);
            this.checkBox1.TabIndex = 3;
            this.checkBox1.Text = "par destinations";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cbbClient
            // 
            this.cbbClient.FormattingEnabled = true;
            this.cbbClient.Location = new System.Drawing.Point(234, 96);
            this.cbbClient.Name = "cbbClient";
            this.cbbClient.Size = new System.Drawing.Size(200, 21);
            this.cbbClient.TabIndex = 6;
            this.cbbClient.Visible = false;
            // 
            // cbbDest
            // 
            this.cbbDest.FormattingEnabled = true;
            this.cbbDest.Location = new System.Drawing.Point(234, 41);
            this.cbbDest.Name = "cbbDest";
            this.cbbDest.Size = new System.Drawing.Size(200, 21);
            this.cbbDest.TabIndex = 0;
            this.cbbDest.Visible = false;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(77, 98);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(69, 17);
            this.checkBox3.TabIndex = 5;
            this.checkBox3.Text = "par client";
            this.checkBox3.UseVisualStyleBackColor = true;
            this.checkBox3.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(234, 69);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 1;
            this.dateTimePicker1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(77, 71);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(65, 17);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "par date";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView2);
            this.tabPage3.Controls.Add(this.grprecherche);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Recherches";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grprecherche
            // 
            this.grprecherche.Controls.Add(this.btnrecherch);
            this.grprecherche.Controls.Add(this.txtprix);
            this.grprecherche.Controls.Add(this.cbbthem);
            this.grprecherche.Controls.Add(this.label2);
            this.grprecherche.Controls.Add(this.label1);
            this.grprecherche.Location = new System.Drawing.Point(7, 7);
            this.grprecherche.Name = "grprecherche";
            this.grprecherche.Size = new System.Drawing.Size(755, 92);
            this.grprecherche.TabIndex = 0;
            this.grprecherche.TabStop = false;
            this.grprecherche.Text = "Filtres de recherche";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thématiques";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prix maximum";
            // 
            // cbbthem
            // 
            this.cbbthem.FormattingEnabled = true;
            this.cbbthem.Location = new System.Drawing.Point(117, 20);
            this.cbbthem.Name = "cbbthem";
            this.cbbthem.Size = new System.Drawing.Size(121, 21);
            this.cbbthem.TabIndex = 2;
            // 
            // txtprix
            // 
            this.txtprix.Location = new System.Drawing.Point(117, 44);
            this.txtprix.Name = "txtprix";
            this.txtprix.Size = new System.Drawing.Size(121, 20);
            this.txtprix.TabIndex = 3;
            // 
            // btnrecherch
            // 
            this.btnrecherch.Location = new System.Drawing.Point(545, 30);
            this.btnrecherch.Name = "btnrecherch";
            this.btnrecherch.Size = new System.Drawing.Size(191, 23);
            this.btnrecherch.TabIndex = 4;
            this.btnrecherch.Text = "Rechercher";
            this.btnrecherch.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(7, 106);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(755, 288);
            this.dataGridView2.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.grprecherche.ResumeLayout(false);
            this.grprecherche.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cbbid;
        private System.Windows.Forms.ComboBox cbbDestinations;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.ComboBox cbbDest;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ComboBox cbbClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnrecherche;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox grprecherche;
        private System.Windows.Forms.Button btnrecherch;
        private System.Windows.Forms.TextBox txtprix;
        private System.Windows.Forms.ComboBox cbbthem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}

