using dotnet__rpg.Models;

namespace dotnet__rpg.Dtos.Character
{
    public class UpdateCharacterDTO
    {
        public int Id { get; set; }
        public string Name { get; set; } = "";
        public int MaxHp { get; set; } = 30;
        public int MaxMp { get; set; } = 20;
        public int Strength { get; set; } = 10;
        public int Intelligence { get; set; } = 8;
        public int Defense { get; set; } = 20;
        public RpgClass Class { get; set; } = RpgClass.Knight;

    }
}