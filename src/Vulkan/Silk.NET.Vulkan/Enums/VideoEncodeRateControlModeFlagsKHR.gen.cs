// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.


using System;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [Flags]
    [NativeName("Name", "VkVideoEncodeRateControlModeFlagsKHR")]
    public enum VideoEncodeRateControlModeFlagsKHR : int
    {
        [NativeName("Name", "")]
        None = 0,
        [Obsolete("Deprecated in favour of \"NoneBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_RATE_CONTROL_MODE_NONE_BIT_KHR")]
        VideoEncodeRateControlModeNoneBitKhr = 0,
        [Obsolete("Deprecated in favour of \"CbrBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_RATE_CONTROL_MODE_CBR_BIT_KHR")]
        VideoEncodeRateControlModeCbrBitKhr = 1,
        [Obsolete("Deprecated in favour of \"VbrBitKhr\"")]
        [NativeName("Name", "VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR")]
        VideoEncodeRateControlModeVbrBitKhr = 2,
        [NativeName("Name", "VK_VIDEO_ENCODE_RATE_CONTROL_MODE_NONE_BIT_KHR")]
        NoneBitKhr = 0,
        [NativeName("Name", "VK_VIDEO_ENCODE_RATE_CONTROL_MODE_CBR_BIT_KHR")]
        CbrBitKhr = 1,
        [NativeName("Name", "VK_VIDEO_ENCODE_RATE_CONTROL_MODE_VBR_BIT_KHR")]
        VbrBitKhr = 2,
    }
}
