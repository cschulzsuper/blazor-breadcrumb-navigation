# Breadcrumb Navigation
A simple breadcrumb navigation component for your Blazor applications.

[![Build](https://img.shields.io/github/workflow/status/cschulzsuper/blazor-breadcrumb-navigation/Deploy%20Master)](https://github.com/cschulzsuper/blazor-breadcrumb-navigation/actions?query=workflow%3A"Deploy+Master")
[![Nuget](https://img.shields.io/github/v/release/cschulzsuper/blazor-breadcrumb-navigation?sort=semver)](https://github.com/cschulzsuper/blazor-breadcrumb-navigation/packages/)

## Getting Started
The package is available on [Nuget](https://www.nuget.org/packages/Supercode.Blazor.BreadcrumbNavigation).  

## Demo

A demo version is aviable on [GitHub Pages](https://cschulzsuper.github.io/blazor-breadcrumb-navigation).
:warning: The demo can include changes which have not yet been released.

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

Add a breadcrumb component to your project by usage of the `RootBreadcrumb` or `Breadcrumb` base class and an implementation of `Configure`.  
The *Link* of your breadcrumb is set throught the given `BreadcrumbBuilder`.

```csharp
public class IndexBreadcrumb : RootBreadcrumb
{
    public override void Configure(BreadcrumbBuilder builder)
        => builder.Link("Home", string.Empty);
}
```

### Set the created Breadcrumb on a Page

In order to set a breadcrumb you need to inject `IBreadcrumbService` as cascading parameter.  
Set a breadcrumb by calling `Set` with the type of your breadcrumb and a position.

```razor
@code {
    [CascadingParameter]
    private IBreadcrumbService BreadcrumbService { get; set; }

    protected override void OnAfterRender(bool _)
    {
        BreadcrumbService
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
- My buddy [@sschwarzrock](https://github.com/sschwarzrock) provided the [geranium leaf](https://github.com/cschulzsuper/blazor-breadcrumb-navigation/blob/master/src/Supercode.Blazor.BreadcrumbNavigation/icon.png) icon for the package.
