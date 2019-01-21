using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeClientes
{
    public partial class Form1 : Form
    {
        public CustomerManager _customerManager ;
        public Form1()
        {
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            _customerManager = new CustomerManager();           
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            lst_ViewCustomer.Items.Clear();
            List<Customer> customers = _customerManager.Customers;
            foreach (Customer customer in customers)
            {
                ListViewItem  item = lst_ViewCustomer.Items.Add(customer.Name);
                item.SubItems.Add(customer.LastName);               
                item.SubItems.Add(customer.Address);
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            AddCustomer add = new AddCustomer();
            add.EditingCustomer = new Customer();

            if (add.ShowDialog() == DialogResult.OK)
            {
                Customer newcustomer = add.EditingCustomer;
                _customerManager.AddCustomer(newcustomer.Name, newcustomer.LastName, newcustomer.Address);
                btn_Refresh.PerformClick();
            }
        }
    } 
}
