namespace GestionContactos
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
            this.btnAddContacto = new System.Windows.Forms.Button();
            this.btnDeleteContacto = new System.Windows.Forms.Button();
            this.btnModificarContacto = new System.Windows.Forms.Button();
            this.btnMostrarContactos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddContacto
            // 
            this.btnAddContacto.Location = new System.Drawing.Point(244, 24);
            this.btnAddContacto.Name = "btnAddContacto";
            this.btnAddContacto.Size = new System.Drawing.Size(146, 23);
            this.btnAddContacto.TabIndex = 0;
            this.btnAddContacto.Text = "Añadir contacto";
            this.btnAddContacto.UseVisualStyleBackColor = true;
            // 
            // btnDeleteContacto
            // 
            this.btnDeleteContacto.Location = new System.Drawing.Point(244, 90);
            this.btnDeleteContacto.Name = "btnDeleteContacto";
            this.btnDeleteContacto.Size = new System.Drawing.Size(146, 23);
            this.btnDeleteContacto.TabIndex = 1;
            this.btnDeleteContacto.Text = "eliminar contacto";
            this.btnDeleteContacto.UseVisualStyleBackColor = true;
            // 
            // btnModificarContacto
            // 
            this.btnModificarContacto.Location = new System.Drawing.Point(244, 139);
            this.btnModificarContacto.Name = "btnModificarContacto";
            this.btnModificarContacto.Size = new System.Drawing.Size(146, 23);
            this.btnModificarContacto.TabIndex = 2;
            this.btnModificarContacto.Text = "modificar teléfono";
            this.btnModificarContacto.UseVisualStyleBackColor = true;
            // 
            // btnMostrarContactos
            // 
            this.btnMostrarContactos.Location = new System.Drawing.Point(244, 199);
            this.btnMostrarContactos.Name = "btnMostrarContactos";
            this.btnMostrarContactos.Size = new System.Drawing.Size(146, 23);
            this.btnMostrarContactos.TabIndex = 3;
            this.btnMostrarContactos.Text = "mostrar contactos";
            this.btnMostrarContactos.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMostrarContactos);
            this.Controls.Add(this.btnModificarContacto);
            this.Controls.Add(this.btnDeleteContacto);
            this.Controls.Add(this.btnAddContacto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddContacto;
        private System.Windows.Forms.Button btnDeleteContacto;
        private System.Windows.Forms.Button btnModificarContacto;
        private System.Windows.Forms.Button btnMostrarContactos;
    }
}

