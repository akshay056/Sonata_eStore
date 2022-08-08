using Microsoft.AspNetCore.Identity;

namespace Sonata_eStore.Models
{
        public class AppUser : IdentityUser
        {
                public string Occupation { get; set; }
        }
}
