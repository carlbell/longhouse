using Microsoft.Maui.Controls;

namespace dotnetprojects.Behaviors;

public class SquareGridBehavior : Behavior<Grid>
{
    protected override void OnAttachedTo(Grid bindable)
    {
        base.OnAttachedTo(bindable);
        bindable.SizeChanged += OnSizeChanged;
    }

    protected override void OnDetachingFrom(Grid bindable)
    {
        base.OnDetachingFrom(bindable);
        bindable.SizeChanged -= OnSizeChanged;
    }

    private void OnSizeChanged(object? sender, EventArgs e)
    {
        var grid = (Grid)sender!;
        var width = grid.Width;
        var height = grid.Height;

        if (width > 0 && height > 0)
        {
            var size = Math.Min(width, height);
            grid.WidthRequest = size;
            grid.HeightRequest = size;

            // Center the grid
            grid.HorizontalOptions = LayoutOptions.Center;
            grid.VerticalOptions = LayoutOptions.Center;
        }
    }
}