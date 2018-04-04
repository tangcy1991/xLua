﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace XLua.LuaDLL
{
    using System;
    using System.Runtime.InteropServices;
    using System.Text;
    using XLua;

    public partial class Lua
    {
        [DllImport(LUADLL, CallingConvention = CallingConvention.Cdecl)]
        public static extern int luaopen_pb(System.IntPtr L);
        
        [MonoPInvokeCallback(typeof(LuaDLL.lua_CSFunction))]
        public static int LoadProtobuf(System.IntPtr L)
        {
            return luaopen_pb(L);
        }

    }
}
