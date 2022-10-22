namespace BlazorQuickGridApp.Client.Services.TeachersService
{
    public interface TeacherInterface 
    {
        List<Teacher> teachers { get; set; }
        List<School> schools { get; set; }
        Task GetSchool();
        Task GetTeacher();
        Task<Teacher> GetOneTeacher(int id);

    }
}
