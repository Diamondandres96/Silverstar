namespace Prototipo002
{
    partial class Instructores
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbFicha = new System.Windows.Forms.ComboBox();
            this.lblFicha = new System.Windows.Forms.Label();
            this.DGAprendices = new System.Windows.Forms.DataGridView();
            this.Validacion = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGAprendices)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(131, 271);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(126, 23);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.DGAprendices);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Controls.Add(this.cmbFicha);
            this.panel2.Controls.Add(this.lblFicha);
            this.panel2.Location = new System.Drawing.Point(220, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(359, 316);
            this.panel2.TabIndex = 3;
            // 
            // cmbFicha
            // 
            this.cmbFicha.FormattingEnabled = true;
            this.cmbFicha.Location = new System.Drawing.Point(136, 61);
            this.cmbFicha.Name = "cmbFicha";
            this.cmbFicha.Size = new System.Drawing.Size(121, 21);
            this.cmbFicha.TabIndex = 2;
            this.cmbFicha.SelectedIndexChanged += new System.EventHandler(this.cmbFicha_SelectedIndexChanged);
            // 
            // lblFicha
            // 
            this.lblFicha.AutoSize = true;
            this.lblFicha.Location = new System.Drawing.Point(72, 61);
            this.lblFicha.Name = "lblFicha";
            this.lblFicha.Size = new System.Drawing.Size(33, 13);
            this.lblFicha.TabIndex = 1;
            this.lblFicha.Text = "Ficha";
            // 
            // DGAprendices
            // 
            this.DGAprendices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGAprendices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Validacion});
            this.DGAprendices.Location = new System.Drawing.Point(75, 97);
            this.DGAprendices.Name = "DGAprendices";
            this.DGAprendices.Size = new System.Drawing.Size(240, 150);
            this.DGAprendices.TabIndex = 3;
            // 
            // Validacion
            // 
            this.Validacion.HeaderText = "Validacion";
            this.Validacion.Name = "Validacion";
            // 
            // Instructores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Name = "Instructores";
            this.Text = "Instructores";
            this.Load += new System.EventHandler(this.Instructores_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGAprendices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox cmbFicha;
        private System.Windows.Forms.Label lblFicha;
        private System.Windows.Forms.DataGridView DGAprendices;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Validacion;
    }
}