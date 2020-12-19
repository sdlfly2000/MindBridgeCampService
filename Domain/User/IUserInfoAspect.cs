﻿using Common.Core.AOP;
using Domain.LoginToken;

namespace Domain.User
{
    public interface IUserInfoAspect : ICacheAspect
    {
        OpenIdReference OpenId { get; set; }

        string NickName { get; set; }

        string AvatarUrl { get; set; }

        string Country { get; set; }

        string Province { get; set; }
        
        string City { get; set; }

        string Language { get; set; }
    }
}
