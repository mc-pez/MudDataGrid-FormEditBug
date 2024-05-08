using System.ComponentModel;

namespace BlazorWebAppDotNet8_Test3.Client.Models
{
    public class CounterViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;

        public int RecordId;
        public List<CounterItem> Items;

        public CounterViewModel()
        {
            Items =
            [
                new CounterItem() { Id = 1, Name = "Item 1", Description = "The First Item" },
                new CounterItem() { Id = 2, Name = "Item 2", Description = "The Second Item" },
                new CounterItem() { Id = 3, Name = "Item 3", Description = "The Third Item" },
                new CounterItem() { Id = 4, Name = "Item 4", Description = "The Fourth Item" },
            ];
        }
    }

    public class CounterItem
    {
        public CounterItem()
        {
            Name = string.Empty; Description = string.Empty;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
