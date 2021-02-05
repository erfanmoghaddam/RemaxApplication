using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace projectRemaxPart2
{
    public partial class frmHomePage : Form
    {
        public frmHomePage()
        {
            InitializeComponent();
        }

        private void frmHomePage_Load(object sender, EventArgs e)
        {
            clsGlobal.mySet = new DataSet();
            clsGlobal.myConn = new SqlConnection("Data Source=LAPTOP-K9JMTI19;Initial Catalog=projectRemaxDB;Integrated Security=True");
            clsGlobal.myConn.Open();

            SqlCommand myCmd = new SqlCommand("SELECT * FROM Employees", clsGlobal.myConn);
            clsGlobal.adpEmployee = new SqlDataAdapter(myCmd);
            clsGlobal.adpEmployee.Fill(clsGlobal.mySet, "Employees");

            myCmd = new SqlCommand("SELECT * FROM Clients", clsGlobal.myConn);
            clsGlobal.adpClient = new SqlDataAdapter(myCmd);
            clsGlobal.adpClient.Fill(clsGlobal.mySet, "Clients");

            myCmd = new SqlCommand("SELECT * FROM Properties", clsGlobal.myConn);
            clsGlobal.adpProperty = new SqlDataAdapter(myCmd);
            clsGlobal.adpProperty.Fill(clsGlobal.mySet, "Properties");
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Application Closing", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void adminFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAdmin fa = new frmAdmin();
            fa.MdiParent = this;
            fa.Show();
        }

        private void employeePageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEmployee fe = new frmEmployee();
            fe.MdiParent = this;
            fe.Show();
        }

        private void clientPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient fc = new frmClient();
            fc.MdiParent = this;
            fc.Show();
        }
    }
}
