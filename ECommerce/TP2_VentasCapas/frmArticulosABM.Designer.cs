namespace TP2_VentasCapas
{
    partial class frmArticulosABM
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
            this.txDescripcion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btGuardar = new System.Windows.Forms.Button();
            this.txNombre = new System.Windows.Forms.TextBox();
            this.txId = new System.Windows.Forms.TextBox();
            this.nuPrecioVenta = new System.Windows.Forms.NumericUpDown();
            this.nuPrecioCompra = new System.Windows.Forms.NumericUpDown();
            this.nuStock = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrecioVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrecioCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuStock)).BeginInit();
            this.SuspendLayout();
            // 
            // txDescripcion
            // 
            this.txDescripcion.Location = new System.Drawing.Point(99, 64);
            this.txDescripcion.Name = "txDescripcion";
            this.txDescripcion.Size = new System.Drawing.Size(215, 20);
            this.txDescripcion.TabIndex = 25;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "Precio Compra";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Precio Venta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Stock";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(77, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Id";
            // 
            // btCancelar
            // 
            this.btCancelar.Location = new System.Drawing.Point(182, 193);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(75, 23);
            this.btCancelar.TabIndex = 18;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = true;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btGuardar
            // 
            this.btGuardar.Location = new System.Drawing.Point(263, 193);
            this.btGuardar.Name = "btGuardar";
            this.btGuardar.Size = new System.Drawing.Size(75, 23);
            this.btGuardar.TabIndex = 17;
            this.btGuardar.Text = "Guardar";
            this.btGuardar.UseVisualStyleBackColor = true;
            this.btGuardar.Click += new System.EventHandler(this.btGuardar_Click);
            // 
            // txNombre
            // 
            this.txNombre.Location = new System.Drawing.Point(99, 38);
            this.txNombre.Name = "txNombre";
            this.txNombre.Size = new System.Drawing.Size(215, 20);
            this.txNombre.TabIndex = 15;
            // 
            // txId
            // 
            this.txId.Location = new System.Drawing.Point(99, 12);
            this.txId.Name = "txId";
            this.txId.ReadOnly = true;
            this.txId.Size = new System.Drawing.Size(100, 20);
            this.txId.TabIndex = 14;
            // 
            // nuPrecioVenta
            // 
            this.nuPrecioVenta.DecimalPlaces = 2;
            this.nuPrecioVenta.Location = new System.Drawing.Point(99, 90);
            this.nuPrecioVenta.Name = "nuPrecioVenta";
            this.nuPrecioVenta.Size = new System.Drawing.Size(100, 20);
            this.nuPrecioVenta.TabIndex = 28;
            // 
            // nuPrecioCompra
            // 
            this.nuPrecioCompra.DecimalPlaces = 2;
            this.nuPrecioCompra.Location = new System.Drawing.Point(99, 116);
            this.nuPrecioCompra.Name = "nuPrecioCompra";
            this.nuPrecioCompra.Size = new System.Drawing.Size(100, 20);
            this.nuPrecioCompra.TabIndex = 29;
            // 
            // nuStock
            // 
            this.nuStock.Location = new System.Drawing.Point(99, 142);
            this.nuStock.Name = "nuStock";
            this.nuStock.Size = new System.Drawing.Size(100, 20);
            this.nuStock.TabIndex = 30;
            // 
            // frmArticulosABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 228);
            this.Controls.Add(this.nuStock);
            this.Controls.Add(this.nuPrecioCompra);
            this.Controls.Add(this.nuPrecioVenta);
            this.Controls.Add(this.txDescripcion);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btGuardar);
            this.Controls.Add(this.txNombre);
            this.Controls.Add(this.txId);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmArticulosABM";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Artículos - ABM";
            this.Load += new System.EventHandler(this.frmArticulosABM_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nuPrecioVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuPrecioCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nuStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txDescripcion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btGuardar;
        private System.Windows.Forms.TextBox txNombre;
        private System.Windows.Forms.TextBox txId;
        private System.Windows.Forms.NumericUpDown nuPrecioVenta;
        private System.Windows.Forms.NumericUpDown nuPrecioCompra;
        private System.Windows.Forms.NumericUpDown nuStock;
    }
}