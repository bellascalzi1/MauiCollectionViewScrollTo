using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace CollectionViewScrollTo.ViewModel
{
    public class MainPageViewModel : ObservableObject
    {
        public ObservableCollection<int> Items { get; } = new(Enumerable.Range(1, 100));
        public MainPageViewModel() { }
    }
}
