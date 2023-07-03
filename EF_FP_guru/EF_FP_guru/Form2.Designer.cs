namespace EF_FP_guru
{
    partial class Enunciado1Form
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
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.txtArray = new System.Windows.Forms.TextBox();
            this.lblDesordenado = new System.Windows.Forms.Label();
            this.lblOrdenado = new System.Windows.Forms.Label();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtArrayDesordenado = new System.Windows.Forms.TextBox();
            this.txtArrayOrdenado = new System.Windows.Forms.TextBox();
            this.lblIngreseArray = new System.Windows.Forms.Label();
            this.lblMensaje = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(348, 109);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(75, 23);
            this.btnOrdenar.TabIndex = 0;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // txtArray
            // 
            this.txtArray.Location = new System.Drawing.Point(127, 71);
            this.txtArray.Name = "txtArray";
            this.txtArray.Size = new System.Drawing.Size(296, 20);
            this.txtArray.TabIndex = 1;
            // 
            // lblDesordenado
            // 
            this.lblDesordenado.AutoSize = true;
            this.lblDesordenado.Location = new System.Drawing.Point(30, 170);
            this.lblDesordenado.Name = "lblDesordenado";
            this.lblDesordenado.Size = new System.Drawing.Size(71, 13);
            this.lblDesordenado.TabIndex = 2;
            this.lblDesordenado.Text = "Desordenado";
            // 
            // lblOrdenado
            // 
            this.lblOrdenado.AutoSize = true;
            this.lblOrdenado.Location = new System.Drawing.Point(30, 196);
            this.lblOrdenado.Name = "lblOrdenado";
            this.lblOrdenado.Size = new System.Drawing.Size(54, 13);
            this.lblOrdenado.TabIndex = 3;
            this.lblOrdenado.Text = "Ordenado";
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(348, 138);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 4;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtArrayDesordenado
            // 
            this.txtArrayDesordenado.Location = new System.Drawing.Point(127, 163);
            this.txtArrayDesordenado.Name = "txtArrayDesordenado";
            this.txtArrayDesordenado.Size = new System.Drawing.Size(296, 20);
            this.txtArrayDesordenado.TabIndex = 5;
            // 
            // txtArrayOrdenado
            // 
            this.txtArrayOrdenado.Location = new System.Drawing.Point(127, 189);
            this.txtArrayOrdenado.Name = "txtArrayOrdenado";
            this.txtArrayOrdenado.Size = new System.Drawing.Size(296, 20);
            this.txtArrayOrdenado.TabIndex = 6;
            // 
            // lblIngreseArray
            // 
            this.lblIngreseArray.AutoSize = true;
            this.lblIngreseArray.Location = new System.Drawing.Point(33, 77);
            this.lblIngreseArray.Name = "lblIngreseArray";
            this.lblIngreseArray.Size = new System.Drawing.Size(74, 13);
            this.lblIngreseArray.TabIndex = 7;
            this.lblIngreseArray.Text = "Ingrese Arrays";
            // 
            // lblMensaje
            // 
            this.lblMensaje.AutoSize = true;
            this.lblMensaje.ForeColor = System.Drawing.Color.Red;
            this.lblMensaje.Location = new System.Drawing.Point(128, 94);
            this.lblMensaje.Name = "lblMensaje";
            this.lblMensaje.Size = new System.Drawing.Size(256, 13);
            this.lblMensaje.TabIndex = 8;
            this.lblMensaje.Text = "Agregar el Array seperado por coma \",\" y sin espacio";
            // 
            // Enunciado1Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMensaje);
            this.Controls.Add(this.lblIngreseArray);
            this.Controls.Add(this.txtArrayOrdenado);
            this.Controls.Add(this.txtArrayDesordenado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lblOrdenado);
            this.Controls.Add(this.lblDesordenado);
            this.Controls.Add(this.txtArray);
            this.Controls.Add(this.btnOrdenar);
            this.Name = "Enunciado1Form";
            this.Text = "Enunciado 1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TextBox txtArray;
        private System.Windows.Forms.Label lblDesordenado;
        private System.Windows.Forms.Label lblOrdenado;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtArrayDesordenado;
        private System.Windows.Forms.TextBox txtArrayOrdenado;
        private System.Windows.Forms.Label lblIngreseArray;
        private System.Windows.Forms.Label lblMensaje;
    }
}