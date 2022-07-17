namespace Blazor.Services.ImageService;

public interface IImageService
{
    string GetRandomImage();
    string GetImageAtIndex(int index);
}