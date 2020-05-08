using System;
using System.Threading;

namespace Events
{
    internal class VideoEncoder
    {
        //public delegate void VideoEncoderEventHandler(object sender, VideoEventArgs args);
        //public event VideoEncoderEventHandler VideoEncoded;

        public event EventHandler<VideoEventArgs> VideoEncoded;


        public VideoEncoder() { }

        internal void Encode(Video video)
        {
            Console.WriteLine("Encoding...");
            Thread.Sleep(1000);

            OnVideoEncoded(video);
        }
        protected virtual void OnVideoEncoded(Video video)
        {
            if (VideoEncoded == null)
                return;

            VideoEncoded(this, new VideoEventArgs() { Video = video });
        }
    }

    public class VideoEventArgs : EventArgs
    {
        public Video Video { get; set; }

    }
}