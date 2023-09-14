using System.Numerics;

namespace Quadratic_Calculator
{
    public static class Quadratic_Solver
    {
        public static (string result, Complex root_1, Complex root_2, double axis_of_symmetry, double vertex_x, double vertex_y, (double focus_x, double focus_y) focus, double directrix) Solve(double a, double b, double c)
        {
            double discriminant = b * b - 4 * a * c;

            Complex root_1;
            Complex root_2;
            string result;

            if (discriminant == 0)
            {
                double real_part = -b / (2 * a);
                root_1 = new(real_part, 0);
                root_2 = root_1;
                result = $"One real root: {root_1.Real}";
            }
            else if (discriminant > 0)
            {
                double real_part_1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double real_part_2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                root_1 = new(real_part_1, 0);
                root_2 = new(real_part_2, 0);

                result = $"Root 1: {root_1.Real}\nRoot 2: {root_2.Real}";
            }
            else // discriminant < 0
            {
                double real_part = -b / (2 * a);
                double imaginary_part = Math.Sqrt(-discriminant) / (2 * a);

                root_1 = new(real_part, imaginary_part);
                root_2 = new(real_part, -imaginary_part);

                result = $"Complex Root ---\nRoot 1: {root_1}\nRoot 2: {root_2}";
            }

            double axis_of_symmetry = -b / (2 * a);
            double vertex_x = axis_of_symmetry;
            double vertex_y = a * vertex_x * vertex_x + b * vertex_x + c;

            // Calculate the focus and directrix
            double focus_x = vertex_x;
            double focus_y = vertex_y + 1 / (4 * a);
            (double focus_x, double focus_y) focus = (focus_x, focus_y);

            double directrix = vertex_y - 1 / (4 * a);

            result += $"\nAxis of Symmetry: x = {axis_of_symmetry:0.00}";
            result += $"\nVertex: ({vertex_x:0.00}, {vertex_y:0.00})";
            result += $"\nFocus: ({focus_x:0.00}, {focus_y:0.00})";
            result += $"\nDirectrix: y = {directrix:0.00}";

            // Domain
            string domain = "Domain: x ∈ (-∞, ∞)";

            // Range
            string range;
            if (a > 0)
            {
                range = $"Range: y ≥ {vertex_y:0.00}";
            }
            else
            {
                range = $"Range: y ≤ {vertex_y:0.00}";
            }

            result += $"\n{domain}\n{range}";

            // End Behavior
            string end_behavior;
            if (a > 0)
            {
                end_behavior = "As x → ±∞, y → ∞";
            }
            else
            {
                end_behavior = "As x → ±∞, y → -∞";
            }

            result += $"\nEnd Behavior: {end_behavior}";

            return (result, root_1, root_2, axis_of_symmetry, vertex_x, vertex_y, focus, directrix);
        }
    }
}