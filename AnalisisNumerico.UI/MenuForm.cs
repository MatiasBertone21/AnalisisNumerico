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

        private void biseccionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (InicioForm biseccionForm = new InicioForm(metodosRaices)
            {
                Owner = this
            })
            {
                biseccionForm.ShowDialog();
            }
        }

        private void reglaFalsaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (ReglaFalsaForm reglaFalsaForm = new ReglaFalsaForm(metodosRaices)
            {
                Owner = this
            })
            {
                reglaFalsaForm.ShowDialog();
            }
        }

        //Implementaciones

        Resultado IMetodosRaices.MetodoBiseccion(ParametrosBiseccion parametros)
        {
            return metodosRaices.MetodoBiseccion(parametros);
        }

        public Resultado MetodoReglaFalsa(ParametrosBiseccion parametros)
        {
            return metodosRaices.MetodoReglaFalsa(parametros);
        }
    }
}
