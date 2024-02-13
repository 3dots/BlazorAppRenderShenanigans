using BlazorAppRenderShenanigans.Client.Model;
using BlazorAppRenderShenanigans.Client.Pages;
using Microsoft.AspNetCore.Components;
using System.Reflection.Metadata;

namespace BlazorAppRenderShenanigans.Client.Components;

public partial class TestComponent
{
    [Parameter, EditorRequired]
    public TestParameterClass MyParameter { get; set; } = null!;

    protected override void OnAfterRender(bool firstRender)
    {
        base.OnAfterRender(firstRender);
        Console.WriteLine($"{nameof(TestComponent)} {nameof(OnAfterRender)}");
    }
}
