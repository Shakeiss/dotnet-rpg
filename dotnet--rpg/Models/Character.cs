namespace dotnet__rpg.Models
{
    public class Character
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MaxHp { get; set; }
        public int MaxMp { get; set; }
        public int Strength { get; set; }
        public int Intelligence { get; set; }
        public int Defense { get; set; }
        public RpgClass Class = RpgClass.Knight;
        public User User { get; set; }
    }
}