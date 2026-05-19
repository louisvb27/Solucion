namespace Proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona persona = new Persona();
            persona.Nombre = "Juan";

            Persona persona2 = new Persona();
            persona2.Nombre = "Pedro";


            Console.WriteLine(persona.Nombre);
            Console.WriteLine(persona2.Nombre);
        }
    }
}
