using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTBac2
{
    public interface IEquation
    {
        string Solve();
    }
    public class LinearEquation : IEquation
    {
        private double a, b;

        public LinearEquation(double a, double b)
        {
            this.a = a;
            this.b = b;
        }

        public string Solve()
        {
            if (a == 0)
                return b == 0 ? "Vô số nghiệm" : "Vô nghiệm";
            double x = -b / a;
            return $"Phương trình có 1 nghiệm x = {x}";
        }
    }
    public class QuadraticEquation : IEquation
    {
        private double a, b, c;

        public QuadraticEquation(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public string Solve()
        {
            if (a == 0)
                return new LinearEquation(b, c).Solve();

            double delta = b * b - 4 * a * c;
            if (delta < 0)
                return "Phương trình vô nghiệm";
            if (delta == 0)
            {
                double x = -b / (2 * a);
                return $"Phương trình có nghiệm kép x = {x}";
            }
            double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
            return $"Phương trình có 2 nghiệm:\nx1 = {x1}, x2 = {x2}";
        }
    }

}
