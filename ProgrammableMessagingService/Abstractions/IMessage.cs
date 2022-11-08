using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgrammableMessagingService.Abstractions
{
    public interface IMessage
    {
        public string Text { get; }
        public string From { get; }
        public string To { get; }
        public DateTime DateReceivedUTC { get; }
    }
}
