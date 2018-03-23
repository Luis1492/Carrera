namespace Carrera_liebre_y_tortuga
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtmostrar = new System.Windows.Forms.TextBox();
            this.txtganador = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(360, 89);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 61);
            this.button1.TabIndex = 0;
            this.button1.Text = "Competir!!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(290, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Competición LIEBRE vs TORTUGA!!!";
            // 
            // txtmostrar
            // 
            this.txtmostrar.Location = new System.Drawing.Point(276, 158);
            this.txtmostrar.Multiline = true;
            this.txtmostrar.Name = "txtmostrar";
            this.txtmostrar.Size = new System.Drawing.Size(396, 415);
            this.txtmostrar.TabIndex = 2;
            // 
            // txtganador
            // 
            this.txtganador.Location = new System.Drawing.Point(440, 579);
            this.txtganador.Multiline = true;
            this.txtganador.Name = "txtganador";
            this.txtganador.Size = new System.Drawing.Size(203, 51);
            this.txtganador.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(294, 593);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ganador:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 693);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtganador);
            this.Controls.Add(this.txtmostrar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmostrar;
        private System.Windows.Forms.TextBox txtganador;
        private System.Windows.Forms.Label label2;
    }
}

