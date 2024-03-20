using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using OrgaNice.ViewModel;
using System.Collections.ObjectModel;
namespace OrgaNice
{
    public partial class MainPage : ContentPage
    {
        string textoTarea;
        ObservableCollection<string> items;

        public MainPage(MainViewModel vm)
        {
            InitializeComponent();
            BindingContext = vm;
        }

        private void OnPickerSelectedIndexChanged(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            var selectedItem = picker.SelectedItem;

            // Aquí puedes realizar acciones basadas en la opción seleccionada
        }


    }


}
