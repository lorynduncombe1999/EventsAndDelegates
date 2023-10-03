using System;
using System.Runtime.InteropServices;
using EventsAndDelegates.Subscribers;

namespace EventsAndDelegates
{/// <summary>
 /// This is the main method that demonstrates the pub/sub relationship. This relationship is one to many
 /// Tutorial From: https://www.youtube.com/watch?v=jQgwEsJISy0&t=1539s
 /// </summary>
    public class Program
    {
        public static void Main(string[] args)
        {
            var video = new Video() { Title = "Video1" }; // video object
            var videoEncoder = new VideoEncoder();//publisher
            var mailService = new MailService(); // subscriber
            var messageService = new MessageService(); //suscriber
            //This creates the pub/sub relationship 
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded; //publisher.eventhanlder += subscriverclass.subscribermethod
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;  //publisher.eventhanlder += subscriverclass.subscribermethod
            videoEncoder.Encode(video);
        }
        
    }

    
 
}