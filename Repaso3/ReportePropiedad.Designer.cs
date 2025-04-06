namespace Repaso3
{
    partial class ReportePropiedad
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
            this.buttonSalir = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonCargar = new System.Windows.Forms.Button();
            this.buttonMayMen = new System.Windows.Forms.Button();
            this.buttonMenMay = new System.Windows.Forms.Button();
            this.buttonAltas = new System.Windows.Forms.Button();
            this.buttonBajas = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(335, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Reporte";
            // 
            // buttonSalir
            // 
            this.buttonSalir.Location = new System.Drawing.Point(653, 139);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(135, 72);
            this.buttonSalir.TabIndex = 11;
            this.buttonSalir.Text = "Salir";
            this.buttonSalir.UseVisualStyleBackColor = true;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(492, 377);
            this.dataGridView1.TabIndex = 12;
            // 
            // buttonCargar
            // 
            this.buttonCargar.Location = new System.Drawing.Point(510, 139);
            this.buttonCargar.Name = "buttonCargar";
            this.buttonCargar.Size = new System.Drawing.Size(135, 72);
            this.buttonCargar.TabIndex = 13;
            this.buttonCargar.Text = "Mostrar Reporte Completo";
            this.buttonCargar.UseVisualStyleBackColor = true;
            this.buttonCargar.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonMayMen
            // 
            this.buttonMayMen.Location = new System.Drawing.Point(510, 217);
            this.buttonMayMen.Name = "buttonMayMen";
            this.buttonMayMen.Size = new System.Drawing.Size(135, 90);
            this.buttonMayMen.TabIndex = 14;
            this.buttonMayMen.Text = "Ordenar desde la mayor cuota de mantenimiento a la menor";
            this.buttonMayMen.UseVisualStyleBackColor = true;
            this.buttonMayMen.Click += new System.EventHandler(this.buttonMayMen_Click);
            // 
            // buttonMenMay
            // 
            this.buttonMenMay.Location = new System.Drawing.Point(653, 217);
            this.buttonMenMay.Name = "buttonMenMay";
            this.buttonMenMay.Size = new System.Drawing.Size(135, 90);
            this.buttonMenMay.TabIndex = 15;
            this.buttonMenMay.Text = "Ordenar desde la menor cuota de mantenimiento a la mayor";
            this.buttonMenMay.UseVisualStyleBackColor = true;
            this.buttonMenMay.Click += new System.EventHandler(this.buttonMenMay_Click);
            // 
            // buttonAltas
            // 
            this.buttonAltas.Location = new System.Drawing.Point(512, 61);
            this.buttonAltas.Name = "buttonAltas";
            this.buttonAltas.Size = new System.Drawing.Size(135, 72);
            this.buttonAltas.TabIndex = 16;
            this.buttonAltas.Text = "Mostrar las 3 cuotas mas altas";
            this.buttonAltas.UseVisualStyleBackColor = true;
            this.buttonAltas.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonBajas
            // 
            this.buttonBajas.Location = new System.Drawing.Point(653, 61);
            this.buttonBajas.Name = "buttonBajas";
            this.buttonBajas.Size = new System.Drawing.Size(135, 72);
            this.buttonBajas.TabIndex = 17;
            this.buttonBajas.Text = "Mostrar las 3 cuotas mas bajas";
            this.buttonBajas.UseVisualStyleBackColor = true;
            this.buttonBajas.Click += new System.EventHandler(this.buttonBajas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(232, 40);
            this.label2.TabIndex = 18;
            this.label2.Text = "Propietario que debe la cuota \r\nmas alta es:\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(510, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "...";
            // 
            // ReportePropiedad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonBajas);
            this.Controls.Add(this.buttonAltas);
            this.Controls.Add(this.buttonMenMay);
            this.Controls.Add(this.buttonMayMen);
            this.Controls.Add(this.buttonCargar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonSalir);
            this.Controls.Add(this.label1);
            this.Name = "ReportePropiedad";
            this.Text = "ReportePropiedad";
            this.Load += new System.EventHandler(this.ReportePropiedad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonCargar;
        private System.Windows.Forms.Button buttonMayMen;
        private System.Windows.Forms.Button buttonMenMay;
        private System.Windows.Forms.Button buttonAltas;
        private System.Windows.Forms.Button buttonBajas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}