using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auctions.Models
{
    public class Bid
    {

        public int id { get; set; }
        public double price { get; set; }

        [Required]
        [ForeignKey("identityUserId")]
        public string identityUserId { get; set; }
        public IdentityUser user { get; set; }
        
        [ForeignKey("listingId")]
        public int? listingId { get; set; }
        public  Listing? listing { get; set; }
    }
}
