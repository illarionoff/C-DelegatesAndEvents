using System;

namespace CEventsAndDelegates
{
    public class MailService
    {
        public void onVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MailService sending email..." +args.Video.Title);
        }
    }
}