using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArtavBlog.Business.Base
{
    public enum MessageId
    {
        NoAction,
        Success,
        Failure,
        NodeCannotEdit,
        LoginFailed
    }
}
