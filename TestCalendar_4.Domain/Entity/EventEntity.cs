namespace TestCalendar_4.Domain.Entity;

public class EventEntity
{
    public int Id { get; set; }
    
    public string Name { get; set; }

    public string? Notes { get; set; }

    public DateOnly? Date { get; set; }

    public TimeOnly? TimeStart { get; set; }

    public DateTime? Deadline { get; set; }

    public TimeSpan? Duration { get; set; }

    public string? Color { get; set; }

    public bool? Status { get; set; }
}