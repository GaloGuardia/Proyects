namespace TP2_VentasCapas
{
    partial class frmArticulos
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
            this.gv = new System.Windows.Forms.DataGridView();
            this.btBuscar = new System.Windows.Forms.Button();
            this.txFiltro = new System.Windows.Forms.TextBox();
            this.btClose = new System.Windows.Forms.Button();
            this.btBaja = new System.Windows.Forms.Button();
            this.btAlta = new System.Windows.Forms.Button();
            this.btModificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gv)).BeginInit();
            this.SuspendLayout();
            // 
            // gv
            // 
            this.gv.AllowUserToAddRows = false;
            this.gv.AllowUserToDeleteRows = false;
            this.gv.AllowUserToOrderColumns = true;
            this.gv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gv.Location = new System.Drawing.Point(12, 48);
            this.gv.Name = "gv";
            this.gv.ReadOnly = true;
            this.gv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gv.Size = new System.Drawing.Size(530, 310);
            this.gv.TabIndex = 0;
            // 
            // btBuscar
            // 
            this.btBuscar.Location = new System.Drawing.Point(254, 19);
            this.btBuscar.Name = "btBuscar";
            this.btBuscar.Size = new System.Drawing.Size(100, 23);
            this.btBuscar.TabIndex = 1;
            this.btBuscar.Text = "Buscar";
            this.btBuscar.UseVisualStyleBackColor = true;
            this.btBuscar.Click += new System.EventHandler(this.btBuscar_Click);
            // 
            // txFiltro
            // 
            this.txFiltro.Location = new System.Drawing.Point(12, 22);
            this.txFiltro.Name = "txFiltro";
            this.txFiltro.Size = new System.Drawing.Size(236, 20);
            this.txFiltro.TabIndex = 2;
            // 
            // btClose
            // 
            this.btClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btClose.Location = new System.Drawing.Point(12, 364);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(100, 23);
            this.btClose.TabIndex = 3;
            this.btClose.Text = "Cerrar";
            this.btClose.UseVisualStyleBackColor = true;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btBaja
            // 
            this.btBaja.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btBaja.Location = new System.Drawing.Point(305, 364);
            this.btBaja.Name = "btBaja";
            this.btBaja.Size = new System.Drawing.Size(75, 23);
            this.btBaja.TabIndex = 8;
            this.btBaja.Text = "Baja";
            this.btBaja.UseVisualStyleBackColor = true;
            this.btBaja.Click += new System.EventHandler(this.btBaja_Click);
            // 
            // btAlta
            // 
            this.btAlta.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btAlta.Location = new System.Drawing.Point(467, 364);
            this.btAlta.Name = "btAlta";
            this.btAlta.Size = new System.Drawing.Size(75, 23);
            this.btAlta.TabIndex = 7;
            this.btAlta.Text = "Alta";
            this.btAlta.UseVisualStyleBackColor = true;
            this.btAlta.Click += new System.EventHandler(this.btAlta_Click);
            // 
            // btModificar
            // 
            this.btModificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btModificar.Location = new System.Drawing.Point(386, 364);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 23);
            this.btModificar.TabIndex = 6;
            this.btModificar.Text = "Modificar";
            this.btModificar.UseVisualStyleBackColor = true;
            this.btModificar.Click += new System.EventHandler(this.btModificar_Click);
            // 
            // frmArticulos
            // 
            this.AcceptButton = this.btBuscar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btClose;
            this.ClientSize = new System.Drawing.Size(554, 399);
            this.Controls.Add(this.btBaja);
            this.Controls.Add(this.btAlta);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.txFiltro);
            this.Controls.Add(this.btBuscar);
            this.Controls.Add(this.gv);
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta de Artículos";
            this.Load += new System.EventHandler(this.frmArticulos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gv;
        private System.Windows.Forms.Button btBuscar;
        private System.Windows.Forms.TextBox txFiltro;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btBaja;
        private System.Windows.Forms.Button btAlta;
        private System.Windows.Forms.Button btModificar;
    }
}