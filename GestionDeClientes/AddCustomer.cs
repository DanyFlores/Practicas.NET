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
    public partial class AddCustomer : Form
    {
        private Customer _editingCustomer;
        public AddCustomer()
        {
            InitializeComponent();
        }

        public Customer EditingCustomer
        {
            get { return _editingCustomer; }
            set { _editingCustomer = value;
                bindingSource.Add(_editingCustomer);
            }
        }
        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
