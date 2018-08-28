namespace AnalisisNumerico.Entidades
{
    public interface IMetodosRaices
    {
        Resultado MetodoBiseccion(ParametrosBiseccion parametros);

        Resultado MetodoReglaFalsa(ParametrosBiseccion parametros);
    }


}