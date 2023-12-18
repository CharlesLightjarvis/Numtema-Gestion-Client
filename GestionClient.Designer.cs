namespace Numtema_Gestion_Client
{
    partial class GestionClient
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbClients = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpDateEnregistrement = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtNumTelephone = new System.Windows.Forms.TextBox();
            this.txtVille = new System.Windows.Forms.TextBox();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnEffacerInfoPerso = new FontAwesome.Sharp.IconButton();
            this.btnEffacerComplements = new FontAwesome.Sharp.IconButton();
            this.btnAjout = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvListeClients = new System.Windows.Forms.DataGridView();
            this.btnEditer = new FontAwesome.Sharp.IconButton();
            this.btnDetails = new FontAwesome.Sharp.IconButton();
            this.btnEffacer = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.cmbRechercheClient = new System.Windows.Forms.ComboBox();
            this.dtpRechercheClient = new System.Windows.Forms.DateTimePicker();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.txtRechercheNom = new System.Windows.Forms.TextBox();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.iconButton5 = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeClients)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 579F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 39);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1158, 254);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbClients);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.txtDescription);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpDateEnregistrement);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(582, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(573, 228);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Données Complémentaires";
            // 
            // cmbClients
            // 
            this.cmbClients.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClients.FormattingEnabled = true;
            this.cmbClients.Location = new System.Drawing.Point(267, 80);
            this.cmbClients.Name = "cmbClients";
            this.cmbClients.Size = new System.Drawing.Size(133, 26);
            this.cmbClients.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Roboto Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(95, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 19);
            this.label10.TabIndex = 13;
            this.label10.Text = "Type Client";
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(22, 150);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDescription.Size = new System.Drawing.Size(530, 68);
            this.txtDescription.TabIndex = 11;
            this.txtDescription.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Roboto Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(250, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 19);
            this.label7.TabIndex = 12;
            this.label7.Text = "Description";
            // 
            // dtpDateEnregistrement
            // 
            this.dtpDateEnregistrement.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDateEnregistrement.Location = new System.Drawing.Point(267, 31);
            this.dtpDateEnregistrement.Name = "dtpDateEnregistrement";
            this.dtpDateEnregistrement.Size = new System.Drawing.Size(200, 26);
            this.dtpDateEnregistrement.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Roboto Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(95, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(141, 19);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date Enregistrement";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtNumTelephone);
            this.groupBox1.Controls.Add(this.txtVille);
            this.groupBox1.Controls.Add(this.txtPrenom);
            this.groupBox1.Controls.Add(this.txtNom);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(573, 228);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informations Personnelles";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Roboto Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(283, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 19);
            this.label5.TabIndex = 9;
            this.label5.Text = "E-Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Roboto Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(283, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 19);
            this.label4.TabIndex = 8;
            this.label4.Text = "Téléphone";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 181);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ville";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 19);
            this.label2.TabIndex = 6;
            this.label2.Text = "Prénom";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nom";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(339, 104);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(228, 30);
            this.txtEmail.TabIndex = 4;
            // 
            // txtNumTelephone
            // 
            this.txtNumTelephone.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumTelephone.Location = new System.Drawing.Point(372, 36);
            this.txtNumTelephone.Name = "txtNumTelephone";
            this.txtNumTelephone.Size = new System.Drawing.Size(168, 30);
            this.txtNumTelephone.TabIndex = 3;
            this.txtNumTelephone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumTelephone_KeyPress);
            // 
            // txtVille
            // 
            this.txtVille.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVille.Location = new System.Drawing.Point(92, 170);
            this.txtVille.Name = "txtVille";
            this.txtVille.Size = new System.Drawing.Size(168, 30);
            this.txtVille.TabIndex = 2;
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(92, 104);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(168, 30);
            this.txtPrenom.TabIndex = 1;
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.ForeColor = System.Drawing.Color.Black;
            this.txtNom.Location = new System.Drawing.Point(92, 39);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(168, 30);
            this.txtNom.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Roboto Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(485, 1);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(227, 35);
            this.label8.TabIndex = 10;
            this.label8.Text = "Formulaire Client";
            // 
            // btnEffacerInfoPerso
            // 
            this.btnEffacerInfoPerso.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnEffacerInfoPerso.IconColor = System.Drawing.Color.Red;
            this.btnEffacerInfoPerso.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEffacerInfoPerso.IconSize = 30;
            this.btnEffacerInfoPerso.Location = new System.Drawing.Point(191, 289);
            this.btnEffacerInfoPerso.Name = "btnEffacerInfoPerso";
            this.btnEffacerInfoPerso.Size = new System.Drawing.Size(167, 50);
            this.btnEffacerInfoPerso.TabIndex = 3;
            this.btnEffacerInfoPerso.Text = "Effacer Infos Perso";
            this.btnEffacerInfoPerso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEffacerInfoPerso.UseVisualStyleBackColor = true;
            this.btnEffacerInfoPerso.Click += new System.EventHandler(this.btnEffacerInfoPerso_Click);
            // 
            // btnEffacerComplements
            // 
            this.btnEffacerComplements.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnEffacerComplements.IconColor = System.Drawing.Color.Red;
            this.btnEffacerComplements.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEffacerComplements.IconSize = 30;
            this.btnEffacerComplements.Location = new System.Drawing.Point(829, 289);
            this.btnEffacerComplements.Name = "btnEffacerComplements";
            this.btnEffacerComplements.Size = new System.Drawing.Size(174, 50);
            this.btnEffacerComplements.TabIndex = 4;
            this.btnEffacerComplements.Text = "Effacer Compléments";
            this.btnEffacerComplements.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEffacerComplements.UseVisualStyleBackColor = true;
            this.btnEffacerComplements.Click += new System.EventHandler(this.btnEffacerComplements_Click);
            // 
            // btnAjout
            // 
            this.btnAjout.IconChar = FontAwesome.Sharp.IconChar.Add;
            this.btnAjout.IconColor = System.Drawing.Color.ForestGreen;
            this.btnAjout.IconFont = FontAwesome.Sharp.IconFont.Brands;
            this.btnAjout.IconSize = 30;
            this.btnAjout.Location = new System.Drawing.Point(549, 289);
            this.btnAjout.Name = "btnAjout";
            this.btnAjout.Size = new System.Drawing.Size(92, 50);
            this.btnAjout.TabIndex = 5;
            this.btnAjout.Text = "Ajouter";
            this.btnAjout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAjout.UseVisualStyleBackColor = true;
            this.btnAjout.Click += new System.EventHandler(this.btnAjout_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Roboto Light", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(461, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(297, 35);
            this.label9.TabIndex = 11;
            this.label9.Text = "Numtema Liste Clients";
            // 
            // dgvListeClients
            // 
            this.dgvListeClients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvListeClients.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvListeClients.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvListeClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvListeClients.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.RaisedHorizontal;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListeClients.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListeClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListeClients.Location = new System.Drawing.Point(12, 407);
            this.dgvListeClients.Name = "dgvListeClients";
            this.dgvListeClients.Size = new System.Drawing.Size(1026, 256);
            this.dgvListeClients.TabIndex = 12;
            // 
            // btnEditer
            // 
            this.btnEditer.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnEditer.IconColor = System.Drawing.Color.ForestGreen;
            this.btnEditer.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnEditer.IconSize = 30;
            this.btnEditer.Location = new System.Drawing.Point(1064, 437);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(92, 50);
            this.btnEditer.TabIndex = 13;
            this.btnEditer.Text = "Editer";
            this.btnEditer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnDetails
            // 
            this.btnDetails.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.btnDetails.IconColor = System.Drawing.Color.Blue;
            this.btnDetails.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnDetails.IconSize = 30;
            this.btnDetails.Location = new System.Drawing.Point(1064, 511);
            this.btnDetails.Name = "btnDetails";
            this.btnDetails.Size = new System.Drawing.Size(92, 50);
            this.btnDetails.TabIndex = 14;
            this.btnDetails.Text = "Détails";
            this.btnDetails.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDetails.UseVisualStyleBackColor = true;
            this.btnDetails.Click += new System.EventHandler(this.btnDetails_Click);
            // 
            // btnEffacer
            // 
            this.btnEffacer.IconChar = FontAwesome.Sharp.IconChar.Trash;
            this.btnEffacer.IconColor = System.Drawing.Color.Red;
            this.btnEffacer.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEffacer.IconSize = 30;
            this.btnEffacer.Location = new System.Drawing.Point(1064, 584);
            this.btnEffacer.Name = "btnEffacer";
            this.btnEffacer.Size = new System.Drawing.Size(92, 50);
            this.btnEffacer.TabIndex = 15;
            this.btnEffacer.Text = "Effacer";
            this.btnEffacer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEffacer.UseVisualStyleBackColor = true;
            this.btnEffacer.Click += new System.EventHandler(this.btnEffacer_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.Transparent;
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.RightToBracket;
            this.iconButton1.IconColor = System.Drawing.Color.Yellow;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconButton1.IconSize = 30;
            this.iconButton1.Location = new System.Drawing.Point(1, 1);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(50, 45);
            this.iconButton1.TabIndex = 16;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // iconButton2
            // 
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconButton2.IconColor = System.Drawing.Color.Black;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.IconSize = 30;
            this.iconButton2.Location = new System.Drawing.Point(155, 669);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(140, 33);
            this.iconButton2.TabIndex = 17;
            this.iconButton2.Text = "Recherche Type";
            this.iconButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // cmbRechercheClient
            // 
            this.cmbRechercheClient.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbRechercheClient.FormattingEnabled = true;
            this.cmbRechercheClient.Location = new System.Drawing.Point(16, 673);
            this.cmbRechercheClient.Name = "cmbRechercheClient";
            this.cmbRechercheClient.Size = new System.Drawing.Size(133, 26);
            this.cmbRechercheClient.TabIndex = 18;
            // 
            // dtpRechercheClient
            // 
            this.dtpRechercheClient.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRechercheClient.Location = new System.Drawing.Point(346, 673);
            this.dtpRechercheClient.Name = "dtpRechercheClient";
            this.dtpRechercheClient.Size = new System.Drawing.Size(200, 26);
            this.dtpRechercheClient.TabIndex = 19;
            // 
            // iconButton3
            // 
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconButton3.IconColor = System.Drawing.Color.Black;
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 30;
            this.iconButton3.Location = new System.Drawing.Point(552, 670);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(140, 33);
            this.iconButton3.TabIndex = 20;
            this.iconButton3.Text = "Recherche Date";
            this.iconButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton3.UseVisualStyleBackColor = true;
            this.iconButton3.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // txtRechercheNom
            // 
            this.txtRechercheNom.Font = new System.Drawing.Font("Roboto Condensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRechercheNom.Location = new System.Drawing.Point(748, 672);
            this.txtRechercheNom.Name = "txtRechercheNom";
            this.txtRechercheNom.Size = new System.Drawing.Size(168, 30);
            this.txtRechercheNom.TabIndex = 10;
            // 
            // iconButton4
            // 
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.Searchengin;
            this.iconButton4.IconColor = System.Drawing.Color.Black;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 30;
            this.iconButton4.Location = new System.Drawing.Point(922, 670);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Size = new System.Drawing.Size(140, 33);
            this.iconButton4.TabIndex = 21;
            this.iconButton4.Text = "Recherche Nom";
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // iconButton5
            // 
            this.iconButton5.FlatAppearance.BorderSize = 0;
            this.iconButton5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.iconButton5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.iconButton5.IconChar = FontAwesome.Sharp.IconChar.ArrowRotateBackward;
            this.iconButton5.IconColor = System.Drawing.Color.Red;
            this.iconButton5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton5.IconSize = 30;
            this.iconButton5.Location = new System.Drawing.Point(12, 361);
            this.iconButton5.Name = "iconButton5";
            this.iconButton5.Size = new System.Drawing.Size(118, 40);
            this.iconButton5.TabIndex = 22;
            this.iconButton5.Text = "Reinitialiser";
            this.iconButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton5.UseVisualStyleBackColor = true;
            this.iconButton5.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // GestionClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(28)))), ((int)(((byte)(126)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1182, 710);
            this.Controls.Add(this.iconButton5);
            this.Controls.Add(this.iconButton4);
            this.Controls.Add(this.txtRechercheNom);
            this.Controls.Add(this.iconButton3);
            this.Controls.Add(this.dtpRechercheClient);
            this.Controls.Add(this.cmbRechercheClient);
            this.Controls.Add(this.iconButton2);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.btnEffacer);
            this.Controls.Add(this.btnDetails);
            this.Controls.Add(this.btnEditer);
            this.Controls.Add(this.dgvListeClients);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnAjout);
            this.Controls.Add(this.btnEffacerComplements);
            this.Controls.Add(this.btnEffacerInfoPerso);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GestionClient";
            this.Text = "GestionClient";
            this.Load += new System.EventHandler(this.GestionClient_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListeClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtNumTelephone;
        private System.Windows.Forms.TextBox txtVille;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpDateEnregistrement;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private FontAwesome.Sharp.IconButton btnEffacerInfoPerso;
        private FontAwesome.Sharp.IconButton btnEffacerComplements;
        private FontAwesome.Sharp.IconButton btnAjout;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvListeClients;
        private FontAwesome.Sharp.IconButton btnEditer;
        private FontAwesome.Sharp.IconButton btnDetails;
        private FontAwesome.Sharp.IconButton btnEffacer;
        private System.Windows.Forms.ComboBox cmbClients;
        private System.Windows.Forms.Label label10;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton iconButton2;
        private System.Windows.Forms.ComboBox cmbRechercheClient;
        private System.Windows.Forms.DateTimePicker dtpRechercheClient;
        private FontAwesome.Sharp.IconButton iconButton3;
        private System.Windows.Forms.TextBox txtRechercheNom;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton iconButton5;
    }
}