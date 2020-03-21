﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace LessPaper.APIGateway.Models
{
    public class UserLoginRequest
    {
        [Required]
        [JsonPropertyName("email")]
        [ModelBinder(Name = "email")]
        public string Email { get; set; }

        [Required]
        [JsonPropertyName("password")]
        [ModelBinder(Name = "password")]
        public string Password { get; set; }
    }
}
