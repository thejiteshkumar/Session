namespace PlayGround.DelegatesAndEventsPlayGround.Subscriber
{
    public class TextService
    {
        //Subscribe event handler
        public void OnVideoEncodedHandler(object source, EventArgs e)
        {
            Console.WriteLine("Video encoded sending Text Message.");
        }
    }
}