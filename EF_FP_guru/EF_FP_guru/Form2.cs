using System;
using System.Collections;
using System.Windows.Forms;

namespace EF_FP_guru
{
    public partial class Enunciado1Form : Form
    {
        private string[] array;

        public Enunciado1Form()
        {
            InitializeComponent();
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtArray.Text))
                {
                    MessageBox.Show("Debe ingresar un array!", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                array = txtArray.Text.Split(',');

                MostrarArrayDesordenado();
                OrdenarArrayRecursivamente(array, 0, array.Length - 1);
                MostrarArrayOrdenado();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido un error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MostrarArrayDesordenado()
        {
            txtArrayDesordenado.Text = string.Join(", ", array);
        }

        private void MostrarArrayOrdenado()
        {
            string[] arrayOrdenado = (string[])array.Clone();
            OrdenarArrayRecursivamente(arrayOrdenado, 0, arrayOrdenado.Length - 1);
            txtArrayOrdenado.Text = string.Join(", ", arrayOrdenado);
        }

        private void OrdenarArrayRecursivamente(string[] arr, int inicio, int fin)
        {
            if (inicio < fin)
            {
                int indiceParticion = ParticionarArray(arr, inicio, fin);
                OrdenarArrayRecursivamente(arr, inicio, indiceParticion - 1);
                OrdenarArrayRecursivamente(arr, indiceParticion + 1, fin);
            }
        }

        private int ParticionarArray(string[] arr, int inicio, int fin)
        {
            string pivote = arr[fin];
            int indiceMenor = inicio - 1;

            for (int i = inicio; i < fin; i++)
            {
                if (string.Compare(arr[i], pivote) <= 0)
                {
                    indiceMenor++;
                    Swap(arr, indiceMenor, i);
                }
            }

            Swap(arr, indiceMenor + 1, fin);
            return indiceMenor + 1;
        }

        private void Swap(string[] arr, int i, int j)
        {
            string temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtArray.Clear();
            txtArrayDesordenado.Clear();
            txtArrayOrdenado.Clear();
            txtArray.Focus();
        }
    }
}
