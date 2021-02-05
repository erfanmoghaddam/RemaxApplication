using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projectRemaxPart2
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        projectRemaxDBEntities1 myRemax;

        private void btnSearch_MouseHover(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Red;
        }

        private void btnSearch_MouseLeave(object sender, EventArgs e)
        {
            btnSearch.BackColor = Color.Aquamarine;
        }

        private void frmClient_Load(object sender, EventArgs e)
        {
            myRemax = new projectRemaxDBEntities1();

            var employeeInfo = from emp in myRemax.Employees
                               select emp.RefEmployee;

            cboAgents.DisplayMember = "FirstName";
            cboAgents.ValueMember = "RefEmployee";
            cboAgents.DataSource = employeeInfo.ToList();

            var propertyInfo = from prop in myRemax.Properties
                               select prop.RefEmployee;

            cboProperties.DisplayMember = "Type";
            cboProperties.ValueMember = "RefProperty";
            cboProperties.DataSource = propertyInfo.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            myRemax = new projectRemaxDBEntities1();
            var employeeInfo = from emp in myRemax.Employees
                             select emp;

            var propInfo = from prop in myRemax.Properties
                           select prop;

            if (chkAgent.Checked && chkProperty.Checked == false)
            {
                employeeInfo = from emp in myRemax.Employees
                             where emp.RefEmployee.ToString() == cboAgents.Text
                             select emp;

                gridResults.DataSource = employeeInfo.ToList();
            }
            else if (chkProperty.Checked && chkAgent.Checked == false)
            {
                propInfo = from prop in myRemax.Properties
                             where prop.RefProperty.ToString() == cboProperties.Text
                             select prop;

                gridResults.DataSource = propInfo.ToList();
            }
            else { }

            
        }
    }
}
