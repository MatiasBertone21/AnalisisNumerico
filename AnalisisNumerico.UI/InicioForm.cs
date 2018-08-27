using AnalisisNumerico.Entidades;
using System;
using System.Windows.Forms;

namespace AnalisisNumerico.UI
{
    public partial class InicioForm : Form
    {
        private void Errorlabel_Click(object sender, EventArgs e)
        {
            Errorlabel.Visible = false;
        }
        private readonly IMetodosRaices metodosRaices;

        public InicioForm(IMetodosRaices metodosRaices)
        {
            this.metodosRaices = metodosRaices;

            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            Errorlabel.Visible = false;
            var funcion = FuncionTextBox.Text;
            var Xi = double.Parse(XiTextBox.Text);
            var Xd = double.Parse(XdTextBox.Text);
            var tole = double.Parse(ToleranciatextBox.Text);
            var Ite = int.Parse(IteracionestextBox.Text);

            var resultado = metodosRaices.MetodoBiseccion(new ParametrosBiseccion
            {
                Funcion = funcion,
                Xi = Xi,
                Xd = Xd,
                Tolerancia = tole,
                Iteraciones = Ite
            });
            if (resultado.Raiz == 00)
            {
                Errorlabel.Visible = true;
                RaiztextBox.Text = "X";
                ItetextBox.Text = "X";
                ErrortextBox.Text = "X";
            }
            else
            {
                RaiztextBox.Text = resultado.Raiz.ToString();
                ItetextBox.Text = resultado.Iteraciones.ToString();
                ErrortextBox.Text = resultado.Error.ToString();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ValorInicialTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void InicioForm_Load(object sender, EventArgs e)
        {

        }
    }
}