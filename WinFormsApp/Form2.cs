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
using WinFormsApp.Models;
using WinFormsApp.Services;

namespace WinFormsApp
{
    public partial class Form2 : Form
    {
        static BrandService brandService = new();
        internal int BrandId;

        public Form2()
        {
            InitializeComponent();

            var command = brandService.GetAllBrands();
            dataGridView1.DataSource = command;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            fr1.Show();
            Hide();
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string BrandName = brandNameTextBox.Text;

            if (idTextBox.Text == string.Empty)
            {
                MessageBox.Show("Enter ID.");
            }
            else
            {
                BrandId = int.Parse(idTextBox.Text);

                Brand brand = new Brand(BrandId);
                var command = brandService.GetBrand(brand);
                dataGridView1.DataSource = command;
            }
        }

        private void insertBtn_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != string.Empty)
            {
                BrandId = int.Parse(idTextBox.Text);
            }

            string BrandName = brandNameTextBox.Text;

            if (BrandName != string.Empty)
            {
                Brand brand = new Brand(BrandName);
                brandService.CreateBrand(brand);
            }
            else { MessageBox.Show("Enter brand name."); }


            var command = brandService.GetAllBrands();
            dataGridView1.DataSource = command;
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {

            string BrandName = brandNameTextBox.Text;
            if (idTextBox.Text == string.Empty)
            {
                MessageBox.Show("Enter ID.");
            }
            else
            {
                BrandId = int.Parse(idTextBox.Text);
                Brand brand = new Brand(BrandId);
                brandService.DeleteBrand(brand);
            }


            var command = brandService.GetAllBrands();
            dataGridView1.DataSource = command;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string BrandName = brandNameTextBox.Text;

            if (idTextBox.Text == string.Empty && BrandName == string.Empty)
            {
                MessageBox.Show("Enter new brand name and ID.");
            }
            else if (idTextBox.Text != string.Empty && BrandName == string.Empty)
            {
                MessageBox.Show("Enter new brand name.");
            }
            else if (idTextBox.Text == string.Empty && BrandName != string.Empty)
            {
                MessageBox.Show("Enter ID.");
            }
            else
            {
                BrandId = int.Parse(idTextBox.Text);
                Brand brand = new Brand(BrandName);
                brandService.UpdateBrand(brand);
            }
        }
    }
}
