using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ippodrom
{
    public partial class ShowElement : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;
        string SName = null;
        IppodromDataSet1.HorsesRow ShowHorse = null;
        IppodromDataSet1.RidersRow ShowRider = null;
        IppodromDataSet1.LapsRow ShowLap = null;
        List<Control> HorseFormControlsNI;
        List<Control> RiderFormControlsNI;
        List<Control> CupFormControlsNI;

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            int xOffset;
            int yOffset;

            if (e.Button == MouseButtons.Left)
            {
                xOffset = -e.X - SystemInformation.FrameBorderSize.Width;
                yOffset = -e.Y - SystemInformation.CaptionHeight -
                    SystemInformation.FrameBorderSize.Height;
                mouseOffset = new Point(xOffset, yOffset);
                isMouseDown = true;
            }
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isMouseDown)
            {
                Point mousePos = Control.MousePosition;
                mousePos.Offset(mouseOffset.X, mouseOffset.Y);
                Location = mousePos;
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isMouseDown = false;
            }
        }
        public ShowElement()
        {
            InitializeComponent();
        }
        int Mode = 0;

        public ShowElement(int mode, string name)
        {
            InitializeComponent();
            Mode = mode;
            SName = name;
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = new Bitmap("errorhov.png");
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            pictureBox1.BackgroundImage = new Bitmap("error3.png");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void colorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.colorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ippodromDataSet11);

        }

        private void ShowElement_Load(object sender, EventArgs e)
        {
            this.sexTableAdapter.Fill(this.ippodromDataSet11.Sex);
            this.riderViewTableAdapter.Fill(this.ippodromDataSet11.RiderView);
            this.ridersTableAdapter.Fill(this.ippodromDataSet11.Riders);
            this.lapViewTableAdapter.Fill(this.ippodromDataSet11.LapView);
            this.lapsTableAdapter.Fill(this.ippodromDataSet11.Laps);
            this.horseViewTableAdapter.Fill(this.ippodromDataSet11.HorseView);
            this.horsesTableAdapter.Fill(this.ippodromDataSet11.Horses);
            this.countriesTableAdapter.Fill(this.ippodromDataSet11.Countries);
            this.colorsTableAdapter.Fill(this.ippodromDataSet11.Colors);
            //Fill lists for form controls that not necessary for review of certain object 
            HorseFormControlsNI = new List<Control>()
            {
                trainerlbl, 
                trainertb, 
                horsewinnerlbl, 
                horsewinnertb, 
                riderwinnerlbl, 
                riderwinnertb
            };
            RiderFormControlsNI = new List<Control>()
            {
                weightlbl, 
                weighttb, 
                heigthlbl, 
                heigthtb, 
                fatherlbl, 
                fathertb, 
                motherlbl, 
                mothertb, 
                Colorlbl, 
                colortb, 
                birthlbl, 
                birthtb, 
                horsewinnerlbl, 
                horsewinnertb, 
                riderwinnerlbl, 
                riderwinnertb, 
                button1
            };
            CupFormControlsNI = new List<Control>()
            {
                sexlbl, 
                sextb, 
                trainerlbl, 
                trainertb, 
                weightlbl, 
                weighttb, 
                heigthlbl, 
                heigthtb, 
                fatherlbl, 
                fathertb, 
                motherlbl, 
                mothertb, 
                Colorlbl, 
                colortb, 
                birthlbl, 
                winnumlbl, 
                winnumtb, 
                birthtb, 
                button1, 
            };
            switch (Mode)
            {
                case 0:
                    ElementPicture.Image = Image.FromFile("horse-head.png");
                    foreach (IppodromDataSet1.HorsesRow horse in ippodromDataSet11.Horses)
                    {
                        if (SName.Equals(horse.Name))
                        {
                            ShowHorse = horse;
                            break;
                        }
                    }
                    ElementName.Text = ShowHorse.Name;
                    weighttb.Text = ShowHorse.Weight.ToString();
                    heigthtb.Text = ShowHorse.Heigth.ToString();
                    birthtb.Text = ShowHorse.BirthDate.ToString();
                    foreach (IppodromDataSet1.ColorsRow color in ippodromDataSet11.Colors)
                    {
                        if (color.ID == ShowHorse.FKID_Color)
                        {
                            colortb.Text = color.Name;
                            break;
                        }
                    }
                    foreach (IppodromDataSet1.SexRow sex in ippodromDataSet11.Sex)
                    {
                        if (sex.ID == ShowHorse.FKID_Sex)
                        {
                            sextb.Text = sex.Name;
                            break;
                        }
                    }
                    foreach (IppodromDataSet1.CountriesRow country in ippodromDataSet11.Countries)
                    {
                        if (country.ID == ShowHorse.FKID_Country)
                        {
                            countrytb.Text = country.Name;
                            break;
                        }
                    }
                    winnumtb.Text = ShowHorse.WinNumber.ToString();
                    try { 
                        foreach (IppodromDataSet1.HorsesRow horse in ippodromDataSet11.Horses)
                        {
                            if (ShowHorse.FKID_Mother == horse.ID)
                            {
                                mothertb.Text = horse.Name;
                                break;
                            }
                        }
                    }
                    catch(Exception)
                    {
                        mothertb.Text = "No information";
                    }
                    try
                    {
                        foreach (IppodromDataSet1.HorsesRow horse in ippodromDataSet11.Horses)
                        {
                            if (ShowHorse.FKID_Father == horse.ID)
                            {
                                fathertb.Text = horse.Name;
                                break;
                            }
                        }
                    }
                    catch(Exception)
                    {
                        fathertb.Text = "No information";
                    }
                    foreach (Control cont in HorseFormControlsNI)
                        cont.Hide();
                    break;
                case 1:
                    ElementPicture.Image = Image.FromFile("horserider_horse_race-512-1.png");
                    foreach (IppodromDataSet1.RidersRow rider in ippodromDataSet11.Riders)
                    {
                        if (SName.Equals(rider.Name))
                        {
                            ShowRider = rider;
                            break;
                        }
                    }
                    ElementName.Text = ShowRider.Name;
                    foreach (IppodromDataSet1.SexRow sex in ippodromDataSet11.Sex)
                    {
                        if (sex.ID == ShowRider.FKID_Sex)
                        {
                            sextb.Text = sex.Name;
                            break;
                        }
                    }
                    foreach (IppodromDataSet1.CountriesRow country in ippodromDataSet11.Countries)
                    {
                        if (country.ID == ShowRider.FKID_Country)
                        {
                            countrytb.Text = country.Name;
                            break;
                        }
                    }
                    winnumtb.Text = ShowRider.WinNumber.ToString();
                    try
                    {
                        foreach (IppodromDataSet1.RidersRow rider in ippodromDataSet11.Riders)
                        {
                            if (ShowRider.FKID_Trainer == rider.ID)
                            {
                                trainertb.Text = rider.Name;
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        trainertb.Text = "No information";
                    }
                    foreach (Control cont in RiderFormControlsNI)
                        cont.Hide();
                    break;
                case 2:
                    ElementPicture.Image = Image.FromFile("icon.png");
                    foreach (IppodromDataSet1.LapsRow lap in ippodromDataSet11.Laps)
                    {
                        if (SName.Equals(lap.Name))
                        {
                            ShowLap = lap;
                            break;
                        }
                    }
                    ElementName.Text = ShowLap.Name;
                    foreach (IppodromDataSet1.CountriesRow country in ippodromDataSet11.Countries)
                    {
                        if (country.ID == ShowLap.FKID_Country)
                        {
                            countrytb.Text = country.Name;
                            break;
                        }
                    }
                    foreach (IppodromDataSet1.HorsesRow horse in ippodromDataSet11.Horses)
                    {
                        if (ShowLap.HorseWinner == horse.ID)
                        {
                            horsewinnertb.Text = horse.Name;
                            break;
                        }
                    }
                    foreach (IppodromDataSet1.RidersRow rider in ippodromDataSet11.Riders)
                    {
                        if (ShowLap.RiderWinner == rider.ID)
                        {
                            riderwinnertb.Text = rider.Name;
                            break;
                        }
                    }
                    foreach (Control cont in CupFormControlsNI)
                        cont.Hide();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GenTree genTree = new GenTree(SName);
            genTree.Show();
        }
    }
}
