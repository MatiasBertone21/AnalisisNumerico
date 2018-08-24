using AnalisisNumerico.Entidades;
using AnalisisNumerico.Logica;
using SimpleInjector;
using System;
using System.Windows.Forms;

namespace AnalisisNumerico.UI
{
    static class Program
    {
        private static Container container;

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Bootstrap();
            Application.Run(container.GetInstance<MenuForm>());
        }

        private static void Bootstrap()
        {
            container = new Container();
            container.Register<IMetodosRaices, MetodosRaices>();
            container.Register<MenuForm>();
        }
    }
}