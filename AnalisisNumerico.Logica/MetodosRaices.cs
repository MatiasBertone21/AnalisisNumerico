
using AnalisisNumerico.Entidades;
using org.mariuszgromada.math.mxparser;
using System;
namespace AnalisisNumerico.Logica
{
    public class MetodosRaices : IMetodosRaices
    {

        public double Calculo(string Funcion, Double valor)
        {
            return new Function(Funcion).calculate(valor);
        }

        public Resultado MetodosCerrados(Parametros parametros)
        {
            double xr = 0;

            var Resultado = new Resultado();

            var nombre = parametros.Funcion.Split('=')[0].Trim();
            var funcion = new Function(parametros.Funcion);
            var argumento1 = new Argument("x", parametros.Xi);
            var argumento2 = new Argument("x", parametros.Xd);
            var expresion1 = new Expression(nombre, funcion, argumento1);
            var expresion2 = new Expression(nombre, funcion, argumento2);

            double Fxi = expresion1.calculate();
            double Fxd = expresion2.calculate();

            double R = Fxi * Fxd;
            Resultado.Iteraciones = 0;
            double xant = 0;
            bool bandera = false;
            while (bandera == false)
            {
                if (R > 0)
                {
                    Resultado.Raiz = 00;
                    bandera = true;
                }
                else if (R < 0)
                {
                    Fxi = expresion1.calculate();
                    Fxd = expresion2.calculate();

                    if (parametros.Tipo)
                    {
                        xr = (parametros.Xi + parametros.Xd) / 2;
                    }
                    else
                    {
                        xr = (Fxd * parametros.Xi - Fxi * parametros.Xd) / (Fxd - Fxi);
                    }

                    var Fxr = Calculo(parametros.Funcion, xr);
                    Resultado.Iteraciones++;
                    Resultado.Error = Math.Abs((xr - xant) / xr);

                    if (Math.Abs(Fxr) < parametros.Tolerancia || Resultado.Error < parametros.Tolerancia || Resultado.Iteraciones >= parametros.Iteraciones)
                    {
                        Resultado.Raiz = xr;
                        bandera = true;
                    }
                    else if (Fxi * Fxr > 0)
                    {
                        parametros.Xi = xr;
                        xant = xr;
                    }
                    else
                    {
                        parametros.Xd = xr;
                        xant = xr;
                    }
                }
                else
                {
                    if (Fxi == 0)
                    {
                        Resultado.Raiz = parametros.Xi;
                        bandera = true;
                    }
                    else
                    {
                        Resultado.Raiz = parametros.Xd;
                        bandera = true;
                    }
                }
            }
            return Resultado;

        }

        public Resultado MetodoTangente(Parametros parametros)
        {
            var Resultado = new Resultado
            {
                Iteraciones = 0
            };

            var nombre = parametros.Funcion.Split('=')[0].Trim();
            var funcion = new Function(parametros.Funcion);
            var argumento1 = new Argument("x", parametros.Xi);
            var expresion1 = new Expression(nombre, funcion, argumento1);

            double Fxi = expresion1.calculate();

            double xant = 0;
            double derFx = 0;
            bool bandera = false;

            while (bandera == false)
            {
                if (Math.Abs(Fxi) == 0)
                {
                    Resultado.Raiz = parametros.Xi;
                    bandera = true;
                }
                else
                {
                    Fxi = expresion1.calculate();

                    var xi = parametros.Xi + parametros.Tolerancia;
                    var Fxitole = Calculo(parametros.Funcion, xi);

                    derFx = (Fxitole - Fxi) / parametros.Tolerancia;

                    if (derFx == 0)
                    {
                        bandera = true;
                        Resultado.Mensaje = "Pendiente cero. Se realiza una división por cero";
                    }

                    double xr = parametros.Xi - (Fxi / derFx);

                    Resultado.Iteraciones++;

                    Resultado.Error = (xr - xant) / xr;

                    var Fxr = Calculo(parametros.Funcion, xr);

                    if (Fxr < parametros.Tolerancia || Resultado.Iteraciones > parametros.Iteraciones || Resultado.Error < parametros.Tolerancia)
                    {
                        Resultado.Raiz = xr;
                        bandera = true;
                        if (Resultado.Iteraciones > parametros.Iteraciones)
                        {
                            Resultado.Mensaje = "Se supero la cantidad máxima de iteraciones. Encontro un punto de inflexion o cicla entre dos valores.";
                        }
                    }
                    else
                    {
                        xant = parametros.Xi;
                        parametros.Xi = xr;
                    }
                }
            }
            return Resultado;
        }

        public Resultado MetodoSecante(Parametros parametros)
        {
            var nombre = parametros.Funcion.Split('=')[0].Trim();
            var funcion = new Function(parametros.Funcion);

            var argumento1 = new Argument("x", parametros.Xi);
            var argumento2 = new Argument("x", parametros.Xd);

            var expresion1 = new Expression(nombre, funcion, argumento1);
            var expresion2 = new Expression(nombre, funcion, argumento2);

            double Fxi = expresion1.calculate();
            double Fxd = expresion2.calculate();

            var Resultado = new Resultado();
            double xant = 0;
            double xr = 0;

            double CalcularSec(double x0, double x1)
            {
                var Fx0 = Calculo(parametros.Funcion, x0);
                var Fx1 = Calculo(parametros.Funcion, x1);

                return ((Fx1 * x0 - Fx0 * x1) / Fx1 - Fx0);
            }

            bool bandera = false;
            while (bandera == false)
            {
                if (Fxi * Fxd == 0)
                {
                    if (Fxi == 0)
                    {
                        Resultado.Raiz = parametros.Xi;
                        bandera = true;
                    }
                    else
                    {
                        Resultado.Raiz = parametros.Xd;
                        bandera = true;
                    }
                }
                else
                {
                    Resultado.Iteraciones++;
                    xr = CalcularSec(parametros.Xi, parametros.Xd);

                    var calculo = Calculo(parametros.Funcion, xr);
                    string calculo2 = calculo.ToString();
                    if (calculo2 == "NaN")
                    {
                        Resultado.Mensaje = "f(x) es de la familia del logaritmo. La función evaluada en x2 no existe";
                        bandera = true;
                    }

                    Resultado.Error = Math.Abs((xr - xant) / xr);

                    Fxi = expresion1.calculate();
                    Fxd = expresion2.calculate();

                    if (Math.Abs(Fxd) < parametros.Tolerancia || Resultado.Error < parametros.Tolerancia || Resultado.Iteraciones >= parametros.Iteraciones)
                    {
                        Resultado.Raiz = xr;
                        bandera = true;
                    }
                    else
                    {
                        parametros.Xi = parametros.Xd;
                        parametros.Xd = xr;
                        xant = parametros.Xd;
                    }
                }
            }
            return Resultado;
        }
    }
}