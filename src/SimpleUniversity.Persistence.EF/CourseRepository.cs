using SimpleUniversity.Application.Courses.Contracts;
using SimpleUniversity.Domain;

namespace SimpleUniversity.Persistence.EF;

public class CourseRepository : ICourseRepository
{
    private readonly EFDbContext _context;

    public CourseRepository(EFDbContext context)
    {
        _context = context;
    }

    public void Add(Course course)
    {
        _context.Courses.Add(course);
    }

    public void Delete(Course course)
    {
        _context.Courses.Remove(course);
    }

    public List<Course> GetAll()
    {
        return _context.Courses.ToList();
    }

    public Course? GetById(int id)
    {
        return _context.Courses.Find(id);
    }

    public void Update(Course course)
    {
        _context.Courses.Update(course);
    }
}
