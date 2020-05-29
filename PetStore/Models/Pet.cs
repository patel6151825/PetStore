using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PetStore.Models
{
    public enum Breed
    {
        Dog, Cat, Fish, Hamster, Guinea, Pig
    }
    public class Pet
    {
        public int PetID { get; set; }

        [Required(ErrorMessage = "Please enter Name.")]
        [StringLength(10, ErrorMessage = "Name length can't be more than 10.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please select Date of Birth(DOB).")]
        public DateTime DOB { get; set; }

        public Breed Breed { get; set; }

        [Required(ErrorMessage = "Please provide OwnerID.")]
        public int OwnerID { get; set; }

        public Owner Owner { get; set; }
    }
}
