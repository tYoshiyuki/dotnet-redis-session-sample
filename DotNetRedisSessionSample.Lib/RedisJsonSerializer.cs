using System.Text;
using Microsoft.Web.Redis;
using Newtonsoft.Json;

namespace DotNetRedisSessionSample.Lib
{
    /// <summary>
    /// Redisシリアライザーです。
    /// </summary>
    /// <remarks>
    ///<para>https://learn.microsoft.com/ja-jp/azure/azure-cache-for-redis/cache-aspnet-output-cache-provider#about-redisserializertype</para>
    /// </remarks>
    public class RedisJsonSerializer : ISerializer
    {
        private static readonly JsonSerializerSettings settings = new JsonSerializerSettings { TypeNameHandling = TypeNameHandling.All };

        public byte[] Serialize(object data)
        {
            return Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data, settings));
        }

        public object Deserialize(byte[] data)
        {
            if (data == null)
            {
                return null;
            }
            return JsonConvert.DeserializeObject(Encoding.UTF8.GetString(data), settings);
        }
    }
}