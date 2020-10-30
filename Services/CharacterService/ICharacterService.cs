using System.Collections.Generic;
using System.Threading.Tasks;
using dotnet__rpg.Dtos.Character;
using dotnet__rpg.Models;

namespace dotnet__rpg.Services.CharacterService
{
    public interface ICharacterService
    {
         Task<ServiceResponse<List<GetCharacterDTO>>> GetAllCharacters();
         Task<ServiceResponse<GetCharacterDTO>> GetCharacterById(int id);
         Task<ServiceResponse<List<GetCharacterDTO>>> AddCharacter(AddCharacterDTO newChar);
         Task<ServiceResponse<GetCharacterDTO>> UpdateCharacter(UpdateCharacterDTO updatedCharacter);
         Task<ServiceResponse<List<GetCharacterDTO>>> DeleteCharacter(int id);

    }
}