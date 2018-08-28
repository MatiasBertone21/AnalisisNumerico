namespace AnalisisNumerico.Entidades
{
    public interface IMetodosRaices
    {
        Resultado MetodoBiseccion(Parametros parametros);

        Resultado MetodoReglaFalsa(Parametros parametros);

        Resultado MetodoTangente(Parametros parametros);

        Resultado MetodoSecante(Parametros parametros);
    }


}