namespace formas
{
    // La clase rectángulo hereda de Forma sus propiedades y métodos
    public class Rectangulo: Forma
    {
        // Utilizamos :base para llamar al constructor de la superclase
        public Rectangulo(double b, double h): base(2 * b + 2 * h, b * h){
            System.Console.WriteLine("Rectangulo creado");
        }
    }
}