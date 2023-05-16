using Microsoft.AspNetCore.Mvc;

static class DownloadHelper
{
    public static IActionResult Download(MemoryStream fileContent, string fileName, string contentType)
    {
        byte[] data = fileContent.ToArray();

        FileContentResult fileResult = new(data, contentType);
        fileResult.FileDownloadName = fileName;

        return fileResult;
    }
}