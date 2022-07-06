using AutoMapper;
using Object_to_Object_Mapping.ViewModel;
using Object_to_Object_Mapping.DTO;

namespace Object_to_Object_Mapping
{

    public abstract class AutoMapperBase
    {
        protected readonly IMapper _mapper;

        protected AutoMapperBase()
        {
            var configuration = new MapperConfiguration
                (
                mapper =>
                {
                    mapper.CreateMap<StudentViewModel, StudentDTO>();
                }
                );

            _mapper = configuration.CreateMapper();
        }
    }
}