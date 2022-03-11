using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PlayersAngularProject.Models
{
    public class Player
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int ShirtNo { get; set; }
        public int Appearances { get; set; }
        public int Goals { get; set; }
        public PlayerPositions Position { get; set; }

        [NotMapped]
        public string PositionName => Position.ToString();

        [NotMapped]
        public decimal GoalsPerMatch => Math.Round((decimal)Goals / (decimal)Appearances, 2);
    }

    public enum PlayerPositions
    {
        Goalkeeper,
        Defender,
        Midfielder,
        Forward
    }
}
