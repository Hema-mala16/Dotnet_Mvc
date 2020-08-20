using System;
using System.Collections.Generic;
using System.EnterpriseServices.Internal;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MovieCustomerMvcApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required]
        [StringLength(40)]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        [DataType(DataType.Date), DisplayFormat(DataFormatString = @"{0:dd\/MM\/yyyy}",
                ApplyFormatInEditMode = true)]
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; }
        public  int MembershipTypeId { get; set; }
        
    }
}