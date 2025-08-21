# How to show the snack bar at the bottom of list

This example demonstrates how to display the snackbar at the bottom of listview.

## Sample

```xaml
<syncfusion:SfListView x:Name="listView"
                ItemsSource="{Binding BookInfo}"
                ItemSize="100">
    <syncfusion:SfListView.ItemTemplate>
        <DataTemplate>
            <Grid>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto" />
                </Grid.RowDefinitions>
                ...
                ...
                    <Label Grid.Row="0" Grid.Column="0" Text="{Binding BookName}" 
                            HorizontalOptions="Center" VerticalOptions="Center"/>

                    <Button Grid.Column="1" Text="Show SnackBar" 
                            HorizontalOptions="Center" VerticalOptions="Center"
                            Command="{Binding Path=BindingContext.TapCommand, Source={x:Reference Name=listView}}"
                            CommandParameter="{x:Reference Name=listView}"/>
                </Grid>
            </Grid>
        </DataTemplate>
    </syncfusion:SfListView.ItemTemplate>
</syncfusion:SfListView>

ViewModel.cs
        private void buttonTapped(object obj)
        {
            var listview = obj as SfListView;
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
```

See [How to show the snack bar at the bottom of list](https://www.syncfusion.com/kb/9317/how-to-show-the-snack-bar-at-the-bottom-of-list) for more details.

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
