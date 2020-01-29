namespace CEventsAndDelegates
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var video = new Video {Title = "Video1"};
            var videoEncoder = new VideoEncoder(); //publisher
            var mailService = new MailService(); //subsciber
            var messageService = new MessageService(); //subsciber

            videoEncoder.VideoEncoded += mailService.onVideoEncoded;
            videoEncoder.VideoEncoded += messageService.onVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}