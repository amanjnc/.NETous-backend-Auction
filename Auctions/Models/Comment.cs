using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Auctions.Models
{
    public class Comment
    {


        public int id { get; set; }
        public string content { get; set; }

        [Required]
        [ForeignKey("identityUserId")]
        public string? identityUserId { get; set; }
        public IdentityUser? user { get; set; }


        [ForeignKey("listingId")]
       public int? listingId { get; set; }
    public Listing? listing { get; set; }

    }
}
