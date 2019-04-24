using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Web;


namespace ShopProject
{
    public class Handler : IHttpHandler
    {
    
        
            public void ProcessRequest(HttpContext context)
            {
                context.Response.Clear();
                context.Response.ContentType = "image/jpeg";
                if (File.Exists(context.Request.PhysicalPath))
                {
                    Image image = Image.FromFile(context.Request.PhysicalPath);
                    Image watermark = Image.FromFile(@"C:/Users/KRS/Desktop/PS3 WWW/PS3 WWW/Images/WaterMark.png");
                    Graphics g = Graphics.FromImage(image);
                    float w = (image.Width / 2);
                    float h = (w / watermark.Width) * watermark.Height;
                    g.DrawImage(watermark, image.Width / 2 - w / 2, image.Height / 2 - h / 2, w, h);
                    using (MemoryStream mStream = new MemoryStream())
                    {
                        image.Save(mStream, image.RawFormat);
                        mStream.WriteTo(context.Response.OutputStream);
                    }
                }
                else
                {
                    context.Response.ContentType = "text/plain";
                    context.Response.Write("Bladbladblad!!!");
                }
                context.Response.End();
            }



        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}