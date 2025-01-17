using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WiseBlog.Shared.Models
{
    public class Secrets
    {
        static string JWTKEY = "4l+A8A7yOW6XkcGbt1QB0sDKo0WkbPQLXWeWriYz1UoYe4dO4YBcXvPZa6ndSNq51ySZicN6Z+5rpIBbHosnHA==";
        static string JWTISSUER = "https://yddfecvmzcdldeetsuhf.supabase.co/auth/v1";
        static string JWTAUDIENCE = "authenticated";

        static string SUPABASEURL = "https://bdckcdljccqeocjolagd.supabase.co";
        static string SUPABASEKEY = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6ImJkY2tjZGxqY2NxZW9jam9sYWdkIiwicm9sZSI6ImFub24iLCJpYXQiOjE3MzUxMzk1NzgsImV4cCI6MjA1MDcxNTU3OH0.LLxVdm3yrqCNZ7yF2heHflGkrEOWGoyekM5nf-sO32g";

        static string MONGODBURL = "mongodb+srv://AravindG:Aravind#4@blazordb.kdp3k.mongodb.net/?retryWrites=true&w=majority&appName=BlazorDB";
        static string MONGODBNAME = "WiseBlog";
        static string MONGOPROFILECOLL = "User Profile";

        public string GetJWTKEY()
        {
            return JWTKEY;
        }

        public string GetJWTISSUER() { return JWTISSUER; }
        public string GetJWTAUDIENCE() { return JWTAUDIENCE; }
        public string GetSUPABASEURL() {  return SUPABASEURL; }
        public string GetSUPABASEKEY() {  return SUPABASEKEY; }
        public string GetMONGODBURL() { return MONGODBURL; }
        public string GetMONGODBNAME() { return MONGODBNAME; }
        public string GetMONGOPROFILECOLL() { return MONGOPROFILECOLL; }
    }
}

