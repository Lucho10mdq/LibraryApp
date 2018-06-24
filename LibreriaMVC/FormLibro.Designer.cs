namespace LibreriaMVC
{
    partial class FormLibro
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
            this.lblLibros = new System.Windows.Forms.Label();
            this.lblisbn = new System.Windows.Forms.Label();
            this.cmbIsbn = new System.Windows.Forms.ComboBox();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.cmbEditorial = new System.Windows.Forms.ComboBox();
            this.lblYearEdicion = new System.Windows.Forms.Label();
            this.mskAnio = new System.Windows.Forms.MaskedTextBox();
            this.lblDisponibilidad = new System.Windows.Forms.Label();
            this.cmbDisponibilidad = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.rdbUsado = new System.Windows.Forms.RadioButton();
            this.rdbNuevo = new System.Windows.Forms.RadioButton();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chocolate;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 75);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblLibros
            // 
            this.lblLibros.AutoSize = true;
            this.lblLibros.BackColor = System.Drawing.Color.Chocolate;
            this.lblLibros.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLibros.Location = new System.Drawing.Point(65, 25);
            this.lblLibros.Name = "lblLibros";
            this.lblLibros.Size = new System.Drawing.Size(149, 24);
            this.lblLibros.TabIndex = 1;
            this.lblLibros.Text = "Agregar Libro";
            // 
            // lblisbn
            // 
            this.lblisbn.AutoSize = true;
            this.lblisbn.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblisbn.Location = new System.Drawing.Point(25, 101);
            this.lblisbn.Name = "lblisbn";
            this.lblisbn.Size = new System.Drawing.Size(38, 16);
            this.lblisbn.TabIndex = 2;
            this.lblisbn.Text = "Isbn:";
            // 
            // cmbIsbn
            // 
            this.cmbIsbn.FormattingEnabled = true;
            this.cmbIsbn.Items.AddRange(new object[] {
            ""});
            this.cmbIsbn.Location = new System.Drawing.Point(149, 96);
            this.cmbIsbn.Name = "cmbIsbn";
            this.cmbIsbn.Size = new System.Drawing.Size(121, 21);
            this.cmbIsbn.TabIndex = 3;
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.Location = new System.Drawing.Point(25, 143);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(65, 16);
            this.lblEditorial.TabIndex = 4;
            this.lblEditorial.Text = "Editorial:";
            // 
            // cmbEditorial
            // 
            this.cmbEditorial.FormattingEnabled = true;
            this.cmbEditorial.Items.AddRange(new object[] {
            ""});
            this.cmbEditorial.Location = new System.Drawing.Point(149, 138);
            this.cmbEditorial.Name = "cmbEditorial";
            this.cmbEditorial.Size = new System.Drawing.Size(121, 21);
            this.cmbEditorial.TabIndex = 5;
            // 
            // lblYearEdicion
            // 
            this.lblYearEdicion.AutoSize = true;
            this.lblYearEdicion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYearEdicion.Location = new System.Drawing.Point(25, 182);
            this.lblYearEdicion.Name = "lblYearEdicion";
            this.lblYearEdicion.Size = new System.Drawing.Size(112, 16);
            this.lblYearEdicion.TabIndex = 6;
            this.lblYearEdicion.Text = "Anio de Edicion:";
            // 
            // mskAnio
            // 
            this.mskAnio.Location = new System.Drawing.Point(149, 178);
            this.mskAnio.Mask = "00/00/0000";
            this.mskAnio.Name = "mskAnio";
            this.mskAnio.Size = new System.Drawing.Size(100, 20);
            this.mskAnio.TabIndex = 7;
            this.mskAnio.ValidatingType = typeof(System.DateTime);
            // 
            // lblDisponibilidad
            // 
            this.lblDisponibilidad.AutoSize = true;
            this.lblDisponibilidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDisponibilidad.Location = new System.Drawing.Point(25, 216);
            this.lblDisponibilidad.Name = "lblDisponibilidad";
            this.lblDisponibilidad.Size = new System.Drawing.Size(103, 16);
            this.lblDisponibilidad.TabIndex = 8;
            this.lblDisponibilidad.Text = "Disponibilidad:";
            // 
            // cmbDisponibilidad
            // 
            this.cmbDisponibilidad.FormattingEnabled = true;
            this.cmbDisponibilidad.Location = new System.Drawing.Point(149, 215);
            this.cmbDisponibilidad.Name = "cmbDisponibilidad";
            this.cmbDisponibilidad.Size = new System.Drawing.Size(121, 21);
            this.cmbDisponibilidad.TabIndex = 9;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(25, 257);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(54, 16);
            this.lblEstado.TabIndex = 10;
            this.lblEstado.Text = "Estado:";
            // 
            // rdbUsado
            // 
            this.rdbUsado.AutoSize = true;
            this.rdbUsado.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbUsado.Location = new System.Drawing.Point(105, 257);
            this.rdbUsado.Name = "rdbUsado";
            this.rdbUsado.Size = new System.Drawing.Size(62, 19);
            this.rdbUsado.TabIndex = 11;
            this.rdbUsado.TabStop = true;
            this.rdbUsado.Text = "Usado";
            this.rdbUsado.UseVisualStyleBackColor = true;
            // 
            // rdbNuevo
            // 
            this.rdbNuevo.AutoSize = true;
            this.rdbNuevo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNuevo.Location = new System.Drawing.Point(185, 258);
            this.rdbNuevo.Name = "rdbNuevo";
            this.rdbNuevo.Size = new System.Drawing.Size(60, 19);
            this.rdbNuevo.TabIndex = 12;
            this.rdbNuevo.TabStop = true;
            this.rdbNuevo.Text = "Nuevo";
            this.rdbNuevo.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(28, 292);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(100, 35);
            this.btnGuardar.TabIndex = 13;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(167, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 35);
            this.button2.TabIndex = 14;
            this.button2.Text = "Lista de Libros";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormLibro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(299, 359);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.rdbNuevo);
            this.Controls.Add(this.rdbUsado);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cmbDisponibilidad);
            this.Controls.Add(this.lblDisponibilidad);
            this.Controls.Add(this.mskAnio);
            this.Controls.Add(this.lblYearEdicion);
            this.Controls.Add(this.cmbEditorial);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.cmbIsbn);
            this.Controls.Add(this.lblisbn);
            this.Controls.Add(this.lblLibros);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormLibro";
            this.Text = "Libros";
            this.Load += new System.EventHandler(this.FormLibro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblLibros;
        private System.Windows.Forms.Label lblisbn;
        private System.Windows.Forms.ComboBox cmbIsbn;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.ComboBox cmbEditorial;
        private System.Windows.Forms.Label lblYearEdicion;
        private System.Windows.Forms.MaskedTextBox mskAnio;
        private System.Windows.Forms.Label lblDisponibilidad;
        private System.Windows.Forms.ComboBox cmbDisponibilidad;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.RadioButton rdbUsado;
        private System.Windows.Forms.RadioButton rdbNuevo;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button button2;
    }
}