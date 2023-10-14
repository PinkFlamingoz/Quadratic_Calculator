using OxyPlot.Axes;
using OxyPlot.Series;
using OxyPlot;
using OxyPlot.WindowsForms;
using OxyPlot.Annotations;
using System.Numerics;

namespace Quadratic_Calculator
{
    public static class Plot_Graph
    {
        // Set some standard colors for the plot's features

        private static readonly OxyColor color = OxyColor.FromRgb(167, 209, 41);
        private static readonly OxyColor fill = OxyColor.FromRgb(44, 51, 51);
        private static readonly OxyColor axis = OxyColor.FromRgb(255, 128, 0);

        // The method Plot creates a visualization of the quadratic function
        public static void Plot(PlotView plot_view, double a, double b, double c, Complex root_1, Complex root_2, double axis_of_symmetry, double vertex_x, double vertex_y, (double focus_x, double focus_y) focus, double directrix)
        {
            // Initialize a new plot model with some basic configurations
            var model = new PlotModel
            {
                Title = "Quadratic Graph",
                Subtitle = $"Equation: y = {a}x^2 + {b}x + {c}",
                TitleFont = "Cascadia Code",
                TitleFontSize = 24,
                TitleColor = color,
                TextColor = color,
                PlotAreaBackground = OxyColors.Automatic,
                Background = OxyColors.Transparent,
                PlotAreaBorderColor = color
            };

            // Create a function series (graph) for the quadratic function
            var series = new FunctionSeries(x => a * x * x + b * x + c, -5, 5, 0.1, $"y = {a}x^2 + {b}x + {c}")
            {
                Color = color,
                StrokeThickness = 1,
                MarkerType = MarkerType.Circle,
                MarkerSize = 2,
                MarkerFill = color,
                MarkerStroke = fill,
                TrackerFormatString = "X: {2:0.00}\nY: {4:0.00}",
            };
            model.Series.Add(series);

            // Add X-axis settings
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Bottom,
                PositionAtZeroCrossing = true,
                Minimum = -10,
                Maximum = 10,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                Title = "X-axis",
                AxislineColor = axis,
                AxislineStyle = LineStyle.Solid,
                TicklineColor = axis,
                // MajorGridlineColor = axis,
                // MinorGridlineColor = axis,
            });

            // Add Y-axis settings
            model.Axes.Add(new LinearAxis
            {
                Position = AxisPosition.Left,
                PositionAtZeroCrossing = true,
                Minimum = -10,
                Maximum = 10,
                MajorGridlineStyle = LineStyle.Solid,
                MinorGridlineStyle = LineStyle.Dot,
                Title = "Y-axis",
                AxislineColor = axis,
                AxislineStyle = LineStyle.Solid,
                TicklineColor = axis,
                // MajorGridlineColor = axis,
                // MinorGridlineColor = axis,
            });

            // Roots
            if (root_1.Imaginary == 0) // Real root
            {
                model.Annotations.Add(new PointAnnotation
                {
                    X = root_1.Real,
                    Y = 0,
                    Text = $"Root 1: {root_1.Real:0.00}"
                });
            }

            if (root_2.Imaginary == 0) // Real root
            {
                model.Annotations.Add(new PointAnnotation
                {
                    X = root_2.Real,
                    Y = 0,
                    Text = $"Root 2: {root_2.Real:0.00}"
                });
            }

            // Vertex
            model.Annotations.Add(new PointAnnotation
            {
                X = vertex_x,
                Y = vertex_y,
                Text = $"Vertex: ({vertex_x:0.00}, {vertex_y:0.00})"
            });

            // Axis of Symmetry
            model.Annotations.Add(new LineAnnotation
            {
                Type = LineAnnotationType.Vertical,
                X = axis_of_symmetry,
                Color = color,
                Text = $"Axis: x = {axis_of_symmetry:0.00}"
            });

            // 4. Y-intercept
            model.Annotations.Add(new PointAnnotation
            {
                X = 0,
                Y = c,
                Text = $"Y-intercept: {c:0.00}"
            });

            // Focus
            model.Annotations.Add(new PointAnnotation
            {
                X = focus.focus_x,
                Y = focus.focus_y,
                Text = $"Focus: ({focus.focus_x:0.00}, {focus.focus_y:0.00})",
                Shape = MarkerType.Circle
            });

            // Directrix
            model.Annotations.Add(new LineAnnotation
            {
                Type = LineAnnotationType.Horizontal,
                Y = directrix,
                Color = color,
                Text = $"Directrix: y = {directrix:0.00}"
            });

            plot_view.Model = model;
        }
    }
}