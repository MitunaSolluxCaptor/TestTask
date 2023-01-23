using Microsoft.AspNetCore.Http;

namespace TestTask.Models
{
    public class Rec
    {
        public string Phone { get; set; }
        public IFormCollection Files { get; set; }
    }
}
