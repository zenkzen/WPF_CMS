using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_CMS.Models;
using WPF_CMS.ViewModels;

namespace WPF_CMS
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;
        public MainWindow()
        {
            InitializeComponent();
            _viewModel = new MainViewModel();
            _viewModel.LoadCustomers();
            DataContext = _viewModel;
            //ShowCustomers();
        }
        //private void ShowCustomers()
        //{
        //    try 
        //    {
        //        using(var db = new AppDbContext())
        //        {
        //            //var customers = db.Customers.ToList();
        //            //customerList.DisplayMemberPath = "Name";
        //            //customerList.SelectedValuePath = "Id";
        //            //customerList.ItemsSource = customers;
        //        }
        //    } catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //}

        //private void customerList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    try
        //    {
               
        //        //if (customerList == null) return;
        //        //Customer selectedItem = customerList.SelectedItem as Customer;
        //        //if (selectedItem == null)
        //        //{
        //        //    appointmentList.ItemsSource = null;
        //        //    return;
        //        //}
        //        //NameTextBox.Text = selectedItem.Name;
        //        //IdNumberTextBox.Text = selectedItem.IdNumber;
        //        //AddressTextBox.Text = selectedItem.Address;
        //        //using(var db = new AppDbContext())
        //        //{
        //        //    var customerId = (int)selectedItem.Id;
        //        //    var appointment = db.Appointments.Where(a => a.CustomerId == customerId).ToList();
        //        //    appointmentList.DisplayMemberPath = "Time";
        //        //    appointmentList.SelectedValuePath = "Id";
        //        //    appointmentList.ItemsSource = appointment;
        //        //}

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        // }

        //private void DeleteAppointment_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        //var appointmentId = appointmentList.SelectedValue;
        //        //using (var db = new AppDbContext())
        //        //{
        //        //    var appointmentToRemove = db.Appointments.Where(a => a.Id == (int)appointmentId).FirstOrDefault();
        //        //    db.Appointments.Remove(appointmentToRemove);
        //        //    db.SaveChanges();
        //        //}
 
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally {
        //        customerList_SelectionChanged(null, null);
        //    }

        //}

        //private void DeleteCustomer_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
               
        //        //var customerId = customerList.SelectedValue;

        //        //using (var db = new AppDbContext())
        //        //{

        //        //    // 注意: 关联的Appointments表记录不为空，级联删除会报错
        //        //    var customerToRemove = db.Customers
        //        //        .Include(c => c.Appointments)
        //        //        .Where(c => c.Id == (int)customerId)
        //        //        .FirstOrDefault();
        //        //    db.Customers.Remove(customerToRemove);
        //        //    db.SaveChanges();
        //        //}

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally
        //    {
        //        ShowCustomers();
        //        customerList_SelectionChanged(null, null);
        //    }
        //}

        //private void AddCustomer_Click(object sender, RoutedEventArgs e)
        //{
        //    try
        //    {
        //        using(var db = new AppDbContext())
        //        {
        //            //var item = new Customer()
        //            //{
        //            //    Name = NameTextBox.Text.Trim(),
        //            //    IdNumber = IdNumberTextBox.Text.Trim(),
        //            //    Address = AddressTextBox.Text.Trim(),
        //            //};
        //            //db.Customers.Add(item);
        //            //db.SaveChanges();
        //        }

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.ToString());
        //    }
        //    finally
        //    {
        //        ShowCustomers();
        //    }

        //}


        private void ClearSelectedCustomer_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.ClearSelectedCustomer();

        }

        private void SaveCustomer_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = NameTextBox.Text.Trim();
                string idNumber = IdNumberTextBox.Text.Trim();
                string address = AddressTextBox.Text.Trim();
                _viewModel.SaveCustomer(name, idNumber, address);

            } catch (Exception ex)
            { 
                MessageBox.Show(ex.ToString());
            }  
        }

        private void AddAppointment_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _viewModel.AddAppointment();

            } catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
