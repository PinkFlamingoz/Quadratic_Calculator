using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quadratic_Calculator
{
    public static class Coefficient_Validator
    {
        // Is one coefficient valid
        public static bool Is_Coefficient_Valid(TextBox text_box, string coefficient_name, out string error_message, bool cannot_be_zero = false)
        {
            error_message = string.Empty;

            if (string.IsNullOrEmpty(text_box.Text))
            {
                error_message = $"Coefficient '{coefficient_name}' cannot be empty.";
                return false;
            }

            if (!double.TryParse(text_box.Text, out double coefficient_value))
            {
                error_message = $"Coefficient '{coefficient_name}' must be a valid number.";
                return false;
            }

            if (cannot_be_zero && coefficient_value == 0)
            {
                error_message = $"Coefficient '{coefficient_name}' cannot be zero for a quadratic equation.";
                return false;
            }

            return true;
        }

        // Validate coefficients

        public static bool Validate_Coefficients(TextBox text_box_a, TextBox text_box_b, TextBox text_box_c, out string error_message)
        {
            StringBuilder error_builder = new();
            if (!Is_Coefficient_Valid(text_box_a, "a", out string a_error, true))
            {
                error_builder.AppendLine(a_error);
            }
            if (!Is_Coefficient_Valid(text_box_b, "b", out string b_error))
            {
                error_builder.AppendLine(b_error);
            }
            if (!Is_Coefficient_Valid(text_box_c, "c", out string c_error))
            {
                error_builder.AppendLine(c_error);
            }

            error_message = error_builder.ToString();
            return string.IsNullOrEmpty(error_message);
        }
    }
}