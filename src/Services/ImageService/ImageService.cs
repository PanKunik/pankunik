namespace Blazor.Services.ImageService;

public class ImageService : IImageService
{
    private readonly string[] _imagePaths;

    public ImageService()
    {
        _imagePaths = new string[]
        {
            @"images\book-with-glasses.webp",
            @"images\bread-on-board.webp",
            @"images\breads-with-wheat.webp",
            @"images\falling-breads.webp",
            @"images\javascript-code.webp",
            @"images\laptop-with-phones.webp",
            @"images\laptop-with-plant.webp",
            @"images\minified-code.webp",
            @"images\open-crumb-bread.webp",
            @"images\variety-of-breads.webp"
        };
    }

    public string GetRandomImage()
    {
        var randomGenerator = new Random();
        var index = randomGenerator.Next(0, _imagePaths.Length);
        return _imagePaths[index];
    }

    public string GetImageAtIndex(int index)
    {
        var imagesCount = _imagePaths.Length;

        if(index > (imagesCount - 1) || index < 0)
            return "";

        return _imagePaths[index];
    }
}