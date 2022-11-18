namespace pryLunaSP4
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
            this.dgvTabla = new System.Windows.Forms.DataGridView();
            this.btnValidar = new System.Windows.Forms.Button();
            this.lstTotales = new System.Windows.Forms.ListBox();
            this.btnTotales = new System.Windows.Forms.Button();
            this.btnMozo = new System.Windows.Forms.Button();
            this.txtMozo = new System.Windows.Forms.TextBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.MOZOS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.COMIDAS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BEBIDAS_SIN_ALCOHOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BEBIDAS_CON_ALCOHOL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.POSTRES = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTabla
            // 
            this.dgvTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTabla.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MOZOS,
            this.COMIDAS,
            this.BEBIDAS_SIN_ALCOHOL,
            this.BEBIDAS_CON_ALCOHOL,
            this.POSTRES});
            this.dgvTabla.Location = new System.Drawing.Point(12, 12);
            this.dgvTabla.Name = "dgvTabla";
            this.dgvTabla.Size = new System.Drawing.Size(519, 251);
            this.dgvTabla.TabIndex = 0;
            // 
            // btnValidar
            // 
            this.btnValidar.Location = new System.Drawing.Point(537, 12);
            this.btnValidar.Name = "btnValidar";
            this.btnValidar.Size = new System.Drawing.Size(173, 84);
            this.btnValidar.TabIndex = 1;
            this.btnValidar.Text = "Validar los datos";
            this.btnValidar.UseVisualStyleBackColor = true;
            this.btnValidar.Click += new System.EventHandler(this.btnValidar_Click);
            // 
            // lstTotales
            // 
            this.lstTotales.FormattingEnabled = true;
            this.lstTotales.Location = new System.Drawing.Point(325, 325);
            this.lstTotales.Name = "lstTotales";
            this.lstTotales.Size = new System.Drawing.Size(206, 95);
            this.lstTotales.TabIndex = 2;
            // 
            // btnTotales
            // 
            this.btnTotales.Location = new System.Drawing.Point(325, 278);
            this.btnTotales.Name = "btnTotales";
            this.btnTotales.Size = new System.Drawing.Size(116, 41);
            this.btnTotales.TabIndex = 3;
            this.btnTotales.Text = "Calcular totales";
            this.btnTotales.UseVisualStyleBackColor = true;
            this.btnTotales.Click += new System.EventHandler(this.btnTotales_Click);
            // 
            // btnMozo
            // 
            this.btnMozo.Location = new System.Drawing.Point(12, 278);
            this.btnMozo.Name = "btnMozo";
            this.btnMozo.Size = new System.Drawing.Size(116, 41);
            this.btnMozo.TabIndex = 4;
            this.btnMozo.Text = "Mozo del dia";
            this.btnMozo.UseVisualStyleBackColor = true;
            this.btnMozo.Click += new System.EventHandler(this.btnMozo_Click);
            // 
            // txtMozo
            // 
            this.txtMozo.Location = new System.Drawing.Point(12, 325);
            this.txtMozo.Name = "txtMozo";
            this.txtMozo.Size = new System.Drawing.Size(116, 20);
            this.txtMozo.TabIndex = 5;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(680, 393);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(108, 45);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // MOZOS
            // 
            this.MOZOS.HeaderText = "MOZOS";
            this.MOZOS.Name = "MOZOS";
            // 
            // COMIDAS
            // 
            this.COMIDAS.HeaderText = "COMIDAS";
            this.COMIDAS.Name = "COMIDAS";
            // 
            // BEBIDAS_SIN_ALCOHOL
            // 
            this.BEBIDAS_SIN_ALCOHOL.HeaderText = "BEBIDAS SIN ALCOHOL";
            this.BEBIDAS_SIN_ALCOHOL.Name = "BEBIDAS_SIN_ALCOHOL";
            // 
            // BEBIDAS_CON_ALCOHOL
            // 
            this.BEBIDAS_CON_ALCOHOL.HeaderText = "BEBIDAS CON ALCOHOL";
            this.BEBIDAS_CON_ALCOHOL.Name = "BEBIDAS_CON_ALCOHOL";
            // 
            // POSTRES
            // 
            this.POSTRES.HeaderText = "POSTRES";
            this.POSTRES.Name = "POSTRES";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 493);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.txtMozo);
            this.Controls.Add(this.btnMozo);
            this.Controls.Add(this.btnTotales);
            this.Controls.Add(this.lstTotales);
            this.Controls.Add(this.btnValidar);
            this.Controls.Add(this.dgvTabla);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTabla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTabla;
        private System.Windows.Forms.Button btnValidar;
        private System.Windows.Forms.ListBox lstTotales;
        private System.Windows.Forms.Button btnTotales;
        private System.Windows.Forms.Button btnMozo;
        private System.Windows.Forms.TextBox txtMozo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridViewTextBoxColumn MOZOS;
        private System.Windows.Forms.DataGridViewTextBoxColumn COMIDAS;
        private System.Windows.Forms.DataGridViewTextBoxColumn BEBIDAS_SIN_ALCOHOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn BEBIDAS_CON_ALCOHOL;
        private System.Windows.Forms.DataGridViewTextBoxColumn POSTRES;
    }
}

