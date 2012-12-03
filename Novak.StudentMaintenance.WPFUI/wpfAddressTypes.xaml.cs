using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

using Novak.StudentMaintenance.BL;

namespace Novak.StudentMaintenance.WPFUI
{
    /// <summary>
    /// Interaction logic for wpfAddressTypes.xaml
    /// </summary>
    public partial class wpfAddressTypes : Window
    {
        CAddressTypes oAddressTypes;

        public wpfAddressTypes()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                oAddressTypes = new CAddressTypes();

                oAddressTypes.GetData();

                dgAddressTypes.ItemsSource = null;
                dgAddressTypes.ItemsSource = oAddressTypes.AddressTypes;
            }
            catch (Exception ex)
            {
                lblStatus.Content = ex.Message;
            }
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                oAddressTypes.AddressTypes[dgAddressTypes.SelectedIndex].Delete();
                oAddressTypes.RemoveAt(dgAddressTypes.SelectedIndex);

                dgAddressTypes.ItemsSource = null;
                dgAddressTypes.ItemsSource = oAddressTypes.AddressTypes;
            }
            catch (Exception ex)
            {
                lblStatus.Content = ex.Message;
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                oAddressTypes.AddressTypes[dgAddressTypes.SelectedIndex].Id = ((CAddressType)dgAddressTypes.Items[dgAddressTypes.SelectedIndex]).Id;
                oAddressTypes.AddressTypes[dgAddressTypes.SelectedIndex].Description = ((CAddressType)dgAddressTypes.Items[dgAddressTypes.SelectedIndex]).Description;
                oAddressTypes.AddressTypes[dgAddressTypes.SelectedIndex].Update();

                dgAddressTypes.ItemsSource = null;
                dgAddressTypes.ItemsSource = oAddressTypes.AddressTypes;
            }
            catch (Exception ex)
            {
                lblStatus.Content = ex.Message;
            }
        }

        private void btnInsert_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CAddressType oAddressType = new CAddressType(dgAddressTypes.Items.Count, ((CAddressType)dgAddressTypes.Items[dgAddressTypes.SelectedIndex]).Description);

                //dgAddressTypes.ItemsSource = null;

                oAddressTypes.Insert(oAddressType);
                //Thread.Sleep(1000);
                dgAddressTypes.ItemsSource = null;
                dgAddressTypes.ItemsSource = oAddressTypes.AddressTypes;
            }
            catch (Exception ex)
            {
                lblStatus.Content = ex.Message;
            }
        }
    }
}
