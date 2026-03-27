namespace TP0._5;

class Curso 
{

 // ATRIBUTOS PRIVADOS
 private string nombre;
 private Dictionary<int, Alumno> dicAlumnos;

public Curso(string nombre)
{
    this.nombre = nombre;
    this.dicAlumnos = new Dictionary <int, Alumno>();
}

public string nuevoEstudiante(string nombre, int dni) 
{
string respuesta = "";
Alumno nuevoAlumno = new Alumno(nombre);
if (dicAlumnos.ContainsKey(dni))
    {
        respuesta = "Ya hay un alumno con ese dni!";
    }
else
    {
        dicAlumnos.Add(dni,nuevoAlumno);
        respuesta = "Alumno agregado!";
    }
return respuesta;
}

public string buscarAlumno(int dni)
{
    string respuesta = "";

    if (dicAlumnos.ContainsKey(dni)) 
    {
        respuesta = "El alumno con este dni es " + dicAlumnos[dni].getNombre() + " y tiene " + dicAlumnos[dni].getFaltas() + " faltas.";
    }

    else if (respuesta == "") 
    {
        respuesta = "No se encontro un alumno con ese dni";
    }
    return respuesta;
}

public string agregarFalta(string cantidad, int dni) 
{
    string respuesta = "";
    cantidad = cantidad.ToLower();

    if (dicAlumnos.ContainsKey(dni)) 
    {

    if (cantidad == "entera") 
    {
        dicAlumnos[dni].sumarFalta(1);
        respuesta = "Se agrego una falta a " + dicAlumnos[dni].getNombre();
    }
    else if (cantidad == "media") 
    {
        dicAlumnos[dni].sumarFalta(0.5);
        respuesta = "Se agrego media falta a " + dicAlumnos[dni].getNombre();
    }
    else if (cantidad == "testing") 
    {
        dicAlumnos[dni].sumarFalta(15);
        respuesta = "Se agrego 15 faltas a " + dicAlumnos[dni].getNombre();
    }
    else 
    {
        respuesta = "Perdon, pero " + cantidad + " no es una opcion valida.";
    }
    
    }
    

    if (respuesta == "") 
    {
        respuesta = "no se encontro un alumno con ese DNI";
    }
    return respuesta;
}

/*

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

*/

public string mostrarAlumnos(bool todos) 
{
    string respuesta = "";
    int i = 0;
    int f = 0;
    foreach (int dni in dicAlumnos.Keys) 
    {
        if (dicAlumnos[dni].getFaltas() >= 15 || todos == true) 
        {
            respuesta = respuesta + dicAlumnos[dni].getNombre() + " " + dni + ", ";
            f++;
        }
        i++;
    }
    if (f == 0 && i != 0) 
    {
        respuesta = "No hay alumnos con mas de 15 faltas";
    }
    else if (i == 0) 
    {
        respuesta = "No hay alumnos";
    }
    return respuesta;
}

public int insertarInt(string s) 
{
    Console.WriteLine(s);
    return int.Parse(Console.ReadLine());
}

}