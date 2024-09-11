namespace EventWithoutArgument
{
	public delegate void EventHandler(); //Delegate
	public class VideoEncoder
	{
		public event EventHandler VideoEncoded; //Event
		public void Encode()
		{
			Console.WriteLine("Encoding video...");
			Thread.Sleep(3000);
			OnVideoEncoded();
		}
		protected virtual void OnVideoEncoded()
		{
			if (VideoEncoded != null)
				VideoEncoded();
		}
	}

	public class MailService
	{
		public void OnVideoEncoded()
		{
			Console.WriteLine("MailService: Sending an email...");
		}
	}
	public class MessageService
	{ public void OnVideoEncoded() 
		{
			Console.WriteLine("MessageService: Sending a text message...");
		}
	}

	class Program
	{
		static void Main()
		{
			var videoEncoder = new VideoEncoder(); // Publisher
			var mailService = new MailService(); // Subscriber
			var messageService = new MessageService(); // Subscriber

			videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
			videoEncoder.VideoEncoded += messageService.OnVideoEncoded;

			videoEncoder.Encode();
		}
	}
}