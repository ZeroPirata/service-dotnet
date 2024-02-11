﻿using TrainingRestFullApi.src.DTOs;
using static TrainingRestFullApi.src.DTOs.ServiceResponse;

namespace TrainingRestFullApi.src.Interfaces
{
    public interface IUserAccount
    {
        Task<GeneralResponse> CreateAccount(UserDTO userDTO);
        Task<LoginResponse> LoginAccount(LoginDTO loginDTO);
    }
}