using System;
using System.IO;
using System.Net;
using System.Text;

public class APIWSServer
{
	public APIWSServer()
	{
		Console.WriteLine("(API) ONLINE!");

	}
	public void Listed()
	{
		var server = new HttpListener();
		server.Prefixes.Add("http://+:2011");
		for(; ; )
		{
			server.Start();
			Console.WriteLine("(API) Listening...");
            var context = server.GetContext();
            string rawurl = context.Request.RawUrl;
            string r = "[]";
            string post;
            byte[] bytepost;
            Console.WriteLine("(API) REQUESTED " + rawurl + "!");
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
                case "/api/versioncheck":
                    r = "{\"ValidVersion\":true}";
                    break;
                
            }
        }
	}
}
