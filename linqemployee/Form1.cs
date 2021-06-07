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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            databaseService.addEmployee(textBox1.Text,textBox2.Text);
            MessageBox.Show("Added "+textBox1.Text);
            dataGridView1.DataSource = databaseService.getAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                databaseService.deleteEmployee(textBox1.Text);
                MessageBox.Show("Deleted " + textBox1.Text);
            }
            catch {
                MessageBox.Show("No such Employee to Delete");
            }
            dataGridView1.DataSource = databaseService.getAll();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = databaseService.getAll();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var content= databaseService.findByOptions(textBox1.Text, textBox2.Text);
            
            dataGridView1.DataSource = content;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = databaseService.getAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            databaseService.updateEmployee(textBox1.Text, textBox2.Text, textBox3.Text);
            dataGridView1.DataSource = databaseService.getAll();
        }
    }
}
