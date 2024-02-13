using BlazorAppRenderShenanigans.Client.Model;

namespace BlazorAppRenderShenanigans.Client.Pages;

public partial class Home
{
    TestParameterClass _TestParameter = new();

    void TestClick()
    {

    }

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
        Console.WriteLine($"{nameof(Home)} {nameof(OnAfterRender)}");
    }
}
