using System;

namespace AnalisisNumerico.Entidades
{
    public interface IMetodosEcuaciones
    {
        double[,] MetodoGaussJordan(double[,] matriz, int cantidad);
        Tuple<double[,], int> MetodoGaussSeidel(double[,] matriz, int cantidad);
    }
}
