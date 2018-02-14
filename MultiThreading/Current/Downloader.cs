using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreading.Current
{
    class Downloader
    {
        public static async Task<string> DownloadHtml(string url)
        {
            WebClient client = new WebClient();

            Debug.WriteLine("Downloading " + url);

            var download = await client.DownloadStringTaskAsync(url);

            Debug.WriteLine("Finished " + url);

            return download;
        }
    }
}
