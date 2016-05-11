using System;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;

namespace CATSThumbnailUploader
{
    /// <summary>
    /// YouTube Data API v3 sample: upload a video.
    /// Relies on the Google APIs Client Library for .NET, v1.7.0 or higher.
    /// See https://code.google.com/p/google-api-dotnet-client/wiki/GettingStarted
    /// </summary>
    public class UploadThumbnail
    {
        public static void run(String id, String fp)
        {
            Console.WriteLine("YouTube Data API: Set thumbnail");
            Console.WriteLine("==============================");

            try
            {
                new UploadThumbnail().Run(id, fp).Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }
            Console.WriteLine("=============DONE=================");

        }

        private async Task Run(String id, String fp)
        {
            UserCredential cred;
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                cred = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    // This OAuth 2.0 access scope allows for read-only access to the authenticated 
                    // user's account, but not other types of account access.
                    new[] { YouTubeService.Scope.YoutubeUpload },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(this.GetType().ToString())
                );
            }
            var youtubeService = new YouTubeService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = cred,
                ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
            });
            using (var fileStream = new FileStream(fp, FileMode.Open))
            {
                var thumbnailsInsertRequest = youtubeService.Thumbnails.Set(id,fileStream, "image/jpeg");
                thumbnailsInsertRequest.Upload();
            }
        }
    }
}