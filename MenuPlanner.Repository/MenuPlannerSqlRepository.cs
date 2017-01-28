namespace MenuPlanner.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data.SqlClient;

    using Common;

    public class MenuPlannerSqlRepository
    {
        private SqlConnection connection;

        public MenuPlannerSqlRepository()
        {
            this.connection = new SqlConnection(ConfigurationManager.ConnectionStrings["MenuPlannerDatabase"].ConnectionString);
        }

        #region Clients

        public List<Client> GetClients()
        {
            throw new NotImplementedException();
        }

        public Client GetClient(int id)
        {
            throw new NotImplementedException();
        }

        public int SaveClient(Client client)
        {
            throw new NotImplementedException();
        }

        public void DeleteClient(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Recipes

        public List<Recipe> GetRecipes()
        {
            throw new NotImplementedException();
        }

        public Recipe GetRecipe(int id)
        {
            throw new NotImplementedException();
        }

        public int SaveRecipe(Recipe recipe)
        {
            throw new NotImplementedException();
        }

        public void DeleteRecipe(int id)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Ingredients

        public List<Ingredient> GetIngredients()
        {
            throw new NotImplementedException();
        }

        public Ingredient GetIngredient(int id)
        {
            throw new NotImplementedException();
        }

        public int SaveIngredient(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteIngredient(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
