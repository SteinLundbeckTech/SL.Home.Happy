/*
    @Date                 : 24.03.2024
    @Author               : Stein Lundbeck
    @Description          : null
*/

using SL.Assets.Core.Components;
using SL.Assets.Core.Components.ApplicationFeatures;

WebApplicationBuilder bld = WebApplication.CreateBuilder(args);

new AssetsConfig(args)
    .AddAssets(null, true,
        new Minify(),
        new Content(),
        new SSL(),
        new DefaultRoute("SL", "Index"));
