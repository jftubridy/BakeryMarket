#pragma checksum "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00acfca5ba62ef1c07380b8226ab42d0a991fdd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Create), @"mvc.1.0.view", @"/Views/Courses/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Create.cshtml", typeof(AspNetCore.Views_Courses_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"00acfca5ba62ef1c07380b8226ab42d0a991fdd3", @"/Views/Courses/Create.cshtml")]
    public class Views_Courses_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Create.cshtml"
  
    Layout="_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(59, 26, true);
            WriteLiteral("\n<h4>Add new Course</h4>\n\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(118, 34, false);
#line 11 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(158, 36, false);
#line 12 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(196, 77, true);
            WriteLiteral("    <input type=\"submit\" value =\" Add new Course\" class =\"btn btn-default\"/>\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Create.cshtml"
}

#line default
#line hidden
            BeginContext(275, 4, true);
            WriteLiteral("<p> ");
            EndContext();
            BeginContext(280, 48, false);
#line 16 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Create.cshtml"
Write(Html.ActionLink("Show all the Courses", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(328, 4, true);
            WriteLiteral("</p>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Registrar.Models.Course> Html { get; private set; }
    }
}
#pragma warning restore 1591