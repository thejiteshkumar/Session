namespace PlayGround.DelegatesAndEventsPlayGround.Subscriber
{
    public class MailService
    {
        //Subscribe event handler

        public void onVideoEncodedHandler(object source, EventArgs e)
        {
            Console.WriteLine("Video encoded sending an email.");
        }
    }
}