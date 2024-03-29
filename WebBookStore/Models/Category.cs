﻿using System.ComponentModel.DataAnnotations;

namespace WebBookStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required, StringLength(50)] 
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}
