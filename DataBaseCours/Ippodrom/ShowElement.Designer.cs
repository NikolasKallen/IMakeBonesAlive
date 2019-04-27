namespace Ippodrom
{
    partial class ShowElement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShowElement));
            this.ElementName = new System.Windows.Forms.Label();
            this.ElementPicture = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ippodromDataSet11 = new Ippodrom.IppodromDataSet1();
            this.Colorlbl = new System.Windows.Forms.Label();
            this.colortb = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.weightlbl = new System.Windows.Forms.Label();
            this.weighttb = new System.Windows.Forms.Label();
            this.heigthlbl = new System.Windows.Forms.Label();
            this.heigthtb = new System.Windows.Forms.Label();
            this.sexlbl = new System.Windows.Forms.Label();
            this.sextb = new System.Windows.Forms.Label();
            this.countrylbl = new System.Windows.Forms.Label();
            this.countrytb = new System.Windows.Forms.Label();
            this.birthlbl = new System.Windows.Forms.Label();
            this.birthtb = new System.Windows.Forms.Label();
            this.winnumlbl = new System.Windows.Forms.Label();
            this.winnumtb = new System.Windows.Forms.Label();
            this.motherlbl = new System.Windows.Forms.Label();
            this.mothertb = new System.Windows.Forms.Label();
            this.fatherlbl = new System.Windows.Forms.Label();
            this.fathertb = new System.Windows.Forms.Label();
            this.trainerlbl = new System.Windows.Forms.Label();
            this.trainertb = new System.Windows.Forms.Label();
            this.horsewinnerlbl = new System.Windows.Forms.Label();
            this.horsewinnertb = new System.Windows.Forms.Label();
            this.riderwinnerlbl = new System.Windows.Forms.Label();
            this.riderwinnertb = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.colorsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.colorsTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.ColorsTableAdapter();
            this.tableAdapterManager = new Ippodrom.IppodromDataSet1TableAdapters.TableAdapterManager();
            this.countriesTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.CountriesTableAdapter();
            this.horsesTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.HorsesTableAdapter();
            this.lapsTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.LapsTableAdapter();
            this.ridersTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.RidersTableAdapter();
            this.sexTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.SexTableAdapter();
            this.countriesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horsesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horseViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.horseViewTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.HorseViewTableAdapter();
            this.lapsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lapViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lapViewTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.LapViewTableAdapter();
            this.ridersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.riderViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.riderViewTableAdapter = new Ippodrom.IppodromDataSet1TableAdapters.RiderViewTableAdapter();
            this.sexBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ElementPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ippodromDataSet11)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
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
            // ElementName
            // 
            this.ElementName.AutoSize = true;
            this.ElementName.BackColor = System.Drawing.SystemColors.Window;
            this.ElementName.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ElementName.Location = new System.Drawing.Point(326, 12);
            this.ElementName.Name = "ElementName";
            this.ElementName.Size = new System.Drawing.Size(220, 39);
            this.ElementName.TabIndex = 23;
            this.ElementName.Text = "Name of object";
            // 
            // ElementPicture
            // 
            this.ElementPicture.Image = ((System.Drawing.Image)(resources.GetObject("ElementPicture.Image")));
            this.ElementPicture.Location = new System.Drawing.Point(108, 12);
            this.ElementPicture.Name = "ElementPicture";
            this.ElementPicture.Size = new System.Drawing.Size(70, 70);
            this.ElementPicture.TabIndex = 24;
            this.ElementPicture.TabStop = false;
            this.ElementPicture.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.ElementPicture.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ElementPicture.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(756, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 32);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // ippodromDataSet11
            // 
            this.ippodromDataSet11.DataSetName = "IppodromDataSet1";
            this.ippodromDataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Colorlbl
            // 
            this.Colorlbl.AutoSize = true;
            this.Colorlbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Colorlbl.Location = new System.Drawing.Point(3, 0);
            this.Colorlbl.Name = "Colorlbl";
            this.Colorlbl.Size = new System.Drawing.Size(61, 26);
            this.Colorlbl.TabIndex = 26;
            this.Colorlbl.Text = "Color:";
            // 
            // colortb
            // 
            this.colortb.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colortb.Location = new System.Drawing.Point(70, 0);
            this.colortb.Name = "colortb";
            this.colortb.Size = new System.Drawing.Size(679, 26);
            this.colortb.TabIndex = 27;
            this.colortb.Text = "ColorVal";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.Colorlbl);
            this.flowLayoutPanel1.Controls.Add(this.colortb);
            this.flowLayoutPanel1.Controls.Add(this.weightlbl);
            this.flowLayoutPanel1.Controls.Add(this.weighttb);
            this.flowLayoutPanel1.Controls.Add(this.heigthlbl);
            this.flowLayoutPanel1.Controls.Add(this.heigthtb);
            this.flowLayoutPanel1.Controls.Add(this.sexlbl);
            this.flowLayoutPanel1.Controls.Add(this.sextb);
            this.flowLayoutPanel1.Controls.Add(this.countrylbl);
            this.flowLayoutPanel1.Controls.Add(this.countrytb);
            this.flowLayoutPanel1.Controls.Add(this.birthlbl);
            this.flowLayoutPanel1.Controls.Add(this.birthtb);
            this.flowLayoutPanel1.Controls.Add(this.winnumlbl);
            this.flowLayoutPanel1.Controls.Add(this.winnumtb);
            this.flowLayoutPanel1.Controls.Add(this.motherlbl);
            this.flowLayoutPanel1.Controls.Add(this.mothertb);
            this.flowLayoutPanel1.Controls.Add(this.fatherlbl);
            this.flowLayoutPanel1.Controls.Add(this.fathertb);
            this.flowLayoutPanel1.Controls.Add(this.trainerlbl);
            this.flowLayoutPanel1.Controls.Add(this.trainertb);
            this.flowLayoutPanel1.Controls.Add(this.horsewinnerlbl);
            this.flowLayoutPanel1.Controls.Add(this.horsewinnertb);
            this.flowLayoutPanel1.Controls.Add(this.riderwinnerlbl);
            this.flowLayoutPanel1.Controls.Add(this.riderwinnertb);
            this.flowLayoutPanel1.Controls.Add(this.button1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(786, 380);
            this.flowLayoutPanel1.TabIndex = 30;
            this.flowLayoutPanel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.flowLayoutPanel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.flowLayoutPanel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            // 
            // weightlbl
            // 
            this.weightlbl.AutoSize = true;
            this.weightlbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weightlbl.Location = new System.Drawing.Point(3, 26);
            this.weightlbl.Name = "weightlbl";
            this.weightlbl.Size = new System.Drawing.Size(76, 26);
            this.weightlbl.TabIndex = 28;
            this.weightlbl.Text = "Weight:";
            // 
            // weighttb
            // 
            this.weighttb.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.weighttb.Location = new System.Drawing.Point(85, 26);
            this.weighttb.Name = "weighttb";
            this.weighttb.Size = new System.Drawing.Size(664, 26);
            this.weighttb.TabIndex = 29;
            this.weighttb.Text = "ColorVal";
            // 
            // heigthlbl
            // 
            this.heigthlbl.AutoSize = true;
            this.heigthlbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heigthlbl.Location = new System.Drawing.Point(3, 52);
            this.heigthlbl.Name = "heigthlbl";
            this.heigthlbl.Size = new System.Drawing.Size(74, 26);
            this.heigthlbl.TabIndex = 30;
            this.heigthlbl.Text = "Heigth:";
            // 
            // heigthtb
            // 
            this.heigthtb.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.heigthtb.Location = new System.Drawing.Point(83, 52);
            this.heigthtb.Name = "heigthtb";
            this.heigthtb.Size = new System.Drawing.Size(666, 26);
            this.heigthtb.TabIndex = 31;
            this.heigthtb.Text = "ColorVal";
            // 
            // sexlbl
            // 
            this.sexlbl.AutoSize = true;
            this.sexlbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sexlbl.Location = new System.Drawing.Point(3, 78);
            this.sexlbl.Name = "sexlbl";
            this.sexlbl.Size = new System.Drawing.Size(46, 26);
            this.sexlbl.TabIndex = 32;
            this.sexlbl.Text = "Sex:";
            // 
            // sextb
            // 
            this.sextb.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sextb.Location = new System.Drawing.Point(55, 78);
            this.sextb.Name = "sextb";
            this.sextb.Size = new System.Drawing.Size(694, 26);
            this.sextb.TabIndex = 33;
            this.sextb.Text = "ColorVal";
            // 
            // countrylbl
            // 
            this.countrylbl.AutoSize = true;
            this.countrylbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countrylbl.Location = new System.Drawing.Point(3, 104);
            this.countrylbl.Name = "countrylbl";
            this.countrylbl.Size = new System.Drawing.Size(85, 26);
            this.countrylbl.TabIndex = 34;
            this.countrylbl.Text = "Country:";
            // 
            // countrytb
            // 
            this.countrytb.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.countrytb.Location = new System.Drawing.Point(94, 104);
            this.countrytb.Name = "countrytb";
            this.countrytb.Size = new System.Drawing.Size(655, 26);
            this.countrytb.TabIndex = 35;
            this.countrytb.Text = "ColorVal";
            // 
            // birthlbl
            // 
            this.birthlbl.AutoSize = true;
            this.birthlbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthlbl.Location = new System.Drawing.Point(3, 130);
            this.birthlbl.Name = "birthlbl";
            this.birthlbl.Size = new System.Drawing.Size(98, 26);
            this.birthlbl.TabIndex = 36;
            this.birthlbl.Text = "BirthDate:";
            // 
            // birthtb
            // 
            this.birthtb.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.birthtb.Location = new System.Drawing.Point(107, 130);
            this.birthtb.Name = "birthtb";
            this.birthtb.Size = new System.Drawing.Size(642, 26);
            this.birthtb.TabIndex = 37;
            this.birthtb.Text = "ColorVal";
            // 
            // winnumlbl
            // 
            this.winnumlbl.AutoSize = true;
            this.winnumlbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winnumlbl.Location = new System.Drawing.Point(3, 156);
            this.winnumlbl.Name = "winnumlbl";
            this.winnumlbl.Size = new System.Drawing.Size(131, 26);
            this.winnumlbl.TabIndex = 38;
            this.winnumlbl.Text = "Wins number:";
            // 
            // winnumtb
            // 
            this.winnumtb.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.winnumtb.Location = new System.Drawing.Point(140, 156);
            this.winnumtb.Name = "winnumtb";
            this.winnumtb.Size = new System.Drawing.Size(607, 26);
            this.winnumtb.TabIndex = 39;
            this.winnumtb.Text = "ColorVal";
            // 
            // motherlbl
            // 
            this.motherlbl.AutoSize = true;
            this.motherlbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.motherlbl.Location = new System.Drawing.Point(3, 182);
            this.motherlbl.Name = "motherlbl";
            this.motherlbl.Size = new System.Drawing.Size(78, 26);
            this.motherlbl.TabIndex = 40;
            this.motherlbl.Text = "Mother:";
            // 
            // mothertb
            // 
            this.mothertb.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mothertb.Location = new System.Drawing.Point(87, 182);
            this.mothertb.Name = "mothertb";
            this.mothertb.Size = new System.Drawing.Size(679, 26);
            this.mothertb.TabIndex = 41;
            this.mothertb.Text = "ColorVal";
            // 
            // fatherlbl
            // 
            this.fatherlbl.AutoSize = true;
            this.fatherlbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fatherlbl.Location = new System.Drawing.Point(3, 208);
            this.fatherlbl.Name = "fatherlbl";
            this.fatherlbl.Size = new System.Drawing.Size(70, 26);
            this.fatherlbl.TabIndex = 42;
            this.fatherlbl.Text = "Father:";
            // 
            // fathertb
            // 
            this.fathertb.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fathertb.Location = new System.Drawing.Point(79, 208);
            this.fathertb.Name = "fathertb";
            this.fathertb.Size = new System.Drawing.Size(679, 26);
            this.fathertb.TabIndex = 43;
            this.fathertb.Text = "ColorVal";
            // 
            // trainerlbl
            // 
            this.trainerlbl.AutoSize = true;
            this.trainerlbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainerlbl.Location = new System.Drawing.Point(3, 234);
            this.trainerlbl.Name = "trainerlbl";
            this.trainerlbl.Size = new System.Drawing.Size(78, 26);
            this.trainerlbl.TabIndex = 44;
            this.trainerlbl.Text = "Trainer:";
            // 
            // trainertb
            // 
            this.trainertb.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.trainertb.Location = new System.Drawing.Point(87, 234);
            this.trainertb.Name = "trainertb";
            this.trainertb.Size = new System.Drawing.Size(679, 26);
            this.trainertb.TabIndex = 45;
            this.trainertb.Text = "ColorVal";
            // 
            // horsewinnerlbl
            // 
            this.horsewinnerlbl.AutoSize = true;
            this.horsewinnerlbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.horsewinnerlbl.Location = new System.Drawing.Point(3, 260);
            this.horsewinnerlbl.Name = "horsewinnerlbl";
            this.horsewinnerlbl.Size = new System.Drawing.Size(135, 26);
            this.horsewinnerlbl.TabIndex = 46;
            this.horsewinnerlbl.Text = "Horse winner :";
            // 
            // horsewinnertb
            // 
            this.horsewinnertb.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.horsewinnertb.Location = new System.Drawing.Point(144, 260);
            this.horsewinnertb.Name = "horsewinnertb";
            this.horsewinnertb.Size = new System.Drawing.Size(557, 26);
            this.horsewinnertb.TabIndex = 47;
            this.horsewinnertb.Text = "ColorVal";
            // 
            // riderwinnerlbl
            // 
            this.riderwinnerlbl.AutoSize = true;
            this.riderwinnerlbl.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.riderwinnerlbl.Location = new System.Drawing.Point(3, 286);
            this.riderwinnerlbl.Name = "riderwinnerlbl";
            this.riderwinnerlbl.Size = new System.Drawing.Size(130, 26);
            this.riderwinnerlbl.TabIndex = 48;
            this.riderwinnerlbl.Text = "Rider winner :";
            // 
            // riderwinnertb
            // 
            this.riderwinnertb.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.riderwinnertb.Location = new System.Drawing.Point(139, 286);
            this.riderwinnertb.Name = "riderwinnertb";
            this.riderwinnertb.Size = new System.Drawing.Size(557, 26);
            this.riderwinnertb.TabIndex = 49;
            this.riderwinnertb.Text = "ColorVal";
            // 
            // button1
            // 
            this.button1.AutoEllipsis = true;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(3, 315);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 44);
            this.button1.TabIndex = 50;
            this.button1.Text = "Genealogic Tree";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // colorsBindingSource
            // 
            this.colorsBindingSource.DataMember = "Colors";
            this.colorsBindingSource.DataSource = this.ippodromDataSet11;
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
            // countriesTableAdapter
            // 
            this.countriesTableAdapter.ClearBeforeFill = true;
            // 
            // horsesTableAdapter
            // 
            this.horsesTableAdapter.ClearBeforeFill = true;
            // 
            // lapsTableAdapter
            // 
            this.lapsTableAdapter.ClearBeforeFill = true;
            // 
            // ridersTableAdapter
            // 
            this.ridersTableAdapter.ClearBeforeFill = true;
            // 
            // sexTableAdapter
            // 
            this.sexTableAdapter.ClearBeforeFill = true;
            // 
            // countriesBindingSource
            // 
            this.countriesBindingSource.DataMember = "Countries";
            this.countriesBindingSource.DataSource = this.ippodromDataSet11;
            // 
            // horsesBindingSource
            // 
            this.horsesBindingSource.DataMember = "Horses";
            this.horsesBindingSource.DataSource = this.ippodromDataSet11;
            // 
            // horseViewBindingSource
            // 
            this.horseViewBindingSource.DataMember = "HorseView";
            this.horseViewBindingSource.DataSource = this.ippodromDataSet11;
            // 
            // horseViewTableAdapter
            // 
            this.horseViewTableAdapter.ClearBeforeFill = true;
            // 
            // lapsBindingSource
            // 
            this.lapsBindingSource.DataMember = "Laps";
            this.lapsBindingSource.DataSource = this.ippodromDataSet11;
            // 
            // lapViewBindingSource
            // 
            this.lapViewBindingSource.DataMember = "LapView";
            this.lapViewBindingSource.DataSource = this.ippodromDataSet11;
            // 
            // lapViewTableAdapter
            // 
            this.lapViewTableAdapter.ClearBeforeFill = true;
            // 
            // ridersBindingSource
            // 
            this.ridersBindingSource.DataMember = "Riders";
            this.ridersBindingSource.DataSource = this.ippodromDataSet11;
            // 
            // riderViewBindingSource
            // 
            this.riderViewBindingSource.DataMember = "RiderView";
            this.riderViewBindingSource.DataSource = this.ippodromDataSet11;
            // 
            // riderViewTableAdapter
            // 
            this.riderViewTableAdapter.ClearBeforeFill = true;
            // 
            // sexBindingSource
            // 
            this.sexBindingSource.DataMember = "Sex";
            this.sexBindingSource.DataSource = this.ippodromDataSet11;
            // 
            // ShowElement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.ElementName);
            this.Controls.Add(this.ElementPicture);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ShowElement";
            this.Text = "ShowElement";
            this.Load += new System.EventHandler(this.ShowElement_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.ElementPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ippodromDataSet11)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ElementName;
        private System.Windows.Forms.PictureBox ElementPicture;
        private System.Windows.Forms.PictureBox pictureBox1;
        private IppodromDataSet1 ippodromDataSet11;
        private System.Windows.Forms.Label Colorlbl;
        private System.Windows.Forms.Label colortb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label weightlbl;
        private System.Windows.Forms.Label weighttb;
        private System.Windows.Forms.Label heigthlbl;
        private System.Windows.Forms.Label heigthtb;
        private System.Windows.Forms.Label sexlbl;
        private System.Windows.Forms.Label sextb;
        private System.Windows.Forms.Label countrylbl;
        private System.Windows.Forms.Label countrytb;
        private System.Windows.Forms.Label birthlbl;
        private System.Windows.Forms.Label birthtb;
        private System.Windows.Forms.Label winnumlbl;
        private System.Windows.Forms.Label winnumtb;
        private System.Windows.Forms.Label motherlbl;
        private System.Windows.Forms.Label mothertb;
        private System.Windows.Forms.Label fatherlbl;
        private System.Windows.Forms.Label fathertb;
        private System.Windows.Forms.Label trainerlbl;
        private System.Windows.Forms.Label trainertb;
        private System.Windows.Forms.Label horsewinnerlbl;
        private System.Windows.Forms.Label horsewinnertb;
        private System.Windows.Forms.Label riderwinnerlbl;
        private System.Windows.Forms.Label riderwinnertb;
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
        private System.Windows.Forms.Button button1;
    }
}