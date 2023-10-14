using System.Text;

namespace Quadratic_Calculator
{
    // Define a static class called Coefficient_Validator, which contains methods to validate the coefficients of a quadratic equation.
    public static class Coefficient_Validator
    {
        // This method checks if an individual coefficient (from a text box) is valid.
        // Parameters:
        // - text_box: The text box from which the coefficient's value will be read.
        // - coefficient_name: The name or identifier of the coefficient (like "a", "b", or "c").
        // - error_message: A string output parameter that returns an error message if the validation fails.
        // - cannot_be_zero: An optional boolean parameter, defaulting to false,
        //   which if set to true ensures the coefficient is not zero (useful for the 'a' coefficient in a quadratic equation).
        public static bool Is_Coefficient_Valid(TextBox text_box, string coefficient_name, out string error_message, bool cannot_be_zero = false)
        {
            error_message = string.Empty;

            // Check if the text in the text box is empty or null.
            if (string.IsNullOrEmpty(text_box.Text))
            {
                error_message = $"Coefficient '{coefficient_name}' cannot be empty.";
                return false;
            }

            // Check if the text in the text box can be parsed as a double (i.e., a valid number).
            if (!double.TryParse(text_box.Text, out double coefficient_value))
            {
                error_message = $"Coefficient '{coefficient_name}' must be a valid number.";
                return false;
            }

            // If the 'cannot_be_zero' flag is true and the coefficient value is zero, then return an error.
            if (cannot_be_zero && coefficient_value == 0)
            {
                error_message = $"Coefficient '{coefficient_name}' cannot be zero for a quadratic equation.";
                return false;
            }

            // If no validation errors occurred, return true.
            return true;
        }

        // This method validates all the coefficients of a quadratic equation.
        // Parameters:
        // - text_box_a, text_box_b, text_box_c: Text boxes containing the coefficients "a", "b", and "c" respectively.
        // - error_message: A string output parameter that consolidates and returns all the error messages from the individual coefficient validations.
        public static bool Validate_Coefficients(TextBox text_box_a, TextBox text_box_b, TextBox text_box_c, out string error_message)
        {
            // Use a StringBuilder to efficiently build the consolidated error message.
            StringBuilder error_builder = new();

            // Validate the 'a' coefficient. If it's not valid, add the error message to the error_builder.
            if (!Is_Coefficient_Valid(text_box_a, "a", out string a_error, true))
            {
                error_builder.AppendLine(a_error);
            }

            // Validate the 'b' coefficient. If it's not valid, add the error message to the error_builder.
            if (!Is_Coefficient_Valid(text_box_b, "b", out string b_error))
            {
                error_builder.AppendLine(b_error);
            }

            // Validate the 'c' coefficient. If it's not valid, add the error message to the error_builder.
            if (!Is_Coefficient_Valid(text_box_c, "c", out string c_error))
            {
                error_builder.AppendLine(c_error);
            }

            // Convert the accumulated error messages in the error_builder to a string.
            error_message = error_builder.ToString();

            // If there are no error messages, return true (indicating all coefficients are valid).
            // Otherwise, return false.
            return string.IsNullOrEmpty(error_message);
        }
    }
}