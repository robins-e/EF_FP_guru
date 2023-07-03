namespace EF_FP_guru
{
    partial class Enunciado2Form
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
            this.dgvLista = new System.Windows.Forms.DataGridView();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblPuntos = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.rbGano = new System.Windows.Forms.RadioButton();
            this.rbPerdio = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.Juegos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resultado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLista
            // 
            this.dgvLista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLista.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Juegos,
            this.Puntaje,
            this.Resultado});
            this.dgvLista.Location = new System.Drawing.Point(51, 208);
            this.dgvLista.Name = "dgvLista";
            this.dgvLista.Size = new System.Drawing.Size(331, 150);
            this.dgvLista.TabIndex = 0;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(77, 87);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(214, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(333, 87);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(350, 378);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(58, 20);
            this.txtResultado.TabIndex = 3;
            // 
            // lblPuntos
            // 
            this.lblPuntos.AutoSize = true;
            this.lblPuntos.Location = new System.Drawing.Point(258, 383);
            this.lblPuntos.Name = "lblPuntos";
            this.lblPuntos.Size = new System.Drawing.Size(67, 13);
            this.lblPuntos.TabIndex = 4;
            this.lblPuntos.Text = "Total Puntos";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(12, 97);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Nombre";
            // 
            // rbGano
            // 
            this.rbGano.AutoSize = true;
            this.rbGano.Location = new System.Drawing.Point(96, 150);
            this.rbGano.Name = "rbGano";
            this.rbGano.Size = new System.Drawing.Size(34, 17);
            this.rbGano.TabIndex = 6;
            this.rbGano.TabStop = true;
            this.rbGano.Text = "Si";
            this.rbGano.UseVisualStyleBackColor = true;
            // 
            // rbPerdio
            // 
            this.rbPerdio.AutoSize = true;
            this.rbPerdio.Location = new System.Drawing.Point(136, 150);
            this.rbPerdio.Name = "rbPerdio";
            this.rbPerdio.Size = new System.Drawing.Size(39, 17);
            this.rbPerdio.TabIndex = 7;
            this.rbPerdio.TabStop = true;
            this.rbPerdio.Text = "No";
            this.rbPerdio.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "¿Ganaste?";
            // 
            // Juegos
            // 
            this.Juegos.HeaderText = "Juegos";
            this.Juegos.Name = "Juegos";
            // 
            // Puntaje
            // 
            this.Puntaje.HeaderText = "Puntajes";
            this.Puntaje.Name = "Puntaje";
            // 
            // Resultado
            // 
            this.Resultado.HeaderText = "Resultados";
            this.Resultado.Name = "Resultado";
            // 
            // Enunciado2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rbPerdio);
            this.Controls.Add(this.rbGano);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblPuntos);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.dgvLista);
            this.Name = "Enunciado2Form";
            this.Text = "Enunciado 2";
            ((System.ComponentModel.ISupportInitialize)(this.dgvLista)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLista;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblPuntos;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RadioButton rbGano;
        private System.Windows.Forms.RadioButton rbPerdio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Juegos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Puntaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resultado;
    }
}