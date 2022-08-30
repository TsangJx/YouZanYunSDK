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
