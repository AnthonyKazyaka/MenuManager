using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuPlanner.Repository
{
    public partial class MenuPlannerContext
    {
        public MenuPlannerContext() : base(ConfigurationManager.ConnectionStrings["MenuPlanner"].ConnectionString)
        {

        }
    }
}
