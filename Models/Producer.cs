﻿using System;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
	public class Producer
	{
        [Key]
        public int Id { get; set; }

        public string ProfielPictureURL { get; set; }

        public string FullName { get; set; }

        public string Bio { get; set; }

        //RelationShips

        public List<Movie> Movies { get; set; }
    }
}

