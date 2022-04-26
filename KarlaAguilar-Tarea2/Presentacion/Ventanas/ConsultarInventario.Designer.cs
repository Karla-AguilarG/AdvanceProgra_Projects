
namespace Presentacion.Ventanas
{
    partial class ConsultarInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultarInventario));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.TablaInventarioArticulos = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaInventarioArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1092, 622);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 93);
            this.pictureBox1.TabIndex = 34;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.TablaInventarioArticulos);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(102, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(981, 559);
            this.panel1.TabIndex = 47;
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
            this.TablaInventarioArticulos.Enabled = false;
            this.TablaInventarioArticulos.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(229)))), ((int)(((byte)(245)))));
            this.TablaInventarioArticulos.Location = new System.Drawing.Point(39, 70);
            this.TablaInventarioArticulos.Name = "TablaInventarioArticulos";
            this.TablaInventarioArticulos.RowHeadersVisible = false;
            this.TablaInventarioArticulos.RowHeadersWidth = 51;
            this.TablaInventarioArticulos.RowTemplate.Height = 24;
            this.TablaInventarioArticulos.Size = new System.Drawing.Size(890, 464);
            this.TablaInventarioArticulos.TabIndex = 48;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(280, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(310, 26);
            this.label4.TabIndex = 46;
            this.label4.Text = "Lista de artículos disponibles";
            // 
            // ConsultarInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ClientSize = new System.Drawing.Size(1200, 737);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ConsultarInventario";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TablaInventarioArticulos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView TablaInventarioArticulos;
    }
}