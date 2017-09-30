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

namespace gun28_09_17_EntityFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        NORTHWNDEntities1 db = new NORTHWNDEntities1();
        private void button1_Click(object sender, EventArgs e)
        {

            //SqlDataAdapter dap = new SqlDataAdapter("Select * from Employees", "Server=WISSEN-PC;Database=NORTHWND;User Id=sa; Password = 1234;");
            //DataTable dt = new DataTable();
            //dap.Fill(dt);
            //dataGridView1.DataSource = dt;
            ////dataGridView1.DisplayMember = "FirstName";
            ////dataGridView1.ValueMember = "LastName";
            dataGridView1.DataSource = db.Employees.ToList();

        }
    }
}

