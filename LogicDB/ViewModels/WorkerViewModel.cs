using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicDB.ViewModels
{
    public class WorkerViewModel
    {
        [DisplayName("Идентификатор")]
        public int Id { get; set; }
        [DisplayName("ФИО сотрудника")]
        public string WorkerName { get; set; }
        [DisplayName("Изображение")]
        public byte[] Image { get; set; }
        [DisplayName("Тип товара")]
        public string SkillType { get; set; }
        [DisplayName("Номер телефона")]
        public string PhoneNumber { get; set; }
    }
}
