# TcpServerKit_Dotnet_Client

**TcpServerKit dotnet client implement**

**get server package https://github.com/mul83rry/TcpServerKit**

**download package from https://www.nuget.org/packages/TcpServerKit_Dotnet_Client**



Add required namespace

```javascript
using TcpClientKit;
```

Set connection event.
```javascript
TcpClient.ConnectResult += (TcpClient.ConnectingStatus cs) =>
{
    Console.WriteLine(cs);                
};
```

Add listeners
```javascript
Client.On("Login", LoginResult);
```

login sample function
```javascript
private void Login(string data)
{
    Console.WriteLine($"{data} from Login");
}
```


init and Start client
```javascript
TcpClient.InitServer("127.0.0.1", 3000);
```

we try to connect to server with ip `127.0.0.1` and port `3000`


For reconnecting
```javascript
Client.CloseConnection();
TcpClient.InitServer("127.0.0.1", 3000);
```

