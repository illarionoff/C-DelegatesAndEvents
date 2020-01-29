using System;

namespace CEventsAndDelegates
{
    public class MessageService
    {
        public void onVideoEncoded(object source, VideoEventArgs args)
        {
            Console.WriteLine("MessageAService sending message..."+args.Video.Title);
        }
    }
}