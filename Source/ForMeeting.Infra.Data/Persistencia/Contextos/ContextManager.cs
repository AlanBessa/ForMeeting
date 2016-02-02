using ForMeeting.Infra.Data.Persistencia.Contextos.Interfaces;
using System.Web;

namespace ForMeeting.Infra.Data.Persistencia.Contextos
{
    public class ContextManager : IContextManager
    {
        private const string ContextKey = "ContextManager.Context";

        public ForMeetingContext GetContext()
        {
            if (HttpContext.Current.Items[ContextKey] == null)
            {
                HttpContext.Current.Items[ContextKey] = new ForMeetingContext();
            }

            return (ForMeetingContext)HttpContext.Current.Items[ContextKey];
        }
    }
}