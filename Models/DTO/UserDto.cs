﻿using System;
namespace taskManagement.Models.DTO
{
	public class UserDto
	{
		public required string Username { get; set; }
		public string Email { get; set; }
		public required string Password { get; set; }
	}
}

