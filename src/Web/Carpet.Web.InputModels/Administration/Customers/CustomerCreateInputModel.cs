﻿namespace Carpet.Web.InputModels.Administration.Customers
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    using Carpet.Common.Constants;
    using Carpet.Data.Models;
    using Carpet.Services.Mapping;

    public class CustomerCreateInputModel : IMapTo<Customer>, IMapFrom<Customer>
    {
        [Required(ErrorMessage =CustomerConstants.ErrorFieldRequired)]
        [MinLength(CustomerConstants.FirstNameMinValue)]
        [Display(Name = CustomerConstants.DisplayNameFirstName)]
        public string FirstName { get; set; }

        [Display(Name = CustomerConstants.DisplayNameLastName)]
        public string LastName { get; set; }

        [NotMapped]
        public string FullName => string.Concat(this.FirstName != null ? this.FirstName + " " : string.Empty, this.LastName != null ? this.LastName : string.Empty).Trim();

        [Required]
        [Display(Name = CustomerConstants.DisplayNamePhoneNumber)]
        [RegularExpression(CustomerConstants.PhoneValidation)]
        public string PhoneNumber { get; set; }

        [Required]
        [Display(Name = CustomerConstants.DisplayNamePickUpAddress)]
        [MinLength(CustomerConstants.AddressMinLength)]
        public string PickUpAddress { get; set; }

        [Display(Name = CustomerConstants.DisplayNameDeliveryAddress)]
        public string DeliveryAddress { get; set; }
    }
}
