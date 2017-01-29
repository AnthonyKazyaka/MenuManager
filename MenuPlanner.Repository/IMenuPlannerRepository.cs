namespace MenuPlanner.Repository
{
    using System.Collections.Generic;

    public interface IMenuPlannerRepository<T>
    {
        List<T> Get();

        T Get(int id);

        int Save(T client);

        void Delete(int id);
    }
}
