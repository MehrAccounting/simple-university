using SimpleUniversity.Application.Contracts;
using SimpleUniversity.Application.Terms.Contracts;
using SimpleUniversity.Application.Terms.Contracts.Exceptions;
using SimpleUniversity.Domain;

namespace SimpleUniversity.Application.Terms;

public class TermService : ITermsService
{
    private readonly ITermRepository _repository;
    private readonly IUnitOfWork _unitOfWork;

    public TermService(ITermRepository repository, IUnitOfWork unitOfWork)
    {
        _repository = repository;
        _unitOfWork = unitOfWork;
    }

    public int Add(AddTermDto dto)
    {
        var term = new Term
        {
            Title = dto.Title,
            IsActive = dto.IsActive,
            StartDate = dto.StartDate,
            EndDate = dto.EndDate
        };
        _repository.Add(term);
        _unitOfWork.SaveChanges();
        return term.Id;
    }

    public void Delete(int id)
    {
        throw new NotImplementedException();
    }

    public List<GetTermDto> GetAll()
    {
        return _repository.GetAll();
    }

    public GetTermDto GetById(int id)
    {
        var term = _repository.GetById(id);
        if (term is null)
            throw new TermNotFoundException();

        return new GetTermDto
        {
            Id = term.Id,
            Title = term.Title,
            IsActive = term.IsActive,
            StartDate = term.StartDate,
            EndDate = term.EndDate
        };
    }

    public void Update(int id, UpdateTermDto dto)
    {
        var term = _repository.GetById(id);
        if (term is null)
            throw new TermNotFoundException();

        term.Title = dto.Title;
        term.IsActive = dto.IsActive;
        term.StartDate = dto.StartDate;
        term.EndDate = dto.EndDate;

        _repository.Update(term);
        _unitOfWork.SaveChanges();
    }

}
