namespace TP0._5;

class Alumno 
{

 // ATRIBUTOS PRIVADOS
 private string nombre;
 private int dni;
 private double cantidadFaltas;

// --- CONSTRUCTOR ---
public Alumno(string nombre, int dni)
{
    this.nombre = nombre;
    this.dni = dni;
    this.cantidadFaltas = 0.0;
}

public int getDNI() 
{
    return this.dni;
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