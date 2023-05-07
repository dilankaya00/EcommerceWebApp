using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using EcommerceWebApp.Core.Entities.Model;
using EcommerceWebApp.Database.Entity;

namespace EcommerceWebApp.Database.JWT
{
    // ilgili user için claimleri içerecek bir token üretecek
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<Role> operationClaims);
    }
}
