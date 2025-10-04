using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Service.Authuser.Dto;

namespace Domain.Service.Authuser.Interfaces
{
    public interface IAuthUserService
    {
        Task<AuthUserDTO> LoginAsync(LoginRequestDTO loginRequest);
        Task<AuthUserDTO> SignupAsync(SignupRequestDTO signupRequest, string password);
        Task<AuthUserDTO> GetUserByIdAsync(Guid id);
        Task<bool> UpdateProfileAsync(AuthUserDTO updatedUser);
    }
}
