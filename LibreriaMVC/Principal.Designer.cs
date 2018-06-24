namespace LibreriaMVC
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.btnSocios = new System.Windows.Forms.Button();
            this.btnAutores = new System.Windows.Forms.Button();
            this.btnEditoriales = new System.Windows.Forms.Button();
            this.btnLibros = new System.Windows.Forms.Button();
            this.btnPrestamos = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.autoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editorialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.librosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.prestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sociosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarAutorTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarAutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeAutoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarLibroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDeLibrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarPrestamoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listaDePrestamosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buscarSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarSocioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSocios
            // 
            this.btnSocios.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSocios.Location = new System.Drawing.Point(35, 67);
            this.btnSocios.Name = "btnSocios";
            this.btnSocios.Size = new System.Drawing.Size(94, 45);
            this.btnSocios.TabIndex = 0;
            this.btnSocios.Text = "Socios";
            this.btnSocios.UseVisualStyleBackColor = true;
            this.btnSocios.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAutores
            // 
            this.btnAutores.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAutores.Location = new System.Drawing.Point(174, 67);
            this.btnAutores.Name = "btnAutores";
            this.btnAutores.Size = new System.Drawing.Size(94, 44);
            this.btnAutores.TabIndex = 1;
            this.btnAutores.Text = "Autores";
            this.btnAutores.UseVisualStyleBackColor = true;
            this.btnAutores.Click += new System.EventHandler(this.btnAutores_Click);
            // 
            // btnEditoriales
            // 
            this.btnEditoriales.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditoriales.Location = new System.Drawing.Point(314, 67);
            this.btnEditoriales.Name = "btnEditoriales";
            this.btnEditoriales.Size = new System.Drawing.Size(98, 44);
            this.btnEditoriales.TabIndex = 2;
            this.btnEditoriales.Text = "Editoriales";
            this.btnEditoriales.UseVisualStyleBackColor = true;
            this.btnEditoriales.Click += new System.EventHandler(this.btnEditoriales_Click);
            // 
            // btnLibros
            // 
            this.btnLibros.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLibros.Location = new System.Drawing.Point(92, 140);
            this.btnLibros.Name = "btnLibros";
            this.btnLibros.Size = new System.Drawing.Size(94, 44);
            this.btnLibros.TabIndex = 3;
            this.btnLibros.Text = "Libros";
            this.btnLibros.UseVisualStyleBackColor = true;
            this.btnLibros.Click += new System.EventHandler(this.btnLibros_Click);
            // 
            // btnPrestamos
            // 
            this.btnPrestamos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrestamos.Location = new System.Drawing.Point(255, 140);
            this.btnPrestamos.Name = "btnPrestamos";
            this.btnPrestamos.Size = new System.Drawing.Size(103, 44);
            this.btnPrestamos.TabIndex = 4;
            this.btnPrestamos.Text = "Prestamos";
            this.btnPrestamos.UseVisualStyleBackColor = true;
            this.btnPrestamos.Click += new System.EventHandler(this.btnPrestamos_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(174, 206);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(94, 44);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.autoresToolStripMenuItem,
            this.editorialesToolStripMenuItem,
            this.librosToolStripMenuItem,
            this.prestamosToolStripMenuItem,
            this.sociosToolStripMenuItem,
            this.salirTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(467, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // autoresToolStripMenuItem
            // 
            this.autoresToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarAutorTSM,
            this.buscarAutorToolStripMenuItem,
            this.listaDeAutoresToolStripMenuItem});
            this.autoresToolStripMenuItem.Name = "autoresToolStripMenuItem";
            this.autoresToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.autoresToolStripMenuItem.Text = "Autores";
            // 
            // editorialesToolStripMenuItem
            // 
            this.editorialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarToolStripMenuItem,
            this.buscarToolStripMenuItem,
            this.listaToolStripMenuItem});
            this.editorialesToolStripMenuItem.Name = "editorialesToolStripMenuItem";
            this.editorialesToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.editorialesToolStripMenuItem.Text = "Editoriales";
            // 
            // librosToolStripMenuItem
            // 
            this.librosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarLibroToolStripMenuItem,
            this.listaDeLibrosToolStripMenuItem});
            this.librosToolStripMenuItem.Name = "librosToolStripMenuItem";
            this.librosToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.librosToolStripMenuItem.Text = "Libros";
            // 
            // prestamosToolStripMenuItem
            // 
            this.prestamosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarPrestamoToolStripMenuItem,
            this.listaDePrestamosToolStripMenuItem});
            this.prestamosToolStripMenuItem.Name = "prestamosToolStripMenuItem";
            this.prestamosToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.prestamosToolStripMenuItem.Text = "Prestamos";
            // 
            // sociosToolStripMenuItem
            // 
            this.sociosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarSocioToolStripMenuItem,
            this.buscarSocioToolStripMenuItem,
            this.listarSocioToolStripMenuItem});
            this.sociosToolStripMenuItem.Name = "sociosToolStripMenuItem";
            this.sociosToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.sociosToolStripMenuItem.Text = "Socios";
            // 
            // salirTSM
            // 
            this.salirTSM.Name = "salirTSM";
            this.salirTSM.Size = new System.Drawing.Size(41, 20);
            this.salirTSM.Text = "Salir";
            this.salirTSM.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // agregarAutorTSM
            // 
            this.agregarAutorTSM.Name = "agregarAutorTSM";
            this.agregarAutorTSM.Size = new System.Drawing.Size(158, 22);
            this.agregarAutorTSM.Text = "Agregar Autor";
            this.agregarAutorTSM.Click += new System.EventHandler(this.agregarAutorTSM_Click);
            // 
            // buscarAutorToolStripMenuItem
            // 
            this.buscarAutorToolStripMenuItem.Name = "buscarAutorToolStripMenuItem";
            this.buscarAutorToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.buscarAutorToolStripMenuItem.Text = "Buscar Autor";
            this.buscarAutorToolStripMenuItem.Click += new System.EventHandler(this.buscarAutorToolStripMenuItem_Click);
            // 
            // listaDeAutoresToolStripMenuItem
            // 
            this.listaDeAutoresToolStripMenuItem.Name = "listaDeAutoresToolStripMenuItem";
            this.listaDeAutoresToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.listaDeAutoresToolStripMenuItem.Text = "Lista de Autores";
            this.listaDeAutoresToolStripMenuItem.Click += new System.EventHandler(this.listaDeAutoresToolStripMenuItem_Click);
            // 
            // agregarToolStripMenuItem
            // 
            this.agregarToolStripMenuItem.Name = "agregarToolStripMenuItem";
            this.agregarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.agregarToolStripMenuItem.Text = "Agregar Editorial";
            this.agregarToolStripMenuItem.Click += new System.EventHandler(this.agregarToolStripMenuItem_Click);
            // 
            // buscarToolStripMenuItem
            // 
            this.buscarToolStripMenuItem.Name = "buscarToolStripMenuItem";
            this.buscarToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.buscarToolStripMenuItem.Text = "Buscar Editorial";
            this.buscarToolStripMenuItem.Click += new System.EventHandler(this.buscarToolStripMenuItem_Click);
            // 
            // listaToolStripMenuItem
            // 
            this.listaToolStripMenuItem.Name = "listaToolStripMenuItem";
            this.listaToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.listaToolStripMenuItem.Text = "Lista  Editoriales";
            this.listaToolStripMenuItem.Click += new System.EventHandler(this.listaToolStripMenuItem_Click);
            // 
            // agregarLibroToolStripMenuItem
            // 
            this.agregarLibroToolStripMenuItem.Name = "agregarLibroToolStripMenuItem";
            this.agregarLibroToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agregarLibroToolStripMenuItem.Text = "Agregar Libro";
            this.agregarLibroToolStripMenuItem.Click += new System.EventHandler(this.agregarLibroToolStripMenuItem_Click);
            // 
            // listaDeLibrosToolStripMenuItem
            // 
            this.listaDeLibrosToolStripMenuItem.Name = "listaDeLibrosToolStripMenuItem";
            this.listaDeLibrosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listaDeLibrosToolStripMenuItem.Text = "Lista de Libros";
            this.listaDeLibrosToolStripMenuItem.Click += new System.EventHandler(this.listaDeLibrosToolStripMenuItem_Click);
            // 
            // agregarPrestamoToolStripMenuItem
            // 
            this.agregarPrestamoToolStripMenuItem.Name = "agregarPrestamoToolStripMenuItem";
            this.agregarPrestamoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.agregarPrestamoToolStripMenuItem.Text = "Agregar Prestamo";
            this.agregarPrestamoToolStripMenuItem.Click += new System.EventHandler(this.agregarPrestamoToolStripMenuItem_Click);
            // 
            // listaDePrestamosToolStripMenuItem
            // 
            this.listaDePrestamosToolStripMenuItem.Name = "listaDePrestamosToolStripMenuItem";
            this.listaDePrestamosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.listaDePrestamosToolStripMenuItem.Text = "Lista de Prestamos";
            this.listaDePrestamosToolStripMenuItem.Click += new System.EventHandler(this.listaDePrestamosToolStripMenuItem_Click);
            // 
            // agregarSocioToolStripMenuItem
            // 
            this.agregarSocioToolStripMenuItem.Name = "agregarSocioToolStripMenuItem";
            this.agregarSocioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.agregarSocioToolStripMenuItem.Text = "Agregar Socio";
            this.agregarSocioToolStripMenuItem.Click += new System.EventHandler(this.agregarSocioToolStripMenuItem_Click);
            // 
            // buscarSocioToolStripMenuItem
            // 
            this.buscarSocioToolStripMenuItem.Name = "buscarSocioToolStripMenuItem";
            this.buscarSocioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.buscarSocioToolStripMenuItem.Text = "Buscar Socio";
            this.buscarSocioToolStripMenuItem.Click += new System.EventHandler(this.buscarSocioToolStripMenuItem_Click);
            // 
            // listarSocioToolStripMenuItem
            // 
            this.listarSocioToolStripMenuItem.Name = "listarSocioToolStripMenuItem";
            this.listarSocioToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.listarSocioToolStripMenuItem.Text = "Listar Socio";
            this.listarSocioToolStripMenuItem.Click += new System.EventHandler(this.listarSocioToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(467, 273);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPrestamos);
            this.Controls.Add(this.btnLibros);
            this.Controls.Add(this.btnEditoriales);
            this.Controls.Add(this.btnAutores);
            this.Controls.Add(this.btnSocios);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSocios;
        private System.Windows.Forms.Button btnAutores;
        private System.Windows.Forms.Button btnEditoriales;
        private System.Windows.Forms.Button btnLibros;
        private System.Windows.Forms.Button btnPrestamos;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem autoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editorialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem librosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem prestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sociosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirTSM;
        private System.Windows.Forms.ToolStripMenuItem agregarAutorTSM;
        private System.Windows.Forms.ToolStripMenuItem buscarAutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeAutoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarLibroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDeLibrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarPrestamoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listaDePrestamosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buscarSocioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarSocioToolStripMenuItem;
    }
}

