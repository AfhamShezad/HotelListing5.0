using Newtonsoft.Json;

namespace HotelListing5._0.Models
{
    public class Error
    {

        public int StatusCode { get; set; }
        public string Message { get; set; }

        public override string ToString() => JsonConvert.SerializeObject(this);
    }
}
