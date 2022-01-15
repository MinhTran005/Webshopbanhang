using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Webshopbanhang.Utilities.Exceptions
{
    public class WebshopException :Exception
    {
        public WebshopException()
        {

        }
        public WebshopException(string message)
            :base(message)
        {

        }
        public WebshopException(string message,Exception inner) : base(message, inner)
        {

        }
    }
}
