namespace Inicio_Sesion
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
            this.gp_DatosPersonales = new System.Windows.Forms.GroupBox();
            this.btn_Iniciar = new System.Windows.Forms.Button();
            this.txt_Apellidos = new System.Windows.Forms.TextBox();
            this.txt_Nombre = new System.Windows.Forms.TextBox();
            this.txt_Direccion = new System.Windows.Forms.TextBox();
            this.txt_Id = new System.Windows.Forms.TextBox();
            this.txt_Telefono = new System.Windows.Forms.TextBox();
            this.lbl_Direccion = new System.Windows.Forms.Label();
            this.lbl_Apellidos = new System.Windows.Forms.Label();
            this.lbl_Telefono = new System.Windows.Forms.Label();
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gp_DatosPersonales.SuspendLayout();
            this.SuspendLayout();
            // 
            // gp_DatosPersonales
            // 
            this.gp_DatosPersonales.Controls.Add(this.btn_Iniciar);
            this.gp_DatosPersonales.Controls.Add(this.txt_Apellidos);
            this.gp_DatosPersonales.Controls.Add(this.txt_Nombre);
            this.gp_DatosPersonales.Controls.Add(this.txt_Direccion);
            this.gp_DatosPersonales.Controls.Add(this.txt_Id);
            this.gp_DatosPersonales.Controls.Add(this.txt_Telefono);
            this.gp_DatosPersonales.Controls.Add(this.lbl_Direccion);
            this.gp_DatosPersonales.Controls.Add(this.lbl_Apellidos);
            this.gp_DatosPersonales.Controls.Add(this.lbl_Telefono);
            this.gp_DatosPersonales.Controls.Add(this.lbl_Nombre);
            this.gp_DatosPersonales.Controls.Add(this.lbl_Id);
            this.gp_DatosPersonales.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gp_DatosPersonales.Location = new System.Drawing.Point(52, 80);
            this.gp_DatosPersonales.Name = "gp_DatosPersonales";
            this.gp_DatosPersonales.Size = new System.Drawing.Size(689, 208);
            this.gp_DatosPersonales.TabIndex = 0;
            this.gp_DatosPersonales.TabStop = false;
            this.gp_DatosPersonales.Text = "Datos Personales";
            // 
            // btn_Iniciar
            // 
            this.btn_Iniciar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_Iniciar.Location = new System.Drawing.Point(493, 145);
            this.btn_Iniciar.Name = "btn_Iniciar";
            this.btn_Iniciar.Size = new System.Drawing.Size(147, 35);
            this.btn_Iniciar.TabIndex = 5;
            this.btn_Iniciar.Text = "Iniciar";
            this.btn_Iniciar.UseVisualStyleBackColor = false;
            this.btn_Iniciar.Click += new System.EventHandler(this.btn_Iniciar_Click);
            // 
            // txt_Apellidos
            // 
            this.txt_Apellidos.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Apellidos.Location = new System.Drawing.Point(145, 142);
            this.txt_Apellidos.Name = "txt_Apellidos";
            this.txt_Apellidos.Size = new System.Drawing.Size(182, 25);
            this.txt_Apellidos.TabIndex = 2;
            this.txt_Apellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Apellidos_KeyPress);
            // 
            // txt_Nombre
            // 
            this.txt_Nombre.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nombre.Location = new System.Drawing.Point(145, 99);
            this.txt_Nombre.Name = "txt_Nombre";
            this.txt_Nombre.Size = new System.Drawing.Size(182, 25);
            this.txt_Nombre.TabIndex = 1;
            this.txt_Nombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Nombre_KeyPress);
            // 
            // txt_Direccion
            // 
            this.txt_Direccion.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Direccion.Location = new System.Drawing.Point(458, 99);
            this.txt_Direccion.Name = "txt_Direccion";
            this.txt_Direccion.Size = new System.Drawing.Size(182, 25);
            this.txt_Direccion.TabIndex = 4;
            this.txt_Direccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Direccion_KeyPress);
            // 
            // txt_Id
            // 
            this.txt_Id.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Id.Location = new System.Drawing.Point(145, 50);
            this.txt_Id.Name = "txt_Id";
            this.txt_Id.Size = new System.Drawing.Size(182, 25);
            this.txt_Id.TabIndex = 0;
            this.txt_Id.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Id_KeyPress);
            // 
            // txt_Telefono
            // 
            this.txt_Telefono.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Telefono.Location = new System.Drawing.Point(458, 50);
            this.txt_Telefono.Name = "txt_Telefono";
            this.txt_Telefono.Size = new System.Drawing.Size(182, 25);
            this.txt_Telefono.TabIndex = 3;
            this.txt_Telefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_Telefono_KeyPress);
            // 
            // lbl_Direccion
            // 
            this.lbl_Direccion.AutoSize = true;
            this.lbl_Direccion.Location = new System.Drawing.Point(352, 96);
            this.lbl_Direccion.Name = "lbl_Direccion";
            this.lbl_Direccion.Size = new System.Drawing.Size(81, 22);
            this.lbl_Direccion.TabIndex = 4;
            this.lbl_Direccion.Text = "Direccion";
            // 
            // lbl_Apellidos
            // 
            this.lbl_Apellidos.AutoSize = true;
            this.lbl_Apellidos.Location = new System.Drawing.Point(31, 145);
            this.lbl_Apellidos.Name = "lbl_Apellidos";
            this.lbl_Apellidos.Size = new System.Drawing.Size(81, 22);
            this.lbl_Apellidos.TabIndex = 3;
            this.lbl_Apellidos.Text = "Apellidos";
            // 
            // lbl_Telefono
            // 
            this.lbl_Telefono.AutoSize = true;
            this.lbl_Telefono.Location = new System.Drawing.Point(352, 53);
            this.lbl_Telefono.Name = "lbl_Telefono";
            this.lbl_Telefono.Size = new System.Drawing.Size(75, 22);
            this.lbl_Telefono.TabIndex = 2;
            this.lbl_Telefono.Text = "Telefono";
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(31, 99);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(72, 22);
            this.lbl_Nombre.TabIndex = 1;
            this.lbl_Nombre.Text = "Nombre";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(31, 50);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(26, 22);
            this.lbl_Id.TabIndex = 0;
            this.lbl_Id.Text = "Id";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(282, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 39);
            this.label6.TabIndex = 1;
            this.label6.Text = "INICIAR SESION";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.gp_DatosPersonales);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gp_DatosPersonales.ResumeLayout(false);
            this.gp_DatosPersonales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gp_DatosPersonales;
        private System.Windows.Forms.Label lbl_Direccion;
        private System.Windows.Forms.Label lbl_Apellidos;
        private System.Windows.Forms.Label lbl_Telefono;
        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_Telefono;
        private System.Windows.Forms.TextBox txt_Apellidos;
        private System.Windows.Forms.TextBox txt_Nombre;
        private System.Windows.Forms.TextBox txt_Direccion;
        private System.Windows.Forms.TextBox txt_Id;
        private System.Windows.Forms.Button btn_Iniciar;
    }
}

