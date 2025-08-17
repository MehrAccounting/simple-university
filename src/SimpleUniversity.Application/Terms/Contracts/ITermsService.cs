namespace SimpleUniversity.Application.Terms.Contracts;
public interface ITermsService
{
    int Add(AddTermDto dto);
    void Update(int id, UpdateTermDto dto);
    void Delete(int id);
    GetTermDto GetById(int id);
    List<GetTermDto> GetAll();
}

