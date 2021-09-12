<h3 align="center">C# Discord RPC</h3>
<p align="center">
  An easy way of brodcasting what program the user is using. (Only works on desktop)
  <p align="center">
    <a href="https://github.com/Shade0122/Discord-RPC/issues">Report A Bug</a>
    ·
    <a href="https://cdn.discordapp.com/attachments/713300799769280602/853349707903664138/discord-rpc-w32.dll">Download discord-rpc-w32.dll</a>
  </p>
</p>

`Before starting make sure you have discord-rpc-w32.dll downloaded and placed in your debug or release build folders for the RPC to take place.`

## Setting Up The RPC/Application
Head over to [Discord Developers Portal](https://discord.com/developers/applications) and create an `application` and copy its `client ID`.
<img src="https://cdn.discordapp.com/attachments/713300799769280602/853263128469045258/OWwyr1K6.gif"/>

Now head over to the source and insert ita client ID just as I do.
<img src="https://cdn.discordapp.com/attachments/713300799769280602/853264669045030912/gNsIQqHy.gif"/>

## Example
We will use the basics to change the appearance of the RPC.

For changing the image of the RPC follow these steps. 
<img src="https://cdn.discordapp.com/attachments/713300799769280602/853344897263599647/YEC8dhM3.gif"/>
_Keep in mind for uploading images they must atleast be 512x512 and a maxuim of 1024x1024, for resizing images automatically I recommend using, [Simple Image Resizer](http://www.simpleimageresizer.com/)_

You can change any of the strings execpt `largeImageKey` and `smallImageKey` if you havnt already changed the name to the image you uploaded to developer portal.

```cs
presence.details = "RPC Details"; // Change the text to whatever you want.
presence.state = "RPC State"; // Change the text to whatever you want.
presence.largeImageKey = "largeimg"; // Change the name to the image you uploaded to developer portal.
presence.smallImageKey = "smallimg"; // Change the name to the image you uploaded to developer portal.
presence.largeImageText = "Large Image Text"; // Change the text to whatever you want.
presence.smallImageText = "Small Image Text"; // Change the text to whatever you want.
```

And after saving and building it run the program and open up Discord App not the browser version as it will not work, and click on your profile and you should see your custom made RPC.
<img src="https://cdn.discordapp.com/attachments/713300799769280602/853346808977424414/Lr1dN4g8.gif"/>

To add extra detail and information to your rpc you can use the other types of strings, bools, ints and longs.
```cs
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
```

## Contact
If you want to contact me, or report any issues with it you can either do the following:
* [Contact Me On Discord: Shade#0122](https://discord.com)
* [Report Issues](https://github.com/Shade0122/Discord-RPC/issues)

## Insight
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url]
[![Stargazers][stars-shield]][stars-url]
[![Issues][issues-shield]][issues-url]

[contributors-shield]: https://img.shields.io/github/contributors/Shade0122/Discord-RPC.svg?style=for-the-badge
[contributors-url]: https://github.com/Shade0122/Discord-RPC/graphs/contributors
[forks-shield]: https://img.shields.io/github/forks/Shade0122/Discord-RPC.svg?style=for-the-badge
[forks-url]: https://github.com/Shade0122/Discord-RPC/network/members
[stars-shield]: https://img.shields.io/github/stars/Shade0122/Discord-RPC.svg?style=for-the-badge
[stars-url]: https://github.com/Shade0122/Discord-RPC/stargazers
[issues-shield]: https://img.shields.io/github/issues/Shade0122/Discord-RPC.svg?style=for-the-badge
[issues-url]: https://github.com/Shade0122/Discord-RPC/issues
