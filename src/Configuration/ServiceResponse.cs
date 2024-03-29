﻿namespace TrainingRestFullApi.src.Configuration
{
    public class ServiceResponse
    {
        public record class GeneralResponse(int Flag, string Message);
        public record class LoginResponse(int Flag, string? Token, string Message);
        public record class DynamicResponse(int Flag, string Message, dynamic Data);
    }
}
