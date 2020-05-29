using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models
{
    public class Owner
    {
        public int ID { get; set; }

        [Required(ErrorMessage = "Please enter FirstName.")]
        [StringLength(20, ErrorMessage = "FirstName length can't be more than 20.")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Please enter LastName.")]
        [StringLength(20, ErrorMessage = "LastName length can't be more than 20.")]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName => this.FirstName + " " + this.LastName;

        [Required(ErrorMessage = "Please enter Street.")]
        [StringLength(20, ErrorMessage = "Street length can't be more than 20.")]
        public string Street { get; set; }

        [Required(ErrorMessage = "Please enter City.")]
        [StringLength(20, ErrorMessage = "City length can't be more than 20.")]
        public string City { get; set; }

        [Required(ErrorMessage = "Please enter EmailAddress.")]
        [DataType(DataType.EmailAddress)]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter PhoneNumber.")]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        [Required(ErrorMessage = "Please enter Occupation.")]
        [StringLength(20, ErrorMessage = "Occupation length can't be more than 20.")]
        public string Occupation { get; set; }

        public ICollection<Pet> Pets { get; set; }
    }
}
