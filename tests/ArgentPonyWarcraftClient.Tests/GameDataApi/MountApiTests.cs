﻿namespace ArgentPonyWarcraftClient.Tests.GameDataApi;

public class MountApiTests
{
    [Fact]
    public async Task GetMountsIndexAsync_Gets_MountsIndex()
    {
        IMountApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/mount/index?namespace=static-us&locale=en_US",
            responseContent: Resources.MountsIndexResponse);

        RequestResult<MountsIndex> result = await warcraftClient.GetMountsIndexAsync("static-us");
        Assert.NotNull(result.Value);
    }

    [Fact]
    public async Task GetMountAsync_Gets_Mount()
    {
        IMountApi warcraftClient = ClientFactory.BuildMockClient(
            requestUri: "https://us.api.blizzard.com/data/wow/mount/6?namespace=static-us&locale=en_US",
            responseContent: Resources.MountResponse);

        RequestResult<Mount> result = await warcraftClient.GetMountAsync(6, "static-us");
        Assert.NotNull(result.Value);
    }
}
