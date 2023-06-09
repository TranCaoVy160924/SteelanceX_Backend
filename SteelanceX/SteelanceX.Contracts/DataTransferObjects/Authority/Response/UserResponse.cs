﻿namespace SteelanceX.Contracts.DataTransferObjects.Authority.Response;
public class UserResponse
{
    public int Id { get; set; }
    public string Username { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Gender { get; set; }
    public string Location { get; set; }
    public bool IsLoginFirstTime { get; set; }
    public DateTime Dob { get; set; }
    public string Email { get; set; }
    public bool IsPremium { get; set; }
    public string Role { get; set; }
}
