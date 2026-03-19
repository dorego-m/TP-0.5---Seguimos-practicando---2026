namespace TP0._5;

class Curso 
{

 // ATRIBUTOS PRIVADOS
 private string nombre;
 private List<Alumno> alumnos;

public Curso(string nombre)
{
    this.nombre = nombre;
    this.alumnos = new List<Alumno>();
}

public string nuevoEstudiante(string nombre int dni) 
{
string respuesta = "";
Alumno nuevoAlumno = new Alumno(nombre, dni);
int i = 0;
while (i < this.alumnos.Count && this.alumnos[i].getDNI() != dni)
    {
        i++;
    }
if (i < this.alumnos.Count)
    {
        respuesta = "Ya hay un alumno con ese dni!";
    }
else
    {
        this.alumnos.Add(nuevoAlumno);
        respuesta = "Alumno agregado!";
    }
return respuesta;
}

public string buscarAlumno(int dni)
{
    string respuesta = "";
    foreach (alumno a in alumnos) 
    {
        if (a.getDNI() == dni) 
        {
            respuesta = "El alumno con este dni es " + a.getNombre() + " y tiene " + a.getFaltas() + " faltas.";
        }
    }
    if (respuesta == "") 
    {
        respuesta = "No se econtro un alumno con ese dni"
    }
    return respuesta;
}

public string agregarFalta(string cantidad int dni) 
{
    string respuesta = "";
    cantidad = cantidad.ToLower();
    foreach(alumno a in alumnos) 
    {
        if (dni == a.getDNI()) 
        {
    if (cantidad == "entera") 
    {
        a.sumarFalta(1);
        respuesta = "Se agrego una falta a " + a.getNombre();
    }
    else if (cantidad == "media") 
    {
        a.sumarFalta(0.5);
        respuesta = "Se agrego media falta a " + a.getNombre();
    }
    else if (cantidad == "testing") 
    {
        a.sumarFalta(15);
        respuesta = "Se agrego 15 faltas a " + a.getNombre();
    }
    else 
    {
        respuesta = "Perdon, pero " + cantidad + " no es una opcion valida.";
    }
        }
    }
    if (respuesta == "") 
    {
        respuesta = "no se encontro un alumno con ese DNI";
    }
    return respuesta;
}

public string mostrarAlumnos() 
{
    string respuesta = "";
    foreach (alumno a in alumnos) 
    {
        respuesta = respuesta + a.getNombre() + " " + a.getDNI() + ", "
    }
    return respuesta;
}

public string mostrarAlumnosConFaltas() 
{
    string respuesta = "";
    foreach (alumno a in alumnos) 
    {
        if (a.getFaltas() >= 15) 
        {
            respuesta = respuesta + a.getNombre() + " " + a.getDNI() + ", "
        }
    }
    if (respuesta == "")
    {
        respuesta = "no hay alumnos con tantas faltas"
    }
    return respuesta;
}





}