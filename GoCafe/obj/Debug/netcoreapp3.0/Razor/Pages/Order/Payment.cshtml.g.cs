#pragma checksum "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a234715c8381b5e6499f3c382590599e35290d4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(GoCafe.Pages.Order.Pages_Order_Payment), @"mvc.1.0.razor-page", @"/Pages/Order/Payment.cshtml")]
namespace GoCafe.Pages.Order
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
#line 1 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\_ViewImports.cshtml"
using GoCafe;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a234715c8381b5e6499f3c382590599e35290d4a", @"/Pages/Order/Payment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3cd6204b39989194ffca410752ac76a5e74a333a", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Order_Payment : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Update", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Order/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
  
    ViewData["Title"] = "Đặt món";
    Layout = "_Layout1";
    int flag=0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
 if(HttpContext.Session.GetString("UserRole")=="Nhân viên")
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Đặt món</h1>\r\n");
#nullable restore
#line 12 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
 foreach (var t in Model.objOrders)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
     if(t.SL!=0){
        flag=1;
        break;
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
     
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
 if(flag==1)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
           Write(Html.DisplayNameFor(model => model.Products[0].ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n             <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryIndexVM.Categorys[0].CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
           Write(Html.DisplayNameFor(model => model.Products[0].Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Số lượng\r\n            </th>\r\n            <th>\r\n                Thành tiền\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n\r\n");
#nullable restore
#line 44 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
 foreach (var item in Model.Products) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a234715c8381b5e6499f3c382590599e35290d4a8075", async() => {
                WriteLiteral("\r\n        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 48 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
           Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </td>\r\n");
#nullable restore
#line 50 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
             foreach (var cate in Model.CategoryIndexVM.Categorys)
            {
                if(item.CategoryId == cate.CategoryId)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 55 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
                   Write(Html.DisplayFor(modelItem => cate.CategoryName));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 57 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 60 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ\r\n            </td>            \r\n");
#nullable restore
#line 62 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
             foreach(var i in Model.objOrders)
            {
                int tmp = Convert.ToInt32(i.id);
                if (tmp == item.Id)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 68 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
                   Write(Html.DisplayFor(Model => i.SL));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n");
#nullable restore
#line 70 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 73 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
             foreach(var i in Model.objOrders)
            {
                int tmp = Convert.ToInt32(i.id);
                if (tmp == item.Id)
                {
                    float gia_pr = item.Price*i.SL;

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <td>\r\n                        ");
#nullable restore
#line 80 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
                   Write(gia_pr);

#line default
#line hidden
#nullable disable
                WriteLiteral(" VNĐ\r\n                    </td>\r\n");
#nullable restore
#line 82 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
                }
                
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("            <td>\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a234715c8381b5e6499f3c382590599e35290d4a11788", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 86 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 86 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
                                                   WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                <input type=\"submit\" value=\"Xoá sản phẩm\" class=\"btn btn-danger\">\r\n            </td>\r\n        </tr>\r\n    ");
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
            WriteLiteral("    \r\n");
#nullable restore
#line 91 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td></td>\r\n            <td></td>\r\n            <th>Tổng cộng: </th>\r\n");
#nullable restore
#line 96 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
              
                float gia = 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 99 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
             foreach (var item in Model.Products)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 101 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
                 foreach(var i in Model.objOrders)
                {
                    int tmp = Convert.ToInt32(i.id);
                    if (tmp == item.Id)
                    {
                        gia += item.Price*i.SL;
                    }
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 108 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
                 
            } 

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\r\n                ");
#nullable restore
#line 111 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
           Write(gia);

#line default
#line hidden
#nullable disable
            WriteLiteral(" VNĐ\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a234715c8381b5e6499f3c382590599e35290d4a17150", async() => {
                WriteLiteral("Tiếp theo&rsaquo;&rsaquo;");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </td>\r\n            \r\n        </tr>\r\n    </tbody>\r\n</table>\r\n");
#nullable restore
#line 120 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
}
else{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Không có sản phâm trong giỏ hàng</h3>\r\n");
#nullable restore
#line 123 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
}

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a234715c8381b5e6499f3c382590599e35290d4a18883", async() => {
                WriteLiteral("&lsaquo;&lsaquo;Trở lại");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 125 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
}
else
{
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Bạn không đủ yêu cầu</h1>\r\n");
#nullable restore
#line 130 "C:\Users\Admin\Desktop\cnpm\Quanly\GoCafe\Pages\Order\Payment.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GoCafe.Pages.Order.PaymentModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GoCafe.Pages.Order.PaymentModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<GoCafe.Pages.Order.PaymentModel>)PageContext?.ViewData;
        public GoCafe.Pages.Order.PaymentModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591