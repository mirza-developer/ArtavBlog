using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ArtavBlog.Business.Base;
using ArtavBlog.Resources;
using Microsoft.AspNetCore.Mvc;

namespace ArtavBlog.Controllers.Base
{
    public class ParentController : Controller
    {
        internal void AlertBgClass(MessageId id)
        {
            if (id == MessageId.Success)
            {
                ViewData["PassedMessage"] = TextResources.APP_STRINGKEYS_Message_Success;
                ViewData["BgClass"] = "success";
            }
            else if (id == MessageId.Failure || id == MessageId.LoginFailed)
            {
                ViewData["PassedMessage"] = TextResources.APP_STRINGKEYS_Message_Failure;
                ViewData["BgClass"] = "danger";
            }
            else if (id == MessageId.NodeCannotEdit)
            {
                ViewData["PassedMessage"] = TextResources.APP_STRINGKEYS_Message_NodeCannotEdit;
                ViewData["BgClass"] = "warning";
            }
            else
            {
                ViewData["PassedMessage"] = string.Empty;
                ViewData["BgClass"] = "hidden";
            }
        }
    }
}