using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica;
using System;
using System.Windows.Forms;

namespace AnalisisNumerico.UI.Forms_Sistemas_Ecuaciones
{
    public partial class GaussJordanForm : Form
    {
        private readonly IMetodosEcuaciones metodosEcuaciones;

        public GaussJordanForm(IMetodosEcuaciones Ecuaciones)
        {
            this.metodosEcuaciones = Ecuaciones;

            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            string[] variables = new string[6] { "x", "y", "z", "t", "w", "u" };

            IngresoDatosMatriz.RowCount = int.Parse(IncognitasTextBox.Text);
            IngresoDatosMatriz.ColumnCount = int.Parse(IncognitasTextBox.Text) + 1;
            IngresoDatosMatriz.RowHeadersVisible = false;

            for (int i = 0; i < int.Parse(IncognitasTextBox.Text); i++)
            {
                IngresoDatosMatriz.Columns[i].HeaderText = variables[i];
            }           
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            string[] variables = new string[6] { "x", "y", "z", "t", "w", "u" };
            double[,] matriz = new double[int.Parse(IncognitasTextBox.Text), int.Parse(IncognitasTextBox.Text) + 1];

            for (int i = 0; i <= int.Parse(IncognitasTextBox.Text) - 1; i++)
            {
                for (int j = 0; j <= int.Parse(IncognitasTextBox.Text); j++)
                {
                    double valor = double.Parse(IngresoDatosMatriz.Rows[i].Cells[j].Value.ToString());

                    matriz[i, j] = valor;
                }
            }

            matriz = metodosEcuaciones.MetodoGaussJordan(matriz, int.Parse(IncognitasTextBox.Text));

            ResultadoMatriz.RowCount = int.Parse(IncognitasTextBox.Text);
            ResultadoMatriz.ColumnCount = int.Parse(IncognitasTextBox.Text) + 1;
            ResultadoMatriz.RowHeadersVisible = false;

            for (int i = 0; i < int.Parse(IncognitasTextBox.Text); i++)
            {
                ResultadoMatriz.Columns[i].HeaderText = variables[i];
            }

            for (int i = 0; i < int.Parse(IncognitasTextBox.Text); i++)
            {
                for (int j = 0; j < int.Parse(IncognitasTextBox.Text) + 1; j++)
                {
                    ResultadoMatriz.Rows[i].Cells[j].Value = matriz[i, j];
                }
            }
        }
    }
}
