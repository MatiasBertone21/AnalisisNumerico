using AnalisisNumerico.Entidades;
using org.mariuszgromada.math.mxparser;
using System;

namespace AnalisisNumerico.Logica
{
    public class MetodosEcuaciones : IMetodosEcuaciones
    {
        public double[,] MetodoGaussJordan(double[,] matriz, int cantidad)
        {
            double[] vector = new double[cantidad + 1];
            for (int i = 0; i < cantidad; i++)
            {
                for (int j = 0; j < cantidad; j++)
                {
                    if (i < j)
                    {
                        break;
                    }

                    if (i == j)
                    {
                        if (matriz[i, j] == 0)
                        {
                            break;
                        }

                        if (matriz[i, j] != 1)
                        {
                            double valor = matriz[i, j];
                            for (int c = 0; c < cantidad + 1; c++)
                            {
                                matriz[i, c] = matriz[i, c] / valor; //Primer ecuacion normalizada
                            }
                        }
                    }
                    if (i > j)
                    {
                        if (matriz[i,j] != 0)
                        {
                            double valor = -matriz[i, j];
                            for (int w = 0; w < cantidad + 1; w++)
                            {
                                if (matriz[(cantidad - 1) - w, j] == 1)
                                {
                                    for (int c = 0; c < cantidad + 1; c++)
                                    {
                                        vector[c] = matriz[(cantidad - 1) - w, c];
                                        vector[c] = vector[c] * valor;
                                    }
                                    break;
                                }
                            }
                            for (int c = 0; c < cantidad + 1; c++)
                            {
                                matriz[i, c] = matriz[i, c] + vector[c];
                            }
                        }                       
                    }
                }
            }

            for (int i = 0; i < cantidad; i++)
            {
                for (int j = 0; j < cantidad; j++)
                {
                    if (i < j)
                    {
                        double valor = -matriz[i, j];
                        for (int w = 0; w <= cantidad; w++)
                        {
                            if (matriz[(cantidad - 1) - w, j] == 1)
                            {
                                for (int c = 0; c < cantidad + 1; c++)
                                {
                                    vector[c] = matriz[(cantidad - 1) - w, c];
                                    vector[c] = vector[c] * valor;
                                }
                                break;
                            }
                        }
                        for (int c = 0; c < cantidad + 1; c++)
                        {
                            matriz[i, c] = matriz[i, c] + vector[c];
                        }
                    }
                }
            }

            return matriz;
        }

        public Tuple<double[,], int> MetodoGaussSeidel(double[,] matriz, int cantidad)
        {
            bool ban = true;
            int Ite = 0;
            double Error = 0.1;

            double[,] matriznegada = new double[cantidad, cantidad + 1];
            double[,] coeficientes = new double[cantidad, cantidad];
            double[,] ResultadoAnterior = new double[cantidad, 1];
            double[,] Resultado = new double[cantidad, 1];

            for (int i = 0; i < cantidad; i++)
            {
                for (int j = 0; j < cantidad; j++)
                {
                    matriznegada[i, j] = -matriz[i, j];
                }
            }

            while (Ite < 500 && ban)
            {
                for (int i = 0; i < cantidad; i++)
                {
                    ResultadoAnterior[i, 0] = Resultado[i, 0];
                }
                for (int i = 0; i < cantidad; i++)
                {
                    for (int j = 0; j < cantidad; j++)
                    {
                        if (i != j)
                        {
                            for (int f = 0; f < cantidad; f++)
                            {
                                for (int c = 0; c < cantidad; c++)
                                {
                                    coeficientes[f, c] = Resultado[c, 0];
                                }
                            }
                            Resultado[i, 0] = (matriz[i, cantidad] + (matriznegada[i, j] * coeficientes[i, j])) / matriz[i, i];
                        }
                    }
                }
                Ite++;
                int cont = 0;
                for (int i = 0; i < cantidad; i++)
                {
                    if (Math.Abs((Resultado[i, 0]) - ResultadoAnterior[i, 0]) < Error)
                    {
                        cont++;
                    }
                    if (cont == cantidad)
                    {
                        ban = false;
                    }
                }
            }
            return Tuple.Create(Resultado, Ite);
        }
    }
}
