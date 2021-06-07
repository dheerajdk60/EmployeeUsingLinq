using linqemployee.Model;
using linqemployee.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace linqemployee
{
    public partial class Form1 : Form
    {
        DatabaseService databaseService = new DatabaseService();
        public Form1()
        {
            InitializeComponent();
            refreshContent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            databaseService.addEmployee(name_txtbx.Text,city_txtbx.Text);
            MessageBox.Show("Added "+name_txtbx.Text);
            refreshContent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                databaseService.deleteEmployee(name_txtbx.Text,city_txtbx.Text,id_txtbx.Text);
                MessageBox.Show("Deleted " + name_txtbx.Text);
            }
            catch {
                MessageBox.Show("No such Employee to Delete");
            }
            refreshContent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refreshContent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var content= databaseService.findByOptions(name_txtbx.Text, city_txtbx.Text);
            refreshContent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            refreshContent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            databaseService.updateEmployee(name_txtbx.Text, city_txtbx.Text, id_txtbx.Text);
            refreshContent();
        }
        void refreshContent()
        {
            dataGridView1.DataSource = databaseService.getAll();
            name_txtbx.Text = "";
            city_txtbx.Text = "";
            id_txtbx.Text = "";
        }
    }
}
