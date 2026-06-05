namespace espacioOperacion;
public enum TipoOperacion
{
    Suma,
    Resta,
    Multiplicacion,
    Division,
    Limpiar
}

public class Operacion
{
    private double resultadoAnterior;
    private double nuevoValor;
    private TipoOperacion operacion;
    public double resultado()
    {   
        switch (operacion)
        {
            case TipoOperacion.Suma:
                return resultadoAnterior+nuevoValor;
            case TipoOperacion.Resta:
                return resultadoAnterior-nuevoValor;
            case TipoOperacion.Multiplicacion:
                return resultadoAnterior*nuevoValor;
            case TipoOperacion.Division:
                return resultadoAnterior/nuevoValor;
            default:
                return resultadoAnterior;
        }
    }

    public Operacion(double resultadoAnterior, double nuevoValor, TipoOperacion operacion)
    {
        this.resultadoAnterior = resultadoAnterior;
        this.nuevoValor = nuevoValor;
        this.operacion = operacion;
    }

    public double NuevoValor { get => nuevoValor;}
    
    
}