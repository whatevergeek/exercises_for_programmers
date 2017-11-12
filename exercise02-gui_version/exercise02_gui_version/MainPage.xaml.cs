using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace exercise02_gui_version
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            EntryBox.TextChanged += EntryBox_TextChanged;
        }

        private void EntryBox_TextChanged(object sender, EventArgs e)
        {
            CountLabel.Text = EntryBox.Text.Length > 0 ?
                $"{EntryBox.Text} has {EntryBox.Text.Length} characters. " :
                "";
        }
    }
}
