﻿namespace CustomerApp.API.Dto.Responses
{
    public class CommonResponse <T>
    {
        public string? Message { get; set; }
        public int? StatusCode { get; set; }
        public T? Data { get; set; }
    }
}
