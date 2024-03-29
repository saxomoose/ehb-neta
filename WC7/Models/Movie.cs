﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WC7.Models
{
    public class Movie
    {
        public Movie() { }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [StringLength(256)]
        public string Title { get; set; }

        [Range(0, 100)]
        public byte Ranking { get; set; }

        [StringLength(256)]
        public string DirectorName { get; set; }
    }
}
