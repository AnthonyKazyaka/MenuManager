namespace MenuPlanner.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using Common;

    public class ClientSqlRepository : IMenuPlannerRepository<Client>
    {

        public List<Client> Get()
        {
            using (var context = new MenuPlannerContext())
            {
                return context.Clients.ToList();
            }
        }

        public Client Get(int id)
        {
            using (var context = new MenuPlannerContext())
            {
                return context.Clients.FirstOrDefault(x=>x.Id == id);
            }
        }

        public int Save(Client client)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }


    }
}
