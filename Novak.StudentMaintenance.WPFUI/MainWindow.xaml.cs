using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

using Novak.StudentMaintenance.BL;

namespace Novak.StudentMaintenance.WPFUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        CAddressTypes oAddressTypes;
        CStudent oStudent;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnMakePerson_Click(object sender, RoutedEventArgs e)
        {

        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            CStudent oStudent = new CStudent();

            oStudent.Firstname = txtFirstname.Text;
            oStudent.Lastname = txtLastname.Text;

            lblFullname.Content = oStudent.Fullname;

            oStudent = null;
        }

        private void btnLoadAddressTypes_Click(object sender, RoutedEventArgs e)
        {
            lblStatus.Content = String.Empty;
            try
            {
                // Instantiate an AddressTypes object
                oAddressTypes = new CAddressTypes();

                // Call the Load
                oAddressTypes.Load();

                // Bind to the combobox
                cboAddressTypes.ItemsSource = oAddressTypes.AddressTypes;
                cboAddressTypes.DisplayMemberPath = "Description";
                cboAddressTypes.SelectedValuePath = "Id";

                dgvAddressTypes.DataContext = oAddressTypes.AddressTypes;
            }
            catch (Exception ex)
            {
                lblStatus.Content = ex.Message;
            }
        }

        private void btnMakeAddressTypes_Click(object sender, RoutedEventArgs e)
        {
            lblStatus.Content = String.Empty;
            try
            {
                oAddressTypes = new CAddressTypes();
                oAddressTypes.MakeAddressTypes();
            }
            catch (Exception ex)
            {
                lblStatus.Content = ex.Message;
            }
        }

        private void btnSaveAddressTypes_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                oAddressTypes.Save();
            }
            catch (Exception ex)
            {
                lblStatus.Content = ex.Message;
            }
        }

        private void btnSaveAddressTypesXML_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                oAddressTypes.SaveXML();
            }
            catch (Exception ex)
            {
                lblStatus.Content = ex.Message;
            }
        }

        private void btnLoadAddressTypesXML_Click(object sender, RoutedEventArgs e)
        {
            lblStatus.Content = String.Empty;
            try
            {
                // Instantiate an AddressTypes object
                oAddressTypes = new CAddressTypes();

                // Call the Load
                oAddressTypes.LoadXML();

                // Bind to the combobox
                cboAddressTypes.ItemsSource = oAddressTypes.AddressTypes;
                cboAddressTypes.DisplayMemberPath = "Description";
                cboAddressTypes.SelectedValuePath = "Id";

                // Bind the datagrid view to the list
                dgvAddressTypes.DataContext = oAddressTypes.AddressTypes;
            }
            catch (Exception ex)
            {
                lblStatus.Content = ex.Message;
            }
        }

        private void btnMakeStudents_Click(object sender, RoutedEventArgs e)
        {
            lblStatus.Content = String.Empty;
            try
            {
                oStudent = new CStudent();
                oStudent.MakeStudent();
            }
            catch (Exception ex)
            {
                lblStatus.Content = ex.Message;
            }
        }

        private void btnSaveStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                oStudent.SaveStudent();
            }
            catch (Exception ex)
            {
                lblStatus.Content = ex.Message;
            }
        }
    }
}
