using System;
using System.Runtime.InteropServices;
using System.Threading;

namespace EventsAndDelegates
{
 
    /// <summary>
    /// This class creates the delegate, event , and publisher 
    /// </summary>
    public class VideoEncoder
    {
        //1. Define a delegate  - signiture of the method in the subscriber
        //2. Define an event based on delegate
        //3. Raise the event 

        public delegate void VideoEncodedEventHandler(object source, VideoEventArgs args);

        public event VideoEncodedEventHandler VideoEncoded;
        
        public void Encode(Video video)
        {
            Console.WriteLine("Encoding Video...");
            Thread.Sleep(3000);
            
            OnVideoEncoded(video);
        }

        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded != null)
            {
                VideoEncoded(this,new VideoEventArgs(){Video =video });
            }
        }
    }
}