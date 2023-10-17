namespace MAUI_Journal_App.Pages;

public partial class JournalList : ContentPage
{
	public JournalList()
	{
		InitializeComponent();
		lstJournalList.ItemsSource = App.journals;
	}
}