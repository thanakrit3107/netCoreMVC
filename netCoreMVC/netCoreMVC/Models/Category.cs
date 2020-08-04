﻿using System.ComponentModel.DataAnnotations;

namespace netCoreMVC.Model
{
    public partial class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }        
    }
}
