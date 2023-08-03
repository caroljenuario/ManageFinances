using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Entitities
{
    public class ApplicationUser: IdentityUser
    {
        [Column("CPF")]
        public string CPF { get; set; }
    }
}
