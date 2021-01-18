using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyTestProgram.Pages.Model
{
    public class Transaction
    {
        //Оюьявление переменных (комент к операции, сумма операции, дата операции)

        public int ID { get; set; }
        [Display(Name = "Комментарий")]
        public string operationСomment { get; set; }

        [Column(TypeName = "double(18, 2)")]
        [Display(Name = "Сумма операции")]
        public double summaOperation { get; set; }
        
        [DataType(DataType.Date)]
        [Display(Name = "Дата операции")]
        public DateTime dateOperation { get; set; }

        //Создаем конструктор
        
        public Transaction()
        {

        }
    }
}
