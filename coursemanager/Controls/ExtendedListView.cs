using System;
using System.Diagnostics;
using System.Windows.Input;
using Xamarin.Forms;

namespace coursemanager.Controls
{
    public class ExtendedListView : ListView
    {
        public static readonly BindableProperty ItemTapCommandProperty = BindableProperty.Create(
            nameof(ItemTapCommand),
            typeof(ICommand),
            typeof(ExtendedListView));


        public ICommand ItemTapCommand
        {
            get => (ICommand)GetValue(ItemTapCommandProperty);
            set => SetValue(ItemTapCommandProperty, value);
        }

        public ExtendedListView()
        {
            ItemTapped += OnItemTapped;
        }

        private void OnItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (ItemTapCommand?.CanExecute(e.Item) == true)
            {
                Debug.WriteLine("---> OnItemTapped");
                ItemTapCommand.Execute(e.Item);
            }
        }

    }
}
