﻿using System.ComponentModel.DataAnnotations;

namespace MottoUI.Api.DataAccessLayer
{
    public class Employee
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
