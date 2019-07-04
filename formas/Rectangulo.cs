namespace formas
{
    // La clase rectángulo hereda de Forma sus propiedades y métodos
    public class Rectangulo: Forma
    {
        private double b;
        private double h;

        // Utilizamos :base para llamar al constructor de la superclase
        public Rectangulo(double b, double h): base(2 * b + 2 * h, b * h){
            System.Console.WriteLine("Rectangulo creado");
            this.b = b;
            this.h = h;
        }

        // Sobrescribimos el método to string de la clase Forma
        public override string ToString(){

            // Tambien podriamos llamar al método ToString de la superclase base.ToString()
            return  string.Format("Esto es un rectángulo de base: {0} altura: {1} perimetro {2} y area: {3}",
                this.b, this.h, base.getPerimetro(), base.getArea()

            );
        }

        public override void Dibujar(){
            for (int i = 0; i < this.h; i++)
            {
                // multiplico por 2 la base para que se adapte más a la realidad
                System.Console.WriteLine(new string('▓', (int)this.b * 2)); 
            }
        }
    }
}