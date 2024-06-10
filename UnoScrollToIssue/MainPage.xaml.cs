namespace UnoScrollToIssue;

public sealed partial class MainPage : Page
{
    public MainPage()
    {
        this.InitializeComponent();

        this.Loaded += (s, e) =>
        {
            this.primaryContent.ScrollTo(horizontalOffset: this.primaryContent.ScrollableWidth, verticalOffset: this.primaryContent.VerticalOffset);
        };
    }
}
