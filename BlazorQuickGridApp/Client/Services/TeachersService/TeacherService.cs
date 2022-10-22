using System.Net.Http.Json;

namespace BlazorQuickGridApp.Client.Services.TeachersService
{
    public class TeacherServices : TeacherInterface
    {
        private readonly HttpClient _http;

        public TeacherServices(HttpClient http)
        {
           _http = http;
        }
        public List<Teacher> teachers { get ; set; } = new List<Teacher>();
        public List<School> schools { get; set; } = new List<School>();

        public Task<Teacher> GetOneTeacher(int id)
        {
            throw new NotImplementedException();
        }

        public Task GetSchool()
        {
            throw new NotImplementedException();
        }

        public async Task GetTeacher()
        {
            var result = await _http.GetFromJsonAsync<List<Teacher>>("api/Teacher");
            if(result != null)
                teachers = result;
        }
    }
}
