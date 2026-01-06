using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WingsOfKaramboProject;

namespace APIClient
{
    public interface IApiService
    {
        public Task<ActionTBList> SelectAllActions();
        
        public Task<int> UpdateAnAction(ActionTBL action);

        public Task<int> DeleteAnAction(ActionTBL action);

    }
}
