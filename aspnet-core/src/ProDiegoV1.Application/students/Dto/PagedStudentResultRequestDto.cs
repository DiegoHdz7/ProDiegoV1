using Abp.Application.Services.Dto;

namespace ProDiegoV1.Students.Dto
{
    public class PagedStudentResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
        public bool? IsActive { get; set; }
    }
}

