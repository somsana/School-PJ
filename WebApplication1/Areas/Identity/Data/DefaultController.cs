using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespacespace School-PJ4.Areas.Identity.Data
    public class ApplicationUser : IdentityUser
{
    [PersonalData]
    [column(TypeName - "nvarchar(100)")]
    pulic string FirstName { get; set; }

    [PersonalData]
    [column(TypeName - "nvarchar(100)")]
    pulic string LastName { get; set; }



}