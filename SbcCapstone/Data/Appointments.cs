using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using MessagePack;
using Microsoft.AspNetCore.Identity;
using Microsoft.Build.Framework;
using Microsoft.EntityFrameworkCore;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;
using RequiredAttribute = System.ComponentModel.DataAnnotations.RequiredAttribute;

namespace SbcCapstone.Data
{
    [Keyless]
    public class Appointments 
    {
        
        public string? Name { get; set; }
        public string? Purpose { get; set; }
	    public DateTime Date { get; set; }
    }
}
