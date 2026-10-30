
using System.Collections.Generic;
using ClinicAppointmentSystem.Models;

namespace ClinicAppointmentSystem.Data;

public static class ClinicData
{
    public static List<User> Users = new()
    {
        new User
        {
            Id = 1,
            FullName = "System Administrator",
            Username = "admin",
            Password = "1234",
            Role = UserRole.Staff
        },

        new User
        {
            Id = 2,
            FullName = "John Patient",
            Username = "patient",
            Password = "1234",
            Role = UserRole.Patient
        },

        new User
        {
            Id = 3,
            FullName = "Dr. Sarah",
            Username = "doctor",
            Password = "1234",
            Role = UserRole.Doctor
        }
    };
}
