using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Collections.Specialized;

namespace CSIS425.Controllers
{
    public interface Base_Controller : Controller
    {
        void run(NameValueCollection parameters);
    }
}