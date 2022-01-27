namespace BlazorUI.Services.ImageService;

public class ImageService : IImageService
{
    private readonly string[] _imagePaths;
    
    public ImageService()
    {
        _imagePaths = new string[]
        {
            @"images\bread-on-board.jpg",
            @"images\book-with-glasses.jpg",
            @"images\breads-with-wheat.jpg",
            @"images\falling-breads.jpg",
            @"images\javascript-code.jpg",
            @"images\laptop-with-phones.jpg",
            @"images\laptop-with-plant.jpg",
            @"images\minified-code.jpg",
            @"images\open-crumb-bread.jpg",
            @"images\variety-of-breads.jpg",
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