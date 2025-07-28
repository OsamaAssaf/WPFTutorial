using System.Collections.ObjectModel;
using WPFTutorial.Model;
using WPFTutorial.MVVM;

namespace WPFTutorial.ViewModel
{
    internal class MainWindowViewModel : ViewModelBase
    {
        public ObservableCollection<Item> Items { get; set; }

        public RelayCommand AddCommand => new(execute => { AddItem(); });
        public RelayCommand DeleteCommand => new(execute => { DeleteItem(); }, canExecute => { return SelectedItem != null; });
        public RelayCommand SaveCommand => new(execute => { Save(); }, canExecute => CanSave());
        public MainWindowViewModel()
        {
            Items = new ObservableCollection<Item>();

        }

        private Item selectedItem;

        public Item SelectedItem
        {
            get { return selectedItem; }
            set
            {
                selectedItem = value;
                OnPropertyChanged();

            }
        }

        private void AddItem()
        {
            Items.Add(new Item { Name = "New Item", SerialNumber = "XXXXXX", Quantity = 1 });
        }
        private void DeleteItem()
        {
            Items.Remove(SelectedItem);
        }
        private void Save()
        {
            // Save to File/DB
        }
        private bool CanSave()
        {
            return true;
        }


    }
}
