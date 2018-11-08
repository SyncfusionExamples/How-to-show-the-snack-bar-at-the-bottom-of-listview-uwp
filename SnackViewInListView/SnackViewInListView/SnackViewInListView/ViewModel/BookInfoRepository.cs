using Syncfusion.ListView.XForms;
using Syncfusion.XForms.PopupLayout;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SnackViewInListView
{
    public class BookInfoRepository :INotifyPropertyChanged
    {
        private ObservableCollection<BookInfo> bookInfo;
        private ICommand tapcommand;
        SfPopupLayout popupLayout;
        private double itemWidth;

        public event PropertyChangedEventHandler PropertyChanged;

        #region Properties

        public ICommand TapCommand
        {
            get { return tapcommand; }
            set { this.tapcommand = value; }
        }
        public double ItemWidth
        {
            get { return itemWidth; }
            set {
                itemWidth = value;
                OnPropertyChanged("ItemWidth");
            }
        }
        public ObservableCollection<BookInfo> BookInfo
        {
            get { return bookInfo; }
            set { this.bookInfo = value; }
        }

        #endregion

        #region Constructor

        public BookInfoRepository()
        {
            GenerateBookInfo();
        }

        #endregion


        #region Interface Member
        public void OnPropertyChanged(string name)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #endregion

        #region Properties

        internal void GenerateBookInfo()
        {
            TapCommand = new Command(buttonTapped);
            bookInfo = new ObservableCollection<BookInfo>();
            bookInfo.Add(new BookInfo() { BookName = "Oops", BookDescription = "Object-oriented programming is the de facto programming paradigm" });
            bookInfo.Add(new BookInfo() { BookName = "C# ", BookDescription = "Code Contracts provide a way to convey code assumptions" });
            bookInfo.Add(new BookInfo() { BookName = "DBMS", BookDescription = "You’ll learn several different approaches to applying machine learning" });
            bookInfo.Add(new BookInfo() { BookName = "Networks", BookDescription = "Neural networks are an exciting field of software development" });
            bookInfo.Add(new BookInfo() { BookName = "Android", BookDescription = "It is a powerful tool for editing code and serves for end-to-end programming" });
            bookInfo.Add(new BookInfo() { BookName = "Apps", BookDescription = "It is provides a useful overview of the Android application lifecycle" });
            bookInfo.Add(new BookInfo() { BookName = "Succinctly", BookDescription = "It is for developers looking to step into frightening world of iPhone" });
            bookInfo.Add(new BookInfo() { BookName = "Studio", BookDescription = "The new version of the widely-used integrated development environment" });
            bookInfo.Add(new BookInfo() { BookName = "Xamarin", BookDescription = "Its creates mappings from its C# classes and controls directly" });
            bookInfo.Add(new BookInfo() { BookName = "Windows", BookDescription = "Windows Store apps present a radical shift in Windows development" });
            bookInfo.Add(new BookInfo() { BookName = "Agile", BookDescription = "Learning new development processes can be difficult" });
            bookInfo.Add(new BookInfo() { BookName = "Assembly", BookDescription = "Assembly language is as close to writing machine code" });
            bookInfo.Add(new BookInfo() { BookName = "OS", BookDescription = "Cryptography is used throughout software to protect all kinds of information" });
            bookInfo.Add(new BookInfo() { BookName = "Framework", BookDescription = "Follow author Ricardo Peres as he introduces the newest development mode" });
            bookInfo.Add(new BookInfo() { BookName = "Localiz", BookDescription = "Learn to write applications that support different languages and cultures" });
        }

        private void buttonTapped(object obj)
        {
            var listview= obj as SfListView;
            popupLayout = new SfPopupLayout();
            popupLayout.PopupView.HeightRequest = 50;
            popupLayout.PopupView.WidthRequest = ItemWidth;
            popupLayout.PopupView.ContentTemplate = new DataTemplate(() =>
            {
                var grid = new Grid();
                grid.BackgroundColor = Color.Black;
                grid.Margin = 5;
                var label1 = new Label()
                {
                    Text = "SnackView",
                    TextColor=Color.White,
                    HorizontalOptions=LayoutOptions.Center,
                    VerticalOptions=LayoutOptions.Center
                };

                var button = new Button()
                {
                    Text = "Action",
                    TextColor = Color.Violet,
                    HorizontalOptions=LayoutOptions.EndAndExpand,
                    VerticalOptions=LayoutOptions.Center,
                    BackgroundColor=Color.Black,
                    BorderRadius=8
                };

                grid.Children.Add(label1,0,0);
                grid.Children.Add(button,1,0);
                return grid;

            });

            popupLayout.PopupView.ShowHeader = false;
            popupLayout.PopupView.ShowFooter = false;
            popupLayout.HeightRequest = 50;
            popupLayout.WidthRequest = 50;
            popupLayout.ShowRelativeToView(listview, RelativePosition.AlignBottom,0,-20);
        }

        #endregion
    }
}
