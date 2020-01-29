using System;
using System.Threading;

namespace CEventsAndDelegates
{
    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }
    }
    public class VideoEncoder
    {
        // Step 1. Define a delegate
        // Step 2. Define event based on that delegate
        // Step 3. Raise an event

        //public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);
        //public event VideoEncodedEventHandler VideoEncoded;

        public event EventHandler<VideoEventArgs> VideoEncoded; 

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video...");
            Thread.Sleep(3000);
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null) VideoEncoded(this, new VideoEventArgs(){Video = video});
        }
    }
}