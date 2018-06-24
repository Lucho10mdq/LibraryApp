namespace LibreriaMVC
{
    partial class FormListaPrestamos
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
            this.lblListaPrestamo = new System.Windows.Forms.Label();
            this.dtgListaPrestamos = new System.Windows.Forms.DataGridView();
            this.Titulo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAlquiler = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devolucion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaPrestamos)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chocolate;
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 97);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblListaPrestamo
            // 
            this.lblListaPrestamo.AutoSize = true;
            this.lblListaPrestamo.BackColor = System.Drawing.Color.Chocolate;
            this.lblListaPrestamo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaPrestamo.Location = new System.Drawing.Point(146, 36);
            this.lblListaPrestamo.Name = "lblListaPrestamo";
            this.lblListaPrestamo.Size = new System.Drawing.Size(205, 24);
            this.lblListaPrestamo.TabIndex = 1;
            this.lblListaPrestamo.Text = "Lista de Prestamos";
            // 
            // dtgListaPrestamos
            // 
            this.dtgListaPrestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaPrestamos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Titulo,
            this.Apellido,
            this.Nombre,
            this.FechaAlquiler,
            this.Devolucion,
            this.Valor});
            this.dtgListaPrestamos.Location = new System.Drawing.Point(12, 139);
            this.dtgListaPrestamos.Name = "dtgListaPrestamos";
            this.dtgListaPrestamos.Size = new System.Drawing.Size(485, 150);
            this.dtgListaPrestamos.TabIndex = 2;
            // 
            // Titulo
            // 
            this.Titulo.HeaderText = "Titulo";
            this.Titulo.Name = "Titulo";
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // FechaAlquiler
            // 
            this.FechaAlquiler.HeaderText = "Fecha de Alquiler";
            this.FechaAlquiler.Name = "FechaAlquiler";
            // 
            // Devolucion
            // 
            this.Devolucion.HeaderText = "Fecha de Devolucion";
            this.Devolucion.Name = "Devolucion";
            // 
            // Valor
            // 
            this.Valor.HeaderText = "Valor";
            this.Valor.Name = "Valor";
            // 
            // FormListaPrestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(509, 334);
            this.Controls.Add(this.dtgListaPrestamos);
            this.Controls.Add(this.lblListaPrestamo);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormListaPrestamos";
            this.Text = "Lista de Prestamos";
            this.Load += new System.EventHandler(this.FormListaPrestamos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaPrestamos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblListaPrestamo;
        private System.Windows.Forms.DataGridView dtgListaPrestamos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAlquiler;
        private System.Windows.Forms.DataGridViewTextBoxColumn Devolucion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor;
    }
}