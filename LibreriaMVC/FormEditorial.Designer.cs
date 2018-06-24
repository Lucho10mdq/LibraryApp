namespace LibreriaMVC
{
    partial class FormEditorial
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
            this.lblEditoriales = new System.Windows.Forms.Label();
            this.lblEditorial = new System.Windows.Forms.Label();
            this.txtEditorial = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnListaEdit = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dtgEditoriales = new System.Windows.Forms.DataGridView();
            this.NroEditorial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEditoriales)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chocolate;
            this.pictureBox1.Location = new System.Drawing.Point(-2, -5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 88);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblEditoriales
            // 
            this.lblEditoriales.AutoSize = true;
            this.lblEditoriales.BackColor = System.Drawing.Color.Chocolate;
            this.lblEditoriales.Font = new System.Drawing.Font("Arial Black", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditoriales.Location = new System.Drawing.Point(88, 28);
            this.lblEditoriales.Name = "lblEditoriales";
            this.lblEditoriales.Size = new System.Drawing.Size(136, 30);
            this.lblEditoriales.TabIndex = 1;
            this.lblEditoriales.Text = "Editoriales";
            // 
            // lblEditorial
            // 
            this.lblEditorial.AutoSize = true;
            this.lblEditorial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditorial.Location = new System.Drawing.Point(54, 113);
            this.lblEditorial.Name = "lblEditorial";
            this.lblEditorial.Size = new System.Drawing.Size(78, 19);
            this.lblEditorial.TabIndex = 2;
            this.lblEditorial.Text = "Editorial:";
            // 
            // txtEditorial
            // 
            this.txtEditorial.Location = new System.Drawing.Point(147, 114);
            this.txtEditorial.Name = "txtEditorial";
            this.txtEditorial.Size = new System.Drawing.Size(100, 20);
            this.txtEditorial.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Location = new System.Drawing.Point(12, 140);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(83, 38);
            this.btnGuardar.TabIndex = 4;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnListaEdit
            // 
            this.btnListaEdit.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListaEdit.Location = new System.Drawing.Point(114, 140);
            this.btnListaEdit.Name = "btnListaEdit";
            this.btnListaEdit.Size = new System.Drawing.Size(83, 38);
            this.btnListaEdit.TabIndex = 5;
            this.btnListaEdit.Text = "Lista Editoriales";
            this.btnListaEdit.UseVisualStyleBackColor = true;
            this.btnListaEdit.Click += new System.EventHandler(this.btnListaEdit_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(220, 140);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(83, 38);
            this.btnBuscar.TabIndex = 6;
            this.btnBuscar.Text = "Buscar Editorial";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // dtgEditoriales
            // 
            this.dtgEditoriales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEditoriales.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NroEditorial,
            this.Nombre});
            this.dtgEditoriales.Location = new System.Drawing.Point(27, 184);
            this.dtgEditoriales.Name = "dtgEditoriales";
            this.dtgEditoriales.Size = new System.Drawing.Size(240, 150);
            this.dtgEditoriales.TabIndex = 7;
            // 
            // NroEditorial
            // 
            this.NroEditorial.HeaderText = "Nro Editorial";
            this.NroEditorial.Name = "NroEditorial";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Editorial";
            this.Nombre.Name = "Nombre";
            // 
            // FormEditorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(326, 346);
            this.Controls.Add(this.dtgEditoriales);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.btnListaEdit);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.txtEditorial);
            this.Controls.Add(this.lblEditorial);
            this.Controls.Add(this.lblEditoriales);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormEditorial";
            this.Text = "Editoriales";
            this.Load += new System.EventHandler(this.FormEditorial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEditoriales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblEditoriales;
        private System.Windows.Forms.Label lblEditorial;
        private System.Windows.Forms.TextBox txtEditorial;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnListaEdit;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridView dtgEditoriales;
        private System.Windows.Forms.DataGridViewTextBoxColumn NroEditorial;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
    }
}