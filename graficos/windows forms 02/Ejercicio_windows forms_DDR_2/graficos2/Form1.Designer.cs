namespace graficos2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN5 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN6 = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(32, 45);
            this.txtN1.Name = "txtN1";
            this.txtN1.ReadOnly = true;
            this.txtN1.Size = new System.Drawing.Size(151, 20);
            this.txtN1.TabIndex = 0;
            // 
            // txtN5
            // 
            this.txtN5.Location = new System.Drawing.Point(32, 204);
            this.txtN5.Name = "txtN5";
            this.txtN5.ReadOnly = true;
            this.txtN5.Size = new System.Drawing.Size(151, 20);
            this.txtN5.TabIndex = 1;
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(32, 165);
            this.txtN4.Name = "txtN4";
            this.txtN4.ReadOnly = true;
            this.txtN4.Size = new System.Drawing.Size(151, 20);
            this.txtN4.TabIndex = 2;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(32, 127);
            this.txtN3.Name = "txtN3";
            this.txtN3.ReadOnly = true;
            this.txtN3.Size = new System.Drawing.Size(151, 20);
            this.txtN3.TabIndex = 3;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(32, 87);
            this.txtN2.Name = "txtN2";
            this.txtN2.ReadOnly = true;
            this.txtN2.Size = new System.Drawing.Size(151, 20);
            this.txtN2.TabIndex = 4;
            // 
            // txtN6
            // 
            this.txtN6.Location = new System.Drawing.Point(32, 244);
            this.txtN6.Name = "txtN6";
            this.txtN6.ReadOnly = true;
            this.txtN6.Size = new System.Drawing.Size(151, 20);
            this.txtN6.TabIndex = 5;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(210, 45);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(138, 219);
            this.btnGenerar.TabIndex = 6;
            this.btnGenerar.Text = "Generar";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 327);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.txtN6);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN4);
            this.Controls.Add(this.txtN5);
            this.Controls.Add(this.txtN1);
            this.Name = "Form1";
            this.Text = "Ejercicio 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN5;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN6;
        private System.Windows.Forms.Button btnGenerar;
    }
}

