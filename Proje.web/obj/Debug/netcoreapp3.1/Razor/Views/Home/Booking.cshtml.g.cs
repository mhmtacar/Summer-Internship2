#pragma checksum "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\Home\Booking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ac17b3b23ede050c92c8bb9568dca40bd152982"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Booking), @"mvc.1.0.view", @"/Views/Home/Booking.cshtml")]
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
#line 1 "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\_ViewImports.cshtml"
using Proje.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\_ViewImports.cshtml"
using Proje.web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\_ViewImports.cshtml"
using Proje.Domain;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ac17b3b23ede050c92c8bb9568dca40bd152982", @"/Views/Home/Booking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7424220cbd7133da57b2fe650005f3bc6500b97a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Booking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CompleteReservation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\n<html lang=\"tr\">\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ac17b3b23ede050c92c8bb9568dca40bd1529824194", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1, shrink-to-fit=no"">
    <title>Bootstrap User Management Data Table</title>
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/css?family=Roboto|Varela+Round"">
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css"">
    <link rel=""stylesheet"" href=""https://fonts.googleapis.com/icon?family=Material+Icons"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css"">
    <script src=""https://code.jquery.com/jquery-3.5.1.min.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js""></script>
    <script src=""https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js""></script>
    <style>
        body {
            color: #566787;
            background: #f5f5f5;
            font-family: 'Varela Round', sans-serif;
            font-size: 13px;
      ");
                WriteLiteral(@"  }

        .table-responsive {
            margin: 30px 0;
        }

        .table-wrapper {
            min-width: 1000px;
            background: #fff;
            padding: 20px 25px;
            border-radius: 3px;
            box-shadow: 0 1px 1px rgba(0,0,0,.05);
        }

        .table-title {
            padding-bottom: 15px;
            background: #299be4;
            color: #fff;
            padding: 16px 30px;
            margin: -20px -25px 10px;
            border-radius: 3px 3px 0 0;
        }

            .table-title h2 {
                margin: 5px 0 0;
                font-size: 24px;
            }

            .table-title .btn {
                color: #566787;
                float: right;
                font-size: 13px;
                background: #fff;
                border: none;
                min-width: 50px;
                border-radius: 2px;
                border: none;
                outline: none !important;
                margin-left: 10px;
            }

           ");
                WriteLiteral(@"     .table-title .btn:hover, .table-title .btn:focus {
                    color: #566787;
                    background: #f2f2f2;
                }

                .table-title .btn i {
                    float: left;
                    font-size: 21px;
                    margin-right: 5px;
                }

                .table-title .btn span {
                    float: left;
                    margin-top: 2px;
                }

        table.table tr th, table.table tr td {
            border-color: #e9e9e9;
            padding: 12px 15px;
            vertical-align: middle;
        }

            table.table tr th:first-child {
                /*    width: 60px;*/
            }

            table.table tr th:last-child {
                /*    width: 100px;*/
            }

        table.table-striped tbody tr:nth-of-type(odd) {
            background-color: #fcfcfc;
        }

        table.table-striped.table-hover tbody tr:hover {
            background: #f5f5f5;
        }

        table.ta");
                WriteLiteral(@"ble th i {
            font-size: 13px;
            margin: 0 5px;
            cursor: pointer;
        }

        table.table td:last-child i {
            opacity: 0.9;
            font-size: 22px;
            margin: 0 5px;
        }

        table.table td a {
            font-weight: bold;
            color: #566787;
            display: inline-block;
            text-decoration: none;
        }

            table.table td a:hover {
                color: #2196F3;
            }

            table.table td a.settings {
                color: #2196F3;
            }

            table.table td a.delete {
                color: #F44336;
            }

        table.table td i {
            font-size: 19px;
        }

        table.table .avatar {
            border-radius: 50%;
            vertical-align: middle;
            margin-right: 10px;
        }

        .status {
            font-size: 30px;
            margin: 2px 2px 0 0;
            display: inline-block;
            vertical-align: middle;
    ");
                WriteLiteral(@"        line-height: 10px;
        }

        .text-success {
            color: #10c469;
        }

        .text-info {
            color: #62c9e8;
        }

        .text-warning {
            color: #FFC107;
        }

        .text-danger {
            color: #ff5b5b;
        }

        .pagination {
            float: right;
            margin: 0 0 5px;
        }

            .pagination li a {
                border: none;
                font-size: 13px;
                min-width: 30px;
                min-height: 30px;
                color: #999;
                margin: 0 2px;
                line-height: 30px;
                border-radius: 2px !important;
                text-align: center;
                padding: 0 6px;
            }

                .pagination li a:hover {
                    color: #666;
                }

            .pagination li.active a, .pagination li.active a.page-link {
                background: #03A9F4;
            }

                .pagination li.active a:hover ");
                WriteLiteral(@"{
                    background: #0397d6;
                }

            .pagination li.disabled i {
                color: #ccc;
            }

            .pagination li i {
                font-size: 16px;
                padding-top: 6px
            }

        .hint-text {
            float: left;
            margin-top: 10px;
            font-size: 13px;
        }

        span {
            padding-right: 10px;
            border: 2px solid red;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ac17b3b23ede050c92c8bb9568dca40bd15298210963", async() => {
                WriteLiteral(@"
    <div class=""container-xl"">
        <div class=""table-responsive"">
            <div class=""table-wrapper"">
                <div class=""table-title"">
                    <div class=""row"">
                        <div class=""col-sm-5"">
                            <h2> <b>Hotel Reservation Details</b></h2>
                        </div>
");
                WriteLiteral("                    </div>\n                </div>\n                <table class=\"table table-striped table-hover\">\n                    <thead>\n                        <tr>\n                            <th>");
#nullable restore
#line 232 "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\Home\Booking.cshtml"
                           Write(Model.HotelName);

#line default
#line hidden
#nullable disable
                WriteLiteral(" Reservation Informations</th>\n                        </tr>\n                    </thead>\n                    <tbody>\n\n\n                        <tr><td>Hotel İsmi : ");
#nullable restore
#line 238 "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\Home\Booking.cshtml"
                                        Write(Model.HotelName);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td></tr>\n                        <tr>\n                            <td>Adult : ");
#nullable restore
#line 240 "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\Home\Booking.cshtml"
                                   Write(Model.Adult);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td>Night : ");
#nullable restore
#line 241 "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\Home\Booking.cshtml"
                                   Write(Model.Night);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                            <td>RoomType : ");
#nullable restore
#line 242 "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\Home\Booking.cshtml"
                                      Write(Model.Room);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\n                        </tr>\n                        <tr>\n                            <td>BeginDate : ");
#nullable restore
#line 245 "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\Home\Booking.cshtml"
                                       Write(Model.BeginDate);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\n                            <td>EndeDate : ");
#nullable restore
#line 246 "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\Home\Booking.cshtml"
                                      Write(Model.EndDate);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\n                        </tr>\n\n                        <tr>\n                            <td>Traveller Name :");
#nullable restore
#line 250 "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\Home\Booking.cshtml"
                                           Write(Model.TravallerName);

#line default
#line hidden
#nullable disable
                WriteLiteral("  </td>\n                            <td>Traveller LastName :");
#nullable restore
#line 251 "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\Home\Booking.cshtml"
                                               Write(Model.TravallerSurname);

#line default
#line hidden
#nullable disable
                WriteLiteral("  </td>\n                            <td>Traveller Mail : ");
#nullable restore
#line 252 "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\Home\Booking.cshtml"
                                            Write(Model.TravallerEmail);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td>\n                        </tr>\n                        <tr> <td>Total Price : ");
#nullable restore
#line 254 "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\Home\Booking.cshtml"
                                          Write(Model.TotalPrice);

#line default
#line hidden
#nullable disable
                WriteLiteral(" </td></tr>\n                        <tr><td>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ac17b3b23ede050c92c8bb9568dca40bd15298215482", async() => {
                    WriteLiteral("Complete Reservation");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-TransactionId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 255 "C:\Users\hp\Desktop\Proje (2)\Proje\Proje.web\Views\Home\Booking.cshtml"
                                                                                                       WriteLiteral(Model.TransactionId);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TransactionId"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-TransactionId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["TransactionId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(" </td></tr>\n\n\n                    </tbody>\n                </table>\n                <div></div>\n            </div>\n        </div>\n    </div>\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</html>\n\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591