namespace TiffinService.Models;

public class MenuItem
{
    public string Emoji   { get; set; } = string.Empty;
    public string Name    { get; set; } = string.Empty;
    public string Desc    { get; set; } = string.Empty;
    public string Price   { get; set; } = string.Empty;
    public string Per     { get; set; } = string.Empty;
    public string Tag     { get; set; } = string.Empty;
}

public class Testimonial
{
    public string Text   { get; set; } = string.Empty;
    public string Name   { get; set; } = string.Empty;
    public string Role   { get; set; } = string.Empty;
    public string Avatar { get; set; } = string.Empty;
    public string Color  { get; set; } = string.Empty;
}

public class HomeViewModel
{
    public List<MenuItem>    MenuItems    { get; set; } = new();
    public List<Testimonial> Testimonials { get; set; } = new();
    public string            WhatsAppUrl  { get; set; } = string.Empty;
}
