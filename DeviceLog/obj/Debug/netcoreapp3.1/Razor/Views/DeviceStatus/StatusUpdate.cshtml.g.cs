#pragma checksum "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\DeviceStatus\StatusUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "641e989670c41022cf37fb197dbf8ee25eaa8f7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DeviceStatus_StatusUpdate), @"mvc.1.0.view", @"/Views/DeviceStatus/StatusUpdate.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\_ViewImports.cshtml"
using DeviceLog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\_ViewImports.cshtml"
using DeviceLog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"641e989670c41022cf37fb197dbf8ee25eaa8f7a", @"/Views/DeviceStatus/StatusUpdate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68b08b6b7941f1134a1051989fdd785bce7c9ba3", @"/Views/_ViewImports.cshtml")]
    public class Views_DeviceStatus_StatusUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Inventory.Models.DeviceStatusUpdate>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "DeviceStatus", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\DeviceStatus\StatusUpdate.cshtml"
  
    ViewData["Title"] = "Device Status";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\DeviceStatus\StatusUpdate.cshtml"
 if (string.IsNullOrEmpty(Model.Error))
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""alert alert-success"">
        Status has been updated successfully
    </div>
    <h4 class=""mb-3"">New Status</h4>
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">Device Name</th>
                <th scope=""col"">Serial #</th>
                <th scope=""col"">Last Updated Date</th>
                <th scope=""col"">Device Owner</th>
                <th scope=""col"">Owner Team</th>
                <th scope=""col"">Status</th>
                <th scope=""col"">Loan Status</th>
                <th scope=""col"">Loaned Team</th>
            </tr>
        </thead>
        <tbody>
            <tr>
                <td>");
#nullable restore
#line 26 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\DeviceStatus\StatusUpdate.cshtml"
               Write(Model.Device.DeviceName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\DeviceStatus\StatusUpdate.cshtml"
               Write(Model.Device.SerialNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\DeviceStatus\StatusUpdate.cshtml"
               Write(Model.Device.LastUpdatedDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\DeviceStatus\StatusUpdate.cshtml"
               Write(Model.Device.DeviceOwner);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\DeviceStatus\StatusUpdate.cshtml"
               Write(Model.Device.OwnerTeam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 31 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\DeviceStatus\StatusUpdate.cshtml"
               Write(Model.Device.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 32 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\DeviceStatus\StatusUpdate.cshtml"
               Write(Model.Device.LoanStatus);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 33 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\DeviceStatus\StatusUpdate.cshtml"
               Write(Model.Device.LoanedTeam);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n        </tbody>\r\n    </table>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "641e989670c41022cf37fb197dbf8ee25eaa8f7a8157", async() => {
                WriteLiteral("Go back to your Team devices list");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-team", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 37 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\DeviceStatus\StatusUpdate.cshtml"
                                                                                      WriteLiteral(Model.Device.OwnerTeam);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["team"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-team", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["team"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 38 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\DeviceStatus\StatusUpdate.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"alert alert-danger\">\r\n        ");
#nullable restore
#line 42 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\DeviceStatus\StatusUpdate.cshtml"
   Write(Model.Error);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 44 "C:\Users\kannanganesan\OneDrive - Hewlett Packard Enterprise\Desktop\DeviceLog\DeviceLog\DeviceLog\Views\DeviceStatus\StatusUpdate.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Inventory.Models.DeviceStatusUpdate> Html { get; private set; }
    }
}
#pragma warning restore 1591