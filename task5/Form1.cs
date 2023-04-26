using System;
using System.Collections.Generic;
using System.Windows.Forms;




namespace task5
{
    public partial class Form1 : Form
    {


        List<RockBand> groups = new List<RockBand>();
        RockBand rockBand;

        public Form1()
        {
            InitializeComponent();
            InitializeGrid();

            this.stopButton.Enabled = false;
        }



        private void InitializeGrid()
        {
            var column1 = new DataGridViewColumn();
            column1.HeaderText = "Название группы";
            column1.Width = 100;
            column1.ReadOnly = true;
            column1.Name = "name";
            column1.Frozen = true;
            column1.CellTemplate = new DataGridViewTextBoxCell();

            var column2 = new DataGridViewColumn();
            column2.HeaderText = "Кол-во людей";
            column1.ReadOnly = true;
            column2.Name = "numMember";
            column2.CellTemplate = new DataGridViewTextBoxCell();

            var column3 = new DataGridViewColumn();
            column3.HeaderText = "Жанр";
            column1.ReadOnly = true;
            column3.Name = "genre";
            column3.CellTemplate = new DataGridViewTextBoxCell();

            var column4 = new DataGridViewColumn();
            column4.HeaderText = "Кол-во гитаристов";
            column1.ReadOnly = true;
            column4.Name = "numGitar";
            column4.CellTemplate = new DataGridViewTextBoxCell();

            var column5 = new DataGridViewColumn();
            column5.HeaderText = "Наличие барабанщика";
            column1.ReadOnly = true;
            column5.Name = "drummer";
            column5.CellTemplate = new DataGridViewTextBoxCell();

            this.dataGridView1.Columns.Add(column1);
            this.dataGridView1.Columns.Add(column2);
            this.dataGridView1.Columns.Add(column3);
            this.dataGridView1.Columns.Add(column4);
            this.dataGridView1.Columns.Add(column5);

            this.dataGridView1.AllowUserToAddRows = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            RockBand band1 = new RockBand();
            band1.Name = "The Rolling Stones";
            band1.NumOfMembers = 4;
            band1.Genre = "Rock";
            band1.NumOfGuitars = 2;
            band1.HasDrummer = true;

        }

        private void updateGrid(RockBand band)
        {
            this.dataGridView1.Rows.Add(band.Name, band.NumOfMembers, band.Genre, band.NumOfGuitars, band.HasDrummer);
        }

        private void updateComboBox()
        {
            this.comboBox1.Items.Clear();
            foreach (var item in fingNames())
            {
                this.comboBox1.Items.Add(item);
            }
        }

        private List<string> fingNames()
        {
            List<string> list = new List<string>();

            foreach (var item in groups)
            {
                list.Add(item.Name);
            }

            return list;
        }

        private RockBand findByName(string name)
        {
            foreach (var item in groups)
            {
                if (item.Name == name)
                {
                    return item;
                }
            }
            return null;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                RockBand band = new RockBand
                {
                    Name = this.name.Text,
                    NumOfMembers = int.Parse(this.numMem.Text),
                    Genre = this.genre.Text,
                    NumOfGuitars = int.Parse(this.numGuitars.Text),
                    HasDrummer = this.checkBox1.Checked
                };

                groups.Add(band);

                updateGrid(band);
                updateComboBox();

                MessageBox.Show("The group is added!");
            }
            catch (Exception)
            {
                MessageBox.Show("Input error!");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string name = this.comboBox1.Text;
            if (!string.IsNullOrEmpty(name))
            {
                this.rockBand = findByName(name);
            }
            else
            {
                MessageBox.Show("Группа не найдена!");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (this.rockBand != null)
            {
                MessageBox.Show($"{this.rockBand.Name} " + Environment.NewLine + this.rockBand.PlayMusic());
                this.stopButton.Enabled = true;
                this.playButton.Enabled = false;
                this.practButton.Enabled = false;
                this.stageButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("The group is not selected or does not exist!");
            }
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            if (this.rockBand != null)
            {
                MessageBox.Show($"{this.rockBand.Name} " + Environment.NewLine + this.rockBand.StopMusic());
                this.stopButton.Enabled = false;
                this.playButton.Enabled = true;
                this.practButton.Enabled = true;
                this.stageButton.Enabled = true;
            }
            else
            {
                MessageBox.Show("The group is not selected or does not exist!");
            }
        }

        private void practButton_Click(object sender, EventArgs e)
        {
            if (this.rockBand != null)
            {
                MessageBox.Show($"{this.rockBand.Name} " + Environment.NewLine + this.rockBand.Practice());
            }
            else
            {
                MessageBox.Show("The group is not selected or does not exist!");
            }
        }

        private void stageButton_Click(object sender, EventArgs e)
        {
            if (this.rockBand != null)
            {
                MessageBox.Show($"{this.rockBand.Name} " + Environment.NewLine + this.rockBand.StageDive());
            }
            else
            {
                MessageBox.Show("The group is not selected or does not exist!");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.name.Text = "";
            this.numMem.Text = "";
            this.genre.Text = "";
            this.numGuitars.Text = "";
            this.checkBox1.Checked = false;
        }
    }
}
