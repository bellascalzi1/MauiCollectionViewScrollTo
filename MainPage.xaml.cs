using CollectionViewScrollTo.ViewModel;

namespace CollectionViewScrollTo
{
    public partial class MainPage : ContentPage
    {
        private MainPageViewModel _viewModel;
        public MainPage(MainPageViewModel vm)
        {
            InitializeComponent();
            _viewModel = vm;

            BindingContext = _viewModel;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            // Should scroll to 100 but scrolls to 99 instead! Removing the header in the CollectionView
            // fixes this though.
            CollectionView.ScrollTo(_viewModel.Items.Count - 1);
        }
    }
}