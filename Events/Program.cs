using System;

//Events are a way to provide notifications to the outside world when some action is performed.
//Events are a way to achieve publisher-subscriber pattern.
//Events are used to work on loosely coupled systems.
namespace Events
{
    class Program
    {
        static void Main()
        {
            var video = new Video() { Title = "Video 1" };
            var videoEncoder = new VideoEncoder(); // Publisher
            var mailService = new MailService(); // Subscriber
            var messageService = new MessageService(); // Subscriber

            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

            videoEncoder.Encode(video);
        }
    }
}