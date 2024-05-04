using PlayGround.DelegatesAndEventsPlayGround.Publisher;
using PlayGround.DelegatesAndEventsPlayGround.Subscriber;

namespace PlayGround.DelegatesAndEventsPlayGround
{
    public class CallDelegatePlayGround
    {
        private VideoEncoder encoder;
        private MailService mailService;
        private TextService textService;

        public CallDelegatePlayGround()
        {
            encoder = new();
            mailService = new();
            textService = new();
        }

        public void CallDelegates()
        {
            //subscribe to the event
            encoder.VideoEncoded += mailService.onVideoEncodedHandler;
            encoder.VideoEncoded += textService.OnVideoEncodedHandler;


            //Calling the publisher method 
            encoder.EncodeVideo();
        }
    }
}