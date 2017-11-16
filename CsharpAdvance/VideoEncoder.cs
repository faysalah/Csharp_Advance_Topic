using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace CsharpAdvance
{
    public class VideoEncoder
    {
        // public delegate void VideoEncodedEventHandler(object source, EventArgs args);
        // public event VideoEncodedEventHandler VideoEncoded;

        // Delegate declaration and event declaration similar this generic EventHandler
        public EventHandler VideoEncoded;

        public void Encode(Video video)
        {
            Console.WriteLine("Encoding video ....");
            Thread.Sleep(3000);
            OnVideoEncoded();
        }

        protected virtual void OnVideoEncoded()
        {
            if (VideoEncoded != null)
                VideoEncoded(this, EventArgs.Empty);
        }
    }
}
