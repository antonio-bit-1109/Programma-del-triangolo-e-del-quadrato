namespace programmaTipoTriangolo
{
    internal class Triangolo
    {
        // proprietà
        public int Lato1 { get; set; }
        public int Lato2 { get; set; }
        public int Lato3 { get; set; }

        // costruttore
        public Triangolo(int lato1, int lato2, int lato3)
        {
            this.Lato1 = lato1;
            this.Lato2 = lato2;
            this.Lato3 = lato3;
        }


        //metodo
        public string CheckTipoTriangolo()
        {
            if (this.Lato1 == this.Lato2 && this.Lato1 == this.Lato3)
            {
                return "Triangolo Equilatero";

            }
            else if (Lato1 == Lato2 || Lato1 == Lato3 || Lato2 == Lato3)
            {

                return "Triangolo Isoscele";

            }
            else { return "Triangolo Scaleno"; }
        }

        public string latoPIulungo()
        {
            if (this.Lato1 > this.Lato2 && this.Lato1 > this.Lato3)
            {
                return $"il lato più lungo è: {this.Lato1}";

            }
            else if (this.Lato2 > this.Lato1 && this.Lato2 > this.Lato3)
            {
                return $"il lato più lungo è: {this.Lato2}";
            }
            else
            {
                return $" il lato maggiore è {this.Lato3}";
            }
        }





    }
}
