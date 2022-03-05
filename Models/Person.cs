using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kadry.Models
{
    public class Person : IEntity
    {
        
        [Required,MinLength(3),MaxLength(20),DisplayName("Imię")]
        public string Name { get; set; }
        [Required,MinLength(3),MaxLength(50),DisplayName("Nazwisko")]
        public string Surname { get; set; }
        [Required,MinLength(2),MaxLength(70),DisplayName("Miasto")]
        public string City { get; set; }
        [Required, MinLength(2),MaxLength(50),DisplayName("Województwo")]
        public string Region { get; set; }
        [Required,MinLength(1),MaxLength(50),DisplayName("Ulica")]
        public string Street { get; set; }
        [Required,MinLength(1),MaxLength(10),DisplayName("Nr. domu")]
        public string Street_nr { get; set; }
        [MinLength(1),DisplayName("Mieszkanie")]
        public int? Local { get; set; }
        [Required,MinLength(6),MaxLength(6),DisplayName("Kod pocztowy")]
        public string Post_Code { get; set; }
        [Required,MinLength(11),MaxLength(11)]
        public string Pesel { get; set; }
        [Required,DisplayName("Data urodzenia"),DataType(DataType.Date)]
        public DateTime Birth_Date { get; set; }





    }
}