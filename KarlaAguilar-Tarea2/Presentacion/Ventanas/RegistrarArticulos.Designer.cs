
namespace Presentacion.Ventanas
{
    partial class RegistrarArticulos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrarArticulos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.txtCantidadDis = new System.Windows.Forms.TextBox();
            this.txtPrecioVendedor = new System.Windows.Forms.TextBox();
            this.txtPrecioFinal = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtIdArticulo = new System.Windows.Forms.TextBox();
            this.labelCant = new System.Windows.Forms.Label();
            this.labelPF = new System.Windows.Forms.Label();
            this.labelPV = new System.Windows.Forms.Label();
            this.labelactivo = new System.Windows.Forms.Label();
            this.labeldesc = new System.Windows.Forms.Label();
            this.label_idart = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel_line = new System.Windows.Forms.Panel();
            this.labeltitulo = new System.Windows.Forms.Label();
            this.TablaArticulos = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel_line.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaArticulos)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.BackColor = System.Drawing.Color.Transparent;
            this.rbNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.Location = new System.Drawing.Point(278, 116);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(55, 26);
            this.rbNo.TabIndex = 32;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = false;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.BackColor = System.Drawing.Color.Transparent;
            this.rbYes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYes.Location = new System.Drawing.Point(189, 116);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(48, 26);
            this.rbYes.TabIndex = 31;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Sí";
            this.rbYes.UseVisualStyleBackColor = false;
            // 
            // txtCantidadDis
            // 
            this.txtCantidadDis.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCantidadDis.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidadDis.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidadDis.Location = new System.Drawing.Point(696, 110);
            this.txtCantidadDis.Name = "txtCantidadDis";
            this.txtCantidadDis.Size = new System.Drawing.Size(145, 30);
            this.txtCantidadDis.TabIndex = 30;
            this.txtCantidadDis.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidadDis_KeyPress);
            // 
            // txtPrecioVendedor
            // 
            this.txtPrecioVendedor.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPrecioVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioVendedor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioVendedor.Location = new System.Drawing.Point(201, 168);
            this.txtPrecioVendedor.Name = "txtPrecioVendedor";
            this.txtPrecioVendedor.Size = new System.Drawing.Size(221, 30);
            this.txtPrecioVendedor.TabIndex = 29;
            this.txtPrecioVendedor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioVendedor_KeyPress);
            // 
            // txtPrecioFinal
            // 
            this.txtPrecioFinal.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPrecioFinal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioFinal.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioFinal.Location = new System.Drawing.Point(610, 168);
            this.txtPrecioFinal.Name = "txtPrecioFinal";
            this.txtPrecioFinal.Size = new System.Drawing.Size(231, 30);
            this.txtPrecioFinal.TabIndex = 28;
            this.txtPrecioFinal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioFinal_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtDescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDescripcion.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(596, 61);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(245, 30);
            this.txtDescripcion.TabIndex = 27;
            this.txtDescripcion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescripcion_KeyPress);
            // 
            // txtIdArticulo
            // 
            this.txtIdArticulo.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtIdArticulo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtIdArticulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIdArticulo.Location = new System.Drawing.Point(189, 61);
            this.txtIdArticulo.Name = "txtIdArticulo";
            this.txtIdArticulo.Size = new System.Drawing.Size(221, 30);
            this.txtIdArticulo.TabIndex = 26;
            this.txtIdArticulo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdArticulo_KeyPress);
            // 
            // labelCant
            // 
            this.labelCant.AutoSize = true;
            this.labelCant.BackColor = System.Drawing.Color.Transparent;
            this.labelCant.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCant.Location = new System.Drawing.Point(473, 117);
            this.labelCant.Name = "labelCant";
            this.labelCant.Size = new System.Drawing.Size(178, 23);
            this.labelCant.TabIndex = 25;
            this.labelCant.Text = "Cantidad Disponible";
            // 
            // labelPF
            // 
            this.labelPF.AutoSize = true;
            this.labelPF.BackColor = System.Drawing.Color.Transparent;
            this.labelPF.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPF.Location = new System.Drawing.Point(473, 175);
            this.labelPF.Name = "labelPF";
            this.labelPF.Size = new System.Drawing.Size(110, 23);
            this.labelPF.TabIndex = 24;
            this.labelPF.Text = "Precio Final";
            // 
            // labelPV
            // 
            this.labelPV.AutoSize = true;
            this.labelPV.BackColor = System.Drawing.Color.Transparent;
            this.labelPV.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPV.Location = new System.Drawing.Point(30, 175);
            this.labelPV.Name = "labelPV";
            this.labelPV.Size = new System.Drawing.Size(149, 23);
            this.labelPV.TabIndex = 23;
            this.labelPV.Text = "Precio Vendedor";
            // 
            // labelactivo
            // 
            this.labelactivo.AutoSize = true;
            this.labelactivo.BackColor = System.Drawing.Color.Transparent;
            this.labelactivo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelactivo.Location = new System.Drawing.Point(30, 117);
            this.labelactivo.Name = "labelactivo";
            this.labelactivo.Size = new System.Drawing.Size(65, 23);
            this.labelactivo.TabIndex = 22;
            this.labelactivo.Text = "Activo";
            // 
            // labeldesc
            // 
            this.labeldesc.AutoSize = true;
            this.labeldesc.BackColor = System.Drawing.Color.Transparent;
            this.labeldesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeldesc.Location = new System.Drawing.Point(473, 68);
            this.labeldesc.Name = "labeldesc";
            this.labeldesc.Size = new System.Drawing.Size(108, 23);
            this.labeldesc.TabIndex = 21;
            this.labeldesc.Text = "Descripción";
            // 
            // label_idart
            // 
            this.label_idart.AutoSize = true;
            this.label_idart.BackColor = System.Drawing.Color.Transparent;
            this.label_idart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idart.Location = new System.Drawing.Point(30, 68);
            this.label_idart.Name = "label_idart";
            this.label_idart.Size = new System.Drawing.Size(127, 23);
            this.label_idart.TabIndex = 20;
            this.label_idart.Text = "Id del artículo";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.MidnightBlue;
            this.btnRegistrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 2;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(610, 215);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(231, 49);
            this.btnRegistrar.TabIndex = 19;
            this.btnRegistrar.Text = "Registrar Artículo";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1094, 632);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 93);
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // panel_line
            // 
            this.panel_line.BackColor = System.Drawing.Color.Transparent;
            this.panel_line.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_line.Controls.Add(this.label_idart);
            this.panel_line.Controls.Add(this.labelactivo);
            this.panel_line.Controls.Add(this.labeltitulo);
            this.panel_line.Controls.Add(this.txtIdArticulo);
            this.panel_line.Controls.Add(this.labeldesc);
            this.panel_line.Controls.Add(this.btnRegistrar);
            this.panel_line.Controls.Add(this.txtPrecioFinal);
            this.panel_line.Controls.Add(this.txtPrecioVendedor);
            this.panel_line.Controls.Add(this.labelPF);
            this.panel_line.Controls.Add(this.txtCantidadDis);
            this.panel_line.Controls.Add(this.rbNo);
            this.panel_line.Controls.Add(this.txtDescripcion);
            this.panel_line.Controls.Add(this.labelPV);
            this.panel_line.Controls.Add(this.rbYes);
            this.panel_line.Controls.Add(this.labelCant);
            this.panel_line.Location = new System.Drawing.Point(154, 38);
            this.panel_line.Name = "panel_line";
            this.panel_line.Size = new System.Drawing.Size(883, 283);
            this.panel_line.TabIndex = 51;
            // 
            // labeltitulo
            // 
            this.labeltitulo.AutoSize = true;
            this.labeltitulo.BackColor = System.Drawing.Color.Transparent;
            this.labeltitulo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltitulo.Location = new System.Drawing.Point(142, 15);
            this.labeltitulo.Name = "labeltitulo";
            this.labeltitulo.Size = new System.Drawing.Size(593, 23);
            this.labeltitulo.TabIndex = 50;
            this.labeltitulo.Text = "Complete con la información correspondiende del artículo a registrar:";
            // 
            // TablaArticulos
            // 
            this.TablaArticulos.AllowUserToAddRows = false;
            this.TablaArticulos.AllowUserToDeleteRows = false;
            this.TablaArticulos.AllowUserToResizeColumns = false;
            this.TablaArticulos.AllowUserToResizeRows = false;
            this.TablaArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaArticulos.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.TablaArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.NullValue = null;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TablaArticulos.DefaultCellStyle = dataGridViewCellStyle6;
            this.TablaArticulos.Enabled = false;
            this.TablaArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.TablaArticulos.Location = new System.Drawing.Point(40, 20);
            this.TablaArticulos.Name = "TablaArticulos";
            this.TablaArticulos.RowHeadersVisible = false;
            this.TablaArticulos.RowHeadersWidth = 51;
            this.TablaArticulos.RowTemplate.Height = 24;
            this.TablaArticulos.Size = new System.Drawing.Size(802, 286);
            this.TablaArticulos.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TablaArticulos);
            this.panel1.Location = new System.Drawing.Point(154, 347);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 327);
            this.panel1.TabIndex = 53;
            // 
            // RegistrarArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1200, 737);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel_line);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar Artículo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel_line.ResumeLayout(false);
            this.panel_line.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaArticulos)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.TextBox txtCantidadDis;
        private System.Windows.Forms.TextBox txtPrecioVendedor;
        private System.Windows.Forms.TextBox txtPrecioFinal;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox txtIdArticulo;
        private System.Windows.Forms.Label labelCant;
        private System.Windows.Forms.Label labelPF;
        private System.Windows.Forms.Label labelPV;
        private System.Windows.Forms.Label labelactivo;
        private System.Windows.Forms.Label labeldesc;
        private System.Windows.Forms.Label label_idart;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel_line;
        private System.Windows.Forms.Label labeltitulo;
        private System.Windows.Forms.DataGridView TablaArticulos;
        private System.Windows.Forms.Panel panel1;
    }
}