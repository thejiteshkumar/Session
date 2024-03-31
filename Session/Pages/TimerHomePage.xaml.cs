namespace Session.Pages;

public partial class TimerHomePage : ContentPage
{
    const string Resume = "Resume";
    const string Pause = "Pause";
    readonly string InitialTime = "00:00:00";
    private bool running = false;
    private readonly IDispatcherTimer _timer;
    private DateTime _startTime;
    private TimeSpan _totalElapsedTime;
    private bool _isPaused;


    public TimerHomePage()
    {
        InitializeComponent();
        _timer = Dispatcher.CreateTimer();
        _timer.Interval = TimeSpan.FromMilliseconds(600);
        _timer.Tick += (s, e) => UpdateTimer();
    }

    private void StartButton_Clicked(object sender, EventArgs e)
    {
        StartButton.IsVisible = false;
        StopButton.IsVisible = true;
        PauseButton.IsVisible = true;
        _startTime = DateTime.Now;
        running = true;
        _timer.Start();
    }

    private void PauseButton_Clicked(object? sender, EventArgs e)
    {
        _isPaused = !_isPaused;

        if (_isPaused)
        {
            PauseButton.Text = Resume;
            _timer.Stop();
        }
        else
        {
            PauseButton.Text = Pause;
            _startTime = DateTime.Now;
            _timer.Start();
        }

    }

    private void StopButton_Clicked(object sender, EventArgs e)
    {
        _timer.Stop();
        _totalElapsedTime = new TimeSpan();
        TimeLabel.Text = InitialTime;
        running = false;
        _isPaused = false;
        PauseButton.IsVisible = false;
        StopButton.IsVisible = false;
        StartButton.IsVisible = true;

    }

    private bool UpdateTimer()
    {
        if (running && !_isPaused)
        {
            DateTime currentTime = DateTime.Now;
            TimeSpan elapsedTime = currentTime - _startTime;
            _totalElapsedTime += elapsedTime;
            _startTime = currentTime;
            TimeLabel.Text = String.Format("{0:00}:{1:00}.{2:00}",
                                            _totalElapsedTime.Minutes, _totalElapsedTime.Seconds, _totalElapsedTime.Milliseconds / 10);
        }
        return true;
    }


}