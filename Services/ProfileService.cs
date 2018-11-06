using System;
using System.IO;
using System.Collections.Generic;
using ProfileApi.DTOs;
using System.Threading.Tasks;
using System.Net.Http;

namespace ProfileApi.Services
{
    public interface IProfileApiClient{
        Task<List<Profile>> GetAllProfile();
    }
    public class ProfileService 
    {
        // public async Task<List<Profile>> GetAllProfile()
        // {
        //     using (HttpClient client = new HttpClient())
        //     {
        //         //Blah blah do everything here I want to do. 
        //         //var result = await client.GetAsync("/tweets");
 
        //         return new List<Profile>  { 
        //             new Profile {
        //                 email = "admin@gmail.com" 
        //             }
                    
        //             };
        //     }
        // }
    }
}