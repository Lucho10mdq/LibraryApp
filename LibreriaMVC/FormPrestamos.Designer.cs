namespace LibreriaMVC
{
    partial class FormPrestamos
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblPrestamo = new System.Windows.Forms.Label();
            this.lblLibro = new System.Windows.Forms.Label();
            this.cmbLibros = new System.Windows.Forms.ComboBox();
            this.lblSocio = new System.Windows.Forms.Label();
            this.cmbSocios = new System.Windows.Forms.ComboBox();
            this.lblFechaAlqui = new System.Windows.Forms.Label();
            this.mskAlquilerFecha = new System.Windows.Forms.MaskedTextBox();
            this.lblEntregaFecha = new System.Windows.Forms.Label();
            this.mskFechaEntrega = new System.Windows.Forms.MaskedTextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnListaPrestamos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chocolate;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(390, 106);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblPrestamo
            // 
            this.lblPrestamo.AutoSize = true;
            this.lblPrestamo.BackColor = System.Drawing.Color.Chocolate;
            this.lblPrestamo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrestamo.Location = new System.Drawing.Point(112, 45);
            this.lblPrestamo.Name = "lblPrestamo";
            this.lblPrestamo.Size = new System.Drawing.Size(107, 24);
            this.lblPrestamo.TabIndex = 1;
            this.lblPrestamo.Text = "Prestamo";
            // 
            // lblLibro
            // 
            this.lblLibro.AutoSize = true;
            this.lblLibro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibro.Location = new System.Drawing.Point(22, 140);
            this.lblLibro.Name = "lblLibro";
            this.lblLibro.Size = new System.Drawing.Size(45, 16);
            this.lblLibro.TabIndex = 2;
            this.lblLibro.Text = "Libro:";
            // 
            // cmbLibros
            // 
            this.cmbLibros.FormattingEnabled = true;
            this.cmbLibros.Items.AddRange(new object[] {
            ""});
            this.cmbLibros.Location = new System.Drawing.Point(169, 135);
            this.cmbLibros.Name = "cmbLibros";
            this.cmbLibros.Size = new System.Drawing.Size(121, 21);
            this.cmbLibros.TabIndex = 3;
            // 
            // lblSocio
            // 
            this.lblSocio.AutoSize = true;
            this.lblSocio.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSocio.Location = new System.Drawing.Point(19, 184);
            this.lblSocio.Name = "lblSocio";
            this.lblSocio.Size = new System.Drawing.Size(48, 16);
            this.lblSocio.TabIndex = 4;
            this.lblSocio.Text = "Socio:";
            // 
            // cmbSocios
            // 
            this.cmbSocios.FormattingEnabled = true;
            this.cmbSocios.Items.AddRange(new object[] {
            ""});
            this.cmbSocios.Location = new System.Drawing.Point(169, 183);
            this.cmbSocios.Name = "cmbSocios";
            this.cmbSocios.Size = new System.Drawing.Size(121, 21);
            this.cmbSocios.TabIndex = 5;
            // 
            // lblFechaAlqui
            // 
            this.lblFechaAlqui.AutoSize = true;
            this.lblFechaAlqui.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechaAlqui.Location = new System.Drawing.Point(22, 232);
            this.lblFechaAlqui.Name = "lblFechaAlqui";
            this.lblFechaAlqui.Size = new System.Drawing.Size(125, 16);
            this.lblFechaAlqui.TabIndex = 6;
            this.lblFechaAlqui.Text = "Fecha de Alquiler:";
            // 
            // mskAlquilerFecha
            // 
            this.mskAlquilerFecha.Location = new System.Drawing.Point(169, 232);
            this.mskAlquilerFecha.Name = "mskAlquilerFecha";
            this.mskAlquilerFecha.Size = new System.Drawing.Size(100, 20);
            this.mskAlquilerFecha.TabIndex = 7;
            // 
            // lblEntregaFecha
            // 
            this.lblEntregaFecha.AutoSize = true;
            this.lblEntregaFecha.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEntregaFecha.Location = new System.Drawing.Point(23, 285);
            this.lblEntregaFecha.Name = "lblEntregaFecha";
            this.lblEntregaFecha.Size = new System.Drawing.Size(124, 16);
            this.lblEntregaFecha.TabIndex = 8;
            this.lblEntregaFecha.Text = "Fecha de Entrega:";
            // 
            // mskFechaEntrega
            // 
            this.mskFechaEntrega.Location = new System.Drawing.Point(169, 280);
            this.mskFechaEntrega.Name = "mskFechaEntrega";
            this.mskFechaEntrega.Size = new System.Drawing.Size(100, 20);
            this.mskFechaEntrega.TabIndex = 9;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(26, 342);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(102, 36);
            this.btnGuardar.TabIndex = 10;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnListaPrestamos
            // 
            this.btnListaPrestamos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaPrestamos.Location = new System.Drawing.Point(169, 342);
            this.btnListaPrestamos.Name = "btnListaPrestamos";
            this.btnListaPrestamos.Size = new System.Drawing.Size(109, 36);
            this.btnListaPrestamos.TabIndex = 11;
            this.btnListaPrestamos.Text = "Lista Prestamos";
            this.btnListaPrestamos.UseVisualStyleBackColor = true;
            this.btnListaPrestamos.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(336, 394);
            this.Controls.Add(this.btnListaPrestamos);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.mskFechaEntrega);
            this.Controls.Add(this.lblEntregaFecha);
            this.Controls.Add(this.mskAlquilerFecha);
            this.Controls.Add(this.lblFechaAlqui);
            this.Controls.Add(this.cmbSocios);
            this.Controls.Add(this.lblSocio);
            this.Controls.Add(this.cmbLibros);
            this.Controls.Add(this.lblLibro);
            this.Controls.Add(this.lblPrestamo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormPrestamos";
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.FormPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblPrestamo;
        private System.Windows.Forms.Label lblLibro;
        private System.Windows.Forms.ComboBox cmbLibros;
        private System.Windows.Forms.Label lblSocio;
        private System.Windows.Forms.ComboBox cmbSocios;
        private System.Windows.Forms.Label lblFechaAlqui;
        private System.Windows.Forms.MaskedTextBox mskAlquilerFecha;
        private System.Windows.Forms.Label lblEntregaFecha;
        private System.Windows.Forms.MaskedTextBox mskFechaEntrega;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnListaPrestamos;
    }
}