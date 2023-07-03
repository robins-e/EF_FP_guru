namespace EF_FP_guru
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
            this.btnAbrirEnunciado1 = new System.Windows.Forms.Button();
            this.btnAbrirEnunciado2 = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAbrirEnunciado1
            // 
            this.btnAbrirEnunciado1.Location = new System.Drawing.Point(65, 77);
            this.btnAbrirEnunciado1.Name = "btnAbrirEnunciado1";
            this.btnAbrirEnunciado1.Size = new System.Drawing.Size(106, 40);
            this.btnAbrirEnunciado1.TabIndex = 0;
            this.btnAbrirEnunciado1.Text = "Enunciado1";
            this.btnAbrirEnunciado1.UseVisualStyleBackColor = true;
            this.btnAbrirEnunciado1.Click += new System.EventHandler(this.btnAbrirEnunciado1_Click);
            // 
            // btnAbrirEnunciado2
            // 
            this.btnAbrirEnunciado2.Location = new System.Drawing.Point(65, 123);
            this.btnAbrirEnunciado2.Name = "btnAbrirEnunciado2";
            this.btnAbrirEnunciado2.Size = new System.Drawing.Size(106, 37);
            this.btnAbrirEnunciado2.TabIndex = 1;
            this.btnAbrirEnunciado2.Text = "Enunciado2";
            this.btnAbrirEnunciado2.UseVisualStyleBackColor = true;
            this.btnAbrirEnunciado2.Click += new System.EventHandler(this.btnAbrirEnunciado2_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(65, 177);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(55, 38);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnAbrirEnunciado2);
            this.Controls.Add(this.btnAbrirEnunciado1);
            this.Name = "Form1";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAbrirEnunciado1;
        private System.Windows.Forms.Button btnAbrirEnunciado2;
        private System.Windows.Forms.Button btnSalir;
    }
}

