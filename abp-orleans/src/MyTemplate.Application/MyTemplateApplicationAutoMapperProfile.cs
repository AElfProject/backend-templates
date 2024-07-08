using AutoMapper;
using MyTemplate.Authors;

namespace MyTemplate;

public class MyTemplateApplicationAutoMapperProfile : Profile
{
    public MyTemplateApplicationAutoMapperProfile()
    {
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
        
        //Example related, can be removed
        CreateMap<Author, AuthorDto>();

    }
}
