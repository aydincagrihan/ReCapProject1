﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.Entities.Concrete;
using Core.Utilities.Results;
using Core.Utilities.Security.JWT;
using Entities.DTOs;

namespace Business.Abstract
{//test
	public interface IAuthService
	{
		IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);

		IDataResult<User> Login(UserForLoginDto userForLoginDto);

		IResult UserExists(string email);

		IDataResult<AccessToken> CreateAccessToken(User user);

		IResult IsAuthenticated(string userMail, List<string> requiredRoles);
	}
}