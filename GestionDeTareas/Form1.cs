using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionDeTareas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        #region Metodos
        public void AddNewTask()
        {
            this.txt_Task.Enabled = true;
            this.btn_Guardar.Enabled = true;
            this.btn_Cancelar.Enabled = true;
            this.txt_Task.Focus();
        }
        public void DeleteTask()
        {

        }
        public void SaveChanges()
        {
            this.ltb_Task.Items.Add(txt_Task.Text);
            this.ltb_Task.Enabled = true;
        }
        public void Cancel()
        {

        }
        #endregion

        #region Eventos
        private void Form1_Load(object sender, EventArgs e)
        {
            this.btn_Guardar.Enabled = false;
            this.btn_Eliminar.Enabled = false;
            this.btn_Cancelar.Enabled = false;
            this.ltb_Task.Enabled = false;
            this.txt_Task.Enabled = false;
        }
        private void btn_AddTask_Click(object sender, EventArgs e)
        {
            this.AddNewTask();
        }
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            this.SaveChanges();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            this.DeleteTask();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Cancel();
        }
        #endregion

    }
}
