using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Partial_views__Load_more.Services.Interfaces
{
    public interface IEmailService
    {
        void Send(string from, string to, string body, string subject);
    }
}
