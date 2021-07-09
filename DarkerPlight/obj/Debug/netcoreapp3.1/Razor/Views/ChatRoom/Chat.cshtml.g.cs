#pragma checksum "C:\Users\User\source\repos\DarkerPlight\DarkerPlight\Views\ChatRoom\Chat.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca5e5042e5fe44f20cadf63db32427adee3526d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ChatRoom_Chat), @"mvc.1.0.view", @"/Views/ChatRoom/Chat.cshtml")]
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
#line 1 "C:\Users\User\source\repos\DarkerPlight\DarkerPlight\Views\_ViewImports.cshtml"
using DarkerPlight;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\source\repos\DarkerPlight\DarkerPlight\Views\_ViewImports.cshtml"
using DarkerPlight.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca5e5042e5fe44f20cadf63db32427adee3526d3", @"/Views/ChatRoom/Chat.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eb0e5e547dcbdea922df9a246202bebaa7c80d1", @"/Views/_ViewImports.cshtml")]
    public class Views_ChatRoom_Chat : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/microsoft/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/chatHub.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\User\source\repos\DarkerPlight\DarkerPlight\Views\ChatRoom\Chat.cshtml"
  
    Layout = "_BasicLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    .contacts li:hover {
        background-color: rgba(0,0,0,0.3) !important;
    }

    .active {
        background-color: rgba(0,0,0,0.3);
    }

    #welcome {
        background-image: url(https://thumbs.dreamstime.com/b/washed-white-wood-texture-light-wooden-texture-background-washed-white-wood-texture-light-wooden-texture-background-woods-133034133.jpg) !important;
        background-repeat: no-repeat !important;
        background-size: cover !important;
    }

    .custom {
        font-family: 'Big Shoulders Stencil Display', cursive;
    }

    .custom2 {
        font-family: 'Bebas Neue', cursive;
    }

    #overlay {
        position: fixed;
        display: none;
        width: 100%;
        height: 100%;
        top: 0;
        left: 0;
        right: 0;
        bottom: 0;
        background-color: rgba(0, 0, 0, 0.74);
        z-index: 2;
        cursor: pointer;
    }

    ");
            WriteLiteral("@media (max-width: 1196px) {\r\n        .chat {\r\n            height: 300px !important;\r\n        }\r\n\r\n        .msg {\r\n            height: 300px !important;\r\n            margin-top: 400px;\r\n            margin-bottom: 630px;\r\n        }\r\n    }\r\n\r\n    ");
            WriteLiteral(@"@media (max-width: 454px) {
        .cip1 {
            max-height: 50px !important;
        }

        .msg {
            height: 50px !important;
            margin-top: 700px;
            margin-bottom: 630px;
        }

        .custom {
            font-size: 14px;
        }

        #titleMsg {
            font-size: 14px;
        }

        .conver {
            padding: 0;
        }
    }

    ");
            WriteLiteral(@"@media(max-width:414px) {
        .space {
            margin-top: 6000px;
        }
    }
</style>

<div id=""app"" class=""container-fluid h-200"">

    <!--profile overlay-->
    <div id=""overlay"" >
        <div class=""row h-100 justify-content-center align-items-center"">
            <div class=""col-md-8 col-lg-6 col-sm-12 mx-auto"">
                <div class=""card"">
                    <div class=""card-header bg-dark"">
                        <label style=""cursor:pointer;"" onclick=""off()"" class=""pull-right mr-5""><i class=""fa-2x fas fa-times text-warning""></i></label>
                        <span class=""custom text-white text-left pull-left"" style=""font-size:22px""><b>PROFILE PAGE</b></span>
                    </div>
                    <div v-if=""userDetails != null"" class=""card-body"" style=""background-size: cover; background-repeat: no-repeat; background-image: linear-gradient(to bottom, rgba(6, 0, 179, 0.47), rgba(17, 39, 55, 0.69)),url(https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9");
            WriteLiteral(@"GcTKh4VPJ0mff-JRAKJjtdZOBdBgllCZR1ZnHg&usqp=CAU);"">
                        <div class=""row"">
                            <div class=""col-md-6 col-sm-12"">
                                <div class=""form-group"">
                                    <label class=""text-warning""><small><b>USERNAME</b></small></label>
                                    <p class=""text-white"">{{userDetails.username}}</p>
                                </div>
                                <div class=""form-group"">
                                    <label class=""text-warning""><small><b>PASSWORD</b></small></label>
                                    <p class=""text-white"">{{userDetails.password}}</p>
                                </div>
                                <div class=""form-group"">
                                    <label class=""text-warning""><small><b>CURRENT CONNECTION ID</b></small></label>
                                    <p class=""text-white"">{{connectionId}}%</p>
                              ");
            WriteLiteral(@"  </div>
                                <div class=""form-group"">
                                    <label class=""text-warning""><small><b>STATUS</b></small></label>
                                    <p class=""text-white"">ONLINE <span class=""badge badge-success"">0</span></p>
                                </div>
                                <hr />
                                <div class=""form-group"">
                                    <label class=""text-warning""><small><b>ACCOUNT SPAN</b></small></label><br />
                                    <button v-on:click=""deleteAccount"" class=""btn btn-outline-danger""><i class=""fa fa-eraser""></i> Delete Account</button>
                                </div>
                            </div>
                            <div class=""col-md-6"">
                                <img  id=""OpenImgUpload"" class=""img-thumbnail order-0"" width=""100"" height=""100"" v-bind:src=""'data:image/jpeg;base64,'+ userDetails.userImage""/>
                            ");
            WriteLiteral("    <input ");
            WriteLiteral(@"@change=""onChangePhoto($event)"" accept="".jpg, .jpeg"" type=""file"" id=""imgupload"" name=""name"" value="""" />
                            </div>
                        </div>
                    </div>
                    <div class=""card-footer"">

                    </div>
                </div>
            </div>
        </div>
    </div>

    <!--UserName-->
    <input type=""text"" id=""username"" hidden name=""name""");
            BeginWriteAttribute("value", " value=\"", 5179, "\"", 5204, 1);
#nullable restore
#line 137 "C:\Users\User\source\repos\DarkerPlight\DarkerPlight\Views\ChatRoom\Chat.cshtml"
WriteAttributeValue("", 5187, ViewBag.Username, 5187, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

    <!--create dynamic titles-->
    <title v-if=""titleChange != null"">{{titleChange}}</title>
    <title v-else>Chat</title>
    <div id=""error"" v-if=""errorMessage != ''"" class=""alert alert-info alert-dismissible fade show"" style=""margin-top:10px;"" role=""alert"">
        <strong>Notice:</strong> {{errorMessage}}.
        <button type=""button"" class=""close"" data-dismiss=""alert"" aria-label=""Close"">
            <span aria-hidden=""true"">&times;</span>
        </button>
    </div>
    <div class=""row p-md-5 p-xl-5 p-sm-0 pt-2 conver"">
        <div class=""col-md-12 col-sm-12 col-xl-4 chat cip1"">
            <div class=""card mb-sm-3 mb-md-0 contacts_card"">
                <div class=""card-header"">
                    <div class=""input-group"">
                        <input type=""text"" placeholder=""Search...""");
            BeginWriteAttribute("name", " name=\"", 6038, "\"", 6045, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control search"">
                        <div class=""input-group-prepend"">
                            <span class=""input-group-text search_btn""><i class=""fas fa-search""></i></span>
                        </div>
                    </div>
                </div>
                <div class=""card-body contacts_body"">
                    <p class=""text-center text-white lip""> Welcome Anonymous <b> {{username}}</b></p>
                    <div v-if=""contactList.length == 0"">
                        <p class=""text-info text-center""><small><i>Hello there is no friend available for chat wait a while...</i></small></p>
                    </div>
                    <ui class=""contacts"">
                        <li v-on:click=""getConnectionString(contact.connection,contact.username)"" v-bind:class=""contact.class"" v-for=""contact in contactList"" style=""cursor:pointer"" id=""contactList"">
                            <div v-on:click=""getUsername(contact.username)"" id=""group"" class=""d-flex bd-highlig");
            WriteLiteral(@"ht"">
                                <div class=""img_cont"">
                                    <img v-bind:src=""contact.image"" class=""rounded-circle user_img"">
                                    <span v-if=""contact.online == true"" class=""online_icon online""></span>
                                    <span v-else class=""online_icon offline""></span>
                                </div>
                                <div class=""user_info"">
                                    <span id=""connectedUser"">{{contact.username}}</span>
                                    <p>{{contact.lastLogin}}</p>
                                </div>
                            </div>
                        </li>
                    </ui>
                </div>
                <div class=""card-footer""></div>
            </div>
        </div>

        <div class=""col-md-12 col-xl-8 chat col-sm-12 msg"">
            <div class=""card"">
                <div class=""card-header msg_head"">
                    <di");
            WriteLiteral(@"v class=""d-flex bd-highlight"">
                        <div class=""img_cont"">
                            <img src=""https://static.turbosquid.com/Preview/001292/481/WV/_D.jpg"" class=""rounded-circle user_img"">
                        </div>
                        <div class=""user_info"">
                            <span id=""titleMsg"">{{chatHeaderMsg}} {{staticUsername}}</span>
                            <p>1767 Messages</p>
                        </div>
                        <div class=""video_cam"">
                            <span id=""action_menu_btn""><i class=""fas fa-ellipsis-v""></i></span>
                            <div class=""action_menu"">
                                <ul>
                                    <li onclick=""on()""><i class=""fas fa-user-circle""></i> View profile</li>
                                    <li><i class=""fas fa-users""></i> Add to close friends</li>
                                    <li><i class=""fas fa-plus""></i> Add to group</li>
                         ");
            WriteLiteral(@"           <li><i class=""fas fa-ban""></i> Block</li>
                                </ul>
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""card-body msg_card_body"" id=""chatMessages"">
                    <div v-if=""messageCount == 0"">
                        <h1 class=""text-center text-info custom2""><b>NO MESSAGE AVAILABLE</b></h1>
                    </div>
                </div>
                <!--<div v-if=""staticUser == null"" id=""welcome"" class=""card-body msg_card_body"">
                    <div class=""text-center"">
                        <i class=""fa-5x fas fa-users text-info""></i>-->
");
            WriteLiteral(@"                    <!--</div>
                </div>-->
                <div class=""card-footer"">
                    <div class=""input-group"">
                        <div class=""input-group-append"">
                            <span class=""input-group-text attach_btn""><i class=""fas fa-paperclip""></i></span>
                        </div>
                        <textarea v-on:keyup.enter=""sendMessage"" id=""message""");
            BeginWriteAttribute("name", " name=\"", 10659, "\"", 10666, 0);
            EndWriteAttribute();
            WriteLiteral(@" class=""form-control type_msg"" placeholder=""Type your message...""></textarea>
                        <div class=""input-group-append"">
                            <span class=""input-group-text send_btn"" v-on:click=""sendMessage""><i class=""fas fa-location-arrow""></i></span>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div class=""space"">
        <div v-on:click=""scrollUp"" style=""visibility:hidden; position:fixed; bottom:-10px; right:0"" class=""upper"">
            <button class=""btn btn-lg space"" style=""border-radius:40px; background-color:#fff; box-shadow:7px 7px 7px rgba(56, 56, 56, 0.19)""><i class=""fas fa-arrow-up""></i></button>
        </div>
        <div v-on:click=""scrollDown"" style=""visibility:hidden; position:fixed; bottom:-10px; right:0"" class=""down"">
            <button class=""btn btn-lg space"" style=""border-radius:40px; background-color:#fff; box-shadow:7px 7px 7px rgba(56, 56, 56, 0.19)""><i class=""fas fa");
            WriteLiteral(@"-arrow-down""></i></button>
        </div>
    </div>

</div>
<script>
    var $ = jQuery = require(""jquery"");
    require(""bootstrap-sass"");
    var bootbox = require('bootbox');
</script>
<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-MrcW6ZMFYlzcLA8Nl+NtUVF0sA7MsXsP1UyJoMp4YLEuNSfAP+JcXn/tWtIaxVXM"" crossorigin=""anonymous""></script>
<script src=""https://cdnjs.cloudflare.com/ajax/libs/bootbox.js/4.4.0/bootbox.min.js""></script>
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca5e5042e5fe44f20cadf63db32427adee3526d317476", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca5e5042e5fe44f20cadf63db32427adee3526d318516", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<script>
    function on() {
        document.getElementById(""overlay"").style.display = ""block"";
    }

    function off() {
        document.getElementById(""overlay"").style.display = ""none"";
        $('.action_menu').toggle();
    }
</script>
<script>
    $(document).scroll(function () {
        var value = $(document).scrollTop();/* <== here*/

        if (value >= 1000) {

        }
        else if (value >= 250) {
            $('.upper').css({ ""visibility"": ""visible"" });
            $('.down').css({ ""visibility"": ""hidden"" });
        }
        else {
            $('.down').css({ ""visibility"": ""visible"" });
            $('.upper').css({ ""visibility"": ""hidden"" });
        }
    });
</script>

");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca5e5042e5fe44f20cadf63db32427adee3526d320311", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
