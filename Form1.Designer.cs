namespace Quadratic_Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button_minus = new Button();
            button0 = new Button();
            button_equals = new Button();
            button_reset = new Button();
            button_next = new Button();
            button_delete_history = new Button();
            richTextBox_history = new RichTextBox();
            label_speed = new Label();
            panel_number_pad_container = new Panel();
            button_decimal_point = new Button();
            button_delete = new Button();
            panel_graph_container = new Panel();
            plotView_quadratic = new OxyPlot.WindowsForms.PlotView();
            progressBar_progress = new ProgressBar();
            panel_result_container = new Panel();
            textBox_c = new TextBox();
            textBox_b = new TextBox();
            textBox_a = new TextBox();
            richTextBox_result = new RichTextBox();
            panel_history_container = new Panel();
            panel_number_pad_container.SuspendLayout();
            panel_graph_container.SuspendLayout();
            panel_result_container.SuspendLayout();
            panel_history_container.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.None;
            button1.BackColor = Color.Black;
            button1.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.White;
            button1.Location = new Point(38, 248);
            button1.Name = "button1";
            button1.Size = new Size(88, 77);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = false;
            button1.Click += Numeric_Button_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.None;
            button2.BackColor = Color.Black;
            button2.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(126, 248);
            button2.Name = "button2";
            button2.Size = new Size(88, 77);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = false;
            button2.Click += Numeric_Button_Click;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.BackColor = Color.Black;
            button3.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button3.ForeColor = Color.White;
            button3.Location = new Point(214, 248);
            button3.Name = "button3";
            button3.Size = new Size(88, 77);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = false;
            button3.Click += Numeric_Button_Click;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.BackColor = Color.Black;
            button4.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button4.ForeColor = Color.White;
            button4.Location = new Point(38, 171);
            button4.Name = "button4";
            button4.Size = new Size(88, 77);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = false;
            button4.Click += Numeric_Button_Click;
            // 
            // button5
            // 
            button5.Anchor = AnchorStyles.None;
            button5.BackColor = Color.Black;
            button5.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button5.ForeColor = Color.White;
            button5.Location = new Point(126, 171);
            button5.Name = "button5";
            button5.Size = new Size(88, 77);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = false;
            button5.Click += Numeric_Button_Click;
            // 
            // button6
            // 
            button6.Anchor = AnchorStyles.None;
            button6.BackColor = Color.Black;
            button6.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button6.ForeColor = Color.White;
            button6.Location = new Point(214, 171);
            button6.Name = "button6";
            button6.Size = new Size(88, 77);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = false;
            button6.Click += Numeric_Button_Click;
            // 
            // button7
            // 
            button7.Anchor = AnchorStyles.None;
            button7.BackColor = Color.Black;
            button7.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button7.ForeColor = Color.White;
            button7.Location = new Point(38, 94);
            button7.Name = "button7";
            button7.Size = new Size(88, 77);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = false;
            button7.Click += Numeric_Button_Click;
            // 
            // button8
            // 
            button8.Anchor = AnchorStyles.None;
            button8.BackColor = Color.Black;
            button8.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button8.ForeColor = Color.White;
            button8.Location = new Point(126, 94);
            button8.Name = "button8";
            button8.Size = new Size(88, 77);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = false;
            button8.Click += Numeric_Button_Click;
            // 
            // button9
            // 
            button9.Anchor = AnchorStyles.None;
            button9.BackColor = Color.Black;
            button9.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button9.ForeColor = Color.White;
            button9.Location = new Point(214, 94);
            button9.Name = "button9";
            button9.Size = new Size(88, 77);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = false;
            button9.Click += Numeric_Button_Click;
            // 
            // button_minus
            // 
            button_minus.Anchor = AnchorStyles.None;
            button_minus.BackColor = Color.Black;
            button_minus.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button_minus.FlatStyle = FlatStyle.Flat;
            button_minus.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button_minus.ForeColor = Color.White;
            button_minus.Location = new Point(38, 17);
            button_minus.Name = "button_minus";
            button_minus.Size = new Size(88, 77);
            button_minus.TabIndex = 9;
            button_minus.Text = "-";
            button_minus.UseVisualStyleBackColor = false;
            button_minus.Click += Button_Minus_Click;
            // 
            // button0
            // 
            button0.Anchor = AnchorStyles.None;
            button0.BackColor = Color.Black;
            button0.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button0.FlatStyle = FlatStyle.Flat;
            button0.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button0.ForeColor = Color.White;
            button0.Location = new Point(214, 17);
            button0.Name = "button0";
            button0.Size = new Size(88, 77);
            button0.TabIndex = 10;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = false;
            button0.Click += Numeric_Button_Click;
            // 
            // button_equals
            // 
            button_equals.Anchor = AnchorStyles.None;
            button_equals.BackColor = Color.Black;
            button_equals.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button_equals.FlatStyle = FlatStyle.Flat;
            button_equals.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button_equals.ForeColor = Color.White;
            button_equals.Location = new Point(214, 402);
            button_equals.Name = "button_equals";
            button_equals.Size = new Size(88, 77);
            button_equals.TabIndex = 11;
            button_equals.Text = "=";
            button_equals.UseVisualStyleBackColor = false;
            button_equals.Click += Button_Equals_Click;
            // 
            // button_reset
            // 
            button_reset.Anchor = AnchorStyles.None;
            button_reset.BackColor = Color.Black;
            button_reset.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button_reset.FlatStyle = FlatStyle.Flat;
            button_reset.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_reset.ForeColor = Color.White;
            button_reset.Location = new Point(126, 402);
            button_reset.Name = "button_reset";
            button_reset.Size = new Size(88, 77);
            button_reset.TabIndex = 12;
            button_reset.Text = "Reset";
            button_reset.UseVisualStyleBackColor = false;
            button_reset.Click += Button_Reset_Click;
            // 
            // button_next
            // 
            button_next.Anchor = AnchorStyles.None;
            button_next.BackColor = Color.Black;
            button_next.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button_next.FlatStyle = FlatStyle.Flat;
            button_next.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_next.ForeColor = Color.White;
            button_next.Location = new Point(38, 402);
            button_next.Name = "button_next";
            button_next.Size = new Size(88, 77);
            button_next.TabIndex = 13;
            button_next.Text = "Select";
            button_next.UseVisualStyleBackColor = false;
            button_next.Click += Button_Next_Click;
            // 
            // button_delete_history
            // 
            button_delete_history.Anchor = AnchorStyles.None;
            button_delete_history.BackColor = Color.Black;
            button_delete_history.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button_delete_history.FlatStyle = FlatStyle.Flat;
            button_delete_history.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_delete_history.ForeColor = Color.White;
            button_delete_history.Location = new Point(126, 325);
            button_delete_history.Name = "button_delete_history";
            button_delete_history.Size = new Size(176, 77);
            button_delete_history.TabIndex = 14;
            button_delete_history.Text = "Delete History";
            button_delete_history.UseVisualStyleBackColor = false;
            button_delete_history.Click += Button_Clear_History_Click;
            // 
            // richTextBox_history
            // 
            richTextBox_history.BackColor = Color.Black;
            richTextBox_history.BorderStyle = BorderStyle.FixedSingle;
            richTextBox_history.Dock = DockStyle.Fill;
            richTextBox_history.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox_history.ForeColor = Color.FromArgb(255, 128, 0);
            richTextBox_history.Location = new Point(0, 74);
            richTextBox_history.Name = "richTextBox_history";
            richTextBox_history.ReadOnly = true;
            richTextBox_history.Size = new Size(385, 698);
            richTextBox_history.TabIndex = 15;
            richTextBox_history.Text = "";
            // 
            // label_speed
            // 
            label_speed.BorderStyle = BorderStyle.Fixed3D;
            label_speed.Dock = DockStyle.Top;
            label_speed.Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label_speed.ForeColor = Color.FromArgb(167, 209, 41);
            label_speed.Location = new Point(0, 0);
            label_speed.Name = "label_speed";
            label_speed.Size = new Size(385, 40);
            label_speed.TabIndex = 20;
            label_speed.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel_number_pad_container
            // 
            panel_number_pad_container.BackColor = Color.FromArgb(44, 51, 51);
            panel_number_pad_container.Controls.Add(button_delete_history);
            panel_number_pad_container.Controls.Add(button_decimal_point);
            panel_number_pad_container.Controls.Add(button_next);
            panel_number_pad_container.Controls.Add(button9);
            panel_number_pad_container.Controls.Add(button_delete);
            panel_number_pad_container.Controls.Add(button_reset);
            panel_number_pad_container.Controls.Add(button1);
            panel_number_pad_container.Controls.Add(button_equals);
            panel_number_pad_container.Controls.Add(button2);
            panel_number_pad_container.Controls.Add(button3);
            panel_number_pad_container.Controls.Add(button4);
            panel_number_pad_container.Controls.Add(button5);
            panel_number_pad_container.Controls.Add(button6);
            panel_number_pad_container.Controls.Add(button7);
            panel_number_pad_container.Controls.Add(button8);
            panel_number_pad_container.Controls.Add(button_minus);
            panel_number_pad_container.Controls.Add(button0);
            panel_number_pad_container.Dock = DockStyle.Bottom;
            panel_number_pad_container.Location = new Point(0, 269);
            panel_number_pad_container.Name = "panel_number_pad_container";
            panel_number_pad_container.Size = new Size(338, 503);
            panel_number_pad_container.TabIndex = 21;
            // 
            // button_decimal_point
            // 
            button_decimal_point.Anchor = AnchorStyles.None;
            button_decimal_point.BackColor = Color.Black;
            button_decimal_point.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button_decimal_point.FlatStyle = FlatStyle.Flat;
            button_decimal_point.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button_decimal_point.ForeColor = Color.White;
            button_decimal_point.Location = new Point(126, 17);
            button_decimal_point.Name = "button_decimal_point";
            button_decimal_point.Size = new Size(88, 77);
            button_decimal_point.TabIndex = 11;
            button_decimal_point.Text = ".";
            button_decimal_point.UseVisualStyleBackColor = false;
            button_decimal_point.Click += Button_Decimal_Point_Click;
            // 
            // button_delete
            // 
            button_delete.Anchor = AnchorStyles.None;
            button_delete.BackColor = Color.Black;
            button_delete.FlatAppearance.BorderColor = Color.FromArgb(44, 51, 51);
            button_delete.FlatStyle = FlatStyle.Flat;
            button_delete.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            button_delete.ForeColor = Color.White;
            button_delete.Location = new Point(38, 325);
            button_delete.Name = "button_delete";
            button_delete.Size = new Size(88, 77);
            button_delete.TabIndex = 11;
            button_delete.Text = "Delete";
            button_delete.UseVisualStyleBackColor = false;
            button_delete.MouseDown += Button_Delete_Mouse_Down;
            button_delete.MouseUp += Button_Delete_Mouse_Up;
            // 
            // panel_graph_container
            // 
            panel_graph_container.BackColor = Color.FromArgb(44, 51, 51);
            panel_graph_container.Controls.Add(plotView_quadratic);
            panel_graph_container.Dock = DockStyle.Fill;
            panel_graph_container.Location = new Point(338, 157);
            panel_graph_container.Name = "panel_graph_container";
            panel_graph_container.Size = new Size(515, 772);
            panel_graph_container.TabIndex = 22;
            // 
            // plotView_quadratic
            // 
            plotView_quadratic.BackColor = Color.Black;
            plotView_quadratic.Dock = DockStyle.Fill;
            plotView_quadratic.ForeColor = Color.Black;
            plotView_quadratic.ImeMode = ImeMode.NoControl;
            plotView_quadratic.Location = new Point(0, 0);
            plotView_quadratic.Name = "plotView_quadratic";
            plotView_quadratic.PanCursor = Cursors.Hand;
            plotView_quadratic.Size = new Size(515, 772);
            plotView_quadratic.TabIndex = 24;
            plotView_quadratic.ZoomHorizontalCursor = Cursors.SizeWE;
            plotView_quadratic.ZoomRectangleCursor = Cursors.SizeNWSE;
            plotView_quadratic.ZoomVerticalCursor = Cursors.SizeNS;
            // 
            // progressBar_progress
            // 
            progressBar_progress.Dock = DockStyle.Top;
            progressBar_progress.Location = new Point(0, 40);
            progressBar_progress.Name = "progressBar_progress";
            progressBar_progress.Size = new Size(385, 34);
            progressBar_progress.TabIndex = 21;
            // 
            // panel_result_container
            // 
            panel_result_container.BackColor = Color.FromArgb(44, 51, 51);
            panel_result_container.Controls.Add(textBox_c);
            panel_result_container.Controls.Add(textBox_b);
            panel_result_container.Controls.Add(textBox_a);
            panel_result_container.Controls.Add(panel_number_pad_container);
            panel_result_container.Dock = DockStyle.Left;
            panel_result_container.Location = new Point(0, 157);
            panel_result_container.Name = "panel_result_container";
            panel_result_container.Size = new Size(338, 772);
            panel_result_container.TabIndex = 23;
            // 
            // textBox_c
            // 
            textBox_c.Anchor = AnchorStyles.None;
            textBox_c.BackColor = Color.Black;
            textBox_c.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_c.ForeColor = Color.White;
            textBox_c.Location = new Point(38, 193);
            textBox_c.Name = "textBox_c";
            textBox_c.PlaceholderText = "c";
            textBox_c.Size = new Size(264, 35);
            textBox_c.TabIndex = 24;
            textBox_c.TextAlign = HorizontalAlignment.Center;
            textBox_c.Click += Text_Box_Enter;
            // 
            // textBox_b
            // 
            textBox_b.Anchor = AnchorStyles.None;
            textBox_b.BackColor = Color.Black;
            textBox_b.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_b.ForeColor = Color.White;
            textBox_b.Location = new Point(38, 124);
            textBox_b.Name = "textBox_b";
            textBox_b.PlaceholderText = "b";
            textBox_b.Size = new Size(264, 35);
            textBox_b.TabIndex = 23;
            textBox_b.TextAlign = HorizontalAlignment.Center;
            textBox_b.Click += Text_Box_Enter;
            // 
            // textBox_a
            // 
            textBox_a.Anchor = AnchorStyles.None;
            textBox_a.BackColor = Color.Black;
            textBox_a.Font = new Font("Cascadia Code", 18F, FontStyle.Regular, GraphicsUnit.Point);
            textBox_a.ForeColor = Color.White;
            textBox_a.Location = new Point(38, 57);
            textBox_a.Name = "textBox_a";
            textBox_a.PlaceholderText = "a";
            textBox_a.Size = new Size(264, 35);
            textBox_a.TabIndex = 22;
            textBox_a.TextAlign = HorizontalAlignment.Center;
            textBox_a.Click += Text_Box_Enter;
            // 
            // richTextBox_result
            // 
            richTextBox_result.BackColor = Color.Black;
            richTextBox_result.BorderStyle = BorderStyle.FixedSingle;
            richTextBox_result.Dock = DockStyle.Top;
            richTextBox_result.Font = new Font("Cascadia Code", 10F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox_result.ForeColor = Color.FromArgb(167, 209, 41);
            richTextBox_result.Location = new Point(0, 0);
            richTextBox_result.Name = "richTextBox_result";
            richTextBox_result.ReadOnly = true;
            richTextBox_result.Size = new Size(1238, 157);
            richTextBox_result.TabIndex = 21;
            richTextBox_result.Text = "";
            // 
            // panel_history_container
            // 
            panel_history_container.Controls.Add(richTextBox_history);
            panel_history_container.Controls.Add(progressBar_progress);
            panel_history_container.Controls.Add(label_speed);
            panel_history_container.Dock = DockStyle.Right;
            panel_history_container.Location = new Point(853, 157);
            panel_history_container.Name = "panel_history_container";
            panel_history_container.Size = new Size(385, 772);
            panel_history_container.TabIndex = 24;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1238, 929);
            Controls.Add(panel_graph_container);
            Controls.Add(panel_history_container);
            Controls.Add(panel_result_container);
            Controls.Add(richTextBox_result);
            Font = new Font("Cascadia Code", 9F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Quadratic Calculator";
            panel_number_pad_container.ResumeLayout(false);
            panel_graph_container.ResumeLayout(false);
            panel_result_container.ResumeLayout(false);
            panel_result_container.PerformLayout();
            panel_history_container.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button_minus;
        private Button button0;
        private Button button_equals;
        private Button button_reset;
        private Button button_next;
        private Button button_delete_history;
        private RichTextBox richTextBox_history;
        private Label label_speed;
        private Panel panel_number_pad_container;
        private Panel panel_graph_container;
        private Panel panel_result_container;
        private Button button_delete;
        private TextBox textBox_c;
        private TextBox textBox_b;
        private TextBox textBox_a;
        private RichTextBox richTextBox_result;
        private Button button_decimal_point;
        private ProgressBar progressBar_progress;
        private OxyPlot.WindowsForms.PlotView plotView_quadratic;
        private Panel panel_history_container;
    }
}