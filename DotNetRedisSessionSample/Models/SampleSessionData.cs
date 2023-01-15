using System;

namespace DotNetRedisSessionSample.Models
{
    /// <summary>
    /// Sessionに保存するデータのモデルです。
    /// </summary>
    public class SampleSessionData
    {
        public const string SampleSessionDataKey = "SampleSessionDataKey";

        public DateTime LastAccessTime { get; set; }
    }
}