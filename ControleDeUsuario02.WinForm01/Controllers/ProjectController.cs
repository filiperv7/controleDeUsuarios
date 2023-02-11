using ControleDeUsuario02.WinForm01.Model;
using RestSharp;

namespace ControleDeUsuario02.WinForm01.Controllers {
    public class ProjectController {

        public static List<ProjectModel> GetAll() {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest("/Project", Method.Get);
            var response = client.ExecuteGet<List<ProjectModel>>(request);

            return response.Data;
        }

        public static ProjectModel GetById(int id) {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest($"/Project/{id}", Method.Get);
            var response = client.ExecuteGet<ProjectModel>(request);

            return response.Data;
        }

        public static List<ProjectModel> GetByName(string name) {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest($"/Project/{name}", Method.Get);
            var response = client.ExecuteGet<List<ProjectModel>>(request);

            return response.Data;
        }

        public static ProjectModel PostOne(ProjectModel project) {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest($"/Project", Method.Post);
            var body = new ProjectModel { Id = project.Id, Name = project.Name, Description = project.Description };
            request.AddBody(body);

            var response = client.ExecutePost<ProjectModel>(request);

            return response.Data;
        }

        public static ProjectModel PutOne(int id, string name, string description) {
            RestClient client = new RestClient("http://localhost:5291/api");

            var request = new RestRequest($"/Project/{id}", Method.Put);
            var body = new ProjectModel { Id = id, Name = name, Description = description };
            request.AddBody(body);

            var response = client.ExecutePut<ProjectModel>(request);

            return response.Data;
        }
    }
}
