﻿using System;
using System.Collections.Generic;

namespace EmulairWEB.Models
{
    public partial class Game
    {
        public Game()
        {
            Achievements = new HashSet<Achievement>();
            Reviews = new HashSet<Review>();
            Stats = new HashSet<Stat>();
        }

        public Guid GameId { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public DateTime? ReleaseDate { get; set; }
        public bool? IsDeleted { get; set; }

        public virtual ICollection<Achievement> Achievements { get; set; }
        public virtual ICollection<Review> Reviews { get; set; }
        public virtual ICollection<Stat> Stats { get; set; }
    }
}
