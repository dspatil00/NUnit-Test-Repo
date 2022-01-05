using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjaProjectTest.Fundamentals
{
    public class CustomerController
    {
        public ActionResult GetCustomer (int id)
        {
            if (id == 0)
            {
                return new NotFound();
            }
            return new ok();
        }
    }

    public class ActionResult
    {

    }

    public class NotFound : ActionResult
    {

    }

    public class ok : ActionResult
    {

    }
}
