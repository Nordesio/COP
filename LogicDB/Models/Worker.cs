using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDB.Models
{
    public class Worker
    {
        public int Id { get; set; }
        [Required]
        public string WorkerName { get; set; }
        [Required]
        public byte[] Image { get; set; }
        [Required]
        public string SkillType { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
    }
}
