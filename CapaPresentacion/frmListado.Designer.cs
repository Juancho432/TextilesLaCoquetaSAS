namespace CapaPresentacion
{
    partial class frmListado
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
            this.label1 = new System.Windows.Forms.Label();
            this.button_Listado = new System.Windows.Forms.Button();
            this.dvg_Listado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Listado)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(211, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "LISTADO DE EMPLEADOS";
            // 
            // button_Listado
            // 
            this.button_Listado.Location = new System.Drawing.Point(668, 387);
            this.button_Listado.Name = "button_Listado";
            this.button_Listado.Size = new System.Drawing.Size(75, 23);
            this.button_Listado.TabIndex = 1;
            this.button_Listado.Text = "Listar";
            this.button_Listado.UseVisualStyleBackColor = true;
            this.button_Listado.Click += new System.EventHandler(this.Button_Listado_Click);
            // 
            // dvg_Listado
            // 
            this.dvg_Listado.AllowUserToAddRows = false;
            this.dvg_Listado.AllowUserToDeleteRows = false;
            this.dvg_Listado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvg_Listado.Location = new System.Drawing.Point(95, 94);
            this.dvg_Listado.Name = "dvg_Listado";
            this.dvg_Listado.ReadOnly = true;
            this.dvg_Listado.RowHeadersVisible = false;
            this.dvg_Listado.RowHeadersWidth = 51;
            this.dvg_Listado.RowTemplate.Height = 24;
            this.dvg_Listado.Size = new System.Drawing.Size(630, 266);
            this.dvg_Listado.TabIndex = 2;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dvg_Listado);
            this.Controls.Add(this.button_Listado);
            this.Controls.Add(this.label1);
            this.Name = "frmListado";
            this.Text = "frmListado";
            ((System.ComponentModel.ISupportInitialize)(this.dvg_Listado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Listado;
        private System.Windows.Forms.DataGridView dvg_Listado;
    }
}