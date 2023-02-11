using ControleDeUsuario02.ConsoleAPI.Model;
using RestSharp;

namespace ControleDeUsuario02.ConsoleAPI.Controllers {
    public class UserController {

        public static List<UserModel> GetAll() {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest("/User", Method.Get);
            var response = client.ExecuteGet<List<UserModel>>(request);

            return response.Data;
        }

        public static FullUserModel GetUserCompleteById(int id) {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest($"/UserFull/{id}", Method.Get);
            var response = client.ExecuteGet<FullUserModel>(request);

            return response.Data;
        }

        public static UserModel GetById(int id) {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest($"/User/{id}", Method.Get);
            var response = client.ExecuteGet<UserModel>(request);

            return response.Data;
        }

        public static List<FullUserModel> GetByName(string name) {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest($"/User/{name}", Method.Get);
            var response = client.ExecuteGet<List<FullUserModel>>(request);

            return response.Data;
        }

        public static FullUserModel InsertFull(FullUserModel fullUser) {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest($"/UserFull", Method.Post);
            var body = new FullUserModel { FirstName = fullUser.FirstName, LastName = fullUser.LastName, Project = fullUser.Project, Departments = fullUser.Departments};
            request.AddBody(body);

            var response = client.ExecutePost<FullUserModel>(request);

            return response.Data;
        }

        public static FullUserModel PutOne(int id, string firstName, string lastName, ProjectModel project, List<DepartmentModel> departments) {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest($"/UserFull/{id}", Method.Put);
            var body = new FullUserModel {Id = id, FirstName = firstName, LastName = lastName, Project = project, Departments = departments };
            request.AddBody(body);

            var response = client.ExecutePut<FullUserModel>(request);

            return response.Data;
        }
    }
}
