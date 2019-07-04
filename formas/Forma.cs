namespace formas
{
    public class Forma
    {
        private double perimetro;
        private double area;
        public Forma()
        {

        }

        public Forma(double perimetro, double area)
        {
            this.setPerimetro(perimetro);
            this.setArea(area);
            System.Console.WriteLine("Forma creada");
        }

        public double getPerimetro()
        {
            return this.perimetro;
        }

        public void setPerimetro(double perimetro)
        {
            this.perimetro = perimetro;
        }

        public double getArea()
        {
            return this.area;
        }

        public void setArea(double area)
        {
            this.area = area;
        }
    }
}