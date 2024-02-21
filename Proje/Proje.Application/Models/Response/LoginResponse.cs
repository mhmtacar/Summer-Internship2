namespace Proje.web.Models
{
    public class LoginResponse
    {
        public class Root
        {
            public Body body { get; set; }
        }

        public class Body
        {
            public string token { get; set; }
        }
    }
}
