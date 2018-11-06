using System;
using System.IO;

namespace ProfileApi.DTOs
{
    public class ProfileDTO{
        public int userId{get;set;}
        public string email{get;set;}
        public string firstName{get;set;}
        public string lastName{get;set;}
        public string displayName{get;set;}
        public string description{get;set;}
        public string department{get;set;}
        public string team{get;set;}
    }
}