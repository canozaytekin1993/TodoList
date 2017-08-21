using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList
{
    public class TodoItem
    {

        public Guid Id { get; set; } = Guid.NewGuid();
        public string GorevMetni { get; set; }
        public DateTime TamamlanmaTarihi { get; set; }
        public bool Tamamlandi { get; set; }
        public override string ToString()
        {
            if (!Tamamlandi)
                return GorevMetni;
            else
                return string.Format("({0}) {1}", TamamlanmaTarihi.ToShortDateString(), GorevMetni);
        }
    }
}
