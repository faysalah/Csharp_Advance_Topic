using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    class Program
    {
        static void Main(string[] args)
        {
            var video = new Video() { Title = " VEDIO_1" };
            var videoEncoder = new VideoEncoder();//broadcaster or publisher
            var mailService = new MailService();// Subscriber
            var textMessageService = new TextMessageService();// Subscriber
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += textMessageService.OnVideoEncoded;
            videoEncoder.Encode(video);
            Console.Read();
        }
    }
}
