using System.Windows.Forms;

namespace DiscordRPC
{
    public partial class Form1 : Form
    {
        private RPC.EventHandlers handlers;
        private RPC.RichPresence presence;
        public Form1()
        {
            InitializeComponent();

            RPC.Initialize("Client ID", ref handlers, true, null);
            presence.details = "RPC Details"; 
            presence.state = "RPC State"; 
            presence.largeImageKey = "Large Image Key"; 
            presence.smallImageKey = "Small Image Key";
            presence.largeImageText = "Large Image Text"; 
            presence.smallImageText = "Small Image Text";
            RPC.UpdatePresence(ref presence);
        }
    }
}   