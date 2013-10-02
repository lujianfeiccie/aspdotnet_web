<%@ WebHandler Language="C#" Class="CheckCode" %>

using System;
using System.Web;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Web.SessionState;

public class CheckCode : IHttpHandler, IRequiresSessionState
{
    public void ProcessRequest(HttpContext context)
    {
        string checkCode = GenCode(4);  // ����5λ����ַ�
        context.Session["VNum"] = checkCode; //���ַ������浽Session�У��Ա���Ҫʱ������֤
        System.Drawing.Bitmap image = new System.Drawing.Bitmap(56, 22);
        Graphics g = Graphics.FromImage(image);
        try
        {
            //�������������
            Random random = new Random();

            //���ͼƬ����ɫ
            g.Clear(Color.White);

            // ��ͼƬ�ı���������
            int i;
            for (i = 0; i < 25; i++)
            {
                int x1 = random.Next(image.Width);
                int x2 = random.Next(image.Width);
                int y1 = random.Next(image.Height);
                int y2 = random.Next(image.Height);
                g.DrawLine(new Pen(Color.Silver), x1, y1, x2, y2);
            }

            Font font = new System.Drawing.Font("Arial", 12, (System.Drawing.FontStyle.Bold));
            System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(new Rectangle(0, 0, image.Width, image.Height), Color.Blue, Color.DarkRed, 1.2F, true);
            g.DrawString(checkCode, font, brush, 2, 2);

            //��ͼƬ��ǰ��������
            g.DrawRectangle(new Pen(Color.Silver), 0, 0, image.Width - 1, image.Height - 1);
            System.IO.MemoryStream ms = new System.IO.MemoryStream();
            image.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            context.Response.ClearContent();
            context.Response.ContentType = "image/Gif";
            context.Response.BinaryWrite(ms.ToArray());
        }
        finally
        {
            g.Dispose();
            image.Dispose();
        }
    }

    /// <summary>
    /// ��������ַ���
    /// </summary>
    /// <param name="num">����������ַ�</param>
    /// <returns>��������ַ���</returns>
    private string GenCode(int num)
    {
        string str = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        string code = "";
        Random rd = new Random();
        int i;
        for (i = 0; i < num; i++)
        {
            code += str.Substring(rd.Next(0, str.Length), 1);
        }
        return code;

    }

    public bool IsReusable
    {
        get
        {
            return false;
        }
    }
}