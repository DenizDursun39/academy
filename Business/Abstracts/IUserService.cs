﻿using Business.Requests.Users;
using Business.Responses.Users;
using Core.Utilities.Results;
using Entities.Concretes;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstracts
{
    public interface IUserService
    {
        IDataResult<List<ListUserResponse>> GetAll();
        IDataResult<User> Add(CreateUserRequest request);
        

    }
}
