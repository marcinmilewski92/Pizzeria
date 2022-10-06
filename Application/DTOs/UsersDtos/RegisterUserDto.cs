using Application.DTOs.AddressDtos;
using Pizzeria.Domain.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.UsersDtos
{
    public class RegisterUserDto : LoginUserDto
    {
        [Required]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        public string LastName { get; set; } = string.Empty;

        [Required]
        public CreateAddressDto UserAddress { get; set; } = default!;
    }
}
