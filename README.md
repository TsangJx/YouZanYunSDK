# YouZanYunSDK
有赞云接口C#的实现

## 使用

```
string client_id = "";
string client_secret = "";
long storeId = 123456;

YouZanYunAPIClient client =new YouZanYunAPIClient(client_id, client_secret, storeId.ToString(), cache);
```
通过手机号查找用户
```
var data = await client.Users.Info.QueryAsync(mobile: mobile);
if (!data.Success || data.Data.UserList.Count <= 0)
{
  return null;
}
return data.Data;
```

## 使用约定
根据接口名称查找路径，例如接口为 youzan.trade.get.4.0.0，
那么调用路径为 client.Trade.GetAsync

后面的4.0.0为版本号，如果要调用指定版本的，则方法名约定为 GetV4_0_0Async
