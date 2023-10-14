using OxyPlot;
using System.Diagnostics;
using System.Text;
using Timer = System.Windows.Forms.Timer;
using System.Numerics;

namespace Quadratic_Calculator
{
    public partial class Form1 : Form
    {
        // Constants

        private const double MIN_TIME = 1.0; // minimum noticeable time
        private const double MAX_TIME = 1000.0; // maximum time for calculation

        // Variables

        // Keeping track of the last clicked button

        private Button? clicked_button;
        private readonly List<TextBox> text_boxes = new();
        private TextBox? active_text_box = null;
        private int current_text_box_index;
        private bool long_press = false;

        // Timers

        private readonly Timer delete_timer = new();
        private readonly Stopwatch stopwatch = new();

        // Constructor
        public Form1()
        {
            InitializeComponent();

            // Add Text Boxes to list so we can swap between them using the Select Button
            text_boxes.Add(textBox_a);
            text_boxes.Add(textBox_b);
            text_boxes.Add(textBox_c);

            // Set up timers
            delete_timer.Interval = 1000; // Set to 1 second
            delete_timer.Tick += Delete_Timer_Tick;

            // Select Text Box
            this.Shown += Form1_Shown;
        }

        // Functions -------------------------------------------------------------------------------------------------------------------------------------------------------

        // Main Functions for calculation ----------------------------------------------------------------------------------------

        // UI set up ----------------------------------------------

        // Reset the Progress Bar
        private void Reset_Progress_Bar()
        {
            progressBar_progress.Value = 0;
        }

        // Start the Stopwatch
        private void Start_Stopwatch()
        {
            stopwatch.Start();
        }

        // Reset Stopwatch
        private void Reset_Stopwatch()
        {
            stopwatch.Reset();
        }

        // Update the UIse
        private void Update_UI()
        {
            label_speed.Text = $"Calculation Time: {stopwatch.ElapsedMilliseconds} ms";

            double ratio = Math.Log10(stopwatch.ElapsedMilliseconds / MIN_TIME) / Math.Log10(MAX_TIME / MIN_TIME);
            progressBar_progress.Value = Math.Min(100, Math.Max(0, (int)(ratio * 100)));
        }

        // Update the history Rich Text Box
        private void Update_History()
        {
            StringBuilder history_builder = new();
            history_builder.AppendLine($"\n-------------\na: {textBox_a.Text}, b: {textBox_b.Text}, c: {textBox_c.Text} => \n{richTextBox_result.Text}\n-------------");
            richTextBox_history.AppendText(history_builder.ToString());
        }

        // UI set up ----------------------------------------------

        // Solver -------------------------------------------------

        // Solve the equation
        private static (string result, Complex root_1, Complex root_2, double axis_of_symmetry, double vertex_x, double vertex_y, (double focus_x, double focus_y) focus, double directrix) Solve_Equation(double a, double b, double c)
        {
            return Quadratic_Solver.Solve(a, b, c);
        }

        // Main solver run
        private void Button_Equals_Click(object? sender, EventArgs args)
        {
            Reset_Progress_Bar();

            string? error_message = null;

            if (double.TryParse(textBox_a.Text, out double a) &&
                double.TryParse(textBox_b.Text, out double b) &&
                double.TryParse(textBox_c.Text, out double c) &&
                Coefficient_Validator.Validate_Coefficients(textBox_a, textBox_b, textBox_c, out error_message))
            {
                Start_Stopwatch();
                var (result, root_1, root_2, axis_of_symmetry, vertex_x, vertex_y, focus, directrix) = Solve_Equation(a, b, c);
                Update_UI();
                Reset_Stopwatch(); // Stop the stopwatch after solving

                // Update the graph and RichTextBox after stopping the stopwatch

                Plot_Graph.Plot(plotView_quadratic, a, b, c, root_1, root_2, axis_of_symmetry, vertex_x, vertex_y, focus, directrix);
                richTextBox_result.Text = result;

                Update_History();
            }
            else
            {
                MessageBox.Show(error_message ?? "Please enter valid numbers for coefficients.");
            }

            Set_Button_Color(sender);
        }

        // Solver -------------------------------------------------

        // Main Functions for calculation ----------------------------------------------------------------------------------------

        // Input Send Functions --------------------------------------------------------------------------------------------------

        // Send the text of the buttons to the Text Box
        private void Numeric_Button_Click(object? sender, EventArgs args)
        {
            // You can add more validation as required

            if (sender is Button clicked_button)
            {
                active_text_box?.AppendText(clicked_button.Text);

                Set_Button_Color(clicked_button);
            }
        }

        // Add a negative sign to the Text Box
        private void Button_Minus_Click(object? sender, EventArgs args)
        {
            if (active_text_box != null && !active_text_box.Text.StartsWith("-"))
            {
                active_text_box.Text = "-" + active_text_box.Text;

                Set_Button_Color(sender);
            }
        }

        // Add a decimal point to the Text Box
        private void Button_Decimal_Point_Click(object? sender, EventArgs args)
        {
            if (active_text_box != null && !active_text_box.Text.Contains('.'))
            {
                active_text_box.AppendText(".");

                Set_Button_Color(sender);
            }
        }

        // Input Send Functions --------------------------------------------------------------------------------------------------

        // Selection functions ---------------------------------------------------------------------------------------------------

        // Select the Text Box
        private void Text_Box_Enter(object? sender, EventArgs args)
        {
            // Set the active Text Box to the Text Box that triggered the event
            active_text_box = sender as TextBox;
        }

        // Select the Text Boxes in a loop
        private void Button_Next_Click(object? sender, EventArgs args)
        {
            // Move to the next Text Box
            current_text_box_index = (current_text_box_index + 1) % text_boxes.Count;

            // Set the focus to the currently indexed Text Box
            text_boxes[current_text_box_index].Focus();

            // Set active Tex tBox to the focused Text Box
            active_text_box = text_boxes[current_text_box_index];

            Set_Button_Color(sender);
        }

        // When the form loads select the fist Text Box
        private void Form1_Shown(object? sender, EventArgs args)
        {
            textBox_a.Focus();
            active_text_box = textBox_a;
        }

        // Selection functions ---------------------------------------------------------------------------------------------------

        // Reset UI functions ----------------------------------------------------------------------------------------------------

        // Reset the UI
        private void Button_Reset_Click(object? sender, EventArgs args)
        {
            Clear_Text_Boxes();
            richTextBox_result.Text = "Result";
            richTextBox_history.Clear();
            textBox_a.Focus();
            Reset_Progress_Bar();
            Clear_Graph();
            Set_Button_Color(sender);
        }

        // Clear the Text Box Fields
        private void Clear_Text_Boxes()
        {
            textBox_a.Clear();
            textBox_b.Clear();
            textBox_c.Clear();
        }

        // Clear the history
        private void Button_Clear_History_Click(object? sender, EventArgs args)
        {
            richTextBox_history.Clear();
            Set_Button_Color(sender);
        }

        // Clear the graph
        private void Clear_Graph()
        {
            plotView_quadratic.Model = new PlotModel();
            plotView_quadratic.InvalidatePlot(true); // Refresh the plot view
        }

        // Reset functions -------------------------------------------------------------------------------------------------------

        // Delete functions ------------------------------------------------------------------------------------------------------

        // Check on every tick if the user holds the delete button if not delete one character else delete everything in the Text Box
        private void Delete_Timer_Tick(object? sender, EventArgs args)
        {
            if (active_text_box != null)
            {
                active_text_box.Clear();
                active_text_box.Focus();
                long_press = true;
            }
            delete_timer.Stop();
        }

        // Delete on mouse down
        private void Button_Delete_Mouse_Down(object? sender, MouseEventArgs args)
        {
            long_press = false;
            delete_timer.Start();
            Set_Button_Color(sender);
        }

        // Delete on mouse up
        private void Button_Delete_Mouse_Up(object? sender, MouseEventArgs args)
        {
            delete_timer.Stop();
            if (!long_press && active_text_box != null)
            {
                if (active_text_box.Text.Length > 0)
                {
                    active_text_box.Text = active_text_box.Text[..^1];
                    active_text_box.SelectionStart = active_text_box.Text.Length; // Set cursor to the end
                    active_text_box.Focus();
                }

                active_text_box.Focus();

                Set_Button_Color(sender);
            }
        }

        // Delete functions ------------------------------------------------------------------------------------------------------
        // Change the color of the clicked button and revert the color of the previous clicked button.
        // Change the color of labels when the custom date button is clicked.
        private void Set_Button_Color(object? sender)
        {
            if (sender is Button button_click)
            {
                // Set the text color of the button to a specific color (167, 209, 41)
                button_click.ForeColor = Color.FromArgb(167, 209, 41);
                button_click.BackColor = Color.FromArgb(44, 51, 51);
                button_click.FlatStyle = FlatStyle.Flat;
                button_click.FlatAppearance.BorderColor = Color.FromArgb(167, 209, 41);  // The border color you want
                button_click.FlatAppearance.BorderSize = 1;  // Border size

                // Check if there is a previously clicked button and it's not the current one
                if (clicked_button != null && clicked_button != button_click)
                {
                    clicked_button.BackColor = this.BackColor;
                    clicked_button.ForeColor = Color.White;

                    clicked_button.FlatStyle = FlatStyle.Flat;  // Reset to the standard style
                    clicked_button.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51); // Reset the border color
                    clicked_button.FlatAppearance.BorderSize = 1;  // Reset the border size, adjust as needed
                }

                // Store the reference to the clicked button for future color change when other buttons are clicked
                clicked_button = button_click;
            }
        }

        // Functions -------------------------------------------------------------------------------------------------------------------------------------------------------
    }
}