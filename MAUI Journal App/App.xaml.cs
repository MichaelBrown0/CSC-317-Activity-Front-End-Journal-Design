using MAUI_Journal_App.Classes;
using System.Collections.ObjectModel;

namespace MAUI_Journal_App;

public partial class App : Application
{
	public static ObservableCollection<JournalEntry> entries = new();
    public static ObservableCollection<Journal> journals = new();

    public App()
	{
		InitializeComponent();
		
		MainPage = new AppShell();

		JournalEntry e1 = new JournalEntry();
		e1.Title = "A Good Day";
		e1.DateWritten = DateTime.Now;
		e1.Entry = "I had a good day today!";


		JournalEntry e2 = new JournalEntry();
		e2.Title = "A Bad Day";
		e2.DateWritten = DateTime.Now;
		e2.Entry = "I had a bad day today.....";


		JournalEntry e3 = new JournalEntry();
		e3.Title = "I Saw a Bird";
		e3.DateWritten = DateTime.Now;
		e3.Entry = "I saw a bird.  It was pretty.";

		App.entries.Add(e1);
		App.entries.Add(e2);
		App.entries.Add(e3);

		for(int i = 0; i < 3; i++)
		{
			Journal j = new Journal();
			j.Name = $"Test Journal {i}";
			j.entries = App.entries;
			journals.Add(j);
		}
	}
}
