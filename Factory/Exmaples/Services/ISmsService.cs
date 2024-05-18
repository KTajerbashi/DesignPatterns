using DesignPatterns.Tools;

namespace DesignPatterns.Factory.Exmaples.Services
{
    public interface ISmsService
    {
        void Send(MailDTO mail);
        List<MailDTO> GetMails();
    }
    public abstract class SmsService : ISmsService
    {
        public abstract List<MailDTO> GetMails();

        public abstract void Send(MailDTO mail);
    }

    public class AfghanistanService : SmsService
    {
        public override List<MailDTO> GetMails()
        {
            return new List<MailDTO>();
        }

        public override void Send(MailDTO mail)
        {
            DesignConsole designConsole = DesignConsole.DesignInstance();
            designConsole.ForeColor(ConsoleColor.Green);
            Console.WriteLine($"AfghanistanService.Send() : {mail.Phone}-{mail.Email}-{mail.Message}");
        }
    }
    public class IranService : SmsService
    {
        public override List<MailDTO> GetMails()
        {
            return new List<MailDTO>();
        }

        public override void Send(MailDTO mail)
        {
            DesignConsole designConsole = DesignConsole.DesignInstance();
            designConsole.ForeColor(ConsoleColor.Green);
            Console.WriteLine($"IranService.Send() : {mail.Phone}-{mail.Email}-{mail.Message}");
        }
    }
    public class TurkeyService : SmsService
    {
        public override List<MailDTO> GetMails()
        {
            return new List<MailDTO>();
        }

        public override void Send(MailDTO mail)
        {
            DesignConsole designConsole = DesignConsole.DesignInstance();
            designConsole.ForeColor(ConsoleColor.Green);
            Console.WriteLine($"TurkeyService.Send() : {mail.Phone}-{mail.Email}-{mail.Message}");
        }
    }
    public class EmailService : SmsService
    {
        public override List<MailDTO> GetMails()
        {
            return new List<MailDTO>();
        }

        public override void Send(MailDTO mail)
        {
            DesignConsole designConsole = DesignConsole.DesignInstance();
            designConsole.ForeColor(ConsoleColor.Green);
            Console.WriteLine($"EmailService.Send() : {mail.Phone}-{mail.Email}-{mail.Message}");
        }
    }

    public interface ICreator
    {
        ISmsService FactoryMethod(CountryType type);
    }
    public class ConcreteCreator : ICreator
    {
        public ISmsService FactoryMethod(CountryType type)
        {
            DesignConsole designConsole = DesignConsole.DesignInstance();
            designConsole.ForeColor(ConsoleColor.Yellow);
            designConsole.Background(ConsoleColor.DarkBlue);
            Console.WriteLine("\t \bConcreteCreator.FactoryMethod()");
            designConsole.Background(ConsoleColor.Black);
            switch (type)
            {
                case CountryType.Afghanistan:
                    return new AfghanistanService();
                case CountryType.Iran:
                    return new IranService();
                case CountryType.Turkey:
                    return new TurkeyService();
                default:
                    return new EmailService();
            }
        }

    }
    public enum CountryType : byte
    {
        None = 0,
        Afghanistan = 1,
        Iran = 2,
        Turkey = 3,
    }
    public class MailDTO
    {
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Message { get; set; }
    }
}
