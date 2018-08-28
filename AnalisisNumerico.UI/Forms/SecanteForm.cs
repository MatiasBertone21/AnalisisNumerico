using AnalisisNumerico.Entidades;
using System;
using System.Windows.Forms;

namespace AnalisisNumerico.UI
{
    public partial class SecanteForm : Form
    {
        private readonly IMetodosRaices metodosRaices;

        public SecanteForm(IMetodosRaices metodosRaices)
        {
            this.metodosRaices = metodosRaices;

            InitializeComponent();
        }
    }
}
