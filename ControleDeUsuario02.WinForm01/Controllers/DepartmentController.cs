using ControleDeUsuario02.WinForm01.Model;
using RestSharp;

namespace ControleDeUsuario02.WinForm01.Controllers {
    internal class DepartmentController {

        public static List<DepartmentModel> GetAll() {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest("/Department", Method.Get);
            var response = client.ExecuteGet<List<DepartmentModel>>(request);

            return response.Data;
        }

        public static DepartmentModel GetById(int id) {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest($"/Department/{id}", Method.Get);
            var response = client.ExecuteGet<DepartmentModel>(request);

            return response.Data;
        }

        public static List<DepartmentModel> GetByName(string name) {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest($"/Department/{name}", Method.Get);
            var response = client.ExecuteGet<List<DepartmentModel>>(request);

            return response.Data;
        }

        public static DepartmentModel PostOne(DepartmentModel department) {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest($"/Department", Method.Post);
            var body = new DepartmentModel {Name = department.Name, Description = department.Description };
            request.AddBody(body);

            var response = client.ExecutePost<DepartmentModel>(request);

            return response.Data;
        }

        public static DepartmentModel PutOne(int id, string name, string description) {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest($"/Department/{id}", Method.Put);
            var body = new DepartmentModel { Id = id, Name = name, Description = description };
            request.AddBody(body);

            var response = client.ExecutePut<DepartmentModel>(request);

            return response.Data;
        }
    }
}
