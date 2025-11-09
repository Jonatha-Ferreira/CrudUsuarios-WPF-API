using System;

namespace CrudUsuarios.Application.DTOs;

public class UserDto
{
    public Guid Id { get; set; }
    public string Nome { get; set; } = "";
    public string Email { get; set; } = "";
    public string Telefone { get; set; } = "";
}