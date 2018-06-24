namespace LibreriaMVC
{
    partial class FormListaSocios
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
            this.lblListaSocios = new System.Windows.Forms.Label();
            this.dtgListaSocios = new System.Windows.Forms.DataGridView();
            this.lblEliminar = new System.Windows.Forms.Label();
            this.txtEliminar = new System.Windows.Forms.TextBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaSocios)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Chocolate;
            this.pictureBox1.Location = new System.Drawing.Point(0, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(551, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblListaSocios
            // 
            this.lblListaSocios.AutoSize = true;
            this.lblListaSocios.BackColor = System.Drawing.Color.Chocolate;
            this.lblListaSocios.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaSocios.Location = new System.Drawing.Point(200, 41);
            this.lblListaSocios.Name = "lblListaSocios";
            this.lblListaSocios.Size = new System.Drawing.Size(134, 24);
            this.lblListaSocios.TabIndex = 1;
            this.lblListaSocios.Text = "Lista Socios";
            this.lblListaSocios.Click += new System.EventHandler(this.lblListaSocios_Click);
            // 
            // dtgListaSocios
            // 
            this.dtgListaSocios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgListaSocios.Location = new System.Drawing.Point(12, 142);
            this.dtgListaSocios.Name = "dtgListaSocios";
            this.dtgListaSocios.Size = new System.Drawing.Size(528, 150);
            this.dtgListaSocios.TabIndex = 2;
            // 
            // lblEliminar
            // 
            this.lblEliminar.AutoSize = true;
            this.lblEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEliminar.Location = new System.Drawing.Point(161, 336);
            this.lblEliminar.Name = "lblEliminar";
            this.lblEliminar.Size = new System.Drawing.Size(31, 16);
            this.lblEliminar.TabIndex = 3;
            this.lblEliminar.Text = "Dni:";
            // 
            // txtEliminar
            // 
            this.txtEliminar.Location = new System.Drawing.Point(213, 336);
            this.txtEliminar.Name = "txtEliminar";
            this.txtEliminar.Size = new System.Drawing.Size(100, 20);
            this.txtEliminar.TabIndex = 4;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(350, 325);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(100, 34);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // FormListaSocios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(552, 394);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.txtEliminar);
            this.Controls.Add(this.lblEliminar);
            this.Controls.Add(this.dtgListaSocios);
            this.Controls.Add(this.lblListaSocios);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormListaSocios";
            this.Text = "ListaSocios";
            this.Load += new System.EventHandler(this.FormListaSocios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgListaSocios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblListaSocios;
        private System.Windows.Forms.DataGridView dtgListaSocios;
        private System.Windows.Forms.Label lblEliminar;
        private System.Windows.Forms.TextBox txtEliminar;
        private System.Windows.Forms.Button btnEliminar;
    }
}