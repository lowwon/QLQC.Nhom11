#pragma checksum "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e328abd9c3b86d0d25e4728a74a9584fd0df1374"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nhom11.QLQC.Pages.Pages_LoaiQuangCao), @"mvc.1.0.razor-page", @"/Pages/LoaiQuangCao.cshtml")]
namespace Nhom11.QLQC.Pages
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
#line 1 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
using global::QLQC.DTO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e328abd9c3b86d0d25e4728a74a9584fd0df1374", @"/Pages/LoaiQuangCao.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c31e6a444f522b33e1936fe7fc53ac62294f87d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_LoaiQuangCao : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/QuangCaoVaLoaiQuangCao", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<script>\r\n    var dataLqc = ");
#nullable restore
#line 9 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
             Write(Html.Raw(JsonSerializer.Serialize(Model.lst)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e328abd9c3b86d0d25e4728a74a9584fd0df13745213", async() => {
                WriteLiteral(@"
<div class=""row"">
    <div class=""col-5 form-group"">
        <label>      Mã loại quảng cáo :    </label>
        <input type=""text""  id=""mlqc"" name=""mlqc"" class=""form-control"" />
    </div>
    <div class=""col-5 form-group"">
        <label>Hình thức quảng cáo : </label>
        <select  id=""ht"" name=""ht"" class=""form-control"">
            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e328abd9c3b86d0d25e4728a74a9584fd0df13745839", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 21 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
             foreach (var item in Model.lst2)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("               ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e328abd9c3b86d0d25e4728a74a9584fd0df13747297", async() => {
#nullable restore
#line 23 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                                          Write(item.HinhThuc);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 23 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                   WriteLiteral(item.HinhThuc);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("  \r\n");
#nullable restore
#line 24 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
            }              

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>          \r\n    </div>\r\n        \r\n    <div class=\"col-2 form-group\">\r\n            <br />\r\n            <input style=\"margin-top: 5px; margin-left: 70px\" type=\"submit\" class=\"btn btn-primary\" value=\"Tìm kiếm\"/>\r\n    </div>\r\n</div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<br />
<div class=""text-center"">
    <h2 style=""display: inline-block""><b>Danh sách loại quảng cáo</b></h2>
    <input style=""float: right"" onclick=""openModalLoaiQuangCaoAdd()"" type = ""button"" class=""btn btn-outline-success"" value=""Thêm mới""/>
        <div style=""text-align:left"" id=""divModalAdd"" class=""modal"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                <h5 class=""modal-title"">Quảng cáo - <span id=""spanid""></span></h5>
                <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                    <label>Mã loại : </label>
                    <input type=""text"" class=""form-control"" id=""txtmlqcA""/> 
                </div>
                <div class=""form-group"">
                    <label>Hình thức");
            WriteLiteral(@" : </label>
                    <input type=""text"" class=""form-control"" id=""txthtA""/> 
                </div>
                <div class=""form-group"">
                    <label>Mô tả</label>
                    <textarea rows=""5"" class=""form-control"" id=""txtmtA""></textarea>
                </div>
                <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary""  data-dismiss=""modal"">Close</button>
                <button type=""button"" onclick=""addLoaiQuangCao()"" class=""btn btn-primary"">Save changes</button>
                </div>
            </div>
        </div>
    </div>
</div>
    
");
#nullable restore
#line 67 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
 if (Request.Method.ToUpper() == "GET")
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table table-success table-condensed"">
    <tr style=""text-align:center"">
        <th>Mã loại quảng cáo</th>
        <th>Hình thức quảng cáo</th>
        <th>Mô tả</th>
        <th>Các dự án quảng cáo</th>
        <th >Tác vụ</th>
    </tr>
");
#nullable restore
#line 77 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
         foreach (LoaiQcDTO lqc in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"text-align:center\">\r\n                <td>");
#nullable restore
#line 80 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.MaLoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 81 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.HinhThuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 82 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 84 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                    foreach (var q in Model.lst1)
                  {
                        if(String.Compare(@q.MaLoai,@lqc.MaLoai) == 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                       Write(q.MaQc);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 89 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                        }
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e328abd9c3b86d0d25e4728a74a9584fd0df137415152", async() => {
                WriteLiteral("Chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                 <td>\r\n                    <button style=\"margin-bottom:5px\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3683, "\"", 3729, 3);
            WriteAttributeValue("", 3693, "openModalLoaiQuangCao(\'", 3693, 23, true);
#nullable restore
#line 94 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
WriteAttributeValue("", 3716, lqc.MaLoai, 3716, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3727, "\')", 3727, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-outline-primary\" >Sửa</button>                   \r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3852, "\"", 3895, 3);
            WriteAttributeValue("", 3862, "deleteLoaiQuangCao(\'", 3862, 20, true);
#nullable restore
#line 95 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
WriteAttributeValue("", 3882, lqc.MaLoai, 3882, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3893, "\')", 3893, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\" >Xoá</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 98 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    \r\n</table>\r\n");
#nullable restore
#line 101 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
}
else if(Request.Method.ToUpper() == "POST") {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table table-success table-condensed"">
    <tr style=""text-align:center"">
        <th>Mã loại quảng cáo</th>
        <th>Hình thức quảng cáo</th>
        <th>Mô tả</th>
        <th>Các dự án quảng cáo</th>
        <th>Tác vụ</th>
    </tr>     
");
#nullable restore
#line 111 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
     foreach (LoaiQcDTO lqc in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"text-align:center\">\r\n                <td>");
#nullable restore
#line 114 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.MaLoai);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 115 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.HinhThuc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 116 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
               Write(lqc.MoTa);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 118 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                    foreach (var q in Model.lst1)
                  {
                        if(String.Compare(@q.MaLoai,@lqc.MaLoai) == 0)
                        {
                            

#line default
#line hidden
#nullable disable
#nullable restore
#line 122 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                       Write(q.MaQc);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n");
#nullable restore
#line 123 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
                        }
                  }

#line default
#line hidden
#nullable disable
            WriteLiteral("                  ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e328abd9c3b86d0d25e4728a74a9584fd0df137420653", async() => {
                WriteLiteral("Chi tiết");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n                 <td>\r\n<button style=\"margin-bottom:5px\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4989, "\"", 5035, 3);
            WriteAttributeValue("", 4999, "openModalLoaiQuangCao(\'", 4999, 23, true);
#nullable restore
#line 128 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
WriteAttributeValue("", 5022, lqc.MaLoai, 5022, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5033, "\')", 5033, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-outline-primary\" >Sửa</button>                   \r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 5158, "\"", 5201, 3);
            WriteAttributeValue("", 5168, "deleteLoaiQuangCao(\'", 5168, 20, true);
#nullable restore
#line 129 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
WriteAttributeValue("", 5188, lqc.MaLoai, 5188, 11, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5199, "\')", 5199, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\" >Xoá</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 132 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
#nullable restore
#line 134 "C:\Users\ngoca\OneDrive\Desktop\TEST\QLQC.Nhom11\Nhom11.QLQC\Pages\LoaiQuangCao.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""text-align:left"" id=""divModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
    <div class=""modal-content"">
        <div class=""modal-header"">
        <h5 class=""modal-title"">Quảng cáo - <span id=""spanid""></span></h5>
        <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
        </div>
        <div class=""modal-body"">
        <div class=""form-group"">
            <label>Hình thức : </label>
            <input type=""text"" class=""form-control"" id=""txtht""/> 
        </div>
        <div class=""form-group"">
            <label>Mô tả</label>
            <textarea rows=""5"" class=""form-control"" id=""txtmt""></textarea>
        </div>
        <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-secondary""  data-dismiss=""modal"">Close</button>
        <button type=""button"" onclick=""saveLoaiQuangCao()"" class=""btn btn-primary"">Save changes</button>
        </div>
    </div>
    ");
            WriteLiteral("</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nhom11.QLQC.Pages.LoaiQuangCaoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.LoaiQuangCaoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.LoaiQuangCaoModel>)PageContext?.ViewData;
        public Nhom11.QLQC.Pages.LoaiQuangCaoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
