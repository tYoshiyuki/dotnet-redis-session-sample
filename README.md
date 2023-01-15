# dotnet-redis-session-sample
ASP.NET MVC で RedisSessionStateProvider を利用したサンプル

## Feature
- ASP.NET MVC
- Redis
- Docker

## Usage
- port 6379  で Redis が動作します。

```
docker-compose up -d
```

- セッションデータをRedisに保存します。設定は `Web.config` にて実施しています。
```xml
    <sessionState mode="Custom" customProvider="MySessionStateStore">
      <providers>
        <add name="MySessionStateStore" type="Microsoft.Web.Redis.RedisSessionStateProvider" redisSerializerType="DotNetRedisSessionSample.Lib.RedisJsonSerializer,DotNetRedisSessionSample.Lib" applicationName="RedisSessionSample" connectionString="localhost:6379" />
      </providers>
    </sessionState>
```

- `DotNetRedisSessionSample.Lib.RedisJsonSerializer` を介して、データのシリアライズを行います。

## Note
- https://learn.microsoft.com/ja-jp/azure/azure-cache-for-redis/cache-aspnet-session-state-provider