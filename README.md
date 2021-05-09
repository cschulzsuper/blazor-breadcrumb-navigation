# Blazor Breadcrumb Navigation
A simple breadcrumb navigation component for your Blazor applications.

[![Build](https://img.shields.io/github/workflow/status/cschulzsuper/blazor-breadcrumb-navigation/Deploy%20Master)](https://github.com/cschulzsuper/blazor-breadcrumb-navigation/actions?query=workflow%3A"Deploy+Master")
[![Nuget](https://img.shields.io/github/v/release/cschulzsuper/blazor-breadcrumb-navigation?sort=semver)](https://github.com/cschulzsuper/blazor-breadcrumb-navigation/packages/)

## Getting Started
Once the first release is ready it will be available on [Nuget](https://www.nuget.org/).  
You can download a preview version [here](https://github.com/cschulzsuper/blazor-breadcrumb-navigation/packages/).

## Usage

### Add Imports

Add the following lines to your *_Imports.razor*.

```razor
@using Supercode.Blazor.BreadcrumbNavigation
@using Supercode.Blazor.BreadcrumbNavigation.Services
```

### Add the CascadingBreadcrumbService

Add the `<CascadingBreadcrumbService />` as component to your *App.razor*.

```razor
<CascadingBreadcrumbService>
    <Router AppAssembly="@typeof(Program).Assembly">
        <Found Context="routeData">
            <RouteView RouteData="@routeData" DefaultLayout="@typeof(MainLayout)" />
        </Found>
        <NotFound>
            <LayoutView Layout="@typeof(MainLayout)">
                <p>Sorry, there's nothing at this address.</p>
            </LayoutView>
        </NotFound>
    </Router>
</CascadingBreadcrumbService>
```

### Create a Breadcrumb

Add a Breadcrumb Component to your project by usage of the `Breadcrumb` base class and the implementation of `ConfigureAsync`.  
The *URL* and the *Title* of your Breadcrumb are set throught the given `BreadcrumbBuilder`.

```csharp
public class IndexBreadcrumb : Breadcrumb
{
    public override Task ConfigureAsync(BreadcrumbBuilder builder)
    {
        builder.SetUrl(string.Empty);
        builder.SetTitle("Home");

        return Task.CompletedTask;
    }
}
```

### Set the created Breadcrumb on a Page

In order to set a Breadcrumb you need to inject `IBreadcrumbService` as cascading parameter.  
Set a Breadcrumb by calling `Set` with the type of your Breadcrumb and a position.

```razor
@code {
    [CascadingParameter]
    private IBreadcrumbService BreadcrumbService { get; set; }

    protected override void OnAfterRender(bool _)
    {
        BreadcrumbService
            .Clear()
            .Set<IndexBreadcrumb>();
    }
}
```

### Use BreadcrumbNavigation in MainLayout

Add the BreadcrumbNavigation component in your *MainLayout*.

```razor
<div class="main">
    <div class="top-row px-4">
        <BreadcrumbNavigation/>
    </div>

    <div class="content px-4">
        @Body
    </div>
</div>
```

## Acknowledgments
- A big resource was [@chrissainty](https://github.com/chrissainty)'s [Blazored Modal](https://github.com/Blazored/Modal) project, where I took most of my inspiration from.
