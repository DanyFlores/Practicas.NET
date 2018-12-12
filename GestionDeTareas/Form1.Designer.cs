namespace GestionDeTareas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ltb_Task = new System.Windows.Forms.ListBox();
            this.txt_Task = new System.Windows.Forms.TextBox();
            this.lbl_Tarea = new System.Windows.Forms.Label();
            this.btn_AddTask = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.btn_Cancelar);
            this.panel1.Controls.Add(this.btn_Eliminar);
            this.panel1.Controls.Add(this.btn_Guardar);
            this.panel1.Controls.Add(this.btn_AddTask);
            this.panel1.Controls.Add(this.lbl_Tarea);
            this.panel1.Controls.Add(this.txt_Task);
            this.panel1.Controls.Add(this.ltb_Task);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 313);
            this.panel1.TabIndex = 0;
            // 
            // ltb_Task
            // 
            this.ltb_Task.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ltb_Task.FormattingEnabled = true;
            this.ltb_Task.Location = new System.Drawing.Point(5, 108);
            this.ltb_Task.Name = "ltb_Task";
            this.ltb_Task.Size = new System.Drawing.Size(634, 199);
            this.ltb_Task.TabIndex = 0;
            // 
            // txt_Task
            // 
            this.txt_Task.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Task.Location = new System.Drawing.Point(54, 58);
            this.txt_Task.Multiline = true;
            this.txt_Task.Name = "txt_Task";
            this.txt_Task.Size = new System.Drawing.Size(507, 33);
            this.txt_Task.TabIndex = 1;
            // 
            // lbl_Tarea
            // 
            this.lbl_Tarea.AutoSize = true;
            this.lbl_Tarea.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Tarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tarea.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Tarea.Location = new System.Drawing.Point(3, 59);
            this.lbl_Tarea.Name = "lbl_Tarea";
            this.lbl_Tarea.Size = new System.Drawing.Size(45, 16);
            this.lbl_Tarea.TabIndex = 2;
            this.lbl_Tarea.Text = "Tarea";
            // 
            // btn_AddTask
            // 
            this.btn_AddTask.Location = new System.Drawing.Point(6, 6);
            this.btn_AddTask.Name = "btn_AddTask";
            this.btn_AddTask.Size = new System.Drawing.Size(124, 33);
            this.btn_AddTask.TabIndex = 3;
            this.btn_AddTask.Text = "Agregar Nueva Tarea";
            this.btn_AddTask.UseVisualStyleBackColor = true;
            this.btn_AddTask.Click += new System.EventHandler(this.btn_AddTask_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Guardar.Location = new System.Drawing.Point(324, 6);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(75, 33);
            this.btn_Guardar.TabIndex = 4;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = true;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Eliminar.Location = new System.Drawing.Point(405, 6);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(75, 33);
            this.btn_Eliminar.TabIndex = 5;
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cancelar.Location = new System.Drawing.Point(486, 6);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(75, 33);
            this.btn_Cancelar.TabIndex = 6;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 313);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_AddTask;
        private System.Windows.Forms.Label lbl_Tarea;
        private System.Windows.Forms.TextBox txt_Task;
        private System.Windows.Forms.ListBox ltb_Task;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Guardar;
    }
}

