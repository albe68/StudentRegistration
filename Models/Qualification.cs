public class Qualification
{
    public int Id { get; set; }
    public int StudentId { get; set; }
    public string Name { get; set; } = string.Empty; // Initialized to empty string
    public Student? Student { get; set; } // Nullable
}
