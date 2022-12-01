using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDB.BindingModels
{
    public class WorkerBindingModel
    {
        public int? Id { get; set; }
        public string WorkerName { get; set; }
        public byte[] Image { get; set; }
        public string SkillType { get; set; }
        public string PhoneNumber { get; set; }
    }
}
