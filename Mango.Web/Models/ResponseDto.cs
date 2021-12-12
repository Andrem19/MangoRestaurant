﻿namespace Mango.Web.Models
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; }
        public object? Result { get; set; }
        public string? DisplayMassage { get; set; }
        public List<string>? ErrorMessages { get; set; }
    }
}
