
namespace Presentacion.Ventanas
{
    partial class ConsultarVentas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarVentas));
            this.TablaVendedores = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.cbIdOrden = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NombreVendedor = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Precio_F = new System.Windows.Forms.Label();
            this.PrecioV = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TablaInventarioArticulos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TablaVendedores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaInventarioArticulos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TablaVendedores
            // 
            this.TablaVendedores.AllowUserToAddRows = false;
            this.TablaVendedores.AllowUserToDeleteRows = false;
            this.TablaVendedores.AllowUserToResizeColumns = false;
            this.TablaVendedores.AllowUserToResizeRows = false;
            this.TablaVendedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaVendedores.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.TablaVendedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaVendedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaVendedores.Enabled = false;
            this.TablaVendedores.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.TablaVendedores.Location = new System.Drawing.Point(19, 15);
            this.TablaVendedores.Name = "TablaVendedores";
            this.TablaVendedores.RowHeadersVisible = false;
            this.TablaVendedores.RowHeadersWidth = 51;
            this.TablaVendedores.RowTemplate.Height = 24;
            this.TablaVendedores.Size = new System.Drawing.Size(429, 232);
            this.TablaVendedores.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1102, 620);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 93);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(75, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1033, 348);
            this.panel1.TabIndex = 54;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.TablaVendedores);
            this.panel5.Location = new System.Drawing.Point(18, 54);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(469, 269);
            this.panel5.TabIndex = 86;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.cbIdOrden);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.NombreVendedor);
            this.panel3.Location = new System.Drawing.Point(512, 11);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 182);
            this.panel3.TabIndex = 85;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(393, 23);
            this.label6.TabIndex = 74;
            this.label6.Text = "Elija un Id Orden Compra para ver el detalle:";
            // 
            // cbIdOrden
            // 
            this.cbIdOrden.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdOrden.FormattingEnabled = true;
            this.cbIdOrden.Location = new System.Drawing.Point(21, 55);
            this.cbIdOrden.Name = "cbIdOrden";
            this.cbIdOrden.Size = new System.Drawing.Size(250, 30);
            this.cbIdOrden.TabIndex = 62;
            this.cbIdOrden.SelectedIndexChanged += new System.EventHandler(this.cbIdOrden_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 23);
            this.label1.TabIndex = 75;
            this.label1.Text = "Nombre Completo del vendedor :";
            // 
            // NombreVendedor
            // 
            this.NombreVendedor.AutoSize = true;
            this.NombreVendedor.BackColor = System.Drawing.Color.Transparent;
            this.NombreVendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombreVendedor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreVendedor.Location = new System.Drawing.Point(30, 138);
            this.NombreVendedor.Name = "NombreVendedor";
            this.NombreVendedor.Size = new System.Drawing.Size(2, 24);
            this.NombreVendedor.TabIndex = 81;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.Precio_F);
            this.panel4.Controls.Add(this.PrecioV);
            this.panel4.Controls.Add(this.label22);
            this.panel4.Controls.Add(this.label21);
            this.panel4.Controls.Add(this.label20);
            this.panel4.Location = new System.Drawing.Point(512, 210);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(505, 113);
            this.panel4.TabIndex = 84;
            // 
            // Precio_F
            // 
            this.Precio_F.AutoSize = true;
            this.Precio_F.BackColor = System.Drawing.Color.Transparent;
            this.Precio_F.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Precio_F.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.Precio_F.Location = new System.Drawing.Point(214, 81);
            this.Precio_F.Name = "Precio_F";
            this.Precio_F.Size = new System.Drawing.Size(23, 21);
            this.Precio_F.TabIndex = 82;
            this.Precio_F.Text = "₡";
            // 
            // PrecioV
            // 
            this.PrecioV.AutoSize = true;
            this.PrecioV.BackColor = System.Drawing.Color.Transparent;
            this.PrecioV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrecioV.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.PrecioV.Location = new System.Drawing.Point(214, 47);
            this.PrecioV.Name = "PrecioV";
            this.PrecioV.Size = new System.Drawing.Size(23, 21);
            this.PrecioV.TabIndex = 81;
            this.PrecioV.Text = "₡";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(15, 83);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(150, 19);
            this.label22.TabIndex = 80;
            this.label22.Text = "Total Precio Final:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(15, 49);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(179, 19);
            this.label21.TabIndex = 79;
            this.label21.Text = "Total Precio Vendedor:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(15, 10);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(202, 22);
            this.label20.TabIndex = 78;
            this.label20.Text = "Desglose de la Factura:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(243, 23);
            this.label4.TabIndex = 34;
            this.label4.Text = "Consultar ventas realizadas";
            // 
            // TablaInventarioArticulos
            // 
            this.TablaInventarioArticulos.AllowUserToAddRows = false;
            this.TablaInventarioArticulos.AllowUserToDeleteRows = false;
            this.TablaInventarioArticulos.AllowUserToResizeColumns = false;
            this.TablaInventarioArticulos.AllowUserToResizeRows = false;
            this.TablaInventarioArticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.TablaInventarioArticulos.BackgroundColor = System.Drawing.SystemColors.ScrollBar;
            this.TablaInventarioArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TablaInventarioArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TablaInventarioArticulos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.TablaInventarioArticulos.Enabled = false;
            this.TablaInventarioArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.TablaInventarioArticulos.Location = new System.Drawing.Point(28, 48);
            this.TablaInventarioArticulos.Name = "TablaInventarioArticulos";
            this.TablaInventarioArticulos.RowHeadersVisible = false;
            this.TablaInventarioArticulos.RowHeadersWidth = 51;
            this.TablaInventarioArticulos.RowTemplate.Height = 24;
            this.TablaInventarioArticulos.Size = new System.Drawing.Size(960, 244);
            this.TablaInventarioArticulos.TabIndex = 49;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(433, 23);
            this.label2.TabIndex = 82;
            this.label2.Text = "Lista de artículos asociados a la orden de compra :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.TablaInventarioArticulos);
            this.panel2.Location = new System.Drawing.Point(75, 391);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1007, 311);
            this.panel2.TabIndex = 83;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Id Artículo";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Artículo";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cantidad";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Precio Vendedor";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Precio Final";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            // 
            // ConsultarVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1200, 737);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarVentas";
            ((System.ComponentModel.ISupportInitialize)(this.TablaVendedores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaInventarioArticulos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TablaVendedores;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView TablaInventarioArticulos;
        private System.Windows.Forms.ComboBox cbIdOrden;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NombreVendedor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label Precio_F;
        private System.Windows.Forms.Label PrecioV;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}