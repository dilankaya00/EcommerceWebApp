using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.IdentityModel.Tokens;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Claims;
using EcommerceWebApp.Database.Entity;

namespace EcommerceWebApp.Database.JWT
{
    public class JwtHelper : ITokenHelper
    {
        public IConfiguration Configuration { get; }
        private TokenOptions _tokenOptions;
        private DateTime _accessTokenExpiration;

        //public AccessToken CreateToken(User user, List<Role> operationClaims)
        //{
        //    _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
        //    var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
        //    var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
        //    var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);
        //    var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        //    var token = jwtSecurityTokenHandler.WriteToken(jwt);
        //    return (AccessToken)token;
        //}
        //public JwtHelper(IConfiguration configuration)
        //{
        //    Configuration = configuration;
        //    _tokenOptions = Configuration.GetSection("TokenOptions").Get<TokenOptions>();

        //}
        //public AccessToken CreateToken(User user, List<Role> operationClaims)
        //{
        //    _accessTokenExpiration = DateTime.Now.AddMinutes(_tokenOptions.AccessTokenExpiration);
        //    var securityKey = SecurityKeyHelper.CreateSecurityKey(_tokenOptions.SecurityKey);
        //    var signingCredentials = SigningCredentialsHelper.CreateSigningCredentials(securityKey);
        //    var jwt = CreateJwtSecurityToken(_tokenOptions, user, signingCredentials, operationClaims);
        //    var jwtSecurityTokenHandler = new JwtSecurityTokenHandler();
        //    var token = jwtSecurityTokenHandler.WriteToken(jwt);

        //    return new AccessToken
        //    {
        //        Token = token,
        //        Expiration = _accessTokenExpiration
        //    };

        //}

        public JwtSecurityToken CreateJwtSecurityToken(TokenOptions tokenOptions, User user,
            SigningCredentials signingCredentials, List<Role> operationClaims)
        {
            var jwt = new JwtSecurityToken(
                issuer: tokenOptions.Issuer,
                audience: tokenOptions.Audience,
                expires: _accessTokenExpiration,
                notBefore: DateTime.Now,
                claims: SetClaims(user, operationClaims),
                signingCredentials: signingCredentials
            );
            return jwt;
        }

        private IEnumerable<Claim> SetClaims(User user, List<Role> operationClaims)
        {
            var claims = new List<Claim>();
            //claims.AddNameIdentifier(user.Id.ToString());
            
            //claims.AddName($"{user.FirstName} {user.LastName}");
            //claims.AddRoles(operationClaims.Select(c => c.Name).ToArray());

            return claims;
        }

        public AccessToken CreateToken(User user, List<Role> operationClaims)
        {
            throw new NotImplementedException();
        }
    }
}
