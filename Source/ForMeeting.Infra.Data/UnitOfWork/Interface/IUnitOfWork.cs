namespace ForMeeting.Infra.Data.UnitOfWork.Interface
{
    public interface IUnitOfWork
    {
        void BeginTransaction();

        void SaveChanges();
    }
}