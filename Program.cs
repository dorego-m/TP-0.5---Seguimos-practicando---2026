namespace TP0._5;

class Program
{
static void Main(string[] args)
{
    Curso info = new curso("Info")
    bool salir = false;
    Console.WriteLine("Bienvenido al menu de tu curso de ort\n")
        while (salir == false)
        {
        Console.WriteLine("Por favor elije una de las siguientes opciones:\n\n" +
                          "1 - agregar nuevo alumno. \n" +
                          "2 - buscar alumno por DNI. \n"+
                          "3 - agregar faltas. \n" +
                          "4 - mostrar alumnos. \n" +
                          "5 - mostrar alumnos con 15+ faltas. ");
        string opcion = Console.ReadLine();

        if (opcion == "1") 
        {
            Console.WriteLine("Como se llama el nuevo alumno?");
            string nombre = Console.ReadLine();
            int dni = insertarInt("Cual es su dni? (debe ser un numero. Sin letras)")
            
            Console.WriteLine(info.nuevoEstudiante(nombre, dni));
        }

        if (opcion == "2") 
        {
            int dni = insertarInt("Cual es el dni del estudiante? (debe ser un numero. Sin letras)")

            Console.WriteLine(info.buscarAlumno(dni));
        }

        if (opcion == "3") 
        {
            int dni = insertarInt("Insertar el dni del estudiante que recibira faltas. (debe ser un numero. Sin letras)")
            Console.WriteLine("vas a agregar una falta entera o media falta? (insertar ENTERA o MEDIA)")
            string cantidad = Console.ReadLine();

            Console.WriteLine(info.agregarFalta(cantidad, dni));
        }

        }
}

public int insertarInt(string s) 
{
    Console.WriteLine(s);
    return int.Parse(Console.ReadLine());
}
}
