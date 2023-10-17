using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Journal_App.Classes
{
    public class JournalEntry
    {
        public string Title { get; set; } = "";
        public string Entry { get; set; } = "";
        public DateTime DateWritten { get; set; } = DateTime.Now;
    }
}
