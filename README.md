# How to show the snack bar at the bottom of list

This example demonstrates how to display the snackbar at the bottom of listview.

## Sample

```xaml
<syncfusion:SfListView x:Name="listView" SelectionMode="None"
                ItemsSource="{Binding BookInfo}"
                ItemSize="100">
    <syncfusion:SfListView.ItemTemplate>
        <DataTemplate>
            <Grid>
                <Grid.RowDefinitions>
                    <RowDefinition Height="Auto" />
                </Grid.RowDefinitions>
                <Grid BackgroundColor="#E6E6E6">
                    <Grid.ColumnDefinitions>
                        <ColumnDefinition Width="*" />
                        <ColumnDefinition Width="*" />
                    </Grid.ColumnDefinitions>
                    <Grid.RowDefinitions>
                        <RowDefinition Height="Auto"/>
                    </Grid.RowDefinitions>
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
```

See [How to show the snack bar at the bottom of list](https://www.syncfusion.com/kb/9317/how-to-show-the-snack-bar-at-the-bottom-of-list) for more details.

## Requirements to run the demo

* [Visual Studio 2017](https://visualstudio.microsoft.com/downloads/) or [Visual Studio for Mac](https://visualstudio.microsoft.com/vs/mac/).
* Xamarin add-ons for Visual Studio (available via the Visual Studio installer).

## Troubleshooting

### Path too long exception

If you are facing path too long exception when building this example project, close Visual Studio and rename the repository to short and build the project.
