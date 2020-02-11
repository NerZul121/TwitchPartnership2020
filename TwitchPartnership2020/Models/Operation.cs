using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TwitchPartnership2020.Models
{
    public enum OperationType
    {
        Refill,//Пополнение
        Enrollment,//Зачисление
        Withdraw,//Снятие
        Freeze,//Заморозка
        Unfreeze//Разморозка
    }
    public class Operation
    {
        public int ID { get; set; }
        public OperationType Type { get; set; }
        public string Description { get; set; }
        public int Summ { get; set; }
        public DateTime Date { get; set; }
        public int PurseID { get; set; }
        public Purse Purse { get; set; }
        public bool State { get; set; }

    }
}
