# Dota 2 C# API

![Dota 2 Logo](/images/Logo_Dota_2.png)

:heart::fire: Completed C# API wrapper for working with Dota 2 Web API :fire::heart:

## Installing

* [Click to download this repo](https://github.com/torbiq/Dota2Api/archive/master.zip)
* Open Dota2Api folder in the root of repo and copy only Convertable, Core, Enums and Extensions folders to your project
* Download Newtonsoft JSON (just run this code in your NuGet console):
```
	PM> Install-Package Newtonsoft.Json
```
* Done, now just add following code to your .cs file:
```cs
using Dota2Api.Core;
using Dota2Api.Enums;
using Dota2Api.Convertable;

    var api = new DotaWebAPI(KEY);
    var heroes = api.GetHeroes(Language.english);
```

## Supported WebAPI functions list with their signature

```cs
public MatchDetails GetMatchDetails(UInt64 match_id);
public List<Hero> GetHeroes(Language? language = null, bool itemizedOnly = false);
public List<GameItem> GetGameItems(Language? language = null);
public List<League> GetLeagueListing(Language? language = null);
public MatchHistoryBySequenceNum GetMatchHistoryBySequenceNum(UInt64? startAtMatchSeqNum = null, uint matchesRequested = 0);
public MatchHistory GetMatchHistory(MatchHistoryRequest request);
public MatchHistory GetMatchHistory(MatchHistoryRequest request);
```

## License

This project is licensed under the GNU General Public License v3.0 - see the [LICENSE.md](LICENSE.md) file for details

## Info used

* [Dota 2 forum thread](http://dev.dota2.com/showthread.php?t=47115)
* [Team Fortress wiki WebAPI](https://wiki.teamfortress.com/wiki/WebAPI)
* [Steam Web API documentation](https://developer.valvesoftware.com/wiki/Steam_Web_API)
* [Another and better Steam Web API documentation](http://steamwebapi.azurewebsites.net/)

## And don't forget to...
* Click :star: if you enjoyed this repository
* Write an issue if you found some