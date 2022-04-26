
namespace Presentacion.Ventanas
{
    partial class RegistrarVendedores
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarVendedores));
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.CalendarIngreso = new System.Windows.Forms.DateTimePicker();
            this.CalendarNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtApellido2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido1 = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtIdentificacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TablaIVendedores = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaIVendedores)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(762, 206);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(175, 48);
            this.btnRegistrar.TabIndex = 44;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // CalendarIngreso
            // 
            this.CalendarIngreso.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CalendarIngreso.Location = new System.Drawing.Point(248, 199);
            this.CalendarIngreso.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.CalendarIngreso.Name = "CalendarIngreso";
            this.CalendarIngreso.Size = new System.Drawing.Size(205, 30);
            this.CalendarIngreso.TabIndex = 42;
            this.CalendarIngreso.Value = new System.DateTime(2021, 9, 30, 0, 0, 0, 0);
            // 
            // CalendarNacimiento
            // 
            this.CalendarNacimiento.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalendarNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.CalendarNacimiento.Location = new System.Drawing.Point(248, 156);
            this.CalendarNacimiento.MaxDate = new System.DateTime(2021, 12, 31, 0, 0, 0, 0);
            this.CalendarNacimiento.MinDate = new System.DateTime(1930, 1, 1, 0, 0, 0, 0);
            this.CalendarNacimiento.Name = "CalendarNacimiento";
            this.CalendarNacimiento.Size = new System.Drawing.Size(205, 30);
            this.CalendarNacimiento.TabIndex = 41;
            this.CalendarNacimiento.Value = new System.DateTime(2021, 9, 30, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 206);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(151, 23);
            this.label7.TabIndex = 40;
            this.label7.Text = "Fecha de ingreso";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(52, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(181, 23);
            this.label6.TabIndex = 39;
            this.label6.Text = "Fecha de nacimiento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(522, 165);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 23);
            this.label5.TabIndex = 38;
            this.label5.Text = "Género";
            // 
            // txtApellido2
            // 
            this.txtApellido2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtApellido2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido2.Location = new System.Drawing.Point(718, 110);
            this.txtApellido2.Name = "txtApellido2";
            this.txtApellido2.Size = new System.Drawing.Size(219, 30);
            this.txtApellido2.TabIndex = 37;
            this.txtApellido2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido2_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(522, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 23);
            this.label3.TabIndex = 36;
            this.label3.Text = "Segundo Apellido";
            // 
            // txtApellido1
            // 
            this.txtApellido1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtApellido1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellido1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido1.Location = new System.Drawing.Point(248, 110);
            this.txtApellido1.Name = "txtApellido1";
            this.txtApellido1.Size = new System.Drawing.Size(205, 30);
            this.txtApellido1.TabIndex = 35;
            this.txtApellido1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido1_KeyPress);
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(651, 62);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(286, 30);
            this.txtNombre.TabIndex = 34;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // txtIdentificacion
            // 
            this.txtIdentificacion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtIdentificacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdentificacion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdentificacion.Location = new System.Drawing.Point(248, 62);
            this.txtIdentificacion.Name = "txtIdentificacion";
            this.txtIdentificacion.Size = new System.Drawing.Size(205, 30);
            this.txtIdentificacion.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(52, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Primer Apellido";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(522, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "Nombre";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 23);
            this.label1.TabIndex = 30;
            this.label1.Text = "Identificación";
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.BackColor = System.Drawing.Color.Transparent;
            this.rbFemenino.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFemenino.Location = new System.Drawing.Point(630, 164);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(136, 26);
            this.rbFemenino.TabIndex = 45;
            this.rbFemenino.TabStop = true;
            this.rbFemenino.Text = "Femenino - F";
            this.rbFemenino.UseVisualStyleBackColor = false;
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.BackColor = System.Drawing.Color.Transparent;
            this.rbMasculino.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasculino.Location = new System.Drawing.Point(789, 164);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(148, 26);
            this.rbMasculino.TabIndex = 46;
            this.rbMasculino.TabStop = true;
            this.rbMasculino.Text = "Masculino - M";
            this.rbMasculino.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(184, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(611, 23);
            this.label8.TabIndex = 47;
            this.label8.Text = "Complete con la información correspondiende del vendedor a registrar :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1099, 632);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 93);
            this.pictureBox1.TabIndex = 48;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btnRegistrar);
            this.panel1.Controls.Add(this.rbMasculino);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.rbFemenino);
            this.panel1.Controls.Add(this.txtIdentificacion);
            this.panel1.Controls.Add(this.txtApellido1);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.CalendarIngreso);
            this.panel1.Controls.Add(this.txtApellido2);
            this.panel1.Controls.Add(this.CalendarNacimiento);
            this.panel1.Controls.Add(this.txtNombre);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(91, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(989, 272);
            this.panel1.TabIndex = 49;
            // 
            // TablaIVendedores
            // 
            this.TablaIVendedores.AllowUserToAddRows = false;
            this.TablaIVendedores.AllowUserToDeleteRows = false;
            this.TablaIVendedores.AllowUserToResizeColumns = false;
            this.TablaIVendedores.AllowUserToResizeRows = false;
            this.TablaIVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaIVendedores.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.TablaIVendedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaIVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaIVendedores.Enabled = false;
            this.TablaIVendedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.TablaIVendedores.Location = new System.Drawing.Point(38, 19);
            this.TablaIVendedores.Name = "TablaIVendedores";
            this.TablaIVendedores.RowHeadersVisible = false;
            this.TablaIVendedores.RowHeadersWidth = 51;
            this.TablaIVendedores.RowTemplate.Height = 24;
            this.TablaIVendedores.Size = new System.Drawing.Size(915, 314);
            this.TablaIVendedores.TabIndex = 53;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.TablaIVendedores);
            this.panel2.Location = new System.Drawing.Point(90, 336);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(990, 352);
            this.panel2.TabIndex = 54;
            // 
            // RegistrarVendedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1200, 737);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegistrarVendedores";
            this.Text = "RegistrarVendedores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaIVendedores)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DateTimePicker CalendarIngreso;
        private System.Windows.Forms.DateTimePicker CalendarNacimiento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtApellido2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtIdentificacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView TablaIVendedores;
        private System.Windows.Forms.Panel panel2;
    }
}