
namespace Presentacion.Ventanas
{
    partial class ActualizarInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ActualizarInventario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.TablaArticulos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPrecioF = new System.Windows.Forms.TextBox();
            this.txtPrecioV = new System.Windows.Forms.TextBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.labelactivo = new System.Windows.Forms.Label();
            this.btnCantidad = new System.Windows.Forms.Button();
            this.btnPrecioVendedor = new System.Windows.Forms.Button();
            this.btnPrecioFinal = new System.Windows.Forms.Button();
            this.btnActivo = new System.Windows.Forms.Button();
            this.cbIdArticulo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaArticulos)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1097, 632);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 93);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.TablaArticulos);
            this.panel1.Location = new System.Drawing.Point(84, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(994, 351);
            this.panel1.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(297, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(300, 26);
            this.label4.TabIndex = 48;
            this.label4.Text = "Actualizar lista de artículos ";
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
            this.TablaArticulos.Enabled = false;
            this.TablaArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.TablaArticulos.Location = new System.Drawing.Point(21, 54);
            this.TablaArticulos.Name = "TablaArticulos";
            this.TablaArticulos.RowHeadersVisible = false;
            this.TablaArticulos.RowHeadersWidth = 51;
            this.TablaArticulos.RowTemplate.Height = 24;
            this.TablaArticulos.Size = new System.Drawing.Size(950, 278);
            this.TablaArticulos.TabIndex = 79;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(28, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(384, 23);
            this.label1.TabIndex = 51;
            this.label1.Text = "Elija el id del artículo que desea actualizar : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(510, 23);
            this.label2.TabIndex = 52;
            this.label2.Text = "¿Desea actualizar la cantidad de disponibilidad del artículo?";
            // 
            // txtCantidad
            // 
            this.txtCantidad.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCantidad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCantidad.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCantidad.Location = new System.Drawing.Point(581, 68);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(176, 34);
            this.txtCantidad.TabIndex = 54;
            this.txtCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCantidad_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(28, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(361, 23);
            this.label3.TabIndex = 57;
            this.label3.Text = "¿Desea actualizar el precio del vendedor?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(28, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(290, 23);
            this.label5.TabIndex = 58;
            this.label5.Text = "¿Desea actualizar el precio final?";
            // 
            // txtPrecioF
            // 
            this.txtPrecioF.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPrecioF.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioF.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioF.Location = new System.Drawing.Point(523, 178);
            this.txtPrecioF.Name = "txtPrecioF";
            this.txtPrecioF.Size = new System.Drawing.Size(234, 34);
            this.txtPrecioF.TabIndex = 59;
            this.txtPrecioF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioF_KeyPress);
            // 
            // txtPrecioV
            // 
            this.txtPrecioV.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtPrecioV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPrecioV.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecioV.Location = new System.Drawing.Point(523, 125);
            this.txtPrecioV.Name = "txtPrecioV";
            this.txtPrecioV.Size = new System.Drawing.Size(234, 34);
            this.txtPrecioV.TabIndex = 60;
            this.txtPrecioV.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecioV_KeyPress);
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.BackColor = System.Drawing.Color.Transparent;
            this.rbNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.Location = new System.Drawing.Point(655, 240);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(55, 26);
            this.rbNo.TabIndex = 63;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = false;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.BackColor = System.Drawing.Color.Transparent;
            this.rbYes.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYes.Location = new System.Drawing.Point(563, 240);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(48, 26);
            this.rbYes.TabIndex = 62;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "Sí";
            this.rbYes.UseVisualStyleBackColor = false;
            // 
            // labelactivo
            // 
            this.labelactivo.AutoSize = true;
            this.labelactivo.BackColor = System.Drawing.Color.Transparent;
            this.labelactivo.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelactivo.Location = new System.Drawing.Point(28, 244);
            this.labelactivo.Name = "labelactivo";
            this.labelactivo.Size = new System.Drawing.Size(336, 22);
            this.labelactivo.TabIndex = 61;
            this.labelactivo.Text = "¿Desea actualizar el activo del artículo?";
            // 
            // btnCantidad
            // 
            this.btnCantidad.BackColor = System.Drawing.Color.Navy;
            this.btnCantidad.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCantidad.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnCantidad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCantidad.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCantidad.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCantidad.Location = new System.Drawing.Point(776, 57);
            this.btnCantidad.Name = "btnCantidad";
            this.btnCantidad.Size = new System.Drawing.Size(195, 45);
            this.btnCantidad.TabIndex = 64;
            this.btnCantidad.Text = "Actualizar Cantidad";
            this.btnCantidad.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCantidad.UseVisualStyleBackColor = false;
            this.btnCantidad.Click += new System.EventHandler(this.btnCantidad_Click);
            // 
            // btnPrecioVendedor
            // 
            this.btnPrecioVendedor.BackColor = System.Drawing.Color.Navy;
            this.btnPrecioVendedor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPrecioVendedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPrecioVendedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecioVendedor.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecioVendedor.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrecioVendedor.Location = new System.Drawing.Point(776, 115);
            this.btnPrecioVendedor.Name = "btnPrecioVendedor";
            this.btnPrecioVendedor.Size = new System.Drawing.Size(196, 44);
            this.btnPrecioVendedor.TabIndex = 65;
            this.btnPrecioVendedor.Text = "Actualizar Precio Vendedor";
            this.btnPrecioVendedor.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPrecioVendedor.UseVisualStyleBackColor = false;
            this.btnPrecioVendedor.Click += new System.EventHandler(this.btnPrecioVendedor_Click);
            // 
            // btnPrecioFinal
            // 
            this.btnPrecioFinal.BackColor = System.Drawing.Color.Navy;
            this.btnPrecioFinal.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnPrecioFinal.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnPrecioFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrecioFinal.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrecioFinal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPrecioFinal.Location = new System.Drawing.Point(776, 169);
            this.btnPrecioFinal.Name = "btnPrecioFinal";
            this.btnPrecioFinal.Size = new System.Drawing.Size(196, 43);
            this.btnPrecioFinal.TabIndex = 66;
            this.btnPrecioFinal.Text = "Actualizar Precio Final";
            this.btnPrecioFinal.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnPrecioFinal.UseVisualStyleBackColor = false;
            this.btnPrecioFinal.Click += new System.EventHandler(this.btnPrecioFinal_Click);
            // 
            // btnActivo
            // 
            this.btnActivo.BackColor = System.Drawing.Color.Navy;
            this.btnActivo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnActivo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.btnActivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnActivo.Location = new System.Drawing.Point(776, 224);
            this.btnActivo.Name = "btnActivo";
            this.btnActivo.Size = new System.Drawing.Size(195, 42);
            this.btnActivo.TabIndex = 67;
            this.btnActivo.Text = "Actualizar Activo";
            this.btnActivo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnActivo.UseVisualStyleBackColor = false;
            this.btnActivo.Click += new System.EventHandler(this.btnActivo_Click);
            // 
            // cbIdArticulo
            // 
            this.cbIdArticulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbIdArticulo.FormattingEnabled = true;
            this.cbIdArticulo.Location = new System.Drawing.Point(508, 12);
            this.cbIdArticulo.Name = "cbIdArticulo";
            this.cbIdArticulo.Size = new System.Drawing.Size(249, 30);
            this.cbIdArticulo.TabIndex = 68;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.btnActivo);
            this.panel2.Controls.Add(this.cbIdArticulo);
            this.panel2.Controls.Add(this.btnPrecioFinal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.btnPrecioVendedor);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnCantidad);
            this.panel2.Controls.Add(this.labelactivo);
            this.panel2.Controls.Add(this.rbNo);
            this.panel2.Controls.Add(this.txtCantidad);
            this.panel2.Controls.Add(this.rbYes);
            this.panel2.Controls.Add(this.txtPrecioV);
            this.panel2.Controls.Add(this.txtPrecioF);
            this.panel2.Location = new System.Drawing.Point(84, 400);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(994, 298);
            this.panel2.TabIndex = 50;
            // 
            // ActualizarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1200, 737);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ActualizarInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ActualizarInventario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaArticulos)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPrecioF;
        private System.Windows.Forms.TextBox txtPrecioV;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Label labelactivo;
        private System.Windows.Forms.Button btnCantidad;
        private System.Windows.Forms.Button btnPrecioVendedor;
        private System.Windows.Forms.Button btnPrecioFinal;
        private System.Windows.Forms.Button btnActivo;
        private System.Windows.Forms.ComboBox cbIdArticulo;
        private System.Windows.Forms.DataGridView TablaArticulos;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}