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
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        projectRemaxDBEntities1 myRemax;
        string mode;
        DataTable tabEmployees, tabClients, tabProperties;
        int current;

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            myRemax = new projectRemaxDBEntities1();

            var empInfo = from emp in myRemax.Employees
                          select emp.RefEmployee;

            var clientInfo = from cli in myRemax.Clients
                             select cli.RefClient;

            var propertyInfo = from prop in myRemax.Properties
                               select prop.RefProperty;

            cboEmployee.DisplayMember = "RefEmployee";
            cboEmployee.ValueMember = "RefEmployee";
            cboEmployee.DataSource = empInfo.ToList();

            cboClients.DisplayMember = "RefClient";
            cboClients.ValueMember = "RefClient";
            cboClients.DataSource = clientInfo.ToList();

            cboProperty.DisplayMember = "RefProperty";
            cboProperty.ValueMember = "RefProperty";
            cboProperty.DataSource = propertyInfo.ToList();

            tabEmployees = clsGlobal.mySet.Tables["Employees"];
            tabClients = clsGlobal.mySet.Tables["Clients"];
            tabProperties = clsGlobal.mySet.Tables["Properties"];
        }

        private void btnAdd_MouseHover(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Red;
        }

        private void btnAdd_MouseLeave(object sender, EventArgs e)
        {
            btnAdd.BackColor = Color.Navy;
        }

        private void btnEdit_MouseHover(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.Red;
        }

        private void btnEdit_MouseLeave(object sender, EventArgs e)
        {
            btnEdit.BackColor = Color.Navy;
        }

        private void btnDelete_MouseHover(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Red;
        }

        private void btnDelete_MouseLeave(object sender, EventArgs e)
        {
            btnDelete.BackColor = Color.Navy;
        }

        private void btnSave_MouseHover(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Red;
        }

        private void btnSave_MouseLeave(object sender, EventArgs e)
        {
            btnSave.BackColor = Color.Navy;
        }

        private void btnCancel_MouseHover(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Red;
        }

        private void btnCancel_MouseLeave(object sender, EventArgs e)
        {
            btnCancel.BackColor = Color.Navy;
        }

        private void cboEmployee_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee empFound = myRemax.Employees.Find(cboEmployee.SelectedValue);

            if (empFound != null)
            {
                txtFirstName.Text = empFound.FirstName;
                txtLastName.Text = empFound.LastName;
                txtLanguage.Text = empFound.Language;
                txtSalary.Text = empFound.Salary.ToString();
                txtEmployeeStatus.Text = empFound.Status;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DataRow myRow;
            current = tabEmployees.Rows.Count - 1;

            if (mode == "add")
            {
                myRow = tabEmployees.NewRow();
                myRow["FirstName"] = txtFirstName.Text;
                myRow["LastName"] = txtLastName.Text;
                myRow["Language"] = txtLanguage.Text;
                myRow["Salary"] = txtSalary.Text;
                myRow["Status"] = txtEmployeeStatus.Text;

                tabEmployees.Rows.Add(myRow);

                // Synchronizes, to make sure the context of the dataset is the same as the dataBase
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpEmployee);
                clsGlobal.adpEmployee.Update(tabEmployees);
            }
            else if (mode == "edit")
            {
                myRow = tabEmployees.Rows[current];
                myRow["RefEmployee"] = Convert.ToInt64(cboEmployee.SelectedValue.ToString());
                myRow["FirstName"] = txtFirstName.Text;
                myRow["LastName"] = txtLastName.Text;
                myRow["Language"] = txtLanguage.Text;
                myRow["Salary"] = txtSalary.Text;

                DataRow[] results = tabEmployees.Select("RefEmployee = '" + cboEmployee.Text + "'");
                myRow["RefEmployee"] = results[0]["RefEmployee"];

                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpEmployee);
                clsGlobal.adpEmployee.Update(tabEmployees);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            mode = "add";
            txtFirstName.Focus();
            cboEmployee.Text = txtFirstName.Text = txtLastName.Text = txtLanguage.Text = txtSalary.Text = txtEmployeeStatus.Text ="";
            cboEmployee.BackColor = txtFirstName.BackColor = txtLastName.BackColor = txtLanguage.BackColor = txtSalary.BackColor = txtEmployeeStatus.BackColor = Color.LightBlue;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            current = tabEmployees.Rows.Count - 1;

            if (MessageBox.Show("Employee deletation mey affect other tables, are you sure?", "Employee Deletation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tabEmployees.Rows[current].Delete();

                // to update the dataBase
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpEmployee);
                clsGlobal.adpEmployee.Update(tabEmployees);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtFirstName.Focus();
            cboEmployee.BackColor = txtFirstName.BackColor = txtLastName.BackColor = txtLanguage.BackColor = txtSalary.BackColor = txtEmployeeStatus.BackColor = Color.LightBlue;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            cboEmployee.BackColor = txtFirstName.BackColor = txtLastName.BackColor = txtLanguage.BackColor = txtSalary.BackColor = txtEmployeeStatus.BackColor = Color.White;
        }

        private void cboClients_SelectedIndexChanged(object sender, EventArgs e)
        {
            Client cliFound = myRemax.Clients.Find(cboClients.SelectedValue);

            if (cliFound != null)
            {
                txtFirstClient.Text = cliFound.FirstName;
                txtLastClient.Text = cliFound.LastName;
                txtClientsAgent.Text = cliFound.RefEmployee.ToString();
                txtType.Text = cliFound.Type;
                txtPropertyClient.Text = cliFound.RefProperty.ToString();
            }
        }

        private void btnAddClients_Click(object sender, EventArgs e)
        {
            mode = "add";
            txtFirstClient.Focus();
            txtFirstClient.Text = txtLastClient.Text = txtClientsAgent.Text = txtType.Text = label.Text = "";
            txtFirstClient.BackColor = txtLastClient.BackColor = txtClientsAgent.BackColor = txtType.BackColor = txtPropertyClient.BackColor = Color.LightBlue;
        }

        private void btnDeleteClients_Click(object sender, EventArgs e)
        {
            current = tabClients.Rows.Count - 1;

            if (MessageBox.Show("Client deletation mey affect other tables, are you sure?", "Client Deletation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tabClients.Rows[current].Delete();

                // to update the dataBase
                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpClient);
                clsGlobal.adpClient.Update(tabClients);
            }
        }

        private void btnEditClients_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtFirstClient.Focus();
            txtFirstClient.BackColor = txtLastClient.BackColor = txtClientsAgent.BackColor = txtType.BackColor = txtPropertyClient.BackColor = Color.LightBlue;
        }

        private void btnSaveClients_Click(object sender, EventArgs e)
        {
            DataRow myRow;
            current = tabClients.Rows.Count - 1;

            if (mode == "add")
            {
                myRow = tabClients.NewRow();
                myRow["FirstName"] = txtFirstClient.Text;
                myRow["LastName"] = txtLastClient.Text;
                myRow["RefEmployee"] = Convert.ToInt64(txtClientsAgent.Text);
                myRow["Type"] = txtType.Text;
                myRow["RefProperty"] = Convert.ToInt64(label.Text);

                tabClients.Rows.Add(myRow);

                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpClient);
                clsGlobal.adpClient.Update(tabClients);
            }
            else if (mode == "edit")
            {
                myRow = tabClients.Rows[current];
                myRow["FirstName"] = txtFirstClient.Text;
                myRow["LastName"] = txtLastClient.Text;
                myRow["RefEmployee"] = Convert.ToInt64(txtClientsAgent.Text);
                myRow["Type"] = txtType.Text;
                myRow["RefProperty"] = Convert.ToInt64(label.Text);

                DataRow[] results = tabProperties.Select("RefProperty = '" + cboProperty.Text + "'");
                myRow["RefProperty"] = results[0]["RefProperty"];

                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpProperty);
                clsGlobal.adpProperty.Update(tabProperties);
            }
        }

        private void btnAddProperties_Click(object sender, EventArgs e)
        {
            mode = "add";
            txtPropertyAgent.Focus();
            txtPropertyAgent.Text = txtPropertyLocation.Text = txtPropertyType.Text = txtPropertyPrice.Text = txtPropertySize.Text = "";
            txtPropertyAgent.BackColor = txtPropertyLocation.BackColor = txtPropertyType.BackColor = txtPropertyPrice.BackColor = txtPropertySize.BackColor = Color.LightBlue;
        }

        private void btnEditProperties_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtPropertyAgent.BackColor = txtPropertyLocation.BackColor = txtPropertyType.BackColor = txtPropertyPrice.BackColor = txtPropertySize.BackColor = Color.LightBlue;
        }

        private void btnCancelProperties_Click(object sender, EventArgs e)
        {
            txtPropertyAgent.BackColor = txtPropertyLocation.BackColor = txtPropertyType.BackColor = txtPropertyPrice.BackColor = txtPropertySize.BackColor = Color.White;
        }

        private void btnDeleteProperties_Click(object sender, EventArgs e)
        {
            current = tabProperties.Rows.Count - 1;

            if (MessageBox.Show("Property deletation mey affect other tables, are you sure?", "Property Deletation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                tabProperties.Rows[current].Delete();

                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpProperty);
                clsGlobal.adpProperty.Update(tabProperties);
            }
        }

        private void btnSaveProperties_Click(object sender, EventArgs e)
        {
            DataRow myRow;
            current = tabProperties.Rows.Count - 1;

            if (mode == "add")
            {
                myRow = tabClients.NewRow();
                myRow["RefEmployee"] = Convert.ToInt64(txtPropertyAgent.Text);
                myRow["Location"] = txtPropertyLocation.Text;
                myRow["Type"] = txtPropertyType.Text;
                myRow["Price"] = Convert.ToDecimal(txtPropertyPrice.Text);
                myRow["Size"] = txtPropertySize.Text;

                tabProperties.Rows.Add(myRow);

                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpProperty);
                clsGlobal.adpProperty.Update(tabProperties);
            }
            else if (mode == "edit")
            {
                myRow = tabProperties.Rows[current];
                myRow["RefEmployee"] = Convert.ToInt64(txtPropertyAgent.Text);
                myRow["Location"] = txtPropertyLocation.Text;
                myRow["Type"] = txtPropertyType.Text;
                myRow["Price"] = Convert.ToDecimal(txtPropertyPrice.Text);
                myRow["Size"] = txtPropertySize.Text;

                DataRow[] results = tabClients.Select("RefClient = '" + cboClients.Text + "'");
                myRow["RefClient"] = results[0]["RefClient"];

                SqlCommandBuilder myBuilder = new SqlCommandBuilder(clsGlobal.adpClient);
                clsGlobal.adpClient.Update(tabClients);
            }
        }

        private void btnCancelClients_Click(object sender, EventArgs e)
        {
            txtFirstClient.BackColor = txtLastClient.BackColor = txtClientsAgent.BackColor = txtType.BackColor = txtPropertyClient.BackColor = Color.White;
        }

        private void cboProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Property propFound = myRemax.Properties.Find(cboProperty.SelectedValue);

            if ( propFound != null)
            {
                txtPropertyAgent.Text = propFound.RefEmployee.ToString();
                txtPropertyLocation.Text = propFound.Location;
                txtPropertyType.Text = propFound.Type;
                txtPropertyPrice.Text = propFound.Price.ToString();
                txtPropertySize.Text = propFound.Size;
            }
        }
    }
}
