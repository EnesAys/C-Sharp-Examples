using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Reflection.BLL;
using Reflection.DAL;

namespace Reflection.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        RepositoryBase<Product> pr = new RepositoryBase<Product>();
        RepositoryBase<Category> cate = new RepositoryBase<Category>();
        RepositoryBase<Employee> emp = new RepositoryBase<Employee>();
        RepositoryBase<Customer> ctmer = new RepositoryBase<Customer>();
        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = pr.SelectAll();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = emp.SelectAll();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = cate.SelectAll();
        }
    }
}
