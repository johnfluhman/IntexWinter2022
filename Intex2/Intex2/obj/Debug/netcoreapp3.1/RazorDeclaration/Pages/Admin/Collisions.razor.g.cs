// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Intex2.Pages.Admin
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
#nullable restore
#line 1 "/Users/yejinchoi/Projects/IntexWinter2022/Intex2/Intex2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yejinchoi/Projects/IntexWinter2022/Intex2/Intex2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Users/yejinchoi/Projects/IntexWinter2022/Intex2/Intex2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/yejinchoi/Projects/IntexWinter2022/Intex2/Intex2/Pages/Admin/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/yejinchoi/Projects/IntexWinter2022/Intex2/Intex2/Pages/Admin/_Imports.razor"
using Microsoft.EntityFrameworkCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/yejinchoi/Projects/IntexWinter2022/Intex2/Intex2/Pages/Admin/_Imports.razor"
using Intex2.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin/collisions")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/admin")]
    public partial class Collisions : OwningComponentBase<ICollisionRepository>
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 49 "/Users/yejinchoi/Projects/IntexWinter2022/Intex2/Intex2/Pages/Admin/Collisions.razor"
       
    public ICollisionRepository repo => Service;
    public IEnumerable<Collision> CollisionData { get; set; }

    protected async override Task OnInitializedAsync()
    {
        await UpdateData();
    }

    public async Task UpdateData()
    {
        CollisionData = await repo.Collisions.ToListAsync();
    }

    public string GetDetailsUrl(long id) => $"/admin/collisions/details/{id}";
    public string GetEditUrl(long id) => $"/admin/collisions/edit/{id}";

    public async Task RemoveCollision (Collision c)
    {
        repo.DeleteCollision(c);
        await UpdateData();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
