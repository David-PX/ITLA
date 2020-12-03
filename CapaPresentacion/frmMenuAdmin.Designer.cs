namespace CapaPresentacion
{
    partial class frmMenuAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenuAdmin));
            this.footer = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.center = new System.Windows.Forms.Panel();
            this.subMenuUsuarios = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.agregarUusarios = new System.Windows.Forms.Button();
            this.subMenuVisitantes = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.verVisitantes = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.modificarVisitantes = new System.Windows.Forms.Button();
            this.agregarVisitante = new System.Windows.Forms.Button();
            this.subMenuOpciones = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnOpciones = new System.Windows.Forms.Button();
            this.btnUsuarios = new System.Windows.Forms.Button();
            this.btnVisitantes = new System.Windows.Forms.Button();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel9 = new System.Windows.Forms.Panel();
            this.modificarUsuarios = new System.Windows.Forms.Button();
            this.footer.SuspendLayout();
            this.center.SuspendLayout();
            this.subMenuUsuarios.SuspendLayout();
            this.subMenuVisitantes.SuspendLayout();
            this.subMenuOpciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.footer.Controls.Add(this.lblFecha);
            this.footer.Controls.Add(this.lblHora);
            this.footer.Controls.Add(this.label1);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 846);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(1440, 94);
            this.footer.TabIndex = 1;
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(1010, 57);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(66, 28);
            this.lblFecha.TabIndex = 2;
            this.lblFecha.Text = "label2";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(1010, 23);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(66, 28);
            this.lblHora.TabIndex = 1;
            this.lblHora.Text = "label2";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "By David-PX";
            // 
            // center
            // 
            this.center.Controls.Add(this.subMenuUsuarios);
            this.center.Controls.Add(this.subMenuVisitantes);
            this.center.Controls.Add(this.subMenuOpciones);
            this.center.Controls.Add(this.pictureBox3);
            this.center.Controls.Add(this.btnOpciones);
            this.center.Controls.Add(this.btnUsuarios);
            this.center.Controls.Add(this.btnVisitantes);
            this.center.Controls.Add(this.bunifuSeparator1);
            this.center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.center.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.center.Location = new System.Drawing.Point(0, 0);
            this.center.Name = "center";
            this.center.Size = new System.Drawing.Size(1440, 846);
            this.center.TabIndex = 2;
            // 
            // subMenuUsuarios
            // 
            this.subMenuUsuarios.Controls.Add(this.panel9);
            this.subMenuUsuarios.Controls.Add(this.panel10);
            this.subMenuUsuarios.Controls.Add(this.modificarUsuarios);
            this.subMenuUsuarios.Controls.Add(this.agregarUusarios);
            this.subMenuUsuarios.Location = new System.Drawing.Point(409, 66);
            this.subMenuUsuarios.Name = "subMenuUsuarios";
            this.subMenuUsuarios.Size = new System.Drawing.Size(200, 103);
            this.subMenuUsuarios.TabIndex = 9;
            this.subMenuUsuarios.Visible = false;
            // 
            // panel10
            // 
            this.panel10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(13, 47);
            this.panel10.TabIndex = 8;
            // 
            // agregarUusarios
            // 
            this.agregarUusarios.BackColor = System.Drawing.Color.White;
            this.agregarUusarios.FlatAppearance.BorderSize = 0;
            this.agregarUusarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarUusarios.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarUusarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.agregarUusarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarUusarios.Location = new System.Drawing.Point(16, 0);
            this.agregarUusarios.Name = "agregarUusarios";
            this.agregarUusarios.Size = new System.Drawing.Size(181, 47);
            this.agregarUusarios.TabIndex = 8;
            this.agregarUusarios.Text = "Agregar";
            this.agregarUusarios.UseVisualStyleBackColor = false;
            this.agregarUusarios.Click += new System.EventHandler(this.agregarUusarios_Click);
            // 
            // subMenuVisitantes
            // 
            this.subMenuVisitantes.Controls.Add(this.panel6);
            this.subMenuVisitantes.Controls.Add(this.verVisitantes);
            this.subMenuVisitantes.Controls.Add(this.panel4);
            this.subMenuVisitantes.Controls.Add(this.panel5);
            this.subMenuVisitantes.Controls.Add(this.modificarVisitantes);
            this.subMenuVisitantes.Controls.Add(this.agregarVisitante);
            this.subMenuVisitantes.Location = new System.Drawing.Point(142, 66);
            this.subMenuVisitantes.Name = "subMenuVisitantes";
            this.subMenuVisitantes.Size = new System.Drawing.Size(200, 153);
            this.subMenuVisitantes.TabIndex = 8;
            this.subMenuVisitantes.Visible = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.panel6.Location = new System.Drawing.Point(0, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(13, 47);
            this.panel6.TabIndex = 11;
            // 
            // verVisitantes
            // 
            this.verVisitantes.BackColor = System.Drawing.SystemColors.Window;
            this.verVisitantes.FlatAppearance.BorderSize = 0;
            this.verVisitantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.verVisitantes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.verVisitantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.verVisitantes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.verVisitantes.Location = new System.Drawing.Point(16, 100);
            this.verVisitantes.Name = "verVisitantes";
            this.verVisitantes.Size = new System.Drawing.Size(181, 47);
            this.verVisitantes.TabIndex = 12;
            this.verVisitantes.Text = "Ver";
            this.verVisitantes.UseVisualStyleBackColor = false;
            this.verVisitantes.Click += new System.EventHandler(this.verVisitantes_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.panel4.Location = new System.Drawing.Point(0, 50);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(13, 47);
            this.panel4.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(13, 47);
            this.panel5.TabIndex = 8;
            // 
            // modificarVisitantes
            // 
            this.modificarVisitantes.BackColor = System.Drawing.SystemColors.Window;
            this.modificarVisitantes.FlatAppearance.BorderSize = 0;
            this.modificarVisitantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarVisitantes.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarVisitantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.modificarVisitantes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificarVisitantes.Location = new System.Drawing.Point(16, 50);
            this.modificarVisitantes.Name = "modificarVisitantes";
            this.modificarVisitantes.Size = new System.Drawing.Size(181, 47);
            this.modificarVisitantes.TabIndex = 10;
            this.modificarVisitantes.Text = "Modificar";
            this.modificarVisitantes.UseVisualStyleBackColor = false;
            this.modificarVisitantes.Click += new System.EventHandler(this.modificarVisitantes_Click);
            // 
            // agregarVisitante
            // 
            this.agregarVisitante.BackColor = System.Drawing.Color.White;
            this.agregarVisitante.FlatAppearance.BorderSize = 0;
            this.agregarVisitante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregarVisitante.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agregarVisitante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.agregarVisitante.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.agregarVisitante.Location = new System.Drawing.Point(16, 0);
            this.agregarVisitante.Name = "agregarVisitante";
            this.agregarVisitante.Size = new System.Drawing.Size(181, 47);
            this.agregarVisitante.TabIndex = 8;
            this.agregarVisitante.Text = "Agregar";
            this.agregarVisitante.UseVisualStyleBackColor = false;
            this.agregarVisitante.Click += new System.EventHandler(this.agregarVisitante_Click);
            // 
            // subMenuOpciones
            // 
            this.subMenuOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.subMenuOpciones.Controls.Add(this.panel3);
            this.subMenuOpciones.Controls.Add(this.panel2);
            this.subMenuOpciones.Controls.Add(this.btnSalir);
            this.subMenuOpciones.Controls.Add(this.btnCerrarSesion);
            this.subMenuOpciones.Location = new System.Drawing.Point(1187, 69);
            this.subMenuOpciones.Name = "subMenuOpciones";
            this.subMenuOpciones.Size = new System.Drawing.Size(200, 100);
            this.subMenuOpciones.TabIndex = 7;
            this.subMenuOpciones.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(229)))), ((int)(((byte)(34)))), ((int)(((byte)(41)))));
            this.panel3.Location = new System.Drawing.Point(0, 50);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(13, 47);
            this.panel3.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(13, 47);
            this.panel2.TabIndex = 8;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnSalir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalir.Location = new System.Drawing.Point(16, 50);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(181, 47);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.Color.White;
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnCerrarSesion.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCerrarSesion.Location = new System.Drawing.Point(16, 0);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(181, 47);
            this.btnCerrarSesion.TabIndex = 8;
            this.btnCerrarSesion.Text = "Cerrar Sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(12, 321);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1171, 519);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // btnOpciones
            // 
            this.btnOpciones.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpciones.BackColor = System.Drawing.Color.White;
            this.btnOpciones.FlatAppearance.BorderSize = 0;
            this.btnOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnOpciones.Image = ((System.Drawing.Image)(resources.GetObject("btnOpciones.Image")));
            this.btnOpciones.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnOpciones.Location = new System.Drawing.Point(1145, 12);
            this.btnOpciones.Name = "btnOpciones";
            this.btnOpciones.Size = new System.Drawing.Size(214, 64);
            this.btnOpciones.TabIndex = 4;
            this.btnOpciones.Text = "Opciones";
            this.btnOpciones.UseVisualStyleBackColor = false;
            this.btnOpciones.Click += new System.EventHandler(this.btnConfiguracion_Click);
            // 
            // btnUsuarios
            // 
            this.btnUsuarios.BackColor = System.Drawing.Color.White;
            this.btnUsuarios.FlatAppearance.BorderSize = 0;
            this.btnUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnUsuarios.Image = ((System.Drawing.Image)(resources.GetObject("btnUsuarios.Image")));
            this.btnUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUsuarios.Location = new System.Drawing.Point(369, 12);
            this.btnUsuarios.Name = "btnUsuarios";
            this.btnUsuarios.Size = new System.Drawing.Size(173, 64);
            this.btnUsuarios.TabIndex = 3;
            this.btnUsuarios.Text = "Usuarios";
            this.btnUsuarios.UseVisualStyleBackColor = false;
            this.btnUsuarios.Click += new System.EventHandler(this.btnUsuarios_Click);
            // 
            // btnVisitantes
            // 
            this.btnVisitantes.BackColor = System.Drawing.Color.White;
            this.btnVisitantes.FlatAppearance.BorderSize = 0;
            this.btnVisitantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVisitantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.btnVisitantes.Image = ((System.Drawing.Image)(resources.GetObject("btnVisitantes.Image")));
            this.btnVisitantes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVisitantes.Location = new System.Drawing.Point(105, 12);
            this.btnVisitantes.Name = "btnVisitantes";
            this.btnVisitantes.Size = new System.Drawing.Size(187, 64);
            this.btnVisitantes.TabIndex = 1;
            this.btnVisitantes.Text = "Visitantes";
            this.btnVisitantes.UseVisualStyleBackColor = false;
            this.btnVisitantes.Click += new System.EventHandler(this.button1_Click);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.Dock = System.Windows.Forms.DockStyle.Top;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.bunifuSeparator1.LineThickness = 4;
            this.bunifuSeparator1.Location = new System.Drawing.Point(0, 0);
            this.bunifuSeparator1.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(1440, 182);
            this.bunifuSeparator1.TabIndex = 0;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = false;
            this.bunifuSeparator1.Load += new System.EventHandler(this.bunifuSeparator1_Load);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.panel9.Location = new System.Drawing.Point(0, 50);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(13, 47);
            this.panel9.TabIndex = 9;
            // 
            // modificarUsuarios
            // 
            this.modificarUsuarios.BackColor = System.Drawing.SystemColors.Window;
            this.modificarUsuarios.FlatAppearance.BorderSize = 0;
            this.modificarUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modificarUsuarios.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(56)))), ((int)(((byte)(119)))));
            this.modificarUsuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.modificarUsuarios.Location = new System.Drawing.Point(16, 50);
            this.modificarUsuarios.Name = "modificarUsuarios";
            this.modificarUsuarios.Size = new System.Drawing.Size(181, 47);
            this.modificarUsuarios.TabIndex = 10;
            this.modificarUsuarios.Text = "Modificar";
            this.modificarUsuarios.UseVisualStyleBackColor = false;
            this.modificarUsuarios.Click += new System.EventHandler(this.modificarUsuarios_Click);
            // 
            // frmMenuAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1440, 940);
            this.Controls.Add(this.center);
            this.Controls.Add(this.footer);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMenuAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMenuPrincipal";
            this.Load += new System.EventHandler(this.frmMenuAdmin_Load);
            this.footer.ResumeLayout(false);
            this.footer.PerformLayout();
            this.center.ResumeLayout(false);
            this.subMenuUsuarios.ResumeLayout(false);
            this.subMenuVisitantes.ResumeLayout(false);
            this.subMenuOpciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Panel center;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.Button btnVisitantes;
        private System.Windows.Forms.Button btnOpciones;
        private System.Windows.Forms.Button btnUsuarios;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel subMenuOpciones;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel subMenuUsuarios;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Button agregarUusarios;
        private System.Windows.Forms.Panel subMenuVisitantes;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button verVisitantes;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button modificarVisitantes;
        private System.Windows.Forms.Button agregarVisitante;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button modificarUsuarios;
    }
}