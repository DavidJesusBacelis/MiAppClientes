namespace MiAppClientes
{
    partial class Clientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAgregarClie = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btnEditarClie = new System.Windows.Forms.Button();
            this.btnEliminarClie = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lvUsers = new System.Windows.Forms.ListView();
            this.clmId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmNombre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmApellido = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmTelefono = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmCorreo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmIdCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnMostrarClie = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(241, 38);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(189, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(241, 75);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(189, 20);
            this.txtApellido.TabIndex = 1;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(241, 116);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(189, 20);
            this.txtTelefono.TabIndex = 2;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(241, 160);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(189, 20);
            this.txtCorreo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Apellidos (Ambos)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Correo Electronico";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(74, 1);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(287, 16);
            this.label5.TabIndex = 8;
            this.label5.Text = "Introduzca o seleccione los datos deseados.";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.cbxCategoria);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtCorreo);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtApellido);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(452, 286);
            this.panel1.TabIndex = 9;
            // 
            // btnAgregarClie
            // 
            this.btnAgregarClie.Location = new System.Drawing.Point(55, 104);
            this.btnAgregarClie.Name = "btnAgregarClie";
            this.btnAgregarClie.Size = new System.Drawing.Size(75, 43);
            this.btnAgregarClie.TabIndex = 13;
            this.btnAgregarClie.Text = "Agregar";
            this.btnAgregarClie.UseVisualStyleBackColor = true;
            this.btnAgregarClie.Click += new System.EventHandler(this.btnAgregarClie_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(80, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Seleccione la accion a realizar.";
            // 
            // btnEditarClie
            // 
            this.btnEditarClie.Location = new System.Drawing.Point(237, 104);
            this.btnEditarClie.Name = "btnEditarClie";
            this.btnEditarClie.Size = new System.Drawing.Size(75, 43);
            this.btnEditarClie.TabIndex = 14;
            this.btnEditarClie.Text = "Editar";
            this.btnEditarClie.UseVisualStyleBackColor = true;
            this.btnEditarClie.Click += new System.EventHandler(this.btnEditarClie_Click);
            // 
            // btnEliminarClie
            // 
            this.btnEliminarClie.Location = new System.Drawing.Point(55, 178);
            this.btnEliminarClie.Name = "btnEliminarClie";
            this.btnEliminarClie.Size = new System.Drawing.Size(75, 43);
            this.btnEliminarClie.TabIndex = 15;
            this.btnEliminarClie.Text = "Eliminar";
            this.btnEliminarClie.UseVisualStyleBackColor = true;
            this.btnEliminarClie.Click += new System.EventHandler(this.btnEliminarClie_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLimpiar);
            this.panel2.Controls.Add(this.btnEliminarClie);
            this.panel2.Controls.Add(this.btnEditarClie);
            this.panel2.Controls.Add(this.btnAgregarClie);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(497, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(367, 286);
            this.panel2.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(376, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 16);
            this.label7.TabIndex = 19;
            this.label7.Text = "Registros";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnMostrarClie);
            this.panel3.Controls.Add(this.lvUsers);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Location = new System.Drawing.Point(22, 319);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(831, 410);
            this.panel3.TabIndex = 20;
            // 
            // lvUsers
            // 
            this.lvUsers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmId,
            this.clmNombre,
            this.clmApellido,
            this.clmTelefono,
            this.clmCorreo,
            this.clmIdCategoria});
            this.lvUsers.FullRowSelect = true;
            this.lvUsers.Location = new System.Drawing.Point(6, 41);
            this.lvUsers.MultiSelect = false;
            this.lvUsers.Name = "lvUsers";
            this.lvUsers.Size = new System.Drawing.Size(825, 314);
            this.lvUsers.TabIndex = 20;
            this.lvUsers.UseCompatibleStateImageBehavior = false;
            this.lvUsers.View = System.Windows.Forms.View.Details;
            this.lvUsers.SelectedIndexChanged += new System.EventHandler(this.lvUsers_SelectedIndexChanged);
            // 
            // clmId
            // 
            this.clmId.Text = "Id";
            this.clmId.Width = 49;
            // 
            // clmNombre
            // 
            this.clmNombre.Text = "Nombre";
            this.clmNombre.Width = 105;
            // 
            // clmApellido
            // 
            this.clmApellido.Text = "Apellido";
            this.clmApellido.Width = 174;
            // 
            // clmTelefono
            // 
            this.clmTelefono.Text = "Telefono";
            this.clmTelefono.Width = 152;
            // 
            // clmCorreo
            // 
            this.clmCorreo.Text = "Correo Electronico";
            this.clmCorreo.Width = 266;
            // 
            // clmIdCategoria
            // 
            this.clmIdCategoria.Text = "Categoria";
            // 
            // btnMostrarClie
            // 
            this.btnMostrarClie.Location = new System.Drawing.Point(357, 361);
            this.btnMostrarClie.Name = "btnMostrarClie";
            this.btnMostrarClie.Size = new System.Drawing.Size(122, 43);
            this.btnMostrarClie.TabIndex = 21;
            this.btnMostrarClie.Text = "Mostrar clientes.";
            this.btnMostrarClie.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(237, 178);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 43);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar Campos";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 227);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Categoria.";
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(241, 227);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(189, 21);
            this.cbxCategoria.TabIndex = 10;
            this.cbxCategoria.SelectedIndexChanged += new System.EventHandler(this.cbxCategoria_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(88, 225);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Actualizar Categorias";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(876, 741);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAgregarClie;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditarClie;
        private System.Windows.Forms.Button btnEliminarClie;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView lvUsers;
        private System.Windows.Forms.ColumnHeader clmId;
        private System.Windows.Forms.ColumnHeader clmNombre;
        private System.Windows.Forms.ColumnHeader clmApellido;
        private System.Windows.Forms.ColumnHeader clmTelefono;
        private System.Windows.Forms.ColumnHeader clmCorreo;
        private System.Windows.Forms.ColumnHeader clmIdCategoria;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnMostrarClie;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label label8;
    }
}