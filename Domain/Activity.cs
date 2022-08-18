namespace Domain;

public class Activity
{
    public Guid Id { get; set; }
    public string Title { get; set; } = default!;
    public DateTime Date { get; set; } =default!;
    public string Description { get; set; } = default!;
    public string Category { get; set; } = default!;
    public string City { get; set; }=default!;
    public string Venue { get; set; } = default!;
}