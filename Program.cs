using System;
using log4net;
using log4net.Config;

namespace lab_4_tp2
{
    class Program
    {
        public static readonly ILog log = LogManager.GetLogger(typeof(Program));
        static void Main(string[] args)
        {
            XmlConfigurator.Configure();
            log.Info("Старт");
            CardSelector.ChooseCard();
            log.Info("Конец");
        }
    }
}
