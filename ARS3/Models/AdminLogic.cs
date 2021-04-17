using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace ARS1.Models
{
    [Table("TblAdminLogin")]
    public class AdminLogic
    {
        [Key]
        public int AdminId { get; set; }
        [Required(ErrorMessage = "User Name Required")]
        [Display(Name = "User Name")]
        [MinLength(3, ErrorMessage = "Min 3 Characters Required"), MaxLength(10, ErrorMessage = "MAx 10 Charactors Allow")]
        public string AName { get; set; }

        [Required(ErrorMessage = "Password required")]
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [MinLength(5, ErrorMessage = "Min 5 Characters Required"), MaxLength(10, ErrorMessage = "MAx 10 Charactors Allow")]
        public string Password { get; set; }

    }
    [Table("TblUserAccount")]
    public class UserAccount
    {
        [Key]
        public int UserID { get; set; }

        [Display(Name = "First Name")]
        [Required(ErrorMessage = "First Name Required")]
        [MaxLength(40, ErrorMessage = "Max 40 char Allow"), MinLength(5, ErrorMessage = "Min 5 char req")]
        public string FirstName { get; set; }

        [Display(Name = "Last Name")]
        [Required(ErrorMessage = "Last Name Required")]
        [MaxLength(40, ErrorMessage = "Max 40 char Allow"), MinLength(5, ErrorMessage = "Min 5 char req")]
        public string LastName { get; set; }

        [Display(Name = "Email ")]
        [Required(ErrorMessage = "Email  Required")]
        [MaxLength(30, ErrorMessage = "Max 30 char Allow"), MinLength(5, ErrorMessage = "Min 5 char req")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password Required")]
        [MaxLength(20, ErrorMessage = "Max 20 char Allow"), MinLength(5, ErrorMessage = "Min 5 char req")]
        public string Password { get; set; }

        [Compare("Password", ErrorMessage = "Password not matched")]
        [MaxLength(20, ErrorMessage = "Max 30 char Allow"), MinLength(5, ErrorMessage = "Min 5 char req")]
        public string CPassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Age Required")]
        [Range(18, 125, ErrorMessage = "Min 18 years has to book the flight")]
        public string Age { get; set; }

        [Display(Name = "Phone No")]
        [Required(ErrorMessage = "phone No Required"), RegularExpression(@"^([0-9]{10})$", ErrorMessage = "Phone Number is not Valid")]
        [StringLength(10)]

        public string Phoneno { get; set; }

        [Display(Name = "NIC No")]
        [Required(ErrorMessage = "phone No Required"), RegularExpression(@"^([v][0-9]{11})$", ErrorMessage = "NIC is not Valid")]
        [StringLength(11)]
        public string NIC { get; set; }
    }

    public class AeroPlaneInfo
    {
        [Key]
        public int Planeid { get; set; }

        [Display(Name = "Aero Plan Name")]
        [Required(ErrorMessage = "Aero Plan Name Required")]
        [MaxLength(30, ErrorMessage = "Max 30 char Allow"), MinLength(3, ErrorMessage = "Min 3 char req")]
        public string APlaneName { get; set; }

        [Required(ErrorMessage = "Capacity Req")]
        [Display(Name = "Seating Capacity")]
        public int SeatingCapacity { get; set; }

        [Required(ErrorMessage = "Price Req")]
        public int Price { get; set; }
    }
    [Table("TblFlightBook")]
    public class FlightBooking
    {
        [Key]
        public int bid { get; set; }

        [Required(ErrorMessage = "From City Req")]
        [Display(Name = "From Capacity")]
        [StringLength(40, ErrorMessage = "Max 40 char allowed")]
        public String From { get; set; }

        [Display(Name = "Depature Date")]
        [DataType(DataType.Date)]
        public DateTime DDate { get; set; }

        [Display(Name = "Depature Time")]
        [StringLength(15)]
        public string DTime { get; set; }

        public int Planeid { get; set; }
        public virtual AeroPlaneInfo PlaneInfo { get; set; }

        [Display(Name = "Seat Type")]
        [StringLength(25)]
        public string SeatType { get; set; }
    }
}
