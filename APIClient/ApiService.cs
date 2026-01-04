using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using WingsOfKaramboProject;

namespace APIClient
{
    public class ApiService : IApiService
    {
        private HttpClient Client;
        public ApiService() {
            Client = new HttpClient();
            Client.BaseAddress = new Uri("http://localhost:5078");
        }

        public async Task<T> Select<T>(string url) where T : class
        {
            return await Client.GetFromJsonAsync<T>(url);
        }

        public async Task<ActionTBList> SelectAllActions()
        {
            return await Select<ActionTBList>("api/Select/ActionSelector");
        }
        public async Task<int> Update<T>(T entity, string url) where T : BaseEntity
        {
            return (await Client.PutAsJsonAsync<T>(url, entity)).IsSuccessStatusCode ? 1:0;
        }
        public async Task<int> UpdateAnAction(ActionTBL action)
        {
            return await Update<ActionTBL>(action, "api/Update/ActionTBLUpdater");
        }
        public async Task<int> Insert<T>(T entity, string url) where T : BaseEntity
        {
            return (await Client.PostAsJsonAsync<T>(url, entity)).IsSuccessStatusCode ? 1 : 0;
        }


        public async Task<int> Delete<T>(int id, string url) where T : BaseEntity
        {
            return (await Client.DeleteFromJsonAsync<T>(url + id)).IsSuccessStatusCode ? 1 : 0;
        }
    }
}
