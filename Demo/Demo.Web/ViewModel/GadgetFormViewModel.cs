using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Demo.Web.ViewModel
{
    public class GadgetFormViewModel
    {
        public HttpPostedFileBase File { get; set; }
        public string GadgetTitle { get; set; }
        public string GadgetDescription { get; set; }
        public decimal GadgetPrice { get; set; }
        public int GadgetCategory { get; set; }
    }
}