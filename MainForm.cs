using System;
using System.Linq;
using System.Windows.Forms;
using zel.DBContext;

namespace zel
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        Model1 model = new Model1();

        private void MainForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = model.Users.ToList();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddUsers form = new AddUsers();
            form.ShowDialog();
            dataGridView1.DataSource = model.Users.ToList();
        }
    }
}
