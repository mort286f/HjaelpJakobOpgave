using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HjælpJakobOpgave
{
    //Interface with all the properties a message contains
    interface IMessage
    {
        string To { get; set; }
        string From { get; set; }
        string Body { get; set; }
        string Subject { get; set; }
        string Cc { get; set; }
    }
}
