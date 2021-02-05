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
    public partial class frmEmployee : Form
    {
        public frmEmployee()
        {
            InitializeComponent();
        }

        projectRemaxDBEntities1 myRemax;
        string mode;
        DataTable tabClients, tabProperties;
        int current;

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

            myRemax = new projectRemaxDBEntities1();

            var clientInfo = from client in myRemax.Clients
                              where client.RefClient.ToString() == cboClients.SelectedValue.ToString()
                              select client;

            gridResult.DataSource = clientInfo.ToList();
        }

        private void cboProperty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Property propFound = myRemax.Properties.Find(cboProperty.SelectedValue);

            if (propFound != null)
            {
                txtPropertyAgent.Text = propFound.RefEmployee.ToString();
                txtPropertyLocation.Text = propFound.Location;
                txtPropertyType.Text = propFound.Type;
                txtPropertyPrice.Text = propFound.Price.ToString();
                txtPropertySize.Text = propFound.Size;
            }

            myRemax = new projectRemaxDBEntities1();

            var propInfo = from property in myRemax.Properties
                             where property.RefProperty.ToString() == cboProperty.SelectedValue.ToString()
                             select property;

            gridResult.DataSource = propInfo.ToList();
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

        private void btnCancelClients_Click(object sender, EventArgs e)
        {
            txtFirstClient.BackColor = txtLastClient.BackColor = txtClientsAgent.BackColor = txtType.BackColor = txtPropertyClient.BackColor = Color.White;
        }

        private void btnAddProperties_Click(object sender, EventArgs e)
        {
            mode = "add";
            txtPropertyAgent.Focus();
            txtPropertyAgent.Text = txtPropertyLocation.Text = txtPropertyType.Text = txtPropertyPrice.Text = txtPropertySize.Text = "";
            txtPropertyAgent.BackColor = txtPropertyLocation.BackColor = txtPropertyType.BackColor = txtPropertyPrice.BackColor = txtPropertySize.BackColor = Color.LightBlue;
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

        private void btnEditProperties_Click(object sender, EventArgs e)
        {
            mode = "edit";
            txtPropertyAgent.BackColor = txtPropertyLocation.BackColor = txtPropertyType.BackColor = txtPropertyPrice.BackColor = txtPropertySize.BackColor = Color.LightBlue;
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

        private void btnCancelProperties_Click(object sender, EventArgs e)
        {
            txtPropertyAgent.BackColor = txtPropertyLocation.BackColor = txtPropertyType.BackColor = txtPropertyPrice.BackColor = txtPropertySize.BackColor = Color.White;

        }

        private void frmEmployee_Load(object sender, EventArgs e)
        {
            myRemax = new projectRemaxDBEntities1();

            var clientInfo = from cli in myRemax.Clients
                             select cli.RefClient;

            var propertyInfo = from prop in myRemax.Properties
                               select prop.RefProperty;

            cboClients.DisplayMember = "RefClient";
            cboClients.ValueMember = "RefClient";
            cboClients.DataSource = clientInfo.ToList();

            cboProperty.DisplayMember = "RefProperty";
            cboProperty.ValueMember = "RefProperty";
            cboProperty.DataSource = propertyInfo.ToList();

            tabClients = clsGlobal.mySet.Tables["Clients"];
            tabProperties = clsGlobal.mySet.Tables["Properties"];
        }
    }
}
