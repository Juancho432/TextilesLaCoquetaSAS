namespace CapaPresentacion
{
    partial class frmSalario
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
            this.label2 = new System.Windows.Forms.Label();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbl_nombre_empleado = new System.Windows.Forms.Label();
            this.lbl_apellido_empleado = new System.Windows.Forms.Label();
            this.lbl_cargo = new System.Windows.Forms.Label();
            this.lbl_salario_base = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_deduccion_salud = new System.Windows.Forms.Label();
            this.lbl_deduccion_pension = new System.Windows.Forms.Label();
            this.lbl_aux_transporte = new System.Windows.Forms.Label();
            this.lbl_salario_neto = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(62, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "SALARIO A PAGAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese el código del empleado:";
            // 
            // txt_codigo
            // 
            this.txt_codigo.Location = new System.Drawing.Point(432, 107);
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(176, 22);
            this.txt_codigo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(171, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nombre: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(171, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cargo: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(474, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apellido: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(474, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Salario base: ";
            // 
            // lbl_nombre_empleado
            // 
            this.lbl_nombre_empleado.AutoSize = true;
            this.lbl_nombre_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nombre_empleado.Location = new System.Drawing.Point(255, 162);
            this.lbl_nombre_empleado.Name = "lbl_nombre_empleado";
            this.lbl_nombre_empleado.Size = new System.Drawing.Size(21, 20);
            this.lbl_nombre_empleado.TabIndex = 7;
            this.lbl_nombre_empleado.Text = "--";
            // 
            // lbl_apellido_empleado
            // 
            this.lbl_apellido_empleado.AutoSize = true;
            this.lbl_apellido_empleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_apellido_empleado.Location = new System.Drawing.Point(613, 162);
            this.lbl_apellido_empleado.Name = "lbl_apellido_empleado";
            this.lbl_apellido_empleado.Size = new System.Drawing.Size(21, 20);
            this.lbl_apellido_empleado.TabIndex = 8;
            this.lbl_apellido_empleado.Text = "--";
            // 
            // lbl_cargo
            // 
            this.lbl_cargo.AutoSize = true;
            this.lbl_cargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cargo.Location = new System.Drawing.Point(255, 221);
            this.lbl_cargo.Name = "lbl_cargo";
            this.lbl_cargo.Size = new System.Drawing.Size(21, 20);
            this.lbl_cargo.TabIndex = 9;
            this.lbl_cargo.Text = "--";
            // 
            // lbl_salario_base
            // 
            this.lbl_salario_base.AutoSize = true;
            this.lbl_salario_base.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salario_base.Location = new System.Drawing.Point(613, 221);
            this.lbl_salario_base.Name = "lbl_salario_base";
            this.lbl_salario_base.Size = new System.Drawing.Size(21, 20);
            this.lbl_salario_base.TabIndex = 10;
            this.lbl_salario_base.Text = "--";
            // 
            // btn_calcular
            // 
            this.btn_calcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_calcular.Location = new System.Drawing.Point(342, 289);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(183, 39);
            this.btn_calcular.TabIndex = 11;
            this.btn_calcular.Text = "Calcular salario neto";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.Btn_buscar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(217, 371);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(173, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Deducción por salud: ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(217, 416);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(191, 20);
            this.label8.TabIndex = 13;
            this.label8.Text = "Deducción por pensión: ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(218, 463);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 20);
            this.label9.TabIndex = 14;
            this.label9.Text = "Auxilio de transporte: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(278, 548);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(191, 20);
            this.label10.TabIndex = 15;
            this.label10.Text = "Salario neto a pagar: ";
            // 
            // lbl_deduccion_salud
            // 
            this.lbl_deduccion_salud.AutoSize = true;
            this.lbl_deduccion_salud.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deduccion_salud.Location = new System.Drawing.Point(448, 371);
            this.lbl_deduccion_salud.Name = "lbl_deduccion_salud";
            this.lbl_deduccion_salud.Size = new System.Drawing.Size(21, 20);
            this.lbl_deduccion_salud.TabIndex = 16;
            this.lbl_deduccion_salud.Text = "--";
            // 
            // lbl_deduccion_pension
            // 
            this.lbl_deduccion_pension.AutoSize = true;
            this.lbl_deduccion_pension.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_deduccion_pension.Location = new System.Drawing.Point(448, 416);
            this.lbl_deduccion_pension.Name = "lbl_deduccion_pension";
            this.lbl_deduccion_pension.Size = new System.Drawing.Size(21, 20);
            this.lbl_deduccion_pension.TabIndex = 17;
            this.lbl_deduccion_pension.Text = "--";
            // 
            // lbl_aux_transporte
            // 
            this.lbl_aux_transporte.AutoSize = true;
            this.lbl_aux_transporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_aux_transporte.Location = new System.Drawing.Point(448, 463);
            this.lbl_aux_transporte.Name = "lbl_aux_transporte";
            this.lbl_aux_transporte.Size = new System.Drawing.Size(21, 20);
            this.lbl_aux_transporte.TabIndex = 18;
            this.lbl_aux_transporte.Text = "--";
            // 
            // lbl_salario_neto
            // 
            this.lbl_salario_neto.AutoSize = true;
            this.lbl_salario_neto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salario_neto.Location = new System.Drawing.Point(487, 548);
            this.lbl_salario_neto.Name = "lbl_salario_neto";
            this.lbl_salario_neto.Size = new System.Drawing.Size(23, 20);
            this.lbl_salario_neto.TabIndex = 19;
            this.lbl_salario_neto.Text = "--";
            // 
            // frmSalario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 651);
            this.Controls.Add(this.lbl_salario_neto);
            this.Controls.Add(this.lbl_aux_transporte);
            this.Controls.Add(this.lbl_deduccion_pension);
            this.Controls.Add(this.lbl_deduccion_salud);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.lbl_salario_base);
            this.Controls.Add(this.lbl_cargo);
            this.Controls.Add(this.lbl_apellido_empleado);
            this.Controls.Add(this.lbl_nombre_empleado);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmSalario";
            this.Text = "frmSalario";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbl_nombre_empleado;
        private System.Windows.Forms.Label lbl_apellido_empleado;
        private System.Windows.Forms.Label lbl_cargo;
        private System.Windows.Forms.Label lbl_salario_base;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_deduccion_salud;
        private System.Windows.Forms.Label lbl_deduccion_pension;
        private System.Windows.Forms.Label lbl_aux_transporte;
        private System.Windows.Forms.Label lbl_salario_neto;
    }
}