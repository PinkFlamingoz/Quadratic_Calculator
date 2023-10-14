using System.Numerics;

namespace Quadratic_Calculator
{
    // Define a static class called Quadratic_Solver, which contains a method to solve a quadratic equation.
    public static class Quadratic_Solver
    {
        // The Solve method is used to solve the quadratic equation and derive its properties.
        // Parameters:
        // - a, b, c: The coefficients of the quadratic equation.
        // Returns:
        // - An organized tuple containing the equation's results and related properties.
        public static (string result, Complex root_1, Complex root_2, double axis_of_symmetry, double vertex_x, double vertex_y, (double focus_x, double focus_y) focus, double directrix) Solve(double a, double b, double c)
        {
            // Calculate the discriminant using the quadratic formula.
            double discriminant = b * b - 4 * a * c;

            // Variables to store the complex roots of the equation.
            Complex root_1;
            Complex root_2;

            // Variable to store the result message that will be shown to the user.
            string result;

            // Check the discriminant's value to determine the nature of the equation's roots.
            if (discriminant == 0)
            {
                // One real root (double root) exists.
                double real_part = -b / (2 * a);
                root_1 = new(real_part, 0);
                root_2 = root_1;
                result = $"One real root: {root_1.Real}";
            }
            else if (discriminant > 0)
            {
                // Two distinct real roots exist.
                double real_part_1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double real_part_2 = (-b - Math.Sqrt(discriminant)) / (2 * a);

                root_1 = new(real_part_1, 0);
                root_2 = new(real_part_2, 0);

                result = $"Root 1: {root_1.Real}\nRoot 2: {root_2.Real}";
            }
            else // discriminant < 0
            {
                // Two distinct complex roots exist.
                double real_part = -b / (2 * a);
                double imaginary_part = Math.Sqrt(-discriminant) / (2 * a);

                root_1 = new(real_part, imaginary_part);
                root_2 = new(real_part, -imaginary_part);

                result = $"Complex Root ---\nRoot 1: {root_1}\nRoot 2: {root_2}";
            }

            // Calculate the axis of symmetry using the formula.
            double axis_of_symmetry = -b / (2 * a);

            // Define vertex coordinates.
            double vertex_x = axis_of_symmetry;
            double vertex_y = a * vertex_x * vertex_x + b * vertex_x + c;

            // Calculate the focus of the parabola.
            double focus_x = vertex_x;
            double focus_y = vertex_y + 1 / (4 * a);
            (double focus_x, double focus_y) focus = (focus_x, focus_y);

            // Calculate the equation of the directrix of the parabola.
            double directrix = vertex_y - 1 / (4 * a);

            // Append the calculated properties to the result message.
            result += $"\nAxis of Symmetry: x = {axis_of_symmetry:0.00}";
            result += $"\nVertex: ({vertex_x:0.00}, {vertex_y:0.00})";
            result += $"\nFocus: ({focus_x:0.00}, {focus_y:0.00})";
            result += $"\nDirectrix: y = {directrix:0.00}";

            // Define the domain of the quadratic function.
            string domain = "Domain: x ∈ (-∞, ∞)";

            // Define the range of the quadratic function based on the 'a' coefficient's sign.
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

            // Define the end behavior of the quadratic function based on the 'a' coefficient's sign.
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

            // Return the final result along with the calculated properties.
            return (result, root_1, root_2, axis_of_symmetry, vertex_x, vertex_y, focus, directrix);
        }
    }
}