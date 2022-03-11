
namespace LaboratorioNo6
{
    partial class IngresoAlquiler
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNit1 = new System.Windows.Forms.TextBox();
            this.txtPlaca1 = new System.Windows.Forms.TextBox();
            this.txtFechaA = new System.Windows.Forms.DateTimePicker();
            this.txtFechaD = new System.Windows.Forms.DateTimePicker();
            this.txtKm = new System.Windows.Forms.TextBox();
            this.btnIngresarDato = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.dgtAlquiler = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgtAlquiler)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "NIT";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Placa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Alquiler";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fecha de devolucion";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 368);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Km recorridos";
            // 
            // txtNit1
            // 
            this.txtNit1.Location = new System.Drawing.Point(49, 68);
            this.txtNit1.Name = "txtNit1";
            this.txtNit1.Size = new System.Drawing.Size(346, 26);
            this.txtNit1.TabIndex = 5;
            // 
            // txtPlaca1
            // 
            this.txtPlaca1.Location = new System.Drawing.Point(49, 152);
            this.txtPlaca1.Name = "txtPlaca1";
            this.txtPlaca1.Size = new System.Drawing.Size(346, 26);
            this.txtPlaca1.TabIndex = 6;
            // 
            // txtFechaA
            // 
            this.txtFechaA.Location = new System.Drawing.Point(49, 235);
            this.txtFechaA.Name = "txtFechaA";
            this.txtFechaA.Size = new System.Drawing.Size(346, 26);
            this.txtFechaA.TabIndex = 7;
            // 
            // txtFechaD
            // 
            this.txtFechaD.Location = new System.Drawing.Point(49, 319);
            this.txtFechaD.Name = "txtFechaD";
            this.txtFechaD.Size = new System.Drawing.Size(346, 26);
            this.txtFechaD.TabIndex = 8;
            // 
            // txtKm
            // 
            this.txtKm.Location = new System.Drawing.Point(49, 403);
            this.txtKm.Name = "txtKm";
            this.txtKm.Size = new System.Drawing.Size(346, 26);
            this.txtKm.TabIndex = 9;
            // 
            // btnIngresarDato
            // 
            this.btnIngresarDato.Location = new System.Drawing.Point(40, 457);
            this.btnIngresarDato.Name = "btnIngresarDato";
            this.btnIngresarDato.Size = new System.Drawing.Size(169, 66);
            this.btnIngresarDato.TabIndex = 10;
            this.btnIngresarDato.Text = "Ingresar";
            this.btnIngresarDato.UseVisualStyleBackColor = true;
            this.btnIngresarDato.Click += new System.EventHandler(this.btnIngresarDato_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(226, 457);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(169, 61);
            this.btnCargar.TabIndex = 11;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(401, 455);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(169, 63);
            this.btnGuardar.TabIndex = 12;
            this.btnGuardar.Text = "Ver Datos";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // dgtAlquiler
            // 
            this.dgtAlquiler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtAlquiler.Location = new System.Drawing.Point(523, 68);
            this.dgtAlquiler.Name = "dgtAlquiler";
            this.dgtAlquiler.RowHeadersWidth = 62;
            this.dgtAlquiler.RowTemplate.Height = 28;
            this.dgtAlquiler.Size = new System.Drawing.Size(664, 361);
            this.dgtAlquiler.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Blue;
            this.label6.Location = new System.Drawing.Point(789, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(160, 25);
            this.label6.TabIndex = 14;
            this.label6.Text = "Datos de Alquiler";
            // 
            // IngresoAlquiler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1306, 656);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dgtAlquiler);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnIngresarDato);
            this.Controls.Add(this.txtKm);
            this.Controls.Add(this.txtFechaD);
            this.Controls.Add(this.txtFechaA);
            this.Controls.Add(this.txtPlaca1);
            this.Controls.Add(this.txtNit1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IngresoAlquiler";
            this.Text = "IngresoAlquiler";
            ((System.ComponentModel.ISupportInitialize)(this.dgtAlquiler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNit1;
        private System.Windows.Forms.TextBox txtPlaca1;
        private System.Windows.Forms.DateTimePicker txtFechaA;
        private System.Windows.Forms.DateTimePicker txtFechaD;
        private System.Windows.Forms.TextBox txtKm;
        private System.Windows.Forms.Button btnIngresarDato;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.DataGridView dgtAlquiler;
        private System.Windows.Forms.Label label6;
    }
}