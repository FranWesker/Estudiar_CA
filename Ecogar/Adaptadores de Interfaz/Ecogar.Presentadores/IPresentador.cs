namespace Ecogar.Presentadores;

public interface IPresentador<out TDato>
{
    TDato Contenido{ get;}
}
