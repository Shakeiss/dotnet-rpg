using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using dotnet__rpg.Dtos.Character;
using dotnet__rpg.Models;
using dotnet__rpg.Services.CharacterService;
using Microsoft.AspNetCore.Mvc;

namespace dotnet__rpg.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CharacterController : ControllerBase
    {
        private static List<Character> characters = new List<Character> {
           /* new Character{Id = 1, Name = "Legolas"},
            new Character{Id = 2, Name = "Samwise"},
            new Character{Id = 3, Name = "Aragorn"},
            new Character{Id = 4}*/
        };
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllCharacters()
        {
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCharacter(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddCharacter(AddCharacterDTO newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCharacter(UpdateCharacterDTO newCharacter)
        {
            ServiceResponse<GetCharacterDTO> response = await _characterService.UpdateCharacter(newCharacter);
            if (response.Data == null)
            {
                return NotFound(response);
            }
            response.Message = "Character updated successfully!";
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacter(int id)
        {
            ServiceResponse<List<GetCharacterDTO>> response = await _characterService.DeleteCharacter(id);
            if(response.Data == null){
                return NotFound(response);
            }
            response.Message = "Character deleted.";

            return Ok(response);

        }
    }
}