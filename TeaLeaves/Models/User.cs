﻿namespace TeaLeaves.Models
{
    /// <summary>
    /// A class representing a User model
    /// </summary>
    public class User
    {
        public int UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }
        public bool IsContainUnread { get; set; }

        public string FullName
        {
            get { return $"{FirstName} {LastName}"; }
        }

        public Image ProfilePicture { get; set; }
        public string Blurb { get; set; }
        public DateTime? TimeStamp { get; set; }
    }
}
