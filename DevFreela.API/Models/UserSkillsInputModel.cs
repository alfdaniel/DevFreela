using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevFreela.API.Models
{
    public class UserSkillsInputModel
    {
        public int[] SkillIds { get; set; }
        public int UserId { get; set; }
    }
}