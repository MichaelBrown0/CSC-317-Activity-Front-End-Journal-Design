using MAUI_Journal_App.Classes;
using System.Collections.ObjectModel;

namespace MAUI_Journal_App.Pages;

public partial class OpenedJournal : ContentPage
{
	public OpenedJournal()
	{
		InitializeComponent();

        lstEntries.ItemsSource = App.entries;
    }
}