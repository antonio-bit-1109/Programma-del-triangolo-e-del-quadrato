namespace programmaTipoTriangolo
{
    internal class Quadrato
    {
        public int lato { get; set; }

        public int area { get; set; }

        public int perimetro { get; set; }

        public Quadrato(int lato)
        {

            this.lato = lato;
            this.area = lato * lato;
            this.perimetro = lato * 4;


        }

        public int CheckMyArea()
        {
            return this.area;
        }

        public int CheckMyPerimeter()
        {
            return this.perimetro;
        }
    }
}
