namespace Blazor.ViewModels
{
    public record ProjectViewModel (
        string Title,
        string Description,
        string ImagePath,
        string WindowsDownloadLink,
        string LinuxDownloadLink,
        string MacDownloadLink,
        string GithubLink,
        string[] Tags);
}