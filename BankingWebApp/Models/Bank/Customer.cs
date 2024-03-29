﻿
namespace BankingWebApp.Models.Bank;

public class Customer
{
    [Key]
    public int CustomerId { get; set; }

    [Display(Name = "First Name")]
    [Required]
    public string? FirstName { get; set; }

    [Display(Name = "Last Name")]
    [Required]
    public string? LastName { get; set; }

    [Display(Name = "Email")]
    [Required(ErrorMessage = "Email cannot be empty")]
    [MaxLength(50, ErrorMessage = "Email cannot exceed 50 characters")]
    public string? EmailAddress { get; set; }

    [Display(Name = "Password")]
    [Required(ErrorMessage = "Password cannot be empty")]
    [MinLength(5, ErrorMessage = "Password needs to be minimum of 5 characters")]
    [MaxLength(50, ErrorMessage = "Password cannot exceed 50 characters")]
    public string? Password { get; set; }

    [Display(Name = "Phone number")]
    [Required(ErrorMessage = "Phone number cannot be empty")]
    [MaxLength(50, ErrorMessage = "Password cannot exceed 50 characters")]
    public string? Phonenum { get; set; }

    [Display(Name = "Street Address")]
    [Required(ErrorMessage = "Street Address cannot be empty")]
    [MaxLength(50, ErrorMessage = "Password cannot exceed 50 characters")]
    public string? StreetAddress { get; set; }

    [Display(Name = "Postcode")]
    [Required(ErrorMessage = "Postcode cannot be empty")]
    [MaxLength(50, ErrorMessage = "Password cannot exceed 50 characters")]
    public string? PostCode { get; set; }

    [Display(Name = "City")]
    [Required(ErrorMessage = "City cannot be empty")]
    [MaxLength(50, ErrorMessage = "Password cannot exceed 50 characters")]
    public string? City { get; set; }

    [Display(Name = "Date Registered")]
    public DateTime RegistrationDate { get; set; }

    public List<Account>? Accounts { get; set; } = new();

    [NotMapped]
    [Compare(nameof(Password), ErrorMessage = "Both passwords needs to be same")]
    [Required(ErrorMessage = "Confirm Password cannot be empty")]
    [MaxLength(50, ErrorMessage = "Password cannot exceed 50 characters")]
    public string? ConfirmPassword { get; set; }

    [NotMapped]
    public string FullName { get => $"{FirstName} {LastName}"; }

    [NotMapped]
    public string FullAddress { get => $"{StreetAddress}, {City}, {PostCode}"; }


    public Customer()
    {

    }

    public Customer(string? firstName, string? lastName, string? emailAddress, string? phonenum, string? streetAddress, string? postCode, string? city, DateTime registrationDate)
    {
        FirstName = firstName;
        LastName = lastName;
        EmailAddress = emailAddress;
        Phonenum = phonenum;
        StreetAddress = streetAddress;
        PostCode = postCode;
        City = city;
        RegistrationDate = registrationDate;
    }
}
