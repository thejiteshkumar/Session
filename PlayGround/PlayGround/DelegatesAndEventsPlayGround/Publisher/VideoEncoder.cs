namespace PlayGround.DelegatesAndEventsPlayGround.Publisher
{
    public class VideoEncoder
    {
        public delegate void VideoEncodedHandler(object o, EventArgs e);

        public event VideoEncodedHandler? VideoEncoded;

        public void EncodeVideo()
        {
            //logic to envoke an event
            Console.WriteLine("Encoding Video");
            Thread.Sleep(3000);
            SendVideoEncodedEvent();
        }

        public void SendVideoEncodedEvent()
        {
            onVideoEncoded();
        }

        protected virtual void onVideoEncoded()
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this, EventArgs.Empty);
            }
        }
    }
}