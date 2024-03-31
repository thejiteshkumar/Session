using System.Diagnostics;

namespace Session.Pages;

public partial class TimerHomePage : ContentPage
{
    const string Start = "Start";
    const string Stop = "Stop";
    readonly string Second = "00:00";
    readonly string Minute = "00:00:00";
    readonly string Hours = "00:00:00:00";
    private bool _running = false;


    public TimerHomePage()
    {
        InitializeComponent();
    }

    private void ActionButton_Clicked(object sender, EventArgs e)
    {
        ActionButton.Text = ToggleButtonText(ActionButton.Text);

        if (PauseButton.IsVisible)
        {
            PauseButton.IsVisible = false;
            TimeLabel.Text = Second;
            _running = false;
            //Do Database operations
        }
        else
        {
            PauseButton.IsVisible = true;
            _running = true;
            RenderStopWatch();
        }
    }

    private void RenderStopWatch()
    {
        TimeLabel.Text = Minute;
        var stopwatch = new Stopwatch();

    }


    private string ToggleButtonText(string text)
    {
        return string.Equals(Start, text, StringComparison.OrdinalIgnoreCase) ? Stop : Start;
    }
}