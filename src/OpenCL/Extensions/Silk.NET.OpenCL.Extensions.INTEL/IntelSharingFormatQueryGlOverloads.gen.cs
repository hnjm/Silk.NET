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

#pragma warning disable 1591

namespace Silk.NET.OpenCL.Extensions.INTEL
{
    public static class IntelSharingFormatQueryGlOverloads
    {
        public static unsafe int GetSupportedGltextureFormats(this IntelSharingFormatQueryGl thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* gl_formats, [Flow(FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedGltextureFormats(context, flags, image_type, num_entries, gl_formats, out num_texture_formats.GetPinnableReference());
        }

        public static unsafe int GetSupportedGltextureFormats(this IntelSharingFormatQueryGl thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> gl_formats, [Flow(FlowDirection.Out)] uint* num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedGltextureFormats(context, flags, image_type, num_entries, out gl_formats.GetPinnableReference(), num_texture_formats);
        }

        public static unsafe int GetSupportedGltextureFormats(this IntelSharingFormatQueryGl thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> gl_formats, [Flow(FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedGltextureFormats(context, flags, image_type, num_entries, out gl_formats.GetPinnableReference(), out num_texture_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedGltextureFormats(this IntelSharingFormatQueryGl thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* gl_formats, [Flow(FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedGltextureFormats(context, flags, image_type, num_entries, gl_formats, out num_texture_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedGltextureFormats(this IntelSharingFormatQueryGl thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> gl_formats, [Flow(FlowDirection.Out)] uint* num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedGltextureFormats(context, flags, image_type, num_entries, out gl_formats.GetPinnableReference(), num_texture_formats);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedGltextureFormats(this IntelSharingFormatQueryGl thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] MemFlags flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> gl_formats, [Flow(FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedGltextureFormats(context, flags, image_type, num_entries, out gl_formats.GetPinnableReference(), out num_texture_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedGltextureFormats(this IntelSharingFormatQueryGl thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* gl_formats, [Flow(FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedGltextureFormats(context, flags, image_type, num_entries, gl_formats, out num_texture_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedGltextureFormats(this IntelSharingFormatQueryGl thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> gl_formats, [Flow(FlowDirection.Out)] uint* num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedGltextureFormats(context, flags, image_type, num_entries, out gl_formats.GetPinnableReference(), num_texture_formats);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedGltextureFormats(this IntelSharingFormatQueryGl thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] MemObjectType image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> gl_formats, [Flow(FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedGltextureFormats(context, flags, image_type, num_entries, out gl_formats.GetPinnableReference(), out num_texture_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedGltextureFormats(this IntelSharingFormatQueryGl thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] uint* gl_formats, [Flow(FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedGltextureFormats(context, flags, image_type, num_entries, gl_formats, out num_texture_formats.GetPinnableReference());
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedGltextureFormats(this IntelSharingFormatQueryGl thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> gl_formats, [Flow(FlowDirection.Out)] uint* num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedGltextureFormats(context, flags, image_type, num_entries, out gl_formats.GetPinnableReference(), num_texture_formats);
        }

        [Obsolete("The \"ungrouped\" enums (CLEnum) are deprecated in favour of the \"grouped\" enums (MemFlags, MemObjectType). Not only is this akin to how the original specification represents enums, it also ensures that the size of the enum is correct which is a guarantee the \"ungrouped\" enums do not provide. As such, we have made every attempt to prevent functions known to use these ungrouped enums problematically from compiling; but regardless of whether usage of these deprecated enums compiles please use the other enums to ensure that all functions will work as intended. ", true)]
        public static unsafe int GetSupportedGltextureFormats(this IntelSharingFormatQueryGl thisApi, [Flow(FlowDirection.In)] nint context, [Flow(FlowDirection.In)] CLEnum flags, [Flow(FlowDirection.In)] uint image_type, [Flow(FlowDirection.In)] uint num_entries, [Flow(FlowDirection.Out)] Span<uint> gl_formats, [Flow(FlowDirection.Out)] Span<uint> num_texture_formats)
        {
            // SpanOverloader
            return thisApi.GetSupportedGltextureFormats(context, flags, image_type, num_entries, out gl_formats.GetPinnableReference(), out num_texture_formats.GetPinnableReference());
        }

    }
}

