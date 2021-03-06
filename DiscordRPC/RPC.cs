using System;
using System.Runtime.InteropServices;

namespace DiscordRPC
{
    class RPC
    {
        [DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Initialize")]
        public static extern void Initialize(string applicationId, ref RPC.EventHandlers handlers, bool autoRegister, string optionalSteamId);
        [DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_RunCallbacks")]
        public static extern void RunCallbacks();
        [DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_Shutdown")]
        public static extern void Shutdown();
        [DllImport("discord-rpc-w32.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "Discord_UpdatePresence")]

        public static extern void UpdatePresence(ref RPC.RichPresence presence);
        public delegate void DisconnectedCallback(int errorCode, string message);
        public delegate void ErrorCallback(int errorCode, string message);
        public delegate void ReadyCallback();

        internal static void Initialize(string v1, ref object handlers, bool v2, object p)
        {
            throw new NotImplementedException();
        }

        public struct EventHandlers
        {
            public RPC.ReadyCallback readyCallback;
            public RPC.DisconnectedCallback disconnectedCallback;
            public RPC.ErrorCallback errorCallback;
        }

        public struct RichPresence
        {
            public string state;
            public string details;
            public long startTimestamp;
            public long endTimestamp;
            public string largeImageKey;
            public string largeImageText;
            public string smallImageKey;
            public string smallImageText;
            public string partyId;
            public int partySize;
            public int partyMax;
            public string matchSecret;
            public string joinSecret;
            public string spectateSecret;
            public bool instance;
        }
    }
}