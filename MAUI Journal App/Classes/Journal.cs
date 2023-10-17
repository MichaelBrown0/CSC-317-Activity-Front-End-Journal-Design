using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUI_Journal_App.Classes
{
    public class Journal
    {
        public string Name { get; set; } = "";
        public ObservableCollection<JournalEntry> entries { get; set; } = new();
        public int EntryCount
        {
            get { return entries.Count; }
        }
    }
}
