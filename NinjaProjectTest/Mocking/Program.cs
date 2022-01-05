using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaProjectTest.Mocking
{
    public class Program
    {
        public static void Main()
        {
            var service = new VideoService();

            //Injecting Via Method Parameter
            // var title = service.ReadVideoTitle(new FileReader());

            //Injecting Via Property
            var title = service.ReadVideoTitle();
        }
    }
}
