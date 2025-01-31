// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
using System;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using System.Text;
using Silk.NET.Core;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.Contexts;
using Silk.NET.Core.Loader;
using Silk.NET.WGL;
using Extension = Silk.NET.Core.Attributes.ExtensionAttribute;

#pragma warning disable 1591

namespace Silk.NET.WGL.Extensions.EXT
{
    [Extension("EXT_make_current_read")]
    public unsafe partial class ExtMakeCurrentRead : NativeExtension<WGL>
    {
        public const string ExtensionName = "EXT_make_current_read";
        [NativeApi(EntryPoint = "wglGetCurrentReadDCEXT", Convention = CallingConvention.Winapi)]
        public partial nint GetCurrentReadDC();

        [NativeApi(EntryPoint = "wglMakeContextCurrentEXT", Convention = CallingConvention.Winapi)]
        public partial Silk.NET.Core.Bool32 MakeContextCurrent([Flow(FlowDirection.In)] nint hDrawDC, [Flow(FlowDirection.In)] nint hReadDC, [Flow(FlowDirection.In)] nint hglrc);

        public ExtMakeCurrentRead(INativeContext ctx)
            : base(ctx)
        {
        }
    }
}

