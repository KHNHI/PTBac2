using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTBac2
{
    internal class EquationSolver
    {
        public static string SolveEquation(double a, double b, double? c = null)
        {
            IEquation equation;
            if (c == null)
                equation = new LinearEquation(a, b);
            else
                equation = new QuadraticEquation(a, b, c.Value);

            return equation.Solve();
        }
    }
}
