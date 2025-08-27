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
            this.Column_codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_cargo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_salario_base = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_salud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_pension = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_aux_transporte = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_salario_neto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.groupBox_totales_nomina = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_total_nomina = new System.Windows.Forms.Label();
            this.lbl_total_salud = new System.Windows.Forms.Label();
            this.lbl_total_pension = new System.Windows.Forms.Label();
            this.lbl_total_transporte = new System.Windows.Forms.Label();
            this.button_filtrar = new System.Windows.Forms.Button();
            this.button_limpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_nomina)).BeginInit();
            this.groupBox_totales_nomina.SuspendLayout();
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
            this.dataGrid_nomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_nomina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_codigo,
            this.Column_nombre,
            this.Column_apellido,
            this.Column_cargo,
            this.Column_salario_base,
            this.Column_salud,
            this.Column_pension,
            this.Column_aux_transporte,
            this.Column_salario_neto});
            this.dataGrid_nomina.Location = new System.Drawing.Point(70, 204);
            this.dataGrid_nomina.Name = "dataGrid_nomina";
            this.dataGrid_nomina.RowHeadersVisible = false;
            this.dataGrid_nomina.RowHeadersWidth = 51;
            this.dataGrid_nomina.RowTemplate.Height = 24;
            this.dataGrid_nomina.Size = new System.Drawing.Size(1129, 234);
            this.dataGrid_nomina.TabIndex = 1;
            // 
            // Column_codigo
            // 
            this.Column_codigo.HeaderText = "Código";
            this.Column_codigo.MinimumWidth = 6;
            this.Column_codigo.Name = "Column_codigo";
            this.Column_codigo.Width = 125;
            // 
            // Column_nombre
            // 
            this.Column_nombre.HeaderText = "Nombre";
            this.Column_nombre.MinimumWidth = 6;
            this.Column_nombre.Name = "Column_nombre";
            this.Column_nombre.Width = 125;
            // 
            // Column_apellido
            // 
            this.Column_apellido.HeaderText = "Apellido";
            this.Column_apellido.MinimumWidth = 6;
            this.Column_apellido.Name = "Column_apellido";
            this.Column_apellido.Width = 125;
            // 
            // Column_cargo
            // 
            this.Column_cargo.HeaderText = "Cargo";
            this.Column_cargo.MinimumWidth = 6;
            this.Column_cargo.Name = "Column_cargo";
            this.Column_cargo.Width = 125;
            // 
            // Column_salario_base
            // 
            this.Column_salario_base.HeaderText = "Salario base";
            this.Column_salario_base.MinimumWidth = 6;
            this.Column_salario_base.Name = "Column_salario_base";
            this.Column_salario_base.Width = 125;
            // 
            // Column_salud
            // 
            this.Column_salud.HeaderText = "Salud";
            this.Column_salud.MinimumWidth = 6;
            this.Column_salud.Name = "Column_salud";
            this.Column_salud.Width = 125;
            // 
            // Column_pension
            // 
            this.Column_pension.HeaderText = "Pensión";
            this.Column_pension.MinimumWidth = 6;
            this.Column_pension.Name = "Column_pension";
            this.Column_pension.Width = 125;
            // 
            // Column_aux_transporte
            // 
            this.Column_aux_transporte.HeaderText = "Aux. Transporte";
            this.Column_aux_transporte.MinimumWidth = 6;
            this.Column_aux_transporte.Name = "Column_aux_transporte";
            this.Column_aux_transporte.Width = 125;
            // 
            // Column_salario_neto
            // 
            this.Column_salario_neto.HeaderText = "Salario Neto";
            this.Column_salario_neto.MinimumWidth = 6;
            this.Column_salario_neto.Name = "Column_salario_neto";
            this.Column_salario_neto.Width = 125;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(245, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(483, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Si desea filtrar por empleado, escriba su código a continuación:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(744, 80);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(241, 22);
            this.txt_codigo.TabIndex = 3;
            // 
            // groupBox_totales_nomina
            // 
            this.groupBox_totales_nomina.Controls.Add(this.lbl_total_transporte);
            this.groupBox_totales_nomina.Controls.Add(this.lbl_total_pension);
            this.groupBox_totales_nomina.Controls.Add(this.lbl_total_salud);
            this.groupBox_totales_nomina.Controls.Add(this.lbl_total_nomina);
            this.groupBox_totales_nomina.Controls.Add(this.label6);
            this.groupBox_totales_nomina.Controls.Add(this.label5);
            this.groupBox_totales_nomina.Controls.Add(this.label4);
            this.groupBox_totales_nomina.Controls.Add(this.label3);
            this.groupBox_totales_nomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_totales_nomina.Location = new System.Drawing.Point(305, 485);
            this.groupBox_totales_nomina.Name = "groupBox_totales_nomina";
            this.groupBox_totales_nomina.Size = new System.Drawing.Size(653, 230);
            this.groupBox_totales_nomina.TabIndex = 4;
            this.groupBox_totales_nomina.TabStop = false;
            this.groupBox_totales_nomina.Text = "Totales generales:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Total nómina: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total deducción en salud: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(223, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total deducción en pensión: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(212, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Total auxilio de transporte: ";
            // 
            // lbl_total_nomina
            // 
            this.lbl_total_nomina.AutoSize = true;
            this.lbl_total_nomina.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_nomina.Location = new System.Drawing.Point(456, 46);
            this.lbl_total_nomina.Name = "lbl_total_nomina";
            this.lbl_total_nomina.Size = new System.Drawing.Size(21, 20);
            this.lbl_total_nomina.TabIndex = 9;
            this.lbl_total_nomina.Text = "--";
            // 
            // lbl_total_salud
            // 
            this.lbl_total_salud.AutoSize = true;
            this.lbl_total_salud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_salud.Location = new System.Drawing.Point(456, 92);
            this.lbl_total_salud.Name = "lbl_total_salud";
            this.lbl_total_salud.Size = new System.Drawing.Size(21, 20);
            this.lbl_total_salud.TabIndex = 10;
            this.lbl_total_salud.Text = "--";
            // 
            // lbl_total_pension
            // 
            this.lbl_total_pension.AutoSize = true;
            this.lbl_total_pension.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_pension.Location = new System.Drawing.Point(456, 139);
            this.lbl_total_pension.Name = "lbl_total_pension";
            this.lbl_total_pension.Size = new System.Drawing.Size(21, 20);
            this.lbl_total_pension.TabIndex = 11;
            this.lbl_total_pension.Text = "--";
            // 
            // lbl_total_transporte
            // 
            this.lbl_total_transporte.AutoSize = true;
            this.lbl_total_transporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_total_transporte.Location = new System.Drawing.Point(456, 183);
            this.lbl_total_transporte.Name = "lbl_total_transporte";
            this.lbl_total_transporte.Size = new System.Drawing.Size(21, 20);
            this.lbl_total_transporte.TabIndex = 12;
            this.lbl_total_transporte.Text = "--";
            // 
            // button_filtrar
            // 
            this.button_filtrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_filtrar.Location = new System.Drawing.Point(566, 131);
            this.button_filtrar.Name = "button_filtrar";
            this.button_filtrar.Size = new System.Drawing.Size(85, 26);
            this.button_filtrar.TabIndex = 5;
            this.button_filtrar.Text = "Filtrar";
            this.button_filtrar.UseVisualStyleBackColor = true;
            // 
            // button_limpiar
            // 
            this.button_limpiar.Location = new System.Drawing.Point(1089, 454);
            this.button_limpiar.Name = "button_limpiar";
            this.button_limpiar.Size = new System.Drawing.Size(75, 31);
            this.button_limpiar.TabIndex = 6;
            this.button_limpiar.Text = "Limpiar";
            this.button_limpiar.UseVisualStyleBackColor = true;
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 764);
            this.Controls.Add(this.button_limpiar);
            this.Controls.Add(this.button_filtrar);
            this.Controls.Add(this.groupBox_totales_nomina);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGrid_nomina);
            this.Controls.Add(this.label1);
            this.Name = "frmNomina";
            this.Text = "frmNomina";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_nomina)).EndInit();
            this.groupBox_totales_nomina.ResumeLayout(false);
            this.groupBox_totales_nomina.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGrid_nomina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_cargo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_salario_base;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_salud;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_pension;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_aux_transporte;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_salario_neto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.GroupBox groupBox_totales_nomina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_total_nomina;
        private System.Windows.Forms.Label lbl_total_transporte;
        private System.Windows.Forms.Label lbl_total_pension;
        private System.Windows.Forms.Label lbl_total_salud;
        private System.Windows.Forms.Button button_filtrar;
        private System.Windows.Forms.Button button_limpiar;
    }
}