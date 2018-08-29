namespace AnalisisNumerico.Entidades
{
    public interface IMetodosRaices
    {
        Resultado MetodosCerrados(Parametros parametros);

        Resultado MetodoTangente(Parametros parametros);

        Resultado MetodoSecante(Parametros parametros);
    }


}