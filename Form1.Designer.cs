namespace DndSheet
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
            this.CName = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.Gender = new System.Windows.Forms.ComboBox();
            this.Str = new System.Windows.Forms.NumericUpDown();
            this.Int = new System.Windows.Forms.NumericUpDown();
            this.Dex = new System.Windows.Forms.NumericUpDown();
            this.Con = new System.Windows.Forms.NumericUpDown();
            this.Cha = new System.Windows.Forms.NumericUpDown();
            this.Luk = new System.Windows.Forms.NumericUpDown();
            this.Hp = new System.Windows.Forms.NumericUpDown();
            this.Mp = new System.Windows.Forms.NumericUpDown();
            this.Race = new System.Windows.Forms.ComboBox();
            this.Save = new System.Windows.Forms.Button();
            this.Faction = new System.Windows.Forms.ComboBox();
            this.Class = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label2 = new System.Windows.Forms.Label();
            this.Lvl = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Mute = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Str)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Int)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Con)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lvl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CName
            // 
            this.CName.Location = new System.Drawing.Point(16, 42);
            this.CName.Margin = new System.Windows.Forms.Padding(2);
            this.CName.Name = "CName";
            this.CName.Size = new System.Drawing.Size(186, 20);
            this.CName.TabIndex = 0;
            this.CName.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column14,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column12,
            this.Column13,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            this.dataGridView1.Location = new System.Drawing.Point(326, 24);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(591, 294);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Character Name";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 125;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Level";
            this.Column14.MinimumWidth = 50;
            this.Column14.Name = "Column14";
            this.Column14.Width = 50;
            // 
            // Column2
            // 
            this.Column2.FillWeight = 125F;
            this.Column2.HeaderText = "HP";
            this.Column2.MinimumWidth = 35;
            this.Column2.Name = "Column2";
            this.Column2.Width = 35;
            // 
            // Column3
            // 
            this.Column3.FillWeight = 125F;
            this.Column3.HeaderText = "MP";
            this.Column3.MinimumWidth = 35;
            this.Column3.Name = "Column3";
            this.Column3.Width = 35;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Gender";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Faction";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.Width = 125;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Race";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.Width = 125;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Class";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.Width = 125;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "STR";
            this.Column6.MinimumWidth = 45;
            this.Column6.Name = "Column6";
            this.Column6.Width = 45;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "DEX";
            this.Column7.MinimumWidth = 45;
            this.Column7.Name = "Column7";
            this.Column7.Width = 45;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "INT";
            this.Column8.MinimumWidth = 45;
            this.Column8.Name = "Column8";
            this.Column8.Width = 45;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "CON";
            this.Column9.MinimumWidth = 45;
            this.Column9.Name = "Column9";
            this.Column9.Width = 45;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "CHA";
            this.Column10.MinimumWidth = 45;
            this.Column10.Name = "Column10";
            this.Column10.Width = 45;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "LUK";
            this.Column11.MinimumWidth = 45;
            this.Column11.Name = "Column11";
            this.Column11.Width = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Character Name";
            // 
            // Gender
            // 
            this.Gender.FormattingEnabled = true;
            this.Gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Gender.Location = new System.Drawing.Point(16, 148);
            this.Gender.Margin = new System.Windows.Forms.Padding(2);
            this.Gender.Name = "Gender";
            this.Gender.Size = new System.Drawing.Size(92, 21);
            this.Gender.TabIndex = 3;
            this.Gender.SelectedIndexChanged += new System.EventHandler(this.Gender_SelectedIndexChanged);
            // 
            // Str
            // 
            this.Str.Location = new System.Drawing.Point(195, 260);
            this.Str.Margin = new System.Windows.Forms.Padding(2);
            this.Str.Name = "Str";
            this.Str.Size = new System.Drawing.Size(44, 20);
            this.Str.TabIndex = 4;
            this.Str.ValueChanged += new System.EventHandler(this.Str_ValueChanged);
            // 
            // Int
            // 
            this.Int.Location = new System.Drawing.Point(195, 341);
            this.Int.Margin = new System.Windows.Forms.Padding(2);
            this.Int.Name = "Int";
            this.Int.Size = new System.Drawing.Size(44, 20);
            this.Int.TabIndex = 5;
            this.Int.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // Dex
            // 
            this.Dex.Location = new System.Drawing.Point(195, 301);
            this.Dex.Margin = new System.Windows.Forms.Padding(2);
            this.Dex.Name = "Dex";
            this.Dex.Size = new System.Drawing.Size(44, 20);
            this.Dex.TabIndex = 6;
            this.Dex.ValueChanged += new System.EventHandler(this.Dex_ValueChanged);
            // 
            // Con
            // 
            this.Con.Location = new System.Drawing.Point(195, 386);
            this.Con.Margin = new System.Windows.Forms.Padding(2);
            this.Con.Name = "Con";
            this.Con.Size = new System.Drawing.Size(44, 20);
            this.Con.TabIndex = 7;
            this.Con.ValueChanged += new System.EventHandler(this.numericUpDown4_ValueChanged);
            // 
            // Cha
            // 
            this.Cha.Location = new System.Drawing.Point(195, 430);
            this.Cha.Margin = new System.Windows.Forms.Padding(2);
            this.Cha.Name = "Cha";
            this.Cha.Size = new System.Drawing.Size(44, 20);
            this.Cha.TabIndex = 8;
            // 
            // Luk
            // 
            this.Luk.Location = new System.Drawing.Point(195, 474);
            this.Luk.Margin = new System.Windows.Forms.Padding(2);
            this.Luk.Name = "Luk";
            this.Luk.Size = new System.Drawing.Size(44, 20);
            this.Luk.TabIndex = 9;
            this.Luk.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // Hp
            // 
            this.Hp.Location = new System.Drawing.Point(195, 95);
            this.Hp.Margin = new System.Windows.Forms.Padding(2);
            this.Hp.Name = "Hp";
            this.Hp.Size = new System.Drawing.Size(44, 20);
            this.Hp.TabIndex = 10;
            this.Hp.ValueChanged += new System.EventHandler(this.numericUpDown7_ValueChanged);
            // 
            // Mp
            // 
            this.Mp.Location = new System.Drawing.Point(106, 95);
            this.Mp.Margin = new System.Windows.Forms.Padding(2);
            this.Mp.Name = "Mp";
            this.Mp.Size = new System.Drawing.Size(44, 20);
            this.Mp.TabIndex = 11;
            // 
            // Race
            // 
            this.Race.FormattingEnabled = true;
            this.Race.Items.AddRange(new object[] {
            "Human",
            "Elf",
            "Orc",
            "Dwarf",
            "Demon"});
            this.Race.Location = new System.Drawing.Point(16, 210);
            this.Race.Margin = new System.Windows.Forms.Padding(2);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(92, 21);
            this.Race.TabIndex = 12;
            this.Race.SelectedIndexChanged += new System.EventHandler(this.Race_SelectedIndexChanged);
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(16, 258);
            this.Save.Margin = new System.Windows.Forms.Padding(2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(77, 20);
            this.Save.TabIndex = 13;
            this.Save.Text = "New Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Faction
            // 
            this.Faction.FormattingEnabled = true;
            this.Faction.Items.AddRange(new object[] {
            "Malayan Empire",
            "Lycean Kingdom",
            "Atenean Dynasty"});
            this.Faction.Location = new System.Drawing.Point(148, 148);
            this.Faction.Margin = new System.Windows.Forms.Padding(2);
            this.Faction.Name = "Faction";
            this.Faction.Size = new System.Drawing.Size(92, 21);
            this.Faction.TabIndex = 14;
            this.Faction.SelectedIndexChanged += new System.EventHandler(this.Faction_SelectedIndexChanged);
            // 
            // Class
            // 
            this.Class.FormattingEnabled = true;
            this.Class.Items.AddRange(new object[] {
            "Warrior",
            "Archer",
            "Mage",
            "Rogue",
            "Cleric"});
            this.Class.Location = new System.Drawing.Point(148, 210);
            this.Class.Margin = new System.Windows.Forms.Padding(2);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(92, 21);
            this.Class.TabIndex = 15;
            this.Class.SelectedIndexChanged += new System.EventHandler(this.Class_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Gender";
            // 
            // Lvl
            // 
            this.Lvl.Location = new System.Drawing.Point(20, 95);
            this.Lvl.Margin = new System.Windows.Forms.Padding(2);
            this.Lvl.Name = "Lvl";
            this.Lvl.Size = new System.Drawing.Size(44, 20);
            this.Lvl.TabIndex = 17;
            this.Lvl.ValueChanged += new System.EventHandler(this.Lvl_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 77);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Level";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(106, 77);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "HP";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(195, 77);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "MP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(146, 130);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Faction";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 193);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 22;
            this.label7.Text = "Race";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(148, 192);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Class";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(158, 262);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(29, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "STR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(158, 303);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "DEX";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(161, 344);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "INT";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(156, 388);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(30, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "CON";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(156, 434);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "CHA";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(158, 476);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(28, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "LUK";
            // 
            // Mute
            // 
            this.Mute.Location = new System.Drawing.Point(16, 492);
            this.Mute.Margin = new System.Windows.Forms.Padding(2);
            this.Mute.Name = "Mute";
            this.Mute.Size = new System.Drawing.Size(30, 32);
            this.Mute.TabIndex = 30;
            this.Mute.UseVisualStyleBackColor = true;
            this.Mute.Click += new System.EventHandler(this.Mute_Click);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(16, 337);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(77, 20);
            this.Clear.TabIndex = 31;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.button1_Click);
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(16, 296);
            this.Update.Margin = new System.Windows.Forms.Padding(2);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(77, 20);
            this.Update.TabIndex = 32;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(326, 322);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 19);
            this.button1.TabIndex = 33;
            this.button1.Text = "Delete All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Delete
            // 
            this.Delete.Location = new System.Drawing.Point(16, 376);
            this.Delete.Margin = new System.Windows.Forms.Padding(2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(77, 20);
            this.Delete.TabIndex = 34;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(326, 360);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(121, 164);
            this.pictureBox1.TabIndex = 35;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(500, 376);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(55, 55);
            this.pictureBox2.TabIndex = 36;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(792, 476);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 45);
            this.button2.TabIndex = 38;
            this.button2.Text = "Enter Game\r\n";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 547);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.Mute);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Lvl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Faction);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Race);
            this.Controls.Add(this.Mp);
            this.Controls.Add(this.Hp);
            this.Controls.Add(this.Luk);
            this.Controls.Add(this.Cha);
            this.Controls.Add(this.Con);
            this.Controls.Add(this.Dex);
            this.Controls.Add(this.Int);
            this.Controls.Add(this.Str);
            this.Controls.Add(this.Gender);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.CName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "RPG Character Creator";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Str)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Int)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Con)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Luk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Mp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Lvl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CName;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Gender;
        private System.Windows.Forms.NumericUpDown Str;
        private System.Windows.Forms.NumericUpDown Int;
        private System.Windows.Forms.NumericUpDown Dex;
        private System.Windows.Forms.NumericUpDown Con;
        private System.Windows.Forms.NumericUpDown Cha;
        private System.Windows.Forms.NumericUpDown Luk;
        private System.Windows.Forms.NumericUpDown Hp;
        private System.Windows.Forms.NumericUpDown Mp;
        private System.Windows.Forms.ComboBox Race;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.ComboBox Faction;
        private System.Windows.Forms.ComboBox Class;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown Lvl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button Mute;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button2;
    }
}

