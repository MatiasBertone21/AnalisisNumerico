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
    public partial class MenuForm : Form, IMetodosRaices
    {
        private readonly IMetodosRaices metodosRaices;
     
        public MenuForm(IMetodosRaices metodosRaices)
        {
            this.metodosRaices = metodosRaices;
            InitializeComponent();
        }

        private void BiseccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (BiseccionForm biseccionForm = new BiseccionForm(metodosRaices)
            {
                Owner = this
            })
            {
                biseccionForm.ShowDialog();
            }
        }

        private void ReglaFalsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ReglaFalsaForm reglaFalsaForm = new ReglaFalsaForm(metodosRaices)
            {
                Owner = this
            })
            {
                reglaFalsaForm.ShowDialog();
            }
        }

        private void NewtonRaphsonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (TangenteForm tangenteForm = new TangenteForm(metodosRaices)
            {
                Owner = this
            })
            {
                tangenteForm.ShowDialog();
            }
        }

        private void secanteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SecanteForm secanteForm = new SecanteForm(metodosRaices)
            {
                Owner = this
            })
            {
                secanteForm.ShowDialog();
            }
        }

        //Implementaciones

        Resultado IMetodosRaices.MetodoBiseccion(Parametros parametros)
        {
            return metodosRaices.MetodoBiseccion(parametros);
        }

        Resultado IMetodosRaices.MetodoReglaFalsa(Parametros parametros)
        {
            return metodosRaices.MetodoReglaFalsa(parametros);
        }

        Resultado IMetodosRaices.MetodoTangente(Parametros parametros)
        {
            return metodosRaices.MetodoTangente(parametros);
        }

        Resultado IMetodosRaices.MetodoSecante(Parametros parametros)
        {
            return metodosRaices.MetodoSecante(parametros);
        }
    }
}
