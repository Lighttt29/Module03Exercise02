using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module03Exercise01.Services
{
    public interface IMYService
    {
        string GetMessage();
        
    }

    public class MyService : IMYService
    {
        public string GetMessage()
        {
            return "Hello From MyService";
        }
    }
}
