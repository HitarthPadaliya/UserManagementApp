using System.Threading.Tasks;
using UserManagementApp.Data;
using UserManagementApp.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System;

namespace UserManagementApp.Services
{
    /// <summary>
    /// Defines the business logic contract for managing User entities.
    /// </summary>
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAllUsersAsync();
        Task<User?> GetUserByIdAsync(int id);
        Task<User?> GetUserByEmailAsync(string email);
        Task<User> CreateUserAsync(UserDto userDto);
        Task UpdateUserAsync(int id, UserDto userDto);
        Task DeleteUserAsync(int id);
    }

    /// <summary>
    /// Data Transfer Object used by the service layer to pass minimal data, promoting clean separation from the domain model.
    /// </summary>
    public class UserDto
    {
        // Note: We intentionally exclude the 'Id' from the DTO to prevent accidental over-writing of IDs.
        [Required] public string FirstName { get; set; } = string.Empty;
        [Required] public string LastName { get; set; } = string.Empty;
        [Required] public string Email { get; set; } = string.Empty;
    }
}