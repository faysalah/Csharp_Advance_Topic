using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpAdvance
{
    class TextMessageService
    {
        public void OnVideoEncoded(object source, EventArgs args)
        {
            Console.WriteLine("TextMessageService: Sending text message ...");
        }
    }
}
