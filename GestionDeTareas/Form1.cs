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
        public bool _isNewTask;
        public Form1()
        {
            InitializeComponent();
            this.LoadValue();
        }
        #region Metodos
        public void AddNewTask()
        {
            this.txt_Task.Enabled = true;
            this.btn_Guardar.Enabled = true;
            this.btn_Cancelar.Enabled = true;
            this.txt_Task.Focus();
            _isNewTask = true;
        }
        public void DeleteTask()
        {
            if (MessageBox.Show("Seguro que desea eliminarlo", "confimacion de Eliminacion", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {   
                if (ltb_Task.SelectedIndex >= 0 && ltb_Task.SelectedIndex <= ltb_Task.Items.Count)
                {
                    this.ltb_Task.Items.RemoveAt(this.ltb_Task.SelectedIndex);
                    this.LoadValue();
                }
            }
        }
        public void SaveChanges()
        {
            if (txt_Task.Text != string.Empty)
            {
                if (_isNewTask)
                {
                    this.ltb_Task.Items.Add(txt_Task.Text);
                    this.txt_Task.Text = string.Empty;
                    this.ltb_Task.Enabled = true;
                    this.LoadValue();
                }
                else
                {
                    this.ltb_Task.Items[this.ltb_Task.SelectedIndex] = txt_Task.Text;
                    this.btn_AddTask.Enabled = true;
                    this.LoadValue();
                }
            }
            else
            {
                //MessageBox.Show("MEnsaje","Titulo",(Tipos de botones) MessageBoxButtons.OK,(tipos de iconos) MessageBoxIcon.Exclamation);
                MessageBox.Show("Debe Ingresar una tarea","Advertencia",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            
        }
        public void Cancel()
        {
            this.LoadValue();
        }

        public void LoadValue()
        {
            this.btn_Guardar.Enabled = false;
            this.btn_AddTask.Enabled = true;
            this.btn_Eliminar.Enabled = false;
            this.btn_Cancelar.Enabled = false;
            this.ltb_Task.Enabled = false;
            this.txt_Task.Enabled = false;
            this.txt_Task.Text = string.Empty;

            this.ltb_Task.Enabled = this.ltb_Task.Items.Count > 0;
        }

        public void LoadSelectedTask()
        {
            if(ltb_Task.SelectedIndex >= 0 && ltb_Task.SelectedIndex <= ltb_Task.Items.Count)
            {
                this.txt_Task.Text = ltb_Task.Items[ltb_Task.SelectedIndex].ToString();

                this.btn_AddTask.Enabled = false;
                this.btn_Guardar.Enabled = true;
                this.btn_Cancelar.Enabled = true;
                this.btn_Eliminar.Enabled = true;
                this.txt_Task.Enabled = true;

                _isNewTask = false;
            }            
        }
        #endregion

        #region Eventos
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

        private void ltb_Task_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.LoadSelectedTask();
        }
    }
}
