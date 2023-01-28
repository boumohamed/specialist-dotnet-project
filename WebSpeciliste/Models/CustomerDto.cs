namespace WebSpeciliste.Models
{
    public class CustomerDto
    {
        public string customerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }

        public List<OfferDto> offers { get; set; }


    }
}
