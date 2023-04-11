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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.datagridrecherche = new System.Windows.Forms.DataGridView();
            this.grprecherche = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.Supprimer = new System.Windows.Forms.Button();
            this.btnrecherch = new System.Windows.Forms.Button();
            this.txtprix = new System.Windows.Forms.TextBox();
            this.cbbthem = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dgvParis = new System.Windows.Forms.DataGridView();
            this.btnpsp = new System.Windows.Forms.Button();
            this.buttonPS = new System.Windows.Forms.Button();
            this.txtpara = new System.Windows.Forms.TextBox();
            this.rtxtModif = new System.Windows.Forms.RichTextBox();
            this.btnModif = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridrecherche)).BeginInit();
            this.grprecherche.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParis)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
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
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridView1.Location = new System.Drawing.Point(7, 166);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle18;
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
            this.tabPage3.Controls.Add(this.rtxtModif);
            this.tabPage3.Controls.Add(this.datagridrecherche);
            this.tabPage3.Controls.Add(this.grprecherche);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(768, 400);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Recherches";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // datagridrecherche
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridrecherche.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.datagridrecherche.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagridrecherche.DefaultCellStyle = dataGridViewCellStyle14;
            this.datagridrecherche.Location = new System.Drawing.Point(7, 106);
            this.datagridrecherche.Name = "datagridrecherche";
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagridrecherche.RowHeadersDefaultCellStyle = dataGridViewCellStyle15;
            this.datagridrecherche.Size = new System.Drawing.Size(539, 288);
            this.datagridrecherche.TabIndex = 1;
            this.datagridrecherche.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.datagridrecherche.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            // 
            // grprecherche
            // 
            this.grprecherche.Controls.Add(this.btnModif);
            this.grprecherche.Controls.Add(this.button3);
            this.grprecherche.Controls.Add(this.Supprimer);
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
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(545, 44);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 23);
            this.button3.TabIndex = 8;
            this.button3.Text = "Annuler";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // Supprimer
            // 
            this.Supprimer.Location = new System.Drawing.Point(348, 44);
            this.Supprimer.Name = "Supprimer";
            this.Supprimer.Size = new System.Drawing.Size(191, 23);
            this.Supprimer.TabIndex = 7;
            this.Supprimer.Text = "Supprimer";
            this.Supprimer.UseVisualStyleBackColor = true;
            this.Supprimer.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // btnrecherch
            // 
            this.btnrecherch.Location = new System.Drawing.Point(348, 20);
            this.btnrecherch.Name = "btnrecherch";
            this.btnrecherch.Size = new System.Drawing.Size(191, 23);
            this.btnrecherch.TabIndex = 4;
            this.btnrecherch.Text = "Rechercher";
            this.btnrecherch.UseVisualStyleBackColor = true;
            this.btnrecherch.Click += new System.EventHandler(this.btnrecherch_Click);
            // 
            // txtprix
            // 
            this.txtprix.Location = new System.Drawing.Point(117, 44);
            this.txtprix.Name = "txtprix";
            this.txtprix.Size = new System.Drawing.Size(121, 20);
            this.txtprix.TabIndex = 3;
            // 
            // cbbthem
            // 
            this.cbbthem.FormattingEnabled = true;
            this.cbbthem.Location = new System.Drawing.Point(117, 20);
            this.cbbthem.Name = "cbbthem";
            this.cbbthem.Size = new System.Drawing.Size(121, 21);
            this.cbbthem.TabIndex = 2;
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
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.txtpara);
            this.tabPage4.Controls.Add(this.dgvParis);
            this.tabPage4.Controls.Add(this.btnpsp);
            this.tabPage4.Controls.Add(this.buttonPS);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(768, 400);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Procédures stockées";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dgvParis
            // 
            this.dgvParis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParis.Location = new System.Drawing.Point(215, 7);
            this.dgvParis.Name = "dgvParis";
            this.dgvParis.Size = new System.Drawing.Size(547, 387);
            this.dgvParis.TabIndex = 3;
            // 
            // btnpsp
            // 
            this.btnpsp.Location = new System.Drawing.Point(6, 62);
            this.btnpsp.Name = "btnpsp";
            this.btnpsp.Size = new System.Drawing.Size(202, 23);
            this.btnpsp.TabIndex = 1;
            this.btnpsp.Text = "Procédures stockées paramétrées";
            this.btnpsp.UseVisualStyleBackColor = true;
            this.btnpsp.Click += new System.EventHandler(this.btnpsp_Click);
            // 
            // buttonPS
            // 
            this.buttonPS.Location = new System.Drawing.Point(4, 7);
            this.buttonPS.Name = "buttonPS";
            this.buttonPS.Size = new System.Drawing.Size(204, 23);
            this.buttonPS.TabIndex = 0;
            this.buttonPS.Text = "Procédure stocké";
            this.buttonPS.UseVisualStyleBackColor = true;
            this.buttonPS.Click += new System.EventHandler(this.buttonPS_Click);
            // 
            // txtpara
            // 
            this.txtpara.Location = new System.Drawing.Point(6, 36);
            this.txtpara.Name = "txtpara";
            this.txtpara.Size = new System.Drawing.Size(202, 20);
            this.txtpara.TabIndex = 4;
            // 
            // rtxtModif
            // 
            this.rtxtModif.Location = new System.Drawing.Point(552, 106);
            this.rtxtModif.Name = "rtxtModif";
            this.rtxtModif.Size = new System.Drawing.Size(210, 288);
            this.rtxtModif.TabIndex = 2;
            this.rtxtModif.Text = "";
            this.rtxtModif.TextChanged += new System.EventHandler(this.rtxtModif_TextChanged);
            // 
            // btnModif
            // 
            this.btnModif.BackColor = System.Drawing.Color.Transparent;
            this.btnModif.Location = new System.Drawing.Point(545, 20);
            this.btnModif.Name = "btnModif";
            this.btnModif.Size = new System.Drawing.Size(191, 23);
            this.btnModif.TabIndex = 9;
            this.btnModif.Text = "Modifications";
            this.btnModif.UseVisualStyleBackColor = false;
            this.btnModif.Click += new System.EventHandler(this.btnModif_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Mode déconnecté";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagridrecherche)).EndInit();
            this.grprecherche.ResumeLayout(false);
            this.grprecherche.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParis)).EndInit();
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
        private System.Windows.Forms.DataGridView datagridrecherche;
        private System.Windows.Forms.Button Supprimer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnpsp;
        private System.Windows.Forms.Button buttonPS;
        private System.Windows.Forms.DataGridView dgvParis;
        private System.Windows.Forms.TextBox txtpara;
        private System.Windows.Forms.RichTextBox rtxtModif;
        private System.Windows.Forms.Button btnModif;
    }
}

