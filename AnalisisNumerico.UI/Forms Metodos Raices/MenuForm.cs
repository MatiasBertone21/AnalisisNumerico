using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica;
using SimpleInjector;

namespace AnalisisNumerico.UI
{
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void BiseccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormBiseccion = Program.container.GetInstance<BiseccionForm>();
            FormBiseccion.Owner = this;
            FormBiseccion.Show();
        }

        private void ReglaFalsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormReglaFalsa = Program.container.GetInstance<ReglaFalsaForm>();
            FormReglaFalsa.Owner = this;
            FormReglaFalsa.Show();
        }

        private void NewtonRaphsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormTangente = Program.container.GetInstance<TangenteForm>();
            FormTangente.Owner = this;
            FormTangente.Show();
        }

        private void SecanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var FormSecante = Program.container.GetInstance<SecanteForm>();
            FormSecante.Owner = this;
            FormSecante.Show();
        }
    }
}