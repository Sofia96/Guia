using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bsi24tallerbilly.Models
{
    public class ContactUsViewModels
    {
        public class SendEmailViewModel
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public string Message { get; set; }
        }
    }
}
