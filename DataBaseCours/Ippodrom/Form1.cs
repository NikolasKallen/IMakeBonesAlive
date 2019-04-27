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
    public partial class Form1 : Form
    {
        private Point mouseOffset;
        private bool isMouseDown = false;

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


        public Form1()
        {
            InitializeComponent();
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
        public int Mode = 0;
        private void RefreshMainPanel()
        {
            switch(Mode)
            {
                case 0:
                    niceLabel1.Text = "Horses";
                    horseViewDataGridView.Show();
                    riderViewDataGridView.Hide();
                    lapViewDataGridView.Hide();
                    FlowLayoutSearch.Hide();
                    break;
                case 1:
                    niceLabel1.Text = "Riders";
                    horseViewDataGridView.Hide();
                    riderViewDataGridView.Show();
                    lapViewDataGridView.Hide();
                    FlowLayoutSearch.Hide();
                    break;
                case 2:
                    niceLabel1.Text = "Laps";
                    horseViewDataGridView.Hide();
                    riderViewDataGridView.Hide();
                    lapViewDataGridView.Show();
                    FlowLayoutSearch.Hide();
                    break;
                case 3:
                    niceLabel1.Text = "Search";
                    horseViewDataGridView.Hide();
                    riderViewDataGridView.Hide();
                    lapViewDataGridView.Hide();
                    FlowLayoutSearch.Show();
                    SearchDatagrid.Hide();
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddButton.Show();
            HorsesHighlight.BackColor = Color.FromArgb(192,0,0);
            RidersHighlight.BackColor = Color.White;
            LapsHighlight.BackColor = Color.White;
            SearchHighlight.BackColor = Color.White;
            Mode = 0;
            RefreshMainPanel();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddButton.Show();

            HorsesHighlight.BackColor = Color.White;
            RidersHighlight.BackColor = Color.FromArgb(192, 0, 0);
            LapsHighlight.BackColor = Color.White;
            SearchHighlight.BackColor = Color.White;
            Mode = 1;
            RefreshMainPanel();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AddButton.Show();
            HorsesHighlight.BackColor = Color.White;
            RidersHighlight.BackColor = Color.White;
            LapsHighlight.BackColor = Color.FromArgb(192, 0, 0);
            SearchHighlight.BackColor = Color.White;
            Mode = 2;
            RefreshMainPanel();
        }

        public void refreshCells()
        {
            this.lapViewTableAdapter.Fill(this.ippodromDataSet1.LapView);
            this.riderViewTableAdapter.Fill(this.ippodromDataSet1.RiderView);
            this.horseViewTableAdapter.Fill(this.ippodromDataSet1.HorseView);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.lapViewTableAdapter.Fill(this.ippodromDataSet1.LapView);
            this.riderViewTableAdapter.Fill(this.ippodromDataSet1.RiderView);
            this.horseViewTableAdapter.Fill(this.ippodromDataSet1.HorseView);
            niceLabel1.Text = "Horses";
            horseViewDataGridView.Height = MainFlowLayoutPanel.Height-10;
            riderViewDataGridView.Height = MainFlowLayoutPanel.Height-10;
            lapViewDataGridView.Height = MainFlowLayoutPanel.Height-10;
            FlowLayoutSearch.Height = MainFlowLayoutPanel.Height-10;
            RefreshMainPanel();
        }

        private void horseViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = horseViewDataGridView.Rows[e.RowIndex];
                ShowElement showElement = new ShowElement(0,row.Cells[0].Value.ToString());
                showElement.Show();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddButton.Hide();
            HorsesHighlight.BackColor = Color.White;
            RidersHighlight.BackColor = Color.White;
            LapsHighlight.BackColor = Color.White;
            SearchHighlight.BackColor = Color.FromArgb(192, 0, 0);
            Mode = 3;
            RefreshMainPanel();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Ippodrom.mdf;Integrated Security=True");
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = null;
            if (HorseFRB.Checked)
                sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM HorseView Where Name Like '%{SearchTextBox.Text}%' OR Sex Like '%{SearchTextBox.Text}%' OR Color Like '%{SearchTextBox.Text}%' OR Country Like '%{SearchTextBox.Text}%'",sqlConnection);
            if (RiderFRB.Checked)
                sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM RiderView Where Name Like '%{SearchTextBox.Text}%' OR Sex Like '%{SearchTextBox.Text}%' OR Country Like '%{SearchTextBox.Text}%'", sqlConnection);
            if (LapsFRB.Checked)
                sqlDataAdapter = new SqlDataAdapter($"SELECT * FROM LapView Where Name Like '%{SearchTextBox.Text}%' OR Country Like '%{SearchTextBox.Text}%' OR [Horse-winner name] LIKE '%{SearchTextBox.Text}%' OR [Rider-winner name] LIKE '%{SearchTextBox.Text}%'", sqlConnection);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            DataSet dataSetbuf = new DataSet();
            sqlDataAdapter.Fill(dataSetbuf);
            SearchDatagrid.DataSource = dataSetbuf.Tables[0];
            SearchDatagrid.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddElement addElementForm = new AddElement(Mode);
            addElementForm.Show();
            addElementForm.FormClosed += AddElementForm_FormClosed;
        }

        private void AddElementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            refreshCells();
        }

        private void riderViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = riderViewDataGridView.Rows[e.RowIndex];
                ShowElement showElement = new ShowElement(1, row.Cells[0].Value.ToString());
                showElement.Show();
            }
        }

        private void lapViewDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = lapViewDataGridView.Rows[e.RowIndex];
                ShowElement showElement = new ShowElement(2, row.Cells[0].Value.ToString());
                showElement.Show();
            }
        }

        private void MainFlowLayoutPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
