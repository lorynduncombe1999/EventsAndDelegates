using System;

namespace EventsAndDelegates.Subscribers
{
    /// <summary>
    /// Sends email once video has been encoded
    /// </summary>
    public class MailService
    {
        /// <summary>
        /// This method is the subscriber method
        /// </summary>
        /// <param name="source"> source</param>
        /// <param name="e">VideoEventArgs</param>
        public void OnVideoEncoded(object source, VideoEventArgs e)
        {
            Console.WriteLine("MaileService: Sending and email..."+ e.Video.Title);
        }
    }
}