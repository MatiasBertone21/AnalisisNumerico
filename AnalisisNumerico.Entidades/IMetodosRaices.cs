namespace AnalisisNumerico.Entidades
{
    public interface IMetodosRaices
    {
        ResultadoRaices MetodosCerrados(ParametrosRaices parametros);

        ResultadoRaices MetodoTangente(ParametrosRaices parametros);

        ResultadoRaices MetodoSecante(ParametrosRaices parametros);
    }
}