using AutoMapper;
using dotnet__rpg.Dtos.Character;
using dotnet__rpg.Models;

namespace dotnet__rpg
{
    public class AutoMapperProfile : Profile
    {
        
        public AutoMapperProfile()
        {
            CreateMap<Character, GetCharacterDTO>();
            CreateMap<AddCharacterDTO, Character>();
        }
    }
}