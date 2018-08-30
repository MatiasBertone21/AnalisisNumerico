using AnalisisNumerico.Entidades;
using System;
using System.Windows.Forms;

namespace AnalisisNumerico.UI
{
    public partial class TangenteForm : Form
    {
        private readonly IMetodosRaices metodosRaices;

        public TangenteForm(IMetodosRaices metodosRaices)
        {
            this.metodosRaices = metodosRaices;

            InitializeComponent();
        }

        private void Errorlabel_Click(object sender, EventArgs e)
        {
            Errorlabel.Visible = false;
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            Errorlabel.Visible = false;
            var funcion = FuncionTextBox.Text;
            var tole = double.Parse(ToleranciatextBox.Text);
            var Ite = int.Parse(IteracionestextBox.Text);
            var xo = double.Parse(PuntoInicioTextBox.Text);

            var resultado = metodosRaices.MetodoTangente(new Parametros
            {
                Funcion = funcion,
                Tolerancia = tole,
                Iteraciones = Ite,
                Xi = xo
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
                Errorlabel.Visible = true;
                Errorlabel.Text = resultado.Mensaje;
                RaiztextBox.Text = resultado.Raiz.ToString();
                ItetextBox.Text = resultado.Iteraciones.ToString();
                ErrortextBox.Text = resultado.Error.ToString();
            }
        }
    }
}
