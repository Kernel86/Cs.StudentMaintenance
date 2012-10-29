using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Novak.StudentMaintenance.BL;

namespace Novak.StudentMaintenance.UI
{
    public partial class frmMaintenance : Form
    {
        CAddressTypes oAddressTypes;

        public frmMaintenance()
        {
            InitializeComponent();
        }

        private void btnMakePerson_Click(object sender, EventArgs e)
        {
            //CPerson oPerson = new CPerson();

            //oPerson.Firstname = txtFirstname.Text;
            //oPerson.Lastname = txtLastname.Text;

            //lblFullname.Text = oPerson.Fullname;

            //oPerson = null;
        }

        private void btnMakeStudent_Click(object sender, EventArgs e)
        {
            CStudent oStudent = new CStudent();

            oStudent.Firstname = txtFirstname.Text;
            oStudent.Lastname = txtLastname.Text;

            lblFullname.Text = oStudent.Fullname;

            oStudent = null;
        }

        private void btnLoadAddressTypes_Click(object sender, EventArgs e)
        {
            lblStatus.Text = String.Empty;
            try
            {
                // Instantiate an AddressTypes object
                oAddressTypes = new CAddressTypes();

                // Call the Load
                oAddressTypes.Load();

                // Bind to the combobox
                cboAddressTypes.DataSource = oAddressTypes.AddressTypes;
                cboAddressTypes.DisplayMember = "Description";
                cboAddressTypes.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void btnMakeAddressTypes_Click(object sender, EventArgs e)
        {
            lblStatus.Text = String.Empty;
            try
            {
                oAddressTypes = new CAddressTypes();
                oAddressTypes.MakeAddressTypes();
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }

        private void btnSaveAddressTypes_Click(object sender, EventArgs e)
        {
            try
            {
                oAddressTypes.Save();
            }
            catch (Exception ex)
            {
                lblStatus.Text = ex.Message;
            }
        }
    }
}
