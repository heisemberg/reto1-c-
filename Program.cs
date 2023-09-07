using System.Reflection.Emit;
using reto1.entities;
internal class Program
{
    private static void Main(string[] args)
    {
    List<Estudiantes> estudiantes = new List<Estudiantes>();
    Menu(estudiantes);
    }

    public static void Menu(List<Estudiantes> estudiantes){
        Console.Clear();
        int opcion = 0;
        Console.WriteLine("Bienvenido al sistema de registro de estudiantes");
        Console.WriteLine("1. Registrar Estudiante: ");
        Console.WriteLine("2. Registrar Notas: ");
        Console.WriteLine("3. Informe de notas: ");
        Console.WriteLine("4. Informe de notas Finales: ");

        Console.WriteLine("Ingrese la opcion que desea realizar: ");
        opcion = int.Parse(Console.ReadLine());

        switch (opcion)
        {
            case 1:
                RegistrarEstudiante(estudiantes);
                break;
            case 2:
                RegistrarNotas();
                break;
            case 3:
                InformeNotas(estudiantes);
                break;
            case 4:
                InformeNotasFinales();
                break;
            default:
                Console.WriteLine("Opcion no valida");
                break;
        }
    }

    public static void RegistrarEstudiante(List<Estudiantes> estudiantes){
    string opc;
    do
    {
        Estudiantes estudiante = new Estudiantes();
        Console.WriteLine("Ingrese el codigo del estudiante: ");
        estudiante.Codigo = Console.ReadLine();
        Console.WriteLine("Ingrese el nombre del estudiante: ");
        estudiante.Nombre = Console.ReadLine();
        Console.WriteLine("Ingrese el correo del estudiante: ");
        estudiante.Correo = Console.ReadLine();
        Console.WriteLine("Ingrese la edad del estudiante: ");
        estudiante.Edad = int.Parse(Console.ReadLine());
        Console.WriteLine("Desea registrar otro estudiante? S/N");
        estudiantes.Add(estudiante);
        opc = Console.ReadLine();
    } while (opc == "s" || opc == "S");
    
    Console.WriteLine("Estudiantes registrados con exito");
    Console.Clear();
    Menu(estudiantes);
    }

    public static void RegistrarNotas(){

    }

    public static void InformeNotas(List<Estudiantes> estudiantes){
        Console.WriteLine("{0,-40} {1,-30} {2,3}", "CODIGO", "NOMBRE", "CORREO");
        foreach(Estudiantes est in estudiantes){
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("{0,-40} {1,-30} {2,3}", est.Codigo, est.Nombre, est.Correo, est.Edad);
        }
    }

    public static void InformeNotasFinales(){

    }
}

    
