using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Auctions.Models
{
    public class Listing
    {

        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public double price { get; set; }
        public string imagePath { get; set; }
        public bool isSold { get; set; }

        [Required]
        [ForeignKey("identityUserId")]
        public string? identityUserId{ get; set; }
        public IdentityUser? user { get; set; }
        
        public List<Bid>? bids { get; set; }
        public List<Comment>? comments { get; set; }

        



    
    }
}
