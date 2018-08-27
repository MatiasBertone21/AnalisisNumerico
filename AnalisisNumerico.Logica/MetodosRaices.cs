
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
                    Fxi = CalcularXi(parametros);
                    Fxd = CalcularXd(parametros);
                    var xr = (parametros.Xi + parametros.Xd) / 2;
                    var Fxr = CalcularXi(new ParametrosBiseccion
                    {
                        Funcion = parametros.Funcion,
                        Xi = xr,
                    });
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
        public Resultado MetodoReglaFalsa(ParametrosBiseccion parametros)
        {
            double Fxi = CalcularXi(parametros);
            double Fxd = CalcularXd(parametros);
            var Resultado = new Resultado();
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
                else if (R < 0) // El algoritmo de la regla falsa es igual al MetodoBiseccion solo cambia la formula de calcular xr
                {
                    Fxi = CalcularXi(parametros);
                    Fxd = CalcularXd(parametros);
                    var xr = ((Fxd * parametros.Xi - Fxi * parametros.Xd) / (Fxi-Fxd)); // <----
                    var Fxr = CalcularXi(new ParametrosBiseccion
                    {
                        Funcion = parametros.Funcion,
                        Xi = xr,
                    });
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
        public Resultado MetodoDeduccionFormulaFundamental (ParametrosBiseccion parametros)
        {
            double Fxi = CalcularXi(parametros);
            var Resultado = new Resultado();
            Resultado.Iteraciones = 0;
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
                    Fxi = CalcularXi(parametros);
                    var Fxitole = CalcularXi(new ParametrosBiseccion
                    {
                        Funcion = parametros.Funcion,
                        Xi = parametros.Xi + parametros.Tolerancia,
                    });
                    derFx = (Fxitole - Fxi) / parametros.Tolerancia;

                    double xr = parametros.Xi - (Fxi / derFx);
                    Resultado.Iteraciones++;
                    Resultado.Error = (xr - xant) / xr;
                    var Fxr = CalcularXi(new ParametrosBiseccion
                    {
                        Funcion = parametros.Funcion,
                        Xi = xr,
                    });

                    if ( Fxr < parametros.Tolerancia || Resultado.Iteraciones > parametros.Iteraciones || Resultado.Error < parametros.Tolerancia )
                    {
                        Resultado.Raiz = xr;
                        bandera = true;
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

        public Resultado MetodoSecante (ParametrosBiseccion parametros)
        {
            var Fxi = CalcularXi(parametros);
            var Fxd = CalcularXd(parametros);
            var Resultado = new Resultado();
            double xant = 0;
            double xr = 0;
            
            double CalcularSec (double x0, double x1)
            {
                var Fx0 = CalcularXi(new ParametrosBiseccion
                {
                    Funcion = parametros.Funcion,
                    Xi = x0,
                });
                var Fx1 = CalcularXi(new ParametrosBiseccion
                {
                    Funcion = parametros.Funcion,
                    Xi = x1,
                });
                return ((Fx1 * x0 - Fx0 * x1)/ Fx1 - Fx0);
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
                    Resultado.Error = Math.Abs((xr - xant) / xr);

                    Fxi = CalcularXi(parametros);
                    Fxd = CalcularXd(parametros);

                    if (Math.Abs(Fxd) < parametros.Tolerancia || Resultado.Error < parametros.Tolerancia || Resultado.Iteraciones >= parametros.Iteraciones )
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