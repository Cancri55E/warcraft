﻿using System.Threading.Tasks;
using ArgentPonyWarcraftClient.Tests.Properties;
using Xunit;

namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class PlayableRaceApiTests
{
    [Fact]
    public async Task GetPlayableRacesIndexAsync_Gets_PlayableRacesIndex()
    {
        IPlayableRaceApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/playable-race/index?namespace=static-us&locale=en_US",
            responseContent: Resources.PlayableRacesIndexResponse);

        RequestResult<PlayableRacesIndex> result = await warcraftClient.GetPlayableRacesIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetPlayableRaceAsync_Gets_PlayableRace()
    {
        IPlayableRaceApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/playable-race/2?namespace=static-us&locale=en_US",
            responseContent: Resources.PlayableRaceResponse);

        RequestResult<PlayableRace> result = await warcraftClient.GetPlayableRaceAsync(2, "static-us");
        Assert.NotNull(result.Value);
    }
}
