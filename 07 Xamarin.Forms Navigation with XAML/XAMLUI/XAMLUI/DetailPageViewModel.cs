using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using Xamarin.Forms;
using System.Collections.ObjectModel;

namespace XAMLUI.ViewModels
{
    public class DetailPageViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public DetailPageViewModel(string Note)
        {
            DismissPageCommand = new Command(async () =>
            {
                await Application.Current.MainPage.Navigation.PopModalAsync();
            });

            NoteText = Note;
        }

        string noteText;
        public string NoteText
        {
            get => noteText;
            set
            {
                noteText = value;
                var args = new PropertyChangedEventArgs(nameof(NoteText));
                PropertyChanged?.Invoke(this, args);
            }
        }

        public Command DismissPageCommand { get; }
    }
}
