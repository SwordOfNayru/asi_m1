#pragma checksum "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6f5ebb3b035973e01a632a46f90f94748812141d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Université.Pages.Notes.Pages_Notes_Edit), @"mvc.1.0.razor-page", @"/Pages/Notes/Edit.cshtml")]
namespace Université.Pages.Notes
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
#line 1 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\_ViewImports.cshtml"
using Université;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6f5ebb3b035973e01a632a46f90f94748812141d", @"/Pages/Notes/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7752ac16113b0856d751356f7cf50e2c078bf01", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Notes_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "id", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "ue", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "note", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 5 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Saisie des Notes - Choisisser l\'UE</h1> ");
#nullable restore
#line 9 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
                                       Write(Html.Raw(Model.Mode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n");
#nullable restore
#line 13 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
         switch(Model.Mode)
        {
            case EditModel.NoteMode.UeChoice :

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f5ebb3b035973e01a632a46f90f94748812141d5888", async() => {
                WriteLiteral("\r\n            \r\n                    <div class=\"form-group\">\r\n                        <label class=\"control-label\">Nom UE</label>\r\n                        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("select", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f5ebb3b035973e01a632a46f90f94748812141d6309", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.SelectTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Name = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 20 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items = ViewBag.LUEID;

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-items", __Microsoft_AspNetCore_Mvc_TagHelpers_SelectTagHelper.Items, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                        <span  class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" value=""Charger les notes de cette UE"" class=""btn btn-primary"" />
                    </div>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 27 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
                break;
            case EditModel.NoteMode.List :

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6f5ebb3b035973e01a632a46f90f94748812141d10008", async() => {
                WriteLiteral("\r\n                    <input name=\"UEID\" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1073, "\"", 1093, 1);
#nullable restore
#line 30 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
WriteAttributeValue("", 1081, Model.UE.ID, 1081, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 31 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
                     if (Model.Errors.Count > 0)
                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                        <div class=\"alert alert-danger\">\r\n                            <div class=\"text-danger\">Erreur :</div>\r\n                            <ul>\r\n");
#nullable restore
#line 36 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
                                 foreach (var error in Model.Errors)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <li>");
#nullable restore
#line 38 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
                                   Write(error);

#line default
#line hidden
#nullable disable
                WriteLiteral("</li>\r\n");
#nullable restore
#line 39 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
                                }

#line default
#line hidden
#nullable disable
                WriteLiteral("                            </ul>\r\n                    </div>\r\n");
#nullable restore
#line 42 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
                    }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                    <div class=""form-group"">
                        <input type=""submit"" value=""Enregistrer les notes de cette UE"" class=""btn btn-primary"" />
                    </div>

                    <table class=""form-group"">
                        <thead>
                            <tr>
                                <th>
                                    Nom étudiant
                                </th>
                                <th>
                                    Note /20
                                </th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 59 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
                              int i = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
                             foreach(var etud in Model.UE.Formation.EtudiantsInscrits)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <tr>\r\n                                    <th>\r\n                                        ");
#nullable restore
#line 64 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
                                   Write(Html.Raw(etud.NomComplet));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                        <input");
                BeginWriteAttribute("name", " name=\"", 2624, "\"", 2665, 3);
                WriteAttributeValue("", 2631, "ListeEtud[", 2631, 10, true);
#nullable restore
#line 65 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
WriteAttributeValue("", 2641, Html.Raw(i), 2641, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 2653, "].EtudiantId", 2653, 12, true);
                EndWriteAttribute();
                WriteLiteral(" type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2680, "\"", 2696, 1);
#nullable restore
#line 65 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
WriteAttributeValue("", 2688, etud.ID, 2688, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" /> \r\n                                    </th>\r\n                                    <th>\r\n");
#nullable restore
#line 68 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
                                          
                                            Université.Entity.Note note = Model.Notes.FirstOrDefault(n => n.RelationEtudiant.LEtudiantID == etud.ID);

                                            if(note != null)
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 3160, "\"", 3201, 3);
                WriteAttributeValue("", 3167, "ListeEtud[", 3167, 10, true);
#nullable restore
#line 73 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
WriteAttributeValue("", 3177, Html.Raw(i), 3177, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3189, "].NoteValeur", 3189, 12, true);
                EndWriteAttribute();
                BeginWriteAttribute("value", " value=\"", 3202, "\"", 3222, 1);
#nullable restore
#line 73 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
WriteAttributeValue("", 3210, note.Valeur, 3210, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 74 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                <input type=\"text\"");
                BeginWriteAttribute("name", " name=\"", 3436, "\"", 3477, 3);
                WriteAttributeValue("", 3443, "ListeEtud[", 3443, 10, true);
#nullable restore
#line 77 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
WriteAttributeValue("", 3453, Html.Raw(i), 3453, 12, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 3465, "].NoteValeur", 3465, 12, true);
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 78 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
                                            }
                                        

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    </th>\r\n                                </tr>\r\n");
#nullable restore
#line 82 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
                                i++;
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </tbody>\r\n                    </table>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.PageHandler = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 87 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
                
            break;
            default: break;
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 95 "C:\Users\thesw\Documents\Projet\asi_m1\TD4\Université\Université\Pages\Notes\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Université.Pages.Notes.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Université.Pages.Notes.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Université.Pages.Notes.EditModel>)PageContext?.ViewData;
        public Université.Pages.Notes.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
