using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Lesson4LabB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_OnTextChanged(object sender, TextChangedEventArgs e)
        {
            Label.Text = e.NewTextValue;
        }

        private void Uppercase_Button_OnClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Editor.Text))
                Editor.Text = Editor.Text.ToUpper();

            if (!string.IsNullOrEmpty(Entry.Text))
            {
                Label.Text = Entry.Text.ToUpper();
                Entry.Text = Entry.Text.ToUpper();
            }
        }
        
        private void Lowercase_Button_OnClicked(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Editor.Text))
                Editor.Text = Editor.Text.ToLower();

            if (!string.IsNullOrEmpty(Entry.Text))
            {
                Label.Text = Entry.Text.ToLower();
                Entry.Text = Entry.Text.ToLower();
            }
        }
    }
}