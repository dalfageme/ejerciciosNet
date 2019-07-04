namespace formas
{
    public class Triangulo: Forma
    {
        private double baseTriangulo, altura, lado1, lado2;

        public Triangulo(double baseTriangulo, double altura, double lado1, double lado2)
            :base(baseTriangulo + lado1 + lado2, baseTriangulo * altura / 2)
        {
            this.baseTriangulo = baseTriangulo;
            this.altura = altura;
            this.lado1 = lado1;
            this.lado2 = lado2;
        }

        public override void Dibujar(){
            System.Console.WriteLine("  *");
            System.Console.WriteLine(" ***");
            System.Console.WriteLine("*****");
        }

    }
}