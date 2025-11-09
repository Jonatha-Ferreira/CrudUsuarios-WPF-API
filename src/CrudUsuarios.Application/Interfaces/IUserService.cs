using CrudUsuarios.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CrudUsuarios.Application.Interfaces;

public interface IUserService
{
    Task<IEnumerable<UserDto>> GetAllAsync();
    Task<UserDto?> GetByIdAsync(Guid id);
    Task<UserDto> CreateAsync(UserDto user);
    Task<UserDto> UpdateAsync(UserDto user);
    Task<bool> DeleteAsync(Guid id);
}