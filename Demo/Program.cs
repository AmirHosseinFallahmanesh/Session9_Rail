using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            



        }
    }
    interface IEmailSender
    {
        void SendMail(string subject, string content, string destination);
    }


    public class YahooMailSender : IEmailSender
    {
        public void SendMail(string subject, string content, string destination)
        {
            throw new NotImplementedException();
        }
    }

    public class GoogleMailSender : IEmailSender
    {
        public void SendMail(string subject, string content, string destination)
        {
            throw new NotImplementedException();
        }
    }

}
