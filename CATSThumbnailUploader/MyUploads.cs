using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using Google.Apis.YouTube.v3;

namespace CATSThumbnailUploader
{
    /// <summary>
    /// YouTube Data API v3 sample: retrieve my uploads.
    /// Relies on the Google APIs Client Library for .NET, v1.7.0 or higher.
    /// See https://code.google.com/p/google-api-dotnet-client/wiki/GettingStarted
    /// </summary>
    public class MyUploads
    {
        [STAThread]
        public void run()
        {
            Console.WriteLine("YouTube Data API: My Uploads");
            Console.WriteLine("============================");

            try
            {
                new MyUploads().Run().Wait();
            }
            catch (AggregateException ex)
            {
                foreach (var e in ex.InnerExceptions)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            }

            Console.WriteLine("Press any key to continue...");
        }

        private async Task Run()
        {
            UserCredential cred;
            using (var stream = new FileStream("client_secrets.json", FileMode.Open, FileAccess.Read))
            {
                cred = await GoogleWebAuthorizationBroker.AuthorizeAsync(
                    GoogleClientSecrets.Load(stream).Secrets,
                    // This OAuth 2.0 access scope allows for read-only access to the authenticated 
                    // user's account, but not other types of account access.
                    new[] { YouTubeService.Scope.YoutubeReadonly },
                    "user",
                    CancellationToken.None,
                    new FileDataStore(this.GetType().ToString())
                );
            }
                var youtubeService = new YouTubeService(new BaseClientService.Initializer()
                {
                    HttpClientInitializer = cred,
                    ApplicationName = this.GetType().ToString()
                });

                // Retrieve channel name.
                var channelData = youtubeService.Channels.List("snippet");
                channelData.Mine = true;
                var channelDataResponse = await channelData.ExecuteAsync();

                foreach (var c in channelDataResponse.Items)
                {
                    Form1.channel = c.Snippet.Title;

                }

                // Retrieve the contentDetails part of the channel resource for the authenticated user's channel.
                var channelsListRequest = youtubeService.Channels.List("contentDetails");
                channelsListRequest.Mine = true;
                var channelsListResponse = await channelsListRequest.ExecuteAsync();

                    foreach (var channel in channelsListResponse.Items)
                {
                    // From the API response, extract the playlist ID that identifies the list
                    // of videos uploaded to the authenticated user's channel.
                    var uploadsListId = channel.ContentDetails.RelatedPlaylists.Uploads;

                    Console.WriteLine("Videos in list {0}", uploadsListId);

                    var nextPageToken = "";
                    while (nextPageToken != null)
                    {
                        var playlistItemsListRequest = youtubeService.PlaylistItems.List("snippet");
                        playlistItemsListRequest.PlaylistId = uploadsListId;
                        playlistItemsListRequest.MaxResults = 50;
                        playlistItemsListRequest.PageToken = nextPageToken;

                        // Retrieve the list of videos uploaded to the authenticated user's channel.
                        var playlistItemsListResponse = await playlistItemsListRequest.ExecuteAsync();

                        foreach (var playlistItem in playlistItemsListResponse.Items)
                        {
                            Video v = new Video();
                            v.name = playlistItem.Snippet.Title;
                            v.id = playlistItem.Snippet.ResourceId.VideoId;
                            v.thumbnail = playlistItem.Snippet.Thumbnails.High;
                            Form1.videos.Add(v);
                        }

                        nextPageToken = playlistItemsListResponse.NextPageToken;
                }
            }
        }
    }
}