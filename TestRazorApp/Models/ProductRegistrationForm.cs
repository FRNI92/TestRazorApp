﻿namespace TestRazorApp.Models;

public class ProductRegistrationForm
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public decimal Price { get; set; }
}
