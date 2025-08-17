using SimpleUniversity.Domain;

namespace SimpleUniversity.Application.Terms.Contracts;

public interface ITermRepository
{
    void Add(Term term);
    void Update(Term term);
    void Delete(Term term);
    Term? GetById(int id);
    List<GetTermDto> GetAll();
}
