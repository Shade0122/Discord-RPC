this.handlers = default(Classes.DiscordRPC.EventHandlers);
Classes.DiscordRPC.Initialize("Client ID", ref this.handlers, true, null);
this.presence.details = "Text 1";
this.presence.state = "Text 2";
this.presence.largeImageKey = "Large Image Name";
this.presence.smallImageKey = "Small Image Name";
this.presence.largeImageText = "Large Image Text";
Classes.DiscordRPC.UpdatePresence(ref this.presence);
