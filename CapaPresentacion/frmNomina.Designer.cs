namespace CapaPresentacion
{
    partial class frmNomina
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
            this.dataGrid_nomina = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalarioNeto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_nomina)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "NÓMINA";
            // 
            // dataGrid_nomina
            // 
            this.dataGrid_nomina.AllowUserToAddRows = false;
            this.dataGrid_nomina.AllowUserToDeleteRows = false;
            this.dataGrid_nomina.AllowUserToResizeColumns = false;
            this.dataGrid_nomina.AllowUserToResizeRows = false;
            this.dataGrid_nomina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid_nomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_nomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Apellido,
            this.Cargo,
            this.SalarioBase,
            this.Salud,
            this.Pension,
            this.Transporte,
            this.SalarioNeto});
            this.dataGrid_nomina.Location = new System.Drawing.Point(70, 204);
            this.dataGrid_nomina.Name = "dataGrid_nomina";
            this.dataGrid_nomina.ReadOnly = true;
            this.dataGrid_nomina.RowHeadersVisible = false;
            this.dataGrid_nomina.RowHeadersWidth = 51;
            this.dataGrid_nomina.RowTemplate.Height = 24;
            this.dataGrid_nomina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid_nomina.Size = new System.Drawing.Size(1129, 509);
            this.dataGrid_nomina.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(351, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Si desea filtrar por empleado, escriba su código a continuación:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(414, 126);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(241, 22);
            this.txt_codigo.TabIndex = 3;
            // 
            // button_filtrar
            // 
            this.button_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_filtrar.Location = new System.Drawing.Point(672, 126);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(85, 26);
            this.button_filtrar.TabIndex = 5;
            this.button_filtrar.Text = "Filtrar";
            this.button_filtrar.UseVisualStyleBackColor = true;
            this.button_filtrar.Click += new System.EventHandler(this.Button_filtrar_Click);
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.MinimumWidth = 6;
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 6;
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.MinimumWidth = 6;
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Cargo
            // 
            this.Cargo.HeaderText = "Cargo";
            this.Cargo.MinimumWidth = 6;
            this.Cargo.Name = "Cargo";
            this.Cargo.ReadOnly = true;
            // 
            // SalarioBase
            // 
            this.SalarioBase.HeaderText = "Salario Base";
            this.SalarioBase.MinimumWidth = 6;
            this.SalarioBase.Name = "SalarioBase";
            this.SalarioBase.ReadOnly = true;
            // 
            // Salud
            // 
            this.Salud.HeaderText = "Deduccion Salud";
            this.Salud.MinimumWidth = 6;
            this.Salud.Name = "Salud";
            this.Salud.ReadOnly = true;
            // 
            // Pension
            // 
            this.Pension.HeaderText = "Deduccion Pension";
            this.Pension.MinimumWidth = 6;
            this.Pension.Name = "Pension";
            this.Pension.ReadOnly = true;
            // 
            // Transporte
            // 
            this.Transporte.HeaderText = "Deduccion Transporte";
            this.Transporte.MinimumWidth = 6;
            this.Transporte.Name = "Transporte";
            this.Transporte.ReadOnly = true;
            // 
            // SalarioNeto
            // 
            this.SalarioNeto.HeaderText = "Salario Neto";
            this.SalarioNeto.MinimumWidth = 6;
            this.SalarioNeto.Name = "SalarioNeto";
            this.SalarioNeto.ReadOnly = true;
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 764);
            this.Controls.Add(this.button_filtrar);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid_nomina);
            this.Controls.Add(this.label1);
            this.Name = "frmNomina";
            this.Text = "frmNomina";
            this.Load += new System.EventHandler(this.FrmNomina_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_nomina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_nomina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Button button_filtrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalarioNeto;
    }
}