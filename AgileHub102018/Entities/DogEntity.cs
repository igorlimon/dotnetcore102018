using System;
using System.ComponentModel.DataAnnotations;

namespace AgileHub102018.Entities
{
    public class DogEntity
    {
        [StringLength(100)]
        public string Name { get; set; }

        public DateTime BirthDay { get; set; }

        public int Id { get; set; }

        public AddressEntity DogAddress { get; set; }

        [CreditCard]
        public string CreditCard { get; set; }

        [EmailAddress]
        public string Email { get; set; }
    }
}
