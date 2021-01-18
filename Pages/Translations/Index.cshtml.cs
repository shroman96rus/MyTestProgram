using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MyTestProgram.Data;
using MyTestProgram.Pages.Model;

namespace MyTestProgram.Pages.Translations
{
    public class IndexModel : PageModel
    {
        private readonly MyTestProgram.Data.MyTestProgramContext _context;

        public double Sum { get; set; }

       

        public IndexModel(MyTestProgram.Data.MyTestProgramContext context)
        {
            _context = context;
        }

        public IList<Transaction> Transaction { get; set; }

        public async Task OnGetAsync()
        {
            Transaction = await _context.Transaction.ToListAsync();

            Sum = GetSumm();

           
        }

        public double GetSumm()
        {
            var sum = Transaction.Sum(i => i.summaOperation);
            return sum;
        }

        ////[HttpPost]
        //public  string IActionResult()
        //{
        //    var sum = Transaction.Sum(i => i.summaOperation);
        //    XDocument xdoc = new XDocument();
        //    XElement tables = new XElement("table");
        //    foreach (var item in Transaction)
        //    {
        //        XElement id = new XElement("Transaction");
        //        XAttribute dateNameAttr = new XAttribute("Date", item.dateOperation.ToString("dd.MMMM.yyyy"));
        //        XElement operationCountElem = new XElement("Summa", item.summaOperation.ToString());
        //        XElement operationNoteElem = new XElement("Comment", item.operationСomment);

        //        // добавляем атрибут и элементы в первый элемент
        //        id.Add(dateNameAttr);
        //        id.Add(operationCountElem);
        //        id.Add(operationNoteElem);
        //        tables.Add(id);
        //    }
        //    XElement balance = new XElement("Transaction");
        //    XAttribute balNameAttr = new XAttribute("Date", "Cумма заработанная на данный момент составляет:");
        //    XElement balEllement = new XElement("Summa", sum);
        //    balance.Add(balNameAttr);
        //    balance.Add(balEllement);
        //    tables.Add(balance);
        //    xdoc.Add(tables);

        //    xdoc.Save(@"C:\Users\User\Desktop\222\result\tabliza Data Base.xml");

        //    return "XML создан";
        //}
    }
}
