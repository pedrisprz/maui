
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Collections;
using System.Collections.ObjectModel;



namespace OrgaNice.ViewModel;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel() {
        Items = new ObservableCollection<string>();
    }

    [ObservableProperty]
    ObservableCollection<string> items;

    [ObservableProperty]
    string text;

    [RelayCommand]
    void Add()
    {
        if (string.IsNullOrEmpty(text))
            return;
        Items.Add(text);
        text = string.Empty;

    }
}

