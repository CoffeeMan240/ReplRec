using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.WebSockets;
using System.Text;
using System.Threading;
using main;
using Newtonsoft.Json;
using RepelRec;

public class APIWSServer
{
	public APIWSServer()
	{
		Console.WriteLine("(API) ONLINE!");
        new Thread(new ThreadStart(Listed)).Start();
	}
	public void Listed()
	{
		var server = new HttpListener();
		server.Prefixes.Add("http://+:2011/");
		for(; ; )
		{
			server.Start();
			Console.WriteLine("(API) Listening...");
            var context = server.GetContext();
            string rawurl = context.Request.RawUrl;
            string rawrawurl = rawurl.Split("?")[0];
            string param = rawurl.Split("?")[1];
            string r = "[]";
            string post;
            byte[] bytepost;
            Console.WriteLine("(API) REQUESTED " + rawrawurl + "!");
            using (MemoryStream getpost = new MemoryStream())
            {
                context.Request.InputStream.CopyTo(getpost);
                bytepost = getpost.ToArray();
                post = Encoding.ASCII.GetString(bytepost);
            }
            switch(rawurl)
            {
                case "/name":
                    r = JsonConvert.SerializeObject(new DSL()
                    {
                        API = "https://replrec.coffeeman240.repl.co/",
                        Notifications = "https://replrec.coffeeman240.repl.co/ws/",
                        Images = "https://img.rec.net/"
                    });
                    break;
                case "/ws/hub/v1":
                    r = "This is a ws!";
                    Websock.ProcessHubRequest(context);
                    break;
                case "/ws/api/notification/v2":
                    r = "This is also ws!";
                    Websock.ProcessNotifRequest(context);
                    break;
                case "/ws/api/notification/v1":
                    r = "This is really a ws moment!";
                    Websock.ProcessHubRequest(context);
                    break;
                case "/api/versioncheck/v3":
                    r = "{\"ValidVersion\":true}";
                    break;
            case "/api/config/v2":
                    r = Config.GetConfig(false);
                    break;

            }
      
                    byte[] bytes = Encoding.UTF8.GetBytes(r);
                    context.Response.ContentLength64 = (long)bytes.Length;
                    Stream outputStream = context.Response.OutputStream;
                    outputStream.Write(bytes, 0, bytes.Length);
        
            Thread.Sleep(50);
            continue;
        End:
            Console.WriteLine("WS Connected");
        }
	}
}
public class DSL
{
    public string API { get; set; }
    public string Notifications { get; set; }
    public string Images { get; set; }
}
public class Websock
{
    public static async void ProcessNotifRequest(HttpListenerContext ctx)
    {
        HttpListenerWebSocketContext wsCtx = await ctx.AcceptWebSocketAsync(null);
        CancellationTokenSource src = new CancellationTokenSource();

        WebSocket ws = wsCtx.WebSocket;

        while (ws.State == WebSocketState.Open)
        {
            byte[] received = new byte[2048];
            int offset = 0;


            while (true)
            {
                try
                {
                    ArraySegment<byte> bytesReceived = new ArraySegment<byte>(received, offset, received.Length);

                    WebSocketReceiveResult result = await ws.ReceiveAsync(bytesReceived, src.Token);
                    offset += result.Count;

                    if (result.EndOfMessage) break;
                }
                catch { break; };
            }

            if (offset == 0) continue;
            string post = Encoding.ASCII.GetString(received);
            byte[] respond = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(new Respond()
            {
                Id = 12,
                Msg = "insert smexy gamesesssion here"
            }));
            if (post.Contains("heartbeat2"))
            {
                respond = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(new Respond()
                {
                    Id = 4,
                    Msg = "insert smexy gamesesssion here"
                }));
            }
            Thread.Sleep(2000);
            await ws.SendAsync(new ArraySegment<byte>(respond, 0, respond.Length), WebSocketMessageType.Text, true, src.Token);

        }
    }
        public static async void ProcessHubRequest(HttpListenerContext ctx)
    {
        HttpListenerWebSocketContext wsCtx = await ctx.AcceptWebSocketAsync(null);
        CancellationTokenSource src = new CancellationTokenSource();

        WebSocket ws = wsCtx.WebSocket;

        while (ws.State == WebSocketState.Open)
        {
            byte[] received = new byte[2048];
            int offset = 0;


            while (true)
            {
                try
                {
                    ArraySegment<byte> bytesReceived = new ArraySegment<byte>(received, offset, received.Length);

                    WebSocketReceiveResult result = await ws.ReceiveAsync(bytesReceived, src.Token);
                    offset += result.Count;

                    if (result.EndOfMessage) break;
                }
                catch { break; };
            }

            if (offset == 0) continue;
            string post = Encoding.ASCII.GetString(received);
            byte[] respond = Encoding.ASCII.GetBytes(JsonConvert.SerializeObject(new HubData()
            {
                accessToken = "SHIIIIIIIIT",
                negotiateVersion = 0,
                SupportedTransports = new List<string>(),
                url = new Uri("https://ReplRec.coffeeman240.repl.co/ws/")
            }));
            Thread.Sleep(2000);
            await ws.SendAsync(new ArraySegment<byte>(respond, 0, respond.Length), WebSocketMessageType.Text, true, src.Token);

        }
        
    }

    public class Respond
    {
        public int Id { get; set; }
        public object Msg { get; set; }
    }
    public class HubData
    {
        public Uri url { get; set; }
        public string accessToken { get; set; }
        public List<string> SupportedTransports { get; set; }
        public int negotiateVersion { get; set; }
    }
}