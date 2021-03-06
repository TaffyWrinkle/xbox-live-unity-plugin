﻿// Copyright (c) Microsoft Corporation
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Microsoft.Xbox.Services.Social.Manager
{
    using global::System;
    using global::System.Runtime.InteropServices;

    public partial class XboxSocialUser
    {
        internal XboxSocialUser(IntPtr xboxSocialUserPtr)
        {
            XBOX_SOCIAL_USER cXboxSocialUser = Marshal.PtrToStructure<XBOX_SOCIAL_USER>(xboxSocialUserPtr);

            XboxUserId = MarshalingHelpers.Utf8ToString(cXboxSocialUser.XboxUserId);
            DisplayName = MarshalingHelpers.Utf8ToString(cXboxSocialUser.DisplayName);
            RealName = MarshalingHelpers.Utf8ToString(cXboxSocialUser.RealName);
            DisplayPicRaw = MarshalingHelpers.Utf8ToString(cXboxSocialUser.DisplayPicUrlRaw);
            UseAvatar = cXboxSocialUser.UseAvatar;
            Gamertag = MarshalingHelpers.Utf8ToString(cXboxSocialUser.Gamertag);
            Gamerscore = MarshalingHelpers.Utf8ToString(cXboxSocialUser.Gamerscore);
            PreferredColor = new PreferredColor(cXboxSocialUser.PreferredColor);
            IsFollowedByCaller = cXboxSocialUser.IsFollowedByCaller;
            IsFollowingUser = cXboxSocialUser.IsFollowingUser;
            IsFavorite = cXboxSocialUser.IsFavorite;

            PresenceRecord = new SocialManagerPresenceRecord(cXboxSocialUser.PresenceRecord);

            TitleHistory = new TitleHistory(cXboxSocialUser.TitleHistory);
        }

        [StructLayout(LayoutKind.Sequential)]
        internal struct XBOX_SOCIAL_USER
        {
            [MarshalAs(UnmanagedType.SysInt)]
            public IntPtr XboxUserId;

            [MarshalAs(UnmanagedType.U1)]
            public bool IsFavorite;

            [MarshalAs(UnmanagedType.U1)]
            public bool IsFollowingUser;

            [MarshalAs(UnmanagedType.U1)]
            public bool IsFollowedByCaller;

            [MarshalAs(UnmanagedType.SysInt)]
            public IntPtr DisplayName;

            [MarshalAs(UnmanagedType.SysInt)]
            public IntPtr RealName;

            [MarshalAs(UnmanagedType.SysInt)]
            public IntPtr DisplayPicUrlRaw;

            [MarshalAs(UnmanagedType.U1)]
            public bool UseAvatar;

            [MarshalAs(UnmanagedType.SysInt)]
            public IntPtr Gamerscore;

            [MarshalAs(UnmanagedType.SysInt)]
            public IntPtr Gamertag;

            [MarshalAs(UnmanagedType.SysInt)]
            public IntPtr PresenceRecord;

            [MarshalAs(UnmanagedType.SysInt)]
            public IntPtr TitleHistory;

            [MarshalAs(UnmanagedType.SysInt)]
            public IntPtr PreferredColor;
        }
    }
}
