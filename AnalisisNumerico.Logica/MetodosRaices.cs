
using AnalisisNumerico.Entidades;
using org.mariuszgromada.math.mxparser;
using System;
namespace AnalisisNumerico.Logica
{
    public class MetodosRaices : IMetodosRaices
    {
        public double CalcularXi(ParametrosBiseccion parametros)
        {
            var funcion = new Function(parametros.Funcion);
            var argumento1 = new Argument("x", parametros.Xi);

            var nombre = parametros.Funcion.Split('=')[0].Trim();

            var expresion = new Expression(nombre, funcion, argumento1);
            var resultado = expresion.calculate();

            return resultado;
        }

        public double CalcularXd (ParametrosBiseccion parametros)
        {
            var funcion = new Function(parametros.Funcion);
            var argumento1 = new Argument("x", parametros.Xd);

            var nombre = parametros.Funcion.Split('=')[0].Trim();

            var expresion = new Expression(nombre, funcion, argumento1);
            var resultado = expresion.calculate();

            return resultado;
        }

        public Resultado MetodoBiseccion( ParametrosBiseccion parametros)
        {
            double Fxi = CalcularXi(parametros);
            double Fxd = CalcularXd(parametros);
            var Resultado = new Resultado();
            double R = Fxi * Fxd;
            
            if (R > 0)
            {
                Resultado.Raiz = 0000000;
                return Resultado;
            }
            else if (R < 0)
            {
                Resultado.Iteraciones = 0;
                double xant = 0;
                var xr = (parametros.Xi+ parametros.Xd) / 2;
                var Fxr = CalcularXi(new ParametrosBiseccion
                { 
                    Funcion = parametros.Funcion,
                    Xi = xr,
                });
                Resultado.Iteraciones = Resultado.Iteraciones + 1;
                Resultado.Error = (xr - xant) / xr;

                while (Math.Abs(Fxr) > parametros.Tolerancia && Resultado.Error > parametros.Tolerancia && Resultado.Iteraciones < parametros.Iteraciones)
                {
                    Resultado.Iteraciones = Resultado.Iteraciones + 1;
                    if (Fxi * Fxr > 0)
                        parametros.Xi = xr;
                    else
                        parametros.Xd = xr;
                    xant = xr;
                    xr = (parametros.Xi + parametros.Xd) / 2;
                    Resultado.Error = (xr - xant) / xr;
                    Fxr = CalcularXi(new ParametrosBiseccion { Funcion = parametros.Funcion, Xi = xr, });
                }
                Resultado.Raiz = xr;
                return Resultado;
            }
            else
            {
                Resultado.Iteraciones =+ 1;
                if (Fxi == 0)
                {
                    Resultado.Raiz = parametros.Xi;
                    return Resultado;
                }
                else
                {
                    Resultado.Raiz = parametros.Xd;
                    return Resultado;
                }
            }
        }
    }
}