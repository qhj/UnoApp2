namespace UnoApp2.Presentation;

public sealed partial class SecondPage : Page
{
    public SecondPage()
    {
        this.DataContext<BindableSecondModel>((page, vm) => page
            .Background(ThemeResource.Get<Brush>("ApplicationPageBackgroundThemeBrush"))
            .Content(new Grid()
                .SafeArea(SafeArea.InsetMask.All)
                .Children(
                new NavigationBar()
                    .Content("Second Page")
                    .MainCommand(new AppBarButton()
                        .Icon(new BitmapIcon().UriSource(new Uri("ms-appx:///UnoApp2/Assets/Icons/back.png")))
                    ),
                new TextBlock()
                    .Text(() => vm.Entity.Name)
                    .HorizontalAlignment(HorizontalAlignment.Center)
                    .VerticalAlignment(VerticalAlignment.Center))));
    }
}

