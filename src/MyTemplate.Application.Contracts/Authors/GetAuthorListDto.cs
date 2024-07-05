using Volo.Abp.Application.Dtos;

namespace MyTemplate.Authors;

public class GetAuthorListDto : PagedAndSortedResultRequestDto
{
    public string? Filter { get; set; }
}
