namespace EspacioCalculadora;
using espacioOperacion;
class Calculadora
{
    private double dato;

    private List<Operacion> operaciones;
    public double Resultado { get => dato;}
    public List<Operacion> Operaciones { get => operaciones;}

    public Calculadora(double dato)
    {
        this.dato = dato;
        operaciones = new List<Operacion>();
    }
    public void Sumar(double termino)
    {
        Operacion operacionSuma = new Operacion(dato,termino,TipoOperacion.Suma);
        operaciones.Add(operacionSuma);
        dato = operacionSuma.resultado();
    }
    public void Restar(double termino)
    {
        Operacion operacionResta = new Operacion(dato,termino,TipoOperacion.Resta);
        Operaciones.Add(operacionResta);
        dato = operacionResta.resultado();
    }
    public void Multiplicar(double termino)
    {
        Operacion operacionProducto = new Operacion(dato,termino,TipoOperacion.Multiplicacion);
        operaciones.Add(operacionProducto);
        dato = operacionProducto.resultado();
    }
    public void Dividir(double termino)
    {
        Operacion operacionDivicion = new Operacion(dato,termino,TipoOperacion.Division);
        operaciones.Add(operacionDivicion);
        dato = operacionDivicion.resultado();
    }
    public void Limpiar()
    {
        foreach (Operacion op in operaciones.ToList()) //opera sobre una lista de las operaciones
        {
            operaciones.Remove(op);
        }
        dato = 0;
    }
}