namespace TP0._5;

class Alumno 
{

 // ATRIBUTOS PRIVADOS
 private string nombre;
 private double cantidadFaltas;

// --- CONSTRUCTOR ---
public Alumno(string nombre)
{
    this.nombre = nombre;
    this.cantidadFaltas = 0.0;
}

public string getNombre() 
{
    return this.nombre;
}

public double getFaltas() 
{
    return this.cantidadFaltas;
}

public void sumarFalta(double nuevasfaltas) 
{
    this.cantidadFaltas = this.cantidadFaltas + nuevasfaltas;
}






}