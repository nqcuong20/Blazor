#pragma checksum "C:\Users\Nguyen Quoc Cuong\source\repos\ToDo_SpaceTeam\ToDo_SpaceTeam\Components\TodoListItem.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b91f29e089612b03e513c4c831e4338b267d697f"
// <auto-generated/>
#pragma warning disable 1591
namespace ToDo_SpaceTeam.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Nguyen Quoc Cuong\source\repos\ToDo_SpaceTeam\ToDo_SpaceTeam\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Nguyen Quoc Cuong\source\repos\ToDo_SpaceTeam\ToDo_SpaceTeam\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Nguyen Quoc Cuong\source\repos\ToDo_SpaceTeam\ToDo_SpaceTeam\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Nguyen Quoc Cuong\source\repos\ToDo_SpaceTeam\ToDo_SpaceTeam\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Nguyen Quoc Cuong\source\repos\ToDo_SpaceTeam\ToDo_SpaceTeam\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Nguyen Quoc Cuong\source\repos\ToDo_SpaceTeam\ToDo_SpaceTeam\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Nguyen Quoc Cuong\source\repos\ToDo_SpaceTeam\ToDo_SpaceTeam\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Nguyen Quoc Cuong\source\repos\ToDo_SpaceTeam\ToDo_SpaceTeam\_Imports.razor"
using ToDo_SpaceTeam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Nguyen Quoc Cuong\source\repos\ToDo_SpaceTeam\ToDo_SpaceTeam\_Imports.razor"
using ToDo_SpaceTeam.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Nguyen Quoc Cuong\source\repos\ToDo_SpaceTeam\ToDo_SpaceTeam\Components\TodoListItem.razor"
using Data;

#line default
#line hidden
#nullable disable
    public partial class TodoListItem : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 3 "C:\Users\Nguyen Quoc Cuong\source\repos\ToDo_SpaceTeam\ToDo_SpaceTeam\Components\TodoListItem.razor"
 if (Item != null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(0, "    ");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "input-group mb-3");
            __builder.AddMarkupContent(3, "\r\n        ");
            __builder.AddMarkupContent(4, "<div class=\"input-group-prepend\">\r\n            <span class=\"input-group-text\">\r\n                <strong>Currently selected</strong>\r\n            </span>\r\n        </div>\r\n        ");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "readonly", true);
            __builder.AddAttribute(7, "type", "text");
            __builder.AddAttribute(8, "class", "form-control");
            __builder.AddAttribute(9, "placeholder", "Todo");
            __builder.AddAttribute(10, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\Nguyen Quoc Cuong\source\repos\ToDo_SpaceTeam\ToDo_SpaceTeam\Components\TodoListItem.razor"
                                           Item.Title

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Item.Title = __value, Item.Title));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n");
#nullable restore
#line 13 "C:\Users\Nguyen Quoc Cuong\source\repos\ToDo_SpaceTeam\ToDo_SpaceTeam\Components\TodoListItem.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 15 "C:\Users\Nguyen Quoc Cuong\source\repos\ToDo_SpaceTeam\ToDo_SpaceTeam\Components\TodoListItem.razor"
       
    [Parameter]
    public TodoItem Item { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
