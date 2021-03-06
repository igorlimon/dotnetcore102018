﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using AgileHub102018.ValidationAtributes;

namespace AgileHub102018.Models.Puppets
{
    public class Dog
    {
        [StringLength(100)]
        public string Name { get; set; }

        public DateTime BirthDay { get; set; }

        public int Id { get; set; }

        public Address DogAddress { get; set; }

        [Vaccine(ErrorMessage = "asdadce")]
        public IList<string> Vaccines { get; set; }

        [CreditCard]
        public string CreditCard { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
