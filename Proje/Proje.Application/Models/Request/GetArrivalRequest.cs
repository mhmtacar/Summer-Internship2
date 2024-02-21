namespace Proje.web.Models
{
    public class GetArrivalRequest
    {
        public int ProductType { get; set; } = 2;
        public string Query { get; set; }
        public string Culture { get; set; } = "en-US";


    }
}
