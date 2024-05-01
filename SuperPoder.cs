
namespace EjercicioClase
{
    internal class SuperPoder : SuperHeroe
    {
        public string Nombre { get; set; }

        public string Descripcion { get; set; }

        public int Nivel { get; set; }

        public void Imprimir()
        {
            Console.WriteLine("Nombre: " + Nombre);
            Console.WriteLine("Identidad secreta: " + IdentidadSecreta);
            Console.WriteLine("Ciudad: " + Ciudad);
            Console.WriteLine("Puede volar: " + PuedeVolar);
            Console.WriteLine("Super poder: " + SuperPoder);
            Console.WriteLine("Descripcion: " + Descripcion);
            Console.WriteLine("Nivel: " + Nivel);
            Console.WriteLine("");
        }
    }
}
