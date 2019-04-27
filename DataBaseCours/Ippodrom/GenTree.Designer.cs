namespace Ippodrom
{
    partial class GenTree
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenTree));
            this.ippodromDataSet1 = new Ippodrom.IppodromDataSet1();
            this.colorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorsTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.ColorsTableAdapter();
            this.tableAdapterManager = new Ippodrom.IppodromDataSet1TableAdapters.TableAdapterManager();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.countriesTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.CountriesTableAdapter();
            this.horsesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horsesTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.HorsesTableAdapter();
            this.horseViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horseViewTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.HorseViewTableAdapter();
            this.lapsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lapsTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.LapsTableAdapter();
            this.lapViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lapViewTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.LapViewTableAdapter();
            this.ridersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ridersTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.RidersTableAdapter();
            this.riderViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.riderViewTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.RiderViewTableAdapter();
            this.sexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.sexTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.SexTableAdapter();
            this.SelfButton = new System.Windows.Forms.Button();
            this.mothbutton = new System.Windows.Forms.Button();
            this.grandma1button = new System.Windows.Forms.Button();
            this.grandfa1button = new System.Windows.Forms.Button();
            this.grandma2button = new System.Windows.Forms.Button();
            this.fathbutton = new System.Windows.Forms.Button();
            this.grandfa2button = new System.Windows.Forms.Button();
            this.ggrandma1button = new System.Windows.Forms.Button();
            this.ggrandfa1button = new System.Windows.Forms.Button();
            this.ggrandma2button = new System.Windows.Forms.Button();
            this.ggrandfa2button = new System.Windows.Forms.Button();
            this.ggrandma3button = new System.Windows.Forms.Button();
            this.ggrandfa3button = new System.Windows.Forms.Button();
            this.ggrandma4button = new System.Windows.Forms.Button();
            this.ggrandfa4button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ippodromDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horsesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lapsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lapViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.riderViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // ippodromDataSet1
            // 
            this.ippodromDataSet1.DataSetName = "IppodromDataSet1";
            this.ippodromDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // colorsBindingSource
            // 
            this.colorsBindingSource.DataMember = "Colors";
            this.colorsBindingSource.DataSource = this.ippodromDataSet1;
            // 
            // colorsTableAdapter
            // 
            this.colorsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ColorsTableAdapter = this.colorsTableAdapter;
            this.tableAdapterManager.CountriesTableAdapter = this.countriesTableAdapter;
            this.tableAdapterManager.HorsesTableAdapter = this.horsesTableAdapter;
            this.tableAdapterManager.LapsTableAdapter = this.lapsTableAdapter;
            this.tableAdapterManager.RidersTableAdapter = this.ridersTableAdapter;
            this.tableAdapterManager.SexTableAdapter = this.sexTableAdapter;
            this.tableAdapterManager.UpdateOrder = Ippodrom.IppodromDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.ippodromDataSet1;
            // 
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // horsesBindingSource
            // 
            this.horsesBindingSource.DataMember = "Horses";
            this.horsesBindingSource.DataSource = this.ippodromDataSet1;
            // 
            // horsesTableAdapter
            // 
            this.horsesTableAdapter.ClearBeforeFill = true;
            // 
            // horseViewBindingSource
            // 
            this.horseViewBindingSource.DataMember = "HorseView";
            this.horseViewBindingSource.DataSource = this.ippodromDataSet1;
            // 
            // horseViewTableAdapter
            // 
            this.horseViewTableAdapter.ClearBeforeFill = true;
            // 
            // lapsBindingSource
            // 
            this.lapsBindingSource.DataMember = "Laps";
            this.lapsBindingSource.DataSource = this.ippodromDataSet1;
            // 
            // lapsTableAdapter
            // 
            this.lapsTableAdapter.ClearBeforeFill = true;
            // 
            // lapViewBindingSource
            // 
            this.lapViewBindingSource.DataMember = "LapView";
            this.lapViewBindingSource.DataSource = this.ippodromDataSet1;
            // 
            // lapViewTableAdapter
            // 
            this.lapViewTableAdapter.ClearBeforeFill = true;
            // 
            // ridersBindingSource
            // 
            this.ridersBindingSource.DataMember = "Riders";
            this.ridersBindingSource.DataSource = this.ippodromDataSet1;
            // 
            // ridersTableAdapter
            // 
            this.ridersTableAdapter.ClearBeforeFill = true;
            // 
            // riderViewBindingSource
            // 
            this.riderViewBindingSource.DataMember = "RiderView";
            this.riderViewBindingSource.DataSource = this.ippodromDataSet1;
            // 
            // riderViewTableAdapter
            // 
            this.riderViewTableAdapter.ClearBeforeFill = true;
            // 
            // sexBindingSource
            // 
            this.sexBindingSource.DataMember = "Sex";
            this.sexBindingSource.DataSource = this.ippodromDataSet1;
            // 
            // sexTableAdapter
            // 
            this.sexTableAdapter.ClearBeforeFill = true;
            // 
            // SelfButton
            // 
            this.SelfButton.BackColor = System.Drawing.Color.White;
            this.SelfButton.Cursor = System.Windows.Forms.Cursors.Default;
            this.SelfButton.Image = ((System.Drawing.Image)(resources.GetObject("SelfButton.Image")));
            this.SelfButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelfButton.Location = new System.Drawing.Point(707, 9);
            this.SelfButton.Name = "SelfButton";
            this.SelfButton.Size = new System.Drawing.Size(187, 76);
            this.SelfButton.TabIndex = 0;
            this.SelfButton.Tag = "";
            this.SelfButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SelfButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SelfButton.UseVisualStyleBackColor = false;
            this.SelfButton.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // mothbutton
            // 
            this.mothbutton.BackColor = System.Drawing.Color.White;
            this.mothbutton.Image = ((System.Drawing.Image)(resources.GetObject("mothbutton.Image")));
            this.mothbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mothbutton.Location = new System.Drawing.Point(309, 97);
            this.mothbutton.Name = "mothbutton";
            this.mothbutton.Size = new System.Drawing.Size(187, 76);
            this.mothbutton.TabIndex = 1;
            this.mothbutton.Text = "Mother: ";
            this.mothbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mothbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.mothbutton.UseVisualStyleBackColor = false;
            this.mothbutton.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // grandma1button
            // 
            this.grandma1button.BackColor = System.Drawing.Color.White;
            this.grandma1button.Image = ((System.Drawing.Image)(resources.GetObject("grandma1button.Image")));
            this.grandma1button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grandma1button.Location = new System.Drawing.Point(110, 190);
            this.grandma1button.Name = "grandma1button";
            this.grandma1button.Size = new System.Drawing.Size(187, 76);
            this.grandma1button.TabIndex = 2;
            this.grandma1button.Text = "Grandmother:              ";
            this.grandma1button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grandma1button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.grandma1button.UseVisualStyleBackColor = false;
            this.grandma1button.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // grandfa1button
            // 
            this.grandfa1button.BackColor = System.Drawing.Color.White;
            this.grandfa1button.Image = ((System.Drawing.Image)(resources.GetObject("grandfa1button.Image")));
            this.grandfa1button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grandfa1button.Location = new System.Drawing.Point(508, 190);
            this.grandfa1button.Name = "grandfa1button";
            this.grandfa1button.Size = new System.Drawing.Size(187, 76);
            this.grandfa1button.TabIndex = 3;
            this.grandfa1button.Text = "Grandfather:              ";
            this.grandfa1button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grandfa1button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.grandfa1button.UseVisualStyleBackColor = false;
            this.grandfa1button.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // grandma2button
            // 
            this.grandma2button.BackColor = System.Drawing.Color.White;
            this.grandma2button.Image = ((System.Drawing.Image)(resources.GetObject("grandma2button.Image")));
            this.grandma2button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grandma2button.Location = new System.Drawing.Point(906, 190);
            this.grandma2button.Name = "grandma2button";
            this.grandma2button.Size = new System.Drawing.Size(187, 76);
            this.grandma2button.TabIndex = 4;
            this.grandma2button.Text = "Grandmother:              ";
            this.grandma2button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grandma2button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.grandma2button.UseVisualStyleBackColor = false;
            this.grandma2button.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // fathbutton
            // 
            this.fathbutton.BackColor = System.Drawing.Color.White;
            this.fathbutton.Image = ((System.Drawing.Image)(resources.GetObject("fathbutton.Image")));
            this.fathbutton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fathbutton.Location = new System.Drawing.Point(1105, 97);
            this.fathbutton.Name = "fathbutton";
            this.fathbutton.Size = new System.Drawing.Size(187, 76);
            this.fathbutton.TabIndex = 5;
            this.fathbutton.Text = "Father: ";
            this.fathbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fathbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.fathbutton.UseVisualStyleBackColor = false;
            this.fathbutton.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // grandfa2button
            // 
            this.grandfa2button.BackColor = System.Drawing.Color.White;
            this.grandfa2button.Image = ((System.Drawing.Image)(resources.GetObject("grandfa2button.Image")));
            this.grandfa2button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grandfa2button.Location = new System.Drawing.Point(1304, 190);
            this.grandfa2button.Name = "grandfa2button";
            this.grandfa2button.Size = new System.Drawing.Size(187, 76);
            this.grandfa2button.TabIndex = 6;
            this.grandfa2button.Text = "Grandfather:               ";
            this.grandfa2button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.grandfa2button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.grandfa2button.UseVisualStyleBackColor = false;
            this.grandfa2button.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // ggrandma1button
            // 
            this.ggrandma1button.BackColor = System.Drawing.Color.White;
            this.ggrandma1button.Image = ((System.Drawing.Image)(resources.GetObject("ggrandma1button.Image")));
            this.ggrandma1button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandma1button.Location = new System.Drawing.Point(10, 285);
            this.ggrandma1button.Name = "ggrandma1button";
            this.ggrandma1button.Size = new System.Drawing.Size(188, 76);
            this.ggrandma1button.TabIndex = 7;
            this.ggrandma1button.Text = "Great-grandmother:       ";
            this.ggrandma1button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandma1button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ggrandma1button.UseVisualStyleBackColor = false;
            this.ggrandma1button.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // ggrandfa1button
            // 
            this.ggrandfa1button.BackColor = System.Drawing.Color.White;
            this.ggrandfa1button.Image = ((System.Drawing.Image)(resources.GetObject("ggrandfa1button.Image")));
            this.ggrandfa1button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandfa1button.Location = new System.Drawing.Point(209, 285);
            this.ggrandfa1button.Name = "ggrandfa1button";
            this.ggrandfa1button.Size = new System.Drawing.Size(188, 76);
            this.ggrandfa1button.TabIndex = 8;
            this.ggrandfa1button.Text = "Great-grandfather:       ";
            this.ggrandfa1button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandfa1button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ggrandfa1button.UseVisualStyleBackColor = false;
            this.ggrandfa1button.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // ggrandma2button
            // 
            this.ggrandma2button.BackColor = System.Drawing.Color.White;
            this.ggrandma2button.Image = ((System.Drawing.Image)(resources.GetObject("ggrandma2button.Image")));
            this.ggrandma2button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandma2button.Location = new System.Drawing.Point(408, 285);
            this.ggrandma2button.Name = "ggrandma2button";
            this.ggrandma2button.Size = new System.Drawing.Size(188, 76);
            this.ggrandma2button.TabIndex = 9;
            this.ggrandma2button.Text = "Great-grandmother:       ";
            this.ggrandma2button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandma2button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ggrandma2button.UseVisualStyleBackColor = false;
            this.ggrandma2button.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // ggrandfa2button
            // 
            this.ggrandfa2button.BackColor = System.Drawing.Color.White;
            this.ggrandfa2button.Image = ((System.Drawing.Image)(resources.GetObject("ggrandfa2button.Image")));
            this.ggrandfa2button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandfa2button.Location = new System.Drawing.Point(607, 285);
            this.ggrandfa2button.Name = "ggrandfa2button";
            this.ggrandfa2button.Size = new System.Drawing.Size(188, 76);
            this.ggrandfa2button.TabIndex = 10;
            this.ggrandfa2button.Text = "Great-grandfather:       ";
            this.ggrandfa2button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandfa2button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ggrandfa2button.UseVisualStyleBackColor = false;
            this.ggrandfa2button.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // ggrandma3button
            // 
            this.ggrandma3button.BackColor = System.Drawing.Color.White;
            this.ggrandma3button.Image = ((System.Drawing.Image)(resources.GetObject("ggrandma3button.Image")));
            this.ggrandma3button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandma3button.Location = new System.Drawing.Point(806, 284);
            this.ggrandma3button.Name = "ggrandma3button";
            this.ggrandma3button.Size = new System.Drawing.Size(188, 76);
            this.ggrandma3button.TabIndex = 11;
            this.ggrandma3button.Text = "Great-grandmother:        ";
            this.ggrandma3button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandma3button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ggrandma3button.UseVisualStyleBackColor = false;
            this.ggrandma3button.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // ggrandfa3button
            // 
            this.ggrandfa3button.BackColor = System.Drawing.Color.White;
            this.ggrandfa3button.Image = ((System.Drawing.Image)(resources.GetObject("ggrandfa3button.Image")));
            this.ggrandfa3button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandfa3button.Location = new System.Drawing.Point(1005, 285);
            this.ggrandfa3button.Name = "ggrandfa3button";
            this.ggrandfa3button.Size = new System.Drawing.Size(188, 76);
            this.ggrandfa3button.TabIndex = 12;
            this.ggrandfa3button.Text = "Great-grandfather:       ";
            this.ggrandfa3button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandfa3button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ggrandfa3button.UseVisualStyleBackColor = false;
            this.ggrandfa3button.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // ggrandma4button
            // 
            this.ggrandma4button.BackColor = System.Drawing.Color.White;
            this.ggrandma4button.Image = ((System.Drawing.Image)(resources.GetObject("ggrandma4button.Image")));
            this.ggrandma4button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandma4button.Location = new System.Drawing.Point(1204, 286);
            this.ggrandma4button.Name = "ggrandma4button";
            this.ggrandma4button.Size = new System.Drawing.Size(188, 76);
            this.ggrandma4button.TabIndex = 13;
            this.ggrandma4button.Text = "Great-grandmother:       ";
            this.ggrandma4button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandma4button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ggrandma4button.UseVisualStyleBackColor = false;
            this.ggrandma4button.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // ggrandfa4button
            // 
            this.ggrandfa4button.BackColor = System.Drawing.Color.White;
            this.ggrandfa4button.Image = ((System.Drawing.Image)(resources.GetObject("ggrandfa4button.Image")));
            this.ggrandfa4button.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandfa4button.Location = new System.Drawing.Point(1403, 285);
            this.ggrandfa4button.Name = "ggrandfa4button";
            this.ggrandfa4button.Size = new System.Drawing.Size(188, 76);
            this.ggrandfa4button.TabIndex = 14;
            this.ggrandfa4button.Text = "Great-grandfather:       ";
            this.ggrandfa4button.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ggrandfa4button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ggrandfa4button.UseVisualStyleBackColor = false;
            this.ggrandfa4button.Click += new System.EventHandler(this.SelfButton_Click);
            // 
            // GenTree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1602, 372);
            this.Controls.Add(this.ggrandfa4button);
            this.Controls.Add(this.ggrandma4button);
            this.Controls.Add(this.ggrandfa3button);
            this.Controls.Add(this.ggrandma3button);
            this.Controls.Add(this.ggrandfa2button);
            this.Controls.Add(this.ggrandma2button);
            this.Controls.Add(this.ggrandfa1button);
            this.Controls.Add(this.ggrandma1button);
            this.Controls.Add(this.grandfa2button);
            this.Controls.Add(this.fathbutton);
            this.Controls.Add(this.grandma2button);
            this.Controls.Add(this.grandfa1button);
            this.Controls.Add(this.grandma1button);
            this.Controls.Add(this.mothbutton);
            this.Controls.Add(this.SelfButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GenTree";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "GenTree";
            this.Load += new System.EventHandler(this.GenTree_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ippodromDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.colorsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.countriesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horsesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.horseViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lapsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lapViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ridersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.riderViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private IppodromDataSet1 ippodromDataSet1;
        private System.Windows.Forms.BindingSource colorsBindingSource;
        private IppodromDataSet1TableAdapters.ColorsTableAdapter colorsTableAdapter;
        private IppodromDataSet1TableAdapters.TableAdapterManager tableAdapterManager;
        private IppodromDataSet1TableAdapters.CountriesTableAdapter countriesTableAdapter;
        private System.Windows.Forms.BindingSource countriesBindingSource;
        private IppodromDataSet1TableAdapters.HorsesTableAdapter horsesTableAdapter;
        private System.Windows.Forms.BindingSource horsesBindingSource;
        private System.Windows.Forms.BindingSource horseViewBindingSource;
        private IppodromDataSet1TableAdapters.HorseViewTableAdapter horseViewTableAdapter;
        private IppodromDataSet1TableAdapters.LapsTableAdapter lapsTableAdapter;
        private System.Windows.Forms.BindingSource lapsBindingSource;
        private System.Windows.Forms.BindingSource lapViewBindingSource;
        private IppodromDataSet1TableAdapters.LapViewTableAdapter lapViewTableAdapter;
        private IppodromDataSet1TableAdapters.RidersTableAdapter ridersTableAdapter;
        private System.Windows.Forms.BindingSource ridersBindingSource;
        private System.Windows.Forms.BindingSource riderViewBindingSource;
        private IppodromDataSet1TableAdapters.RiderViewTableAdapter riderViewTableAdapter;
        private IppodromDataSet1TableAdapters.SexTableAdapter sexTableAdapter;
        private System.Windows.Forms.BindingSource sexBindingSource;
        private System.Windows.Forms.Button SelfButton;
        private System.Windows.Forms.Button mothbutton;
        private System.Windows.Forms.Button grandma1button;
        private System.Windows.Forms.Button grandfa1button;
        private System.Windows.Forms.Button grandma2button;
        private System.Windows.Forms.Button fathbutton;
        private System.Windows.Forms.Button grandfa2button;
        private System.Windows.Forms.Button ggrandma1button;
        private System.Windows.Forms.Button ggrandfa1button;
        private System.Windows.Forms.Button ggrandma2button;
        private System.Windows.Forms.Button ggrandfa2button;
        private System.Windows.Forms.Button ggrandma3button;
        private System.Windows.Forms.Button ggrandfa3button;
        private System.Windows.Forms.Button ggrandma4button;
        private System.Windows.Forms.Button ggrandfa4button;
    }
}