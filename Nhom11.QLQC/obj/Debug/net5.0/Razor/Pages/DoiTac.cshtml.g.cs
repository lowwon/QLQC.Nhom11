#pragma checksum "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57c77e206c5f6f60f436da2431929a79a783f36a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Nhom11.QLQC.Pages.Pages_DoiTac), @"mvc.1.0.razor-page", @"/Pages/DoiTac.cshtml")]
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
#line 1 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
using Nhom11.QLQC.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
using global::QLQC.DTO;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57c77e206c5f6f60f436da2431929a79a783f36a", @"/Pages/DoiTac.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b39bf525f09de2fceaa200944ecf09c0e81b8ae", @"/Pages/_ViewImports.cshtml")]
    public class Pages_DoiTac : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    var dataKH = ");
#nullable restore
#line 8 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
            Write(Html.Raw(JsonSerializer.Serialize(Model.lst)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</script>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57c77e206c5f6f60f436da2431929a79a783f36a4511", async() => {
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-5 form-group"">
            <label>     Mã khách hàng :    </label>
            <input type=""text"" id=""maKH"" name=""maKH"" class=""form-control"">  

        </div>
        <div class=""col-5 form-group"">
            <label>Họ Tên : </label>
            <input type=""text"" id=""tenKH"" name=""tenKH"" class=""form-control"">                
        </div>

        <div class=""col-2 form-group"">
            <br />
            <input style=""margin-top: 5px; margin-left: 70px"" type=""submit"" class=""btn btn-primary"" value=""Tìm kiếm"" />
        </div>
    </div>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
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
    <h2 style=""display: inline-block""><b>Danh sách Khách Hàng</b></h2>
    <input style=""float: right"" onclick=""openKH(null)"" type=""button"" class=""btn btn-outline-success"" value=""Thêm mới"" />
    <div style=""text-align:left"" id=""divModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
        <div class=""modal-dialog modal-lg"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"">Khách Hàng - <span id=""spanMaKH""></span></h5>
                    <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
                </div>
                <div class=""modal-body"">
                    <div class=""form-group"">
                        <label for=""txtMaKH"">Mã Khách Hàng</label>
                        <input type=""text"" class=""form-control"" id=""txtMaKH"" aria-describedby=""KHHelp"" placeholder=""Nhập mã Khách Hàng"">
                    </div>
        ");
            WriteLiteral(@"            <div class=""form-group"">
                        <label for=""txtTenKH"">Tên Khách Hàng</label>
                        <input type=""text"" class=""form-control"" id=""txtTenKH"" aria-describedby=""TenKHHelp"" placeholder=""Nhập tên Khách Hàng"">
                    </div>
                    <div class=""form-group"">
                        <label for=""txtGT"">Giới tính</label>
                        <input type=""text"" class=""form-control"" id=""txtGT"" aria-describedby=""GTHelp"" placeholder=""Nam"">
                    </div>
                    <div class=""form-group"">
                        <label for=""exampleInputEmail1"">Email</label>
                        <input type=""email"" class=""form-control"" id=""txtEmailKH"" aria-describedby=""EmailKHHelp"" placeholder=""Nhập email"">
                    </div>
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" onclick=""saveKH();"" class=""btn btn-primary"">Lưu thay đổi</button>
                    <button");
            WriteLiteral(" type=\"button\" class=\"btn btn-secondary\" data-dismiss=\"modal\">Close</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n</div>\r\n");
#nullable restore
#line 68 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
 if (Request.Method.ToUpper() == "GET")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-success table-condensed\">\r\n        <tr style=\"text-align:center\">\r\n            <th>Mã khách hàng</th>\r\n            <th>Họ Tên</th>\r\n            <th>Giới tính</th>\r\n            <th>Email</th>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 78 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
         foreach (KhachHangDTO c in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"text-align:center\">\r\n                <td>");
#nullable restore
#line 81 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
               Write(c.MaKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 82 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
               Write(c.TenKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 83 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
               Write(c.GT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 84 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
               Write(c.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>\r\n                    <button style=\"margin-bottom:5px\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3684, "\"", 3711, 3);
            WriteAttributeValue("", 3694, "openKH(\'", 3694, 8, true);
#nullable restore
#line 87 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
WriteAttributeValue("", 3702, c.MaKH, 3702, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3709, "\')", 3709, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-outline-primary\">Sửa</button>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 3814, "\"", 3843, 3);
            WriteAttributeValue("", 3824, "deleteKH(\'", 3824, 10, true);
#nullable restore
#line 88 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
WriteAttributeValue("", 3834, c.MaKH, 3834, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3841, "\')", 3841, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Xoá</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 91 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n");
#nullable restore
#line 94 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
}
else if (Request.Method.ToUpper() == "POST")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table table-success table-condensed\">\r\n        <tr style=\"text-align:center\">\r\n            <th>Mã khách hàng</th>\r\n            <th>Họ Tên</th>\r\n            <th>Giới tính</th>\r\n            <th>Email</th>\r\n        </tr>\r\n");
#nullable restore
#line 104 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
         foreach (KhachHangDTO c in Model.lst)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr style=\"text-align:center\">\r\n                <td>");
#nullable restore
#line 107 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
               Write(c.MaKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 108 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
               Write(c.TenKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 109 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
               Write(c.GT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 110 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
               Write(c.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n                    <button style=\"margin-bottom:5px\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4562, "\"", 4589, 3);
            WriteAttributeValue("", 4572, "openKH(\'", 4572, 8, true);
#nullable restore
#line 112 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
WriteAttributeValue("", 4580, c.MaKH, 4580, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4587, "\')", 4587, 2, true);
            EndWriteAttribute();
            WriteLiteral(" type=\"button\" class=\"btn btn-outline-primary\">Sửa</button>\r\n                    <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 4692, "\"", 4721, 3);
            WriteAttributeValue("", 4702, "deleteKH(\'", 4702, 10, true);
#nullable restore
#line 113 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
WriteAttributeValue("", 4712, c.MaKH, 4712, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4719, "\')", 4719, 2, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Xoá</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 116 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </table>\r\n");
#nullable restore
#line 118 "C:\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div style=""text-align:left"" id=""divModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Khách Hàng - <span id=""spanMaKH""></span></h5>
                <button type=""button"" class=""btn-close"" data-dismiss=""modal"" aria-label=""Close""></button>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
                    <label for=""txtMaKH"">Mã Khách Hàng</label>
                    <input type=""text"" class=""form-control"" id=""txtMaKH"" aria-describedby=""KHHelp"" placeholder=""Nhập mã Khách Hàng"">
                </div>
                <div class=""form-group"">
                    <label for=""txtTenKH"">Tên Khách Hàng</label>
                    <input type=""text"" class=""form-control"" id=""txtTenKH"" aria-describedby=""TenKHHelp"" placeholder=""Nhập tên Khách Hàng"">
                </div>
                ");
            WriteLiteral(@"<div class=""form-group"">
                    <label for=""txtGT"">Giới tính</label>
                    <input type=""text"" class=""form-control"" id=""txtGT"" aria-describedby=""GTHelp"" placeholder=""Nam"">
                </div>
                <div class=""form-group"">
                    <label for=""exampleInputEmail1"">Email</label>
                    <input type=""email"" class=""form-control"" id=""txtEmailKH"" aria-describedby=""EmailKHHelp"" placeholder=""Nhập email"">
                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                    <button type=""button"" onclick=""saveKH()"" class=""btn btn-primary"">Save changes</button>
                </div>
            </div>
        </div>
    </div>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Nhom11.QLQC.Pages.DoiTacModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.DoiTacModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Nhom11.QLQC.Pages.DoiTacModel>)PageContext?.ViewData;
        public Nhom11.QLQC.Pages.DoiTacModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
