namespace LibreriaMVC
{
    partial class FormAutores
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
            this.lblAutores = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.dtgAutor = new System.Windows.Forms.DataGridView();
            this.NroAutor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAutor)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chocolate;
            this.pictureBox1.Location = new System.Drawing.Point(-2, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(385, 79);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblAutores
            // 
            this.lblAutores.AutoSize = true;
            this.lblAutores.BackColor = System.Drawing.Color.Chocolate;
            this.lblAutores.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAutores.Location = new System.Drawing.Point(141, 30);
            this.lblAutores.Name = "lblAutores";
            this.lblAutores.Size = new System.Drawing.Size(90, 24);
            this.lblAutores.TabIndex = 1;
            this.lblAutores.Text = "Autores";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(43, 162);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(75, 39);
            this.btnGuardar.TabIndex = 2;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnLista
            // 
            this.btnLista.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.Location = new System.Drawing.Point(145, 162);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(75, 39);
            this.btnLista.TabIndex = 3;
            this.btnLista.Text = "Lista Autores";
            this.btnLista.UseVisualStyleBackColor = true;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(246, 162);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 39);
            this.btnBuscar.TabIndex = 4;
            this.btnBuscar.Text = "Buscar Autor";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreCompleto.Location = new System.Drawing.Point(58, 114);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(127, 16);
            this.lblNombreCompleto.TabIndex = 5;
            this.lblNombreCompleto.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(201, 114);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 6;
            // 
            // dtgAutor
            // 
            this.dtgAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgAutor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroAutor,
            this.Nombre});
            this.dtgAutor.Location = new System.Drawing.Point(61, 218);
            this.dtgAutor.Name = "dtgAutor";
            this.dtgAutor.Size = new System.Drawing.Size(240, 150);
            this.dtgAutor.TabIndex = 8;
            this.dtgAutor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgAutor_CellContentClick);
            // 
            // NroAutor
            // 
            this.NroAutor.HeaderText = "Nro Autor";
            this.NroAutor.Name = "NroAutor";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // FormAutores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(381, 392);
            this.Controls.Add(this.dtgAutor);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombreCompleto);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.lblAutores);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormAutores";
            this.Text = "FormAutores";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgAutor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAutores;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.DataGridView dtgAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroAutor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}