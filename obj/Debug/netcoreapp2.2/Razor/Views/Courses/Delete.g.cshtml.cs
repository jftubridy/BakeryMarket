#pragma checksum "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "70414d6339cc44555dfa4cbb58d1c79fc5fa3a48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Delete), @"mvc.1.0.view", @"/Views/Courses/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Courses/Delete.cshtml", typeof(AspNetCore.Views_Courses_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70414d6339cc44555dfa4cbb58d1c79fc5fa3a48", @"/Views/Courses/Delete.cshtml")]
    public class Views_Courses_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Registrar.Models.Course>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Delete.cshtml"
  
    Layout= "_Layout";

#line default
#line hidden
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(60, 48, true);
            WriteLiteral("\n<h2>Are you sure you want to delete this?</h2>\n");
            EndContext();
            BeginContext(109, 40, false);
#line 8 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Delete.cshtml"
Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(149, 2, true);
            WriteLiteral(": ");
            EndContext();
            BeginContext(152, 40, false);
#line 8 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Delete.cshtml"
                                      Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(192, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Delete.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(221, 47, true);
            WriteLiteral("    <input type =\"submit\" value=\"Delete\"    />\n");
            EndContext();
#line 12 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Delete.cshtml"

}

#line default
#line hidden
            BeginContext(272, 40, false);
#line 14 "/Users/Guest/Desktop/UniversityRegistrar/Views/Courses/Delete.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

#line default
#line hidden
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