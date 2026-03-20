namespace TP0._5;

class Program
{
static void Main(string[] args)
{
    Curso info = new Curso("Info");
    bool salir = false;
    Console.WriteLine("Bienvenido al menu de tu curso de ort\n");
        while (salir == false)
        {
        Console.WriteLine("Por favor elije una de las siguientes opciones:\n\n" +
                          "1 - agregar nuevo alumno. \n" +
                          "2 - buscar alumno por DNI. \n"+
                          "3 - agregar faltas. \n" +
                          "4 - mostrar alumnos. \n" +
                          "5 - mostrar alumnos con 15+ faltas. \n" +
                          "6 - Salir");

        string opcion = Console.ReadLine();

        if (opcion == "1") 
        {
            Console.WriteLine("Como se llama el nuevo alumno?");
            string nombre = Console.ReadLine();
            int dni = info.insertarInt("Cual es su dni? (debe ser un numero. Sin letras)");
            
            Console.WriteLine(info.nuevoEstudiante(nombre, dni));
        }

        else if (opcion == "2") 
        {
            int dni = info.insertarInt("Cual es el dni del estudiante? (debe ser un numero. Sin letras)");

            Console.WriteLine(info.buscarAlumno(dni));
        }

        else if (opcion == "3") 
        {
            int dni = info.insertarInt("Insertar el dni del estudiante que recibira faltas. (debe ser un numero. Sin letras)");
            Console.WriteLine("vas a agregar una falta entera o media falta? (insertar ENTERA o MEDIA)");
            string cantidad = Console.ReadLine();

            Console.WriteLine(info.agregarFalta(cantidad, dni));
        }

        else if (opcion == "4")
        {
            bool todos = true;
            Console.WriteLine(info.mostrarAlumnos(todos));
        }

        else if (opcion == "5")
        {
            bool todos = false;
            Console.WriteLine(info.mostrarAlumnos(todos));
        }

        else if (opcion == "6") 
        {
            salir = true;
        }

        else 
        {
            Console.WriteLine("ingresa una opcion valida.");
        }

        }

        Console.WriteLine("Chau!");

}

}
