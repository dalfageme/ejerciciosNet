namespace formas
{
    public abstract class Forma
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

        // Sobrescribir método de la clase object con override
        public override string ToString(){
            return string.Format("Soy una forma de perimetro: {0} y area: {1}", this.perimetro, this.area);
        }

        public abstract void Dibujar();
    }
}