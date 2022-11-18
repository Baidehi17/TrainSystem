using TrainGR.Models;

namespace TrainGR.Repository
{
    public interface IRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);
        T ADD(T ID);
         T UPDATE(T id);
        T Deletes(T entityToDelete);
        void Save();      
    }
}
