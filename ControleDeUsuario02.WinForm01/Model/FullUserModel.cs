namespace ControleDeUsuario02.WinForm01.Model {
    public class FullUserModel {

        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public ProjectModel? Project { get; set; }
        public List<DepartmentModel>? Departments { get; set; }


    }
}
