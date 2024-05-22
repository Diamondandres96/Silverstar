namespace Prototipo002
{
    partial class Vigilantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vigilantes));
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lblCedula = new System.Windows.Forms.Label();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.panelRegistro = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtFicha = new System.Windows.Forms.TextBox();
            this.lblFicha = new System.Windows.Forms.Label();
            this.txtTipo_Usuario = new System.Windows.Forms.TextBox();
            this.lblTipo_usuario = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnCerrar = new System.Windows.Forms.Button();
            this.menuDeControlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.todosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aprendizToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelRegistro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(269, 112);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lblCedula
            // 
            this.lblCedula.AutoSize = true;
            this.lblCedula.Location = new System.Drawing.Point(241, 62);
            this.lblCedula.Name = "lblCedula";
            this.lblCedula.Size = new System.Drawing.Size(40, 13);
            this.lblCedula.TabIndex = 1;
            this.lblCedula.Text = "Cedula";
            // 
            // txtCedula
            // 
            this.txtCedula.Location = new System.Drawing.Point(299, 62);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(100, 20);
            this.txtCedula.TabIndex = 2;
            // 
            // panelRegistro
            // 
            this.panelRegistro.Controls.Add(this.pictureBox1);
            this.panelRegistro.Controls.Add(this.txtFicha);
            this.panelRegistro.Controls.Add(this.lblFicha);
            this.panelRegistro.Controls.Add(this.txtTipo_Usuario);
            this.panelRegistro.Controls.Add(this.lblTipo_usuario);
            this.panelRegistro.Location = new System.Drawing.Point(144, 141);
            this.panelRegistro.Name = "panelRegistro";
            this.panelRegistro.Size = new System.Drawing.Size(361, 243);
            this.panelRegistro.TabIndex = 3;
            this.panelRegistro.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(203, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(155, 171);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtFicha
            // 
            this.txtFicha.Location = new System.Drawing.Point(97, 69);
            this.txtFicha.Name = "txtFicha";
            this.txtFicha.ReadOnly = true;
            this.txtFicha.Size = new System.Drawing.Size(100, 20);
            this.txtFicha.TabIndex = 3;
            // 
            // lblFicha
            // 
            this.lblFicha.AutoSize = true;
            this.lblFicha.Location = new System.Drawing.Point(17, 72);
            this.lblFicha.Name = "lblFicha";
            this.lblFicha.Size = new System.Drawing.Size(33, 13);
            this.lblFicha.TabIndex = 2;
            this.lblFicha.Text = "Ficha";
            // 
            // txtTipo_Usuario
            // 
            this.txtTipo_Usuario.Location = new System.Drawing.Point(97, 14);
            this.txtTipo_Usuario.Name = "txtTipo_Usuario";
            this.txtTipo_Usuario.ReadOnly = true;
            this.txtTipo_Usuario.Size = new System.Drawing.Size(100, 20);
            this.txtTipo_Usuario.TabIndex = 1;
            // 
            // lblTipo_usuario
            // 
            this.lblTipo_usuario.AutoSize = true;
            this.lblTipo_usuario.Location = new System.Drawing.Point(17, 17);
            this.lblTipo_usuario.Name = "lblTipo_usuario";
            this.lblTipo_usuario.Size = new System.Drawing.Size(82, 13);
            this.lblTipo_usuario.TabIndex = 0;
            this.lblTipo_usuario.Text = "Tipo de Usuario";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDeControlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnCerrar
            // 
            this.btnCerrar.Location = new System.Drawing.Point(376, 112);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrar.TabIndex = 5;
            this.btnCerrar.Text = "Cerrar";
            this.btnCerrar.UseVisualStyleBackColor = true;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // menuDeControlToolStripMenuItem
            // 
            this.menuDeControlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.todosToolStripMenuItem,
            this.instructorToolStripMenuItem,
            this.aprendizToolStripMenuItem,
            this.visitantesToolStripMenuItem});
            this.menuDeControlToolStripMenuItem.Name = "menuDeControlToolStripMenuItem";
            this.menuDeControlToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.menuDeControlToolStripMenuItem.Text = "Menu de Control";
            // 
            // todosToolStripMenuItem
            // 
            this.todosToolStripMenuItem.Name = "todosToolStripMenuItem";
            this.todosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.todosToolStripMenuItem.Text = "Todos";
            // 
            // instructorToolStripMenuItem
            // 
            this.instructorToolStripMenuItem.Name = "instructorToolStripMenuItem";
            this.instructorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.instructorToolStripMenuItem.Text = "Instructor";
            // 
            // aprendizToolStripMenuItem
            // 
            this.aprendizToolStripMenuItem.Name = "aprendizToolStripMenuItem";
            this.aprendizToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aprendizToolStripMenuItem.Text = "Aprendiz";
            // 
            // visitantesToolStripMenuItem
            // 
            this.visitantesToolStripMenuItem.Name = "visitantesToolStripMenuItem";
            this.visitantesToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.visitantesToolStripMenuItem.Text = "Visitantes";
            // 
            // Vigilantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrar);
            this.Controls.Add(this.panelRegistro);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.lblCedula);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Vigilantes";
            this.Text = "Vigilantes";
            this.panelRegistro.ResumeLayout(false);
            this.panelRegistro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Label lblCedula;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Panel panelRegistro;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtFicha;
        private System.Windows.Forms.Label lblFicha;
        private System.Windows.Forms.TextBox txtTipo_Usuario;
        private System.Windows.Forms.Label lblTipo_usuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btnCerrar;
        private System.Windows.Forms.ToolStripMenuItem menuDeControlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem todosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aprendizToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitantesToolStripMenuItem;
    }
}