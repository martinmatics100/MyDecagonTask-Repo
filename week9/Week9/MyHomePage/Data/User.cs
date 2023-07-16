using System;
using System.Collections.Generic;
using MyHomePage.Models;

namespace MyHomePage.Data;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string Pwd { get; set; } = null!;

    public DateTime DateCreation { get; set; }
}
