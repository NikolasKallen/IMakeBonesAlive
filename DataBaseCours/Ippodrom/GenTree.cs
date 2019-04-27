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
    public partial class GenTree : Form
    {
        public GenTree()
        {
            InitializeComponent();
        }

        string HorseName = null;

        public GenTree(string horseName)
        {
            InitializeComponent();
            HorseName = horseName;
        }

        private void GenTree_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ippodromDataSet1.Sex". При необходимости она может быть перемещена или удалена.
            this.sexTableAdapter.Fill(this.ippodromDataSet1.Sex);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ippodromDataSet1.RiderView". При необходимости она может быть перемещена или удалена.
            this.riderViewTableAdapter.Fill(this.ippodromDataSet1.RiderView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ippodromDataSet1.Riders". При необходимости она может быть перемещена или удалена.
            this.ridersTableAdapter.Fill(this.ippodromDataSet1.Riders);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ippodromDataSet1.LapView". При необходимости она может быть перемещена или удалена.
            this.lapViewTableAdapter.Fill(this.ippodromDataSet1.LapView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ippodromDataSet1.Laps". При необходимости она может быть перемещена или удалена.
            this.lapsTableAdapter.Fill(this.ippodromDataSet1.Laps);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ippodromDataSet1.HorseView". При необходимости она может быть перемещена или удалена.
            this.horseViewTableAdapter.Fill(this.ippodromDataSet1.HorseView);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ippodromDataSet1.Horses". При необходимости она может быть перемещена или удалена.
            this.horsesTableAdapter.Fill(this.ippodromDataSet1.Horses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ippodromDataSet1.Countries". При необходимости она может быть перемещена или удалена.
            this.countriesTableAdapter.Fill(this.ippodromDataSet1.Countries);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "ippodromDataSet1.Colors". При необходимости она может быть перемещена или удалена.
            this.colorsTableAdapter.Fill(this.ippodromDataSet1.Colors);
            //self
            foreach (IppodromDataSet1.HorsesRow horse1 in ippodromDataSet1.Horses)
            {
                if (horse1.Name.Equals(HorseName))
                {
                    SelfButton.Text = horse1.Name;
                    SelfButton.Tag = horse1.Name;
                    //mother
                    try
                    {
                        foreach (IppodromDataSet1.HorsesRow horsemother in ippodromDataSet1.Horses)
                        {
                            if (horsemother.ID == horse1.FKID_Mother)
                            {
                                mothbutton.Text = $"{mothbutton.Text}{horsemother.Name}";
                                mothbutton.Tag = horsemother.Name;
                                //grandma1
                                try
                                {
                                    foreach (IppodromDataSet1.HorsesRow horsegrandma in ippodromDataSet1.Horses)
                                    {
                                        if (horsegrandma.ID == horsemother.FKID_Mother)
                                        {
                                            grandma1button.Text = $"{grandma1button.Text}{horsegrandma.Name}";
                                            grandma1button.Tag = horsegrandma.Name;
                                            //ggrandma1
                                            try
                                            {
                                                foreach (IppodromDataSet1.HorsesRow horseggrandma in ippodromDataSet1.Horses)
                                                {
                                                    if (horseggrandma.ID == horsegrandma.FKID_Mother)
                                                    {
                                                        ggrandma1button.Text = $"{ggrandma1button.Text}{horseggrandma.Name}";
                                                        ggrandma1button.Tag = horseggrandma.Name;
                                                        break;
                                                    }
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                IsInfo(true, true, true, true, true, true, false, true, true, true, true, true, true, true);
                                            }
                                            //ggrandfa1
                                            try
                                            {
                                                foreach (IppodromDataSet1.HorsesRow horseggrandfa in ippodromDataSet1.Horses)
                                                {
                                                    if (horseggrandfa.ID == horsegrandma.FKID_Father)
                                                    {
                                                        ggrandfa1button.Text = $"{ggrandfa1button.Text}{horseggrandfa.Name}";
                                                        ggrandfa1button.Tag = horseggrandfa.Name; 
                                                        break;
                                                    }
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                IsInfo(true, true, true, true, true, true, true, false, true, true, true, true, true, true);
                                            }
                                            break;
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                    IsInfo(true, true, false, true, true, true, false, false, true, true, true, true, true, true);
                                }
                                //grandfa1
                                try
                                {
                                    foreach (IppodromDataSet1.HorsesRow horsegrandfa in ippodromDataSet1.Horses)
                                    {
                                        if (horsegrandfa.ID == horsemother.FKID_Father)
                                        {
                                            grandfa1button.Text = $"{grandfa1button.Text}{horsegrandfa.Name}";
                                            grandfa1button.Tag = horsegrandfa.Name;
                                            //ggrandma2
                                            try
                                            {
                                                foreach (IppodromDataSet1.HorsesRow horseggrandma in ippodromDataSet1.Horses)
                                                {
                                                    if (horseggrandma.ID == horsegrandfa.FKID_Mother)
                                                    {
                                                        ggrandma2button.Text = $"{ggrandma2button.Text}{horseggrandma.Name}";
                                                        ggrandma2button.Tag = horseggrandma.Name;
                                                        break;
                                                    }
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                IsInfo(true, true, true, true, true, true, true, true, false, true, true, true, true, true);
                                            }
                                            //ggrandfa2
                                            try
                                            {
                                                foreach (IppodromDataSet1.HorsesRow horseggrandfa in ippodromDataSet1.Horses)
                                                {
                                                    if (horseggrandfa.ID == horsegrandfa.FKID_Father)
                                                    {
                                                        ggrandfa2button.Text = $"{ggrandfa2button.Text}{horseggrandfa.Name}";
                                                        ggrandfa2button.Tag = horseggrandfa.Name;
                                                        break;
                                                    }
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                IsInfo(true, true, true, true, true, true, true, true, true, false, true, true, true, true);
                                            }
                                            break;
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                    IsInfo(true, true, true, false, true, true, true, true, false, false, true, true, true, true);
                                }
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        IsInfo(false, true, false, false, true, true, false, false, false, false, true, true, true, true);
                    }
                    //father
                    try
                    {
                        foreach (IppodromDataSet1.HorsesRow horsefather in ippodromDataSet1.Horses)
                        {
                            if (horsefather.ID == horse1.FKID_Father)
                            {
                                fathbutton.Text = $"{fathbutton.Text}{horsefather.Name}";
                                fathbutton.Tag = horsefather.Name;
                                //grandma2
                                try
                                {
                                    foreach (IppodromDataSet1.HorsesRow horsegrandma in ippodromDataSet1.Horses)
                                    {
                                        if (horsegrandma.ID == horsefather.FKID_Mother)
                                        {
                                            grandma2button.Text = $"{grandma2button.Text}{horsegrandma.Name}";
                                            grandma2button.Tag = horsegrandma.Name;
                                            //ggrandma3
                                            try
                                            {
                                                foreach (IppodromDataSet1.HorsesRow horseggrandma in ippodromDataSet1.Horses)
                                                {
                                                    if (horseggrandma.ID == horsegrandma.FKID_Mother)
                                                    {
                                                        ggrandma3button.Text = $"{ggrandma3button.Text}{horseggrandma.Name}";
                                                        ggrandma3button.Tag = horseggrandma.Name;
                                                        break;
                                                    }
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                IsInfo(true, true, true, true, true, true, true, true, true, true, false, true, true, true);
                                            }
                                            //ggrandfa3
                                            try
                                            {
                                                foreach (IppodromDataSet1.HorsesRow horseggrandfa in ippodromDataSet1.Horses)
                                                {
                                                    if (horseggrandfa.ID == horsegrandma.FKID_Father)
                                                    {
                                                        ggrandfa3button.Text = $"{ggrandfa3button.Text}{horseggrandfa.Name}";
                                                        ggrandfa3button.Tag = horseggrandfa.Name;
                                                        break;
                                                    }
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                IsInfo(true, true, true, true, true, true, true, true, true, true, true, false, true, true);
                                            }
                                            break;
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                    IsInfo(true, true, true, true, false, true, true, true, true, true, false, false, true, true);
                                }
                                //grandfa2
                                try
                                {
                                    foreach (IppodromDataSet1.HorsesRow horsegrandfa in ippodromDataSet1.Horses)
                                    {
                                        if (horsegrandfa.ID == horsefather.FKID_Father)
                                        {
                                            grandfa2button.Text = $"{grandfa2button.Text}{horsegrandfa.Name}";
                                            grandfa2button.Tag = horsegrandfa.Name;
                                            //ggrandma4
                                            try
                                            {
                                                foreach (IppodromDataSet1.HorsesRow horseggrandma in ippodromDataSet1.Horses)
                                                {
                                                    if (horseggrandma.ID == horsegrandfa.FKID_Mother)
                                                    {
                                                        ggrandma4button.Text = $"{ggrandma4button.Text}{horseggrandma.Name}";
                                                        ggrandma4button.Tag = horseggrandma.Name;
                                                        break;
                                                    }
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                IsInfo(true, true, true, true, true, true, true, true, true, true, true, true, false, true);
                                            }
                                            //ggrandfa4
                                            try
                                            {
                                                foreach (IppodromDataSet1.HorsesRow horseggrandfa in ippodromDataSet1.Horses)
                                                {
                                                    if (horseggrandfa.ID == horsegrandfa.FKID_Father)
                                                    {
                                                        ggrandfa4button.Text = $"{ggrandfa4button.Text}{horseggrandfa.Name}";
                                                        ggrandfa4button.Tag = horseggrandfa.Name;
                                                        break;
                                                    }
                                                }
                                            }
                                            catch (Exception)
                                            {
                                                IsInfo(true, true, true, true, true, true, true, true, true, true, true, true, true, false);
                                            }
                                            break;
                                        }
                                    }
                                }
                                catch (Exception)
                                {
                                    IsInfo(true, true, true, true, true, false, true, true, true, true, true, true, false, false);
                                }
                                break;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        IsInfo(true, false, true, true, false, false, true, true, true, true, false, false, false, false);
                    }
                    break;
                }
            }

        }

        private void colorsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.colorsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.ippodromDataSet1);

        }

        void IsInfo(bool mother,bool father, bool grandma1,bool grandfa1, bool grandma2,bool grandfa2, bool ggrandma1, bool ggrandfa1, bool ggrandma2, bool ggrandfa2, bool ggrandma3, bool ggrandfa3, bool ggrandma4, bool ggrandfa4)
        {
            if(!mother)
            {
                mothbutton.Text = $"{mothbutton.Text}No information";
                mothbutton.Enabled = false;
            }
            if (!father)
            {
                fathbutton.Text = $"{fathbutton.Text}No information";
                fathbutton.Enabled = false;
            }
            if (!grandfa1)
            {
                grandfa1button.Text = $"{grandfa1button.Text}No information";
                grandfa1button.Enabled = false;
            }
            if (!grandma1)
            {
                grandma1button.Text = $"{grandma1button.Text}No information";
                grandma1button.Enabled = false;
            }
            if (!grandfa2)
            {
                grandfa2button.Text = $"{grandfa2button.Text}No information";
                grandfa2button.Enabled = false;
            }
            if (!grandma2)
            {
                grandma2button.Text = $"{grandma2button.Text}No information";
                grandma2button.Enabled = false;
            }
            if (!ggrandfa1)
            {
                ggrandfa1button.Text = $"{ggrandfa1button.Text}No information";
                ggrandfa1button.Enabled = false;
            }
            if (!ggrandma1)
            {
                ggrandma1button.Text = $"{ggrandma1button.Text}No information";
                ggrandma1button.Enabled = false;
            }
            if (!ggrandfa2)
            {
                ggrandfa2button.Text = $"{ggrandfa2button.Text}No information";
                ggrandfa2button.Enabled = false;
            }
            if (!ggrandma2)
            {
                ggrandma2button.Text = $"{ggrandma2button.Text}No information";
                ggrandma2button.Enabled = false;
            }
            if (!ggrandfa3)
            {
                ggrandfa3button.Text = $"{ggrandfa3button.Text}No information";
                ggrandfa3button.Enabled = false;
            }
            if (!ggrandma3)
            {
                ggrandma3button.Text = $"{ggrandma3button.Text}No information";
                ggrandma3button.Enabled = false;
            }
            if (!ggrandfa4)
            {
                ggrandfa4button.Text = $"{ggrandfa4button.Text}No information";
                ggrandfa4button.Enabled = false;
            }
            if (!ggrandma4)
            {
                ggrandma4button.Text = $"{ggrandma4button.Text}No information";
                ggrandma4button.Enabled = false;
            }
        }

        private void SelfButton_Click(object sender, EventArgs e)
        {
            Button bttn = sender as Button;
            ShowElement showElement = new ShowElement(0,bttn.Tag.ToString());
            showElement.Show();
        }
    }
}
