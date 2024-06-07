public class Student
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty; // Initialized to empty string
    public string LastName { get; set; } = string.Empty;  // Initialized to empty string
    public int Age { get; set; }
    public DateTime DOB { get; set; }
    public string Gender { get; set; } = string.Empty;    // Initialized to empty string
    public string EmailId { get; set; } = string.Empty;   // Initialized to empty string
    public string PhoneNumber { get; set; } = string.Empty; // Initialized to empty string
    public List<Qualification> Qualifications { get; set; } = new List<Qualification>(); // Initialized list
}
