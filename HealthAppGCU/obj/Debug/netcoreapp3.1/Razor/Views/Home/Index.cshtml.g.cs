#pragma checksum "C:\Users\Krasy\source\repos\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f323ebd6617e13344037ce26ecf8ca50f7aac0c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\Krasy\source\repos\HealthAppGCU\HealthAppGCU\Views\_ViewImports.cshtml"
using HealthAppGCU;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Krasy\source\repos\HealthAppGCU\HealthAppGCU\Views\_ViewImports.cshtml"
using HealthAppGCU.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f323ebd6617e13344037ce26ecf8ca50f7aac0c", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7da1098273bbaabc6bbfb53c2e674b104e7afc36", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HealthcareActivityViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Krasy\source\repos\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <h5 class=\"h5\" style=\"margin:8px\">");
#nullable restore
#line 7 "C:\Users\Krasy\source\repos\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
                                 Write(Model.Date.Value.ToShortDateString().TrimEnd(new char[] { '.', 'г'} ));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <hr />\r\n</div>\r\n<div class=\"row\" style=\"text-align:center; margin-top:60px\">\r\n    <div class=\"col-3\">\r\n        <h2 class=\"display-3\">Calories</h2>\r\n        <br />\r\n        <hr />\r\n        <h3 class=\"display-4\">");
#nullable restore
#line 15 "C:\Users\Krasy\source\repos\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
                          Write(Model.Calories);

#line default
#line hidden
#nullable disable
            WriteLiteral("kcal.</h3>\r\n    </div>\r\n    <div class=\"col-3\">\r\n        <h2 class=\"display-3\">Water Intake</h2>\r\n        <hr />\r\n        <h3 class=\"display-4\">");
#nullable restore
#line 20 "C:\Users\Krasy\source\repos\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
                          Write(Model.WaterIntake);

#line default
#line hidden
#nullable disable
            WriteLiteral("ml.</h3>\r\n    </div>\r\n    <div class=\"col-3\">\r\n        <h2 class=\"display-3\">Weight</h2>\r\n        <br />\r\n        <hr />\r\n        <h3 class=\"display-4\">");
#nullable restore
#line 26 "C:\Users\Krasy\source\repos\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
                          Write(Model.Weight);

#line default
#line hidden
#nullable disable
            WriteLiteral("kg.</h3>\r\n    </div>\r\n    <div class=\"col-3\">\r\n        <h2 class=\"display-3\">Hours Slept</h2>\r\n        <hr />\r\n        <h3 class=\"display-4\">");
#nullable restore
#line 31 "C:\Users\Krasy\source\repos\HealthAppGCU\HealthAppGCU\Views\Home\Index.cshtml"
                          Write(Model.HoursSlept);

#line default
#line hidden
#nullable disable
            WriteLiteral("h</h3>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HealthcareActivityViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
