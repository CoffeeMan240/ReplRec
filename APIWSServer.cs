using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;

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
                case "/j":
                    Console.WriteLine("j");
                    r = "jaded";
                    break;
            case "/api/versioncheck/v4":
                    r = "{\"ValidVersion\":true}";
                    break;
            case "/api/config/v2":
                    r = "{\"ValidVersion\":true}";
                    break;

            }
      
                    byte[] bytes = Encoding.UTF8.GetBytes(r);
                    context.Response.ContentLength64 = (long)bytes.Length;
                    Stream outputStream = context.Response.OutputStream;
                    outputStream.Write(bytes, 0, bytes.Length);
                    End:
                    Thread.Sleep(50);
                    server.Stop();
        }
	}
}
