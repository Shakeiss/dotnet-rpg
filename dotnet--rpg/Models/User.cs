using System.Collections.Generic;

namespace dotnet__rpg.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Username { get; set; }
        
        public byte[] PasswordHash { get; set; } 
        public byte[] PasswordSalt { get; set; }

        public List<Character> Characters { get; set; }

    }
}