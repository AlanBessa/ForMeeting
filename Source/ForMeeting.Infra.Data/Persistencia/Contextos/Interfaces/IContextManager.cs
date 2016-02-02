using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForMeeting.Infra.Data.Persistencia.Contextos.Interfaces
{
    public interface IContextManager
    {
        ForMeetingContext GetContext();
    }
}
