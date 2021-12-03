using System;

namespace LarguraAlturaTreiangulo
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }

        public double Diagonal()
        {
            double diagonal = (Largura * Largura) + (Altura * Altura);
            return Math.Sqrt(diagonal);
        }

        public override string ToString()
        {
            return "Area = " + Area()
                             + "\nPerimetro = "
                             + Perimetro()
                             + "\nDiagonal = "
                             + Diagonal();
        }
    }
}
