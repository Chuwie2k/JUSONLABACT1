using System;
using System.ComponentModel.DataAnnotations;

public class Instructor
{
    public int Id { get; set; }

    [Required]
    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Required]
    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Display(Name = "Is Tenured")]
    public bool IsTenured { get; set; }

    public string Rank { get; set; }

    [Display(Name = "Hiring Date")]
    [DataType(DataType.Date)]
    public DateTime HiringDate { get; set; }
}
