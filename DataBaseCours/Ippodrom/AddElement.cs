using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ippodrom
{
    public partial class AddElement : Form
    {
        
        public AddElement()
        {
            InitializeComponent();
        }
        int Mode = 0;
        public AddElement(int mode)
        {
            InitializeComponent();
            Mode = mode;
            switch (mode)
            {
                case 0:
                    ElementPicture.Image = Image.FromFile("horse-head.png");
                    ElementName.Text = "Add horse";
                    TrainerTB.Hide();
                    trainerLbl.Hide();
                    for(int i = 1; i<9;i++)
                    {
                        foreach(Control cntrl in flowLayoutPanel1.Controls)
                        {
                            if(cntrl.Name.Equals($"prtcp{i}"))
                            {
                                cntrl.Hide();
                            }
                            if(cntrl.Name.Equals($"prtcp{i}zone"))
                            {
                                cntrl.Hide();
                                break;
                            }
                        }
                    }
                    break;
                case 1:
                    ElementPicture.Image = Image.FromFile("horserider_horse_race-512-1.png");
                    ElementName.Text = "Add rider";
                    ColorCB.Hide();
                    colorlbl.Hide();
                    WeigthTB.Hide();
                    weigthlbl.Hide();
                    HeightTB.Hide();
                    heightlbl.Hide();
                    BirthDateMTB.Hide();
                    birthdatelbl.Hide();
                    MotherTB.Hide();
                    motherlbl.Hide();
                    FatherTB.Hide();
                    fatherlbl.Hide();
                    for (int i = 1; i < 9; i++)
                    {
                        foreach (Control cntrl in flowLayoutPanel1.Controls)
                        {
                            if (cntrl.Name.Equals($"prtcp{i}"))
                            {
                                cntrl.Hide();
                            }
                            if (cntrl.Name.Equals($"prtcp{i}zone"))
                            {
                                cntrl.Hide();
                                break;
                            }
                        }
                    }
                    break;
                case 2:
                    ElementPicture.Image = Image.FromFile("icon.png");
                    ElementName.Text = "Add lap";
                    AddButton.Image = Image.FromFile("horse-running-silhouette-facing-right.png");
                    AddButton.ImageAlign = ContentAlignment.MiddleCenter;
                    ColorCB.Hide();
                    colorlbl.Hide();
                    WeigthTB.Hide();
                    weigthlbl.Hide();
                    HeightTB.Hide();
                    heightlbl.Hide();
                    BirthDateMTB.Hide();
                    birthdatelbl.Hide();
                    MotherTB.Hide();
                    motherlbl.Hide();
                    FatherTB.Hide();
                    fatherlbl.Hide();
                    TrainerTB.Hide();
                    trainerLbl.Hide();
                    sexlbl.Hide();
                    SexCB.Hide();
                    break;
            }

        }

        private void AddElement_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ippodromDataSet1.Laps". При необходимости она может быть перемещена или удалена.
            this.lapsTableAdapter.Fill(this.ippodromDataSet1.Laps);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ippodromDataSet1.Colors". При необходимости она может быть перемещена или удалена.
            this.colorsTableAdapter.Fill(this.ippodromDataSet1.Colors);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ippodromDataSet1.Sex". При необходимости она может быть перемещена или удалена.
            this.sexTableAdapter.Fill(this.ippodromDataSet1.Sex);
            this.horsesTableAdapter1.Fill(this.ippodromDataSet1.Horses);
            this.countriesTableAdapter1.Fill(this.ippodromDataSet1.Countries);
            this.ridersTableAdapter1.Fill(this.ippodromDataSet1.Riders);
        }

        private string nullornot(int? ID)
        {
            return ID == null ? "NULL" : ID.ToString();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            int? motherid = null;
            int? fatherid = null;
            int? colorid = null;
            int? sexid = null;
            int? countryid = null;
            int? trainerid = null;
            if(Mode == 0)
            {
                foreach (IppodromDataSet1.HorsesRow horse in ippodromDataSet1.Horses)
                {
                    if ((motherid != null && fatherid != null) ||
                        (motherid != null && FatherTB.Text.Equals("")) ||
                        (MotherTB.Text.Equals("") && fatherid != null) ||
                        (MotherTB.Text.Equals("") && FatherTB.Text.Equals(""))
                        )
                        break;
                    if (horse.Name.Equals(MotherTB.Text))
                        motherid = horse.ID;
                    if (horse.Name.Equals(FatherTB.Text))
                        fatherid = horse.ID;
                }
                foreach (IppodromDataSet1.ColorsRow color in ippodromDataSet1.Colors)
                {
                    if (color.Name.Equals(ColorCB.Text))
                    {
                        colorid = color.ID;
                        break;
                    }
                }
                foreach (IppodromDataSet1.SexRow sex in ippodromDataSet1.Sex)
                {
                    if (sex.Name.Equals(SexCB.Text))
                    {
                        sexid = sex.ID;
                        break;
                    }
                }
                foreach (IppodromDataSet1.CountriesRow country in ippodromDataSet1.Countries)
                {
                    if (country.Name.Equals(CountryTB.Text))
                    {
                        countryid = country.ID;
                        break;
                    }
                }
                SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Ippodrom.mdf;Integrated Security=True");
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"INSERT INTO Horses(Name,FKID_Mother,FKID_Father,Weight,Heigth,FKID_Color,BirthDate,FKID_Sex,FKID_Country,WinNumber) VALUES('{NameTB.Text}',{nullornot(motherid)},{nullornot(fatherid)},{WeigthTB.Text},{HeightTB.Text},{nullornot(colorid)},'{BirthDateMTB.Text}',{nullornot(sexid)},{nullornot(countryid)},0)", sqlConnection);
                try
                {
                    if (sqlCommand.ExecuteNonQuery() == 1)
                        MessageBox.Show("Horse added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if(Mode == 1)
            {
                foreach (IppodromDataSet1.RidersRow trainer in ippodromDataSet1.Riders)
                {
                    if(trainer.Name == TrainerTB.Text)
                    {
                        trainerid = trainer.ID;
                        break;
                    }
                }
                foreach (IppodromDataSet1.SexRow sex in ippodromDataSet1.Sex)
                {
                    if (sex.Name.Equals(SexCB.Text))
                    {
                        sexid = sex.ID;
                        break;
                    }
                }
                foreach (IppodromDataSet1.CountriesRow country in ippodromDataSet1.Countries)
                {
                    if (country.Name.Equals(CountryTB.Text))
                    {
                        countryid = country.ID;
                        break;
                    }
                }
                SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Ippodrom.mdf;Integrated Security=True");
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"INSERT INTO Riders(Name,FKID_Sex,FKID_Country,FKID_Trainer,WinNumber) VALUES('{NameTB.Text}',{nullornot(sexid)},{nullornot(countryid)},{trainerid},0)", sqlConnection);
                try
                {
                    if (sqlCommand.ExecuteNonQuery() == 1)
                        MessageBox.Show("Rider added");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if(Mode == 2)
            {
                foreach (IppodromDataSet1.CountriesRow country in ippodromDataSet1.Countries)
                {
                    if (country.Name.Equals(CountryTB.Text))
                    {
                        countryid = country.ID;
                        break;
                    }
                }
                string[,] participants = new string[8, 2];
                int legalparticipants = 0;
                foreach(IppodromDataSet1.HorsesRow hrs in ippodromDataSet1.Horses)
                {
                    if(prtcp1htb.Text.Equals(hrs.Name))
                    {
                        legalparticipants++;
                        participants[0, 1] = hrs.Name;
                    }
                    if (prtcp2htb.Text.Equals(hrs.Name))
                    {
                        legalparticipants++;
                        participants[1, 1] = hrs.Name;
                    }
                    if (prtcp3htb.Text.Equals(hrs.Name))
                    {
                        legalparticipants++;
                        participants[2, 1] = hrs.Name;
                    }
                    if (prtcp4htb.Text.Equals(hrs.Name))
                    {
                        legalparticipants++;
                        participants[3, 1] = hrs.Name;
                    }
                    if (prtcp5htb.Text.Equals(hrs.Name))
                    {
                        legalparticipants++;
                        participants[4, 1] = hrs.Name;
                    }
                    if (prtcp6htb.Text.Equals(hrs.Name))
                    {
                        legalparticipants++;
                        participants[5, 1] = hrs.Name;
                    }
                    if (prtcp7htb.Text.Equals(hrs.Name))
                    {
                        legalparticipants++;
                        participants[6, 1] = hrs.Name;
                    }
                    if (prtcp8htb.Text.Equals(hrs.Name))
                    {
                        legalparticipants++;
                        participants[7, 1] = hrs.Name;
                    }
                }
                foreach (IppodromDataSet1.RidersRow rdr in ippodromDataSet1.Riders)
                {
                    if (prtcp1rtb.Text.Equals(rdr.Name))
                    {
                        legalparticipants++;
                        participants[0, 0] = rdr.Name;
                    }
                    if (prtcp2rtb.Text.Equals(rdr.Name))
                    {
                        legalparticipants++;
                        participants[1, 0] = rdr.Name;
                    }
                    if (prtcp3rtb.Text.Equals(rdr.Name))
                    {
                        legalparticipants++;
                        participants[2, 0] = rdr.Name;
                    }
                    if (prtcp4rtb.Text.Equals(rdr.Name))
                    {
                        legalparticipants++;
                        participants[3, 0] = rdr.Name;
                    }
                    if (prtcp5rtb.Text.Equals(rdr.Name))
                    {
                        legalparticipants++;
                        participants[4, 0] = rdr.Name;
                    }
                    if (prtcp6rtb.Text.Equals(rdr.Name))
                    {
                        legalparticipants++;
                        participants[5, 0] = rdr.Name;
                    }
                    if (prtcp7rtb.Text.Equals(rdr.Name))
                    {
                        legalparticipants++;
                        participants[6, 0] = rdr.Name;
                    }
                    if (prtcp8rtb.Text.Equals(rdr.Name))
                    {
                        legalparticipants++;
                        participants[7, 0] = rdr.Name;
                    }
                }
                if(legalparticipants<16)
                {
                    MessageBox.Show("Some of participants is illegal (we can`t find them in our data base);");
                    return;
                }
                Random random = new Random();
                string[] buf = new string[2];
                for(int i = 7;i>=1;i--)
                {
                    int j = random.Next(i+1);
                    for(int k = 0; k < 2;k++)
                        buf[k] = participants[j, k];
                    for (int k = 0; k < 2; k++)
                        participants[j,k] = participants[i, k];
                    for (int k = 0; k < 2; k++)
                        participants[i, k] = buf[k];
                }
                for(int i = 0; i < 8;i++)
                {
                    FlowLayoutPanel pn = new FlowLayoutPanel();
                    pn.AutoSize = true;
                    Label lbuf = new Label();
                    lbuf.AutoSize = true;
                    lbuf.Font = new Font(new FontFamily("Palatino Linotype"), 14);
                    lbuf.Text = $"{i + 1}. ";
                    Button Rbutton = new Button(), Hbutton = new Button();
                    Rbutton.Click += Rbutton_Click;
                    Rbutton.AutoSize = true;
                    Rbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
                    Rbutton.Image = Image.FromFile("horserider_horse_race-512-1.png"); 
                    Rbutton.Text = $"{ participants[i, 0]}";
                    Rbutton.Font = new Font(new FontFamily("Palatino Linotype"), 14);
                    Hbutton.Click += Hbutton_Click;
                    Hbutton.AutoSize = true;
                    Hbutton.TextImageRelation = TextImageRelation.ImageBeforeText;
                    Hbutton.Image = Image.FromFile("horse-head.png");
                    Hbutton.Text = $"{participants[i, 1]}";
                    Hbutton.Font = new Font(new FontFamily("Palatino Linotype"), 14);
                    pn.Controls.Add(lbuf);
                    pn.Controls.Add(Rbutton);
                    pn.Controls.Add(Hbutton);
                    flowLayoutPanel1.Controls.Add(pn);
                }
                int riderid = 0;
                int horseid = 0;
                foreach (IppodromDataSet1.RidersRow winrider in ippodromDataSet1.Riders)
                {
                    if(participants[0,0].Equals(winrider.Name))
                    {
                        riderid = winrider.ID;
                        break;
                    }
                }
                foreach (IppodromDataSet1.HorsesRow winhorse in ippodromDataSet1.Horses)
                {
                    if (participants[0, 1].Equals(winhorse.Name))
                    {
                        horseid = winhorse.ID;
                        break;
                    }
                }
                SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Ippodrom.mdf;Integrated Security=True");
                sqlConnection.Open();
                SqlCommand sqlCommand = new SqlCommand($"INSERT INTO Laps(Name,FKID_Country,RiderWinner,HorseWinner) VALUES('{NameTB.Text}',{countryid},{riderid},{horseid})", sqlConnection);
                try
                {
                    if (sqlCommand.ExecuteNonQuery() == 1)
                        MessageBox.Show("Lap added");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void Hbutton_Click(object sender, EventArgs e)
        {
            Button bttn = sender as Button;
            ShowElement showElement = new ShowElement(0, bttn.Text.ToString());
            showElement.Show();
        }

        private void Rbutton_Click(object sender, EventArgs e)
        {
            Button bttn = sender as Button;
            ShowElement showElement = new ShowElement(1, bttn.Text.ToString());
            showElement.Show();
        }

        private void ElementName_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
