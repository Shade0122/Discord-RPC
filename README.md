<h3 align="center">C# Discord RPC</h3>
<p align="center">
  An easy and reliable way to send an output from a program to a discord webhook in C#.
  <p align="center">
    <a href="https://github.com/Shade0122/Discord-RPC/issues">Report A Bug</a>
  </p>
</p>

## Setting Up The RPC/Application
Head over to [Discord Developers](https://discord.com/developers/applications) and create an `application` and copy its `client ID`.
<img src="https://cdn.discordapp.com/attachments/713300799769280602/853263128469045258/OWwyr1K6.gif"/>

Now head over to the source and insert your client ID just as I do.
<img src="https://cdn.discordapp.com/attachments/713300799769280602/853264669045030912/gNsIQqHy.gif"/>

## Example
We will use the basics to change the appearance of the RPC.
```cs
presence.details = "RPC Details";
presence.state = "RPC State";
presence.largeImageKey = "Large Image Key";
presence.smallImageKey = "Small Image Key";
presence.largeImageText = "Large Image Text";
presence.smallImageText = "Small Image Text";
```
So change any of the string to whatever you want.

_For chaning the image of the RPC follow these steps. `(Keep in mind for uploading images they must atleast be 512x512 and a maxuim of 1024x1024, for resizing images automatically I recommend using,` [Simple Image Resizer](http://www.simpleimageresizer.com/))_

## Contact
If you want to contact me, or report any issues with it you can either do the following:
* [Contact Me On Discord: Shade#0122](https://discord.com)
* [Report Issues](https://github.com/Shade0122/Discord-RPC/issues)

## Insight
[![Contributors][contributors-shield]][contributors-url]
[![Forks][forks-shield]][forks-url
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
