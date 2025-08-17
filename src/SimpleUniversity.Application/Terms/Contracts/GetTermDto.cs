namespace SimpleUniversity.Application.Terms.Contracts;

public class GetTermDto
{
    public int Id { get; set; }
    public string Title { get; set; }
    public bool IsActive { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }

}

