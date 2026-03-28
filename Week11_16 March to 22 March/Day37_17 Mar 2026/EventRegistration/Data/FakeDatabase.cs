using EventRegistration.Models;
namespace EventRegistration.Data
{
    public static class FakeDatabase
    {
        public static List<EventRegister> Registrations { get; set; } = new List<EventRegister>();
    }
}
