
namespace ConsoleBd
{
    class Bot
    {
        private const string strChannelId = "-1001300416202";
        private const string strChannelToken = "782293323:AAF0QeKtnMXThF329WfHc8Pi3NKvqYVYW9A";
        private static string SendLink;

        public Bot()
        {
            SendLink = null;
            SendMessage();

        }

        public static void SendMessage()
        {
            var Addresses = new Telegram.Bot.TelegramBotClient(strChannelToken);
            var SendMessage = Addresses.SendTextMessageAsync(strChannelId, SendLink);
        }


    }
}
