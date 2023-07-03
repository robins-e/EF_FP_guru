using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EF_FP_guru
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

    
   
        private void btnAbrirEnunciado2_Click(object sender, EventArgs e)
        {
            Enunciado2Form enunciado2Form = new Enunciado2Form();
            enunciado2Form.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAbrirEnunciado1_Click(object sender, EventArgs e)
        {
            Enunciado1Form enunciado1Form = new Enunciado1Form();
            enunciado1Form.Show();
        }
    }
}
