<<<<<<< HEAD
#pragma checksum "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad19155e8b97bc6e02d3f7e56082452f2a2a9e76"
=======
#pragma checksum "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a80cf23f6c21af9c9f27bbcc9e525514c34d04ea"
>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5
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
<<<<<<< HEAD
#line 1 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
=======
#line 1 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\_ViewImports.cshtml"
>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5
using Nhom11.QLQC;

#line default
#line hidden
#nullable disable
<<<<<<< HEAD
#nullable restore
#line 3 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
using System.Text.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad19155e8b97bc6e02d3f7e56082452f2a2a9e76", @"/Pages/DoiTac.cshtml")]
=======
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a80cf23f6c21af9c9f27bbcc9e525514c34d04ea", @"/Pages/DoiTac.cshtml")]
>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c31e6a444f522b33e1936fe7fc53ac62294f87d", @"/Pages/_ViewImports.cshtml")]
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
<<<<<<< HEAD
            WriteLiteral("\r\n");
#nullable restore
#line 6 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<script type=\"text/javascript\">\r\n    var dataKH = ");
#nullable restore
#line 8 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
            Write(Html.Raw(JsonSerializer.Serialize(Model.lst)));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n</script>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ad19155e8b97bc6e02d3f7e56082452f2a2a9e763980", async() => {
=======
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a80cf23f6c21af9c9f27bbcc9e525514c34d04ea3313", async() => {
>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5
                WriteLiteral(@"
    <div class=""row"">
        <div class=""col-3 form-group"">
            <label>    Mã khách hàng :    </label>
            <input type=""text"" id=""mn"" name=""mn"" class=""form-control"" />
        </div>
        <div class=""col-3 form-group"">
            <label style=""margin-left: 50px"">Tên khách hàng : </label>
            <input style=""margin-left: 50px"" type=""text"" id=""tn"" name=""tn"" class=""form-control"" />
        </div>
        <div class=""col-3 form-group"">
            <label style=""margin-left: 105px"">Giới tính : </label>
            <input style=""margin-left: 105px"" type=""text"" id=""mtn"" name=""mtn"" class=""form-control"" />
        </div>
        <div class=""col-3 form-group"">
            <label style=""margin-left: 105px"">Email : </label>
            <input style=""margin-left: 105px"" type=""text"" id=""mtn"" name=""mtn"" class=""form-control"" />
        </div>
        <div class=""col-3 form-group"">
            <br />
            <input style=""margin-top: 5px; margin-left: 165px"" type=""submit"" cl");
                WriteLiteral("ass=\"btn btn-primary\" value=\"Tìm kiếm\" />\r\n        </div>\r\n    </div>\r\n");
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
    <h2><b>Danh sách Khách hàng</b></h2>
</div>


<div>
    <table id=""tbKH"" class=""table table-success table-condensed"">
        <tr>
            <th>Mã khách hàng</th>
            <th>Tên khách hàng</th>
            <th>Giới tính</th>
            <th>Email</th>
           
        </tr>
");
#nullable restore
<<<<<<< HEAD
#line 51 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
         foreach (var c in Model.lst)
        {
=======
#line 28 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
 if (Request.Method.ToUpper() == "GET")
{
>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr");
            BeginWriteAttribute("id", " id=\"", 1758, "\"", 1775, 2);
            WriteAttributeValue("", 1763, "trKH_", 1763, 5, true);
#nullable restore
<<<<<<< HEAD
#line 53 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
WriteAttributeValue("", 1768, c.MaKH, 1768, 7, false);
=======
#line 44 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
}
else if(Request.Method.ToUpper() == "POST") {
>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td>");
#nullable restore
<<<<<<< HEAD
#line 54 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
           Write(c.MaKH);
=======
#line 54 "C:\Users\quoch\OneDrive\Máy tính\New folder (2)\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
}
>>>>>>> 66b4d91e6a008838e6cb84adf942a761692763b5

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 55 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
           Write(c.TenKH);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 56 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
           Write(c.GT);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 57 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
           Write(c.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1954, "\"", 1982, 3);
            WriteAttributeValue("", 1964, "openKH(\'", 1964, 8, true);
#nullable restore
#line 59 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
WriteAttributeValue("", 1972, c.MaKH, 1972, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1979, "\');", 1979, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary btn-sm\">Sửa</button>\r\n                <button type=\"button\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2074, "\"", 2104, 3);
            WriteAttributeValue("", 2084, "deleteKH(\'", 2084, 10, true);
#nullable restore
#line 60 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
WriteAttributeValue("", 2094, c.MaKH, 2094, 7, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2101, "\');", 2101, 3, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger btn-sm\">Xóa</button>\r\n            </td>\r\n         </tr>\r\n");
#nullable restore
#line 63 "E:\LTCSDL\QlQcao\QLQC.Nhom11\Nhom11.QLQC\Pages\DoiTac.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    </table>
</div>
<div id=""divModal"" class=""modal"" tabindex=""-1"" role=""dialog"">
    <div class=""modal-dialog modal-lg"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"">Sửa thông tin Khách hàng - <span id=""spanMaKH""></span></h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                <div class=""form-group"">
                    <label for=""txtMaKH"">Mã Khách Hàng</label>
                    <input type=""text"" class=""form-control"" id=""txtMaKH"" aria-describedby=""KHHelp"" placeholder=""Nhập mã Khách Hàng"">
                </div>
                <div class=""form-group"">
                    <label for=""txtTenKH"">Tên Khách Hàng</label>
                    <input type=""text"" class=""form-control"" id=""txtTenKH"" aria-describedby=""");
            WriteLiteral(@"TenKHHelp"" placeholder=""Nhập tên Khách Hàng"">
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
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
            </div>
        </div>
    </div>
</div>
<div>
    <button type=""button"" onclick=""openKH(null);"" class=""btn btn-outline-success"">Thêm mới</button>
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
