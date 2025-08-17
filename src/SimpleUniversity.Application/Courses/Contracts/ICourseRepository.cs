using SimpleUniversity.Domain;

namespace SimpleUniversity.Application.Courses.Contracts;

public interface ICourseRepository
{
    void Add(Course course);
    void Update(Course course);
    void Delete(Course course);
    Course? GetById(int id);
    List<Course> GetAll();
}
