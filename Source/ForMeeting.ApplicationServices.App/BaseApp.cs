using ForMeeting.Infra.CrossCutting.Common.IoC;
using ForMeeting.Infra.Data.UnitOfWork.Interface;

namespace ForMeeting.ApplicationServices.App
{
    public class BaseApp
    {
        private IUnitOfWork _unitOfWork;

        public void BeginTransaction()
        {
            _unitOfWork = ObjectFactory.GetInstance<IUnitOfWork>();
            _unitOfWork.BeginTransaction();
        }

        public void Commit()
        {
            _unitOfWork.SaveChanges();
        }
    }
}