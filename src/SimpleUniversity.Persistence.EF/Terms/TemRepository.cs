using SimpleUniversity.Application.Terms.Contracts;
using SimpleUniversity.Domain;

namespace SimpleUniversity.Persistence.EF.Terms;

public class TemRepository : ITermRepository
{
    private readonly EFDbContext _context;

    public TemRepository(EFDbContext context)
    {
        _context = context;
    }

    public void Add(Term term)
    {
        _context.Terms.Add(term);
    }

    public void Delete(Term term)
    {
        _context.Terms.Remove(term);
    }

    public List<GetTermDto> GetAll()
    {
        return _context.Terms.Select(x => new GetTermDto
        {
            Id = x.Id,
            Title = x.Title,
            StartDate = x.StartDate,
            EndDate = x.EndDate,
            IsActive = x.IsActive,
        }).ToList();
    }

    public Term? GetById(int id)
    {
        return _context.Terms.Find(id);
    }

    public void Update(Term term)
    {
        _context.Terms.Update(term);
    }
}
