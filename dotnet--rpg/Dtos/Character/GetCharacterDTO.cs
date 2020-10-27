using dotnet__rpg.Models;

namespace dotnet__rpg.Dtos.Character
{
    public class GetCharacterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxHp { get; set; }
        public int MaxMp { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Defense { get; set; }
        public RpgClass Class { get; set; } = RpgClass.Knight;
    }
}