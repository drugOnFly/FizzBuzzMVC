﻿using System.Collections.Generic;

namespace FizzBuzzMVC.Models
{
    public class FizzBuzz
    {
        public int FizzValue { get; set; }
        public int BuzzValue { get; set; }
        public List<string> Result { get; set; } = new List<string>();
    }
}