﻿
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using Element;
using System.Threading.Tasks;

namespace Element.ServerRender.Demo.Dialog
{
    public class TestContentBase:BDialogBase
    {
        [Parameter]
        public string Name { get; set; }
    }
}
