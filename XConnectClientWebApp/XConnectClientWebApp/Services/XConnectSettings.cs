using System;
using System.Configuration;

namespace XConnectClientWebApp.Services
{
    public static class XConnectSettings
    {
/// <summary>
        /// Search parameters for starting interaction searches (year, month, day)
        /// </summary>
        public static int SearchYear = DateTime.UtcNow.Year;
        public const int SearchMonth = 1;
        public const int SearchStartDay = 20;
        public const int SearchDays = 10;

        /// <summary>
        /// 
        /// </summary>
        public const string EmailIdentificationSource = "email";

        /// <summary>
        ///     XConnect connection properties
        /// </summary>
        public static string XconnectUrl = ConfigurationManager.AppSettings["xconnect.Url"];
        public static string XconnectThumbprint = ConfigurationManager.AppSettings["xconnect.Thumbprint"];
        public static string AppSourceID = ConfigurationManager.AppSettings["xconnect.AppSourceID"];
        public static string SiteSourceLabel = ConfigurationManager.AppSettings["xconnect.SiteSourceLabel"];
        public static string AppDomain = ConfigurationManager.AppSettings["xconnect.AppDomain"];

        /// <summary>
        ///     Sitecore Item IDs for goals and channels.
        /// </summary>
        public static Guid LoginGoalId = string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["xconnect.interaction.LoginGoalId"]) ?
            Guid.Parse("{66722F52-2D13-4DCC-90FC-EA7117CF2298}") //  "Login" goal
            : Guid.Parse(ConfigurationManager.AppSettings["xconnect.interaction.LoginGoalId"]);

        public static Guid OnlineGoalId = string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["xconnect.interaction.OnlineGoalId"]) ?
            Guid.Parse("{475E9026-333F-432D-A4DC-52E03B75CB6B}") // "Generic" goal
            : Guid.Parse(ConfigurationManager.AppSettings["xconnect.interaction.OnlineGoalId"]);

        public static Guid OnlineChannelId = string.IsNullOrWhiteSpace(ConfigurationManager.AppSettings["xconnect.interaction.OnlineChannelId"]) ?
            Guid.Parse("{59BD107F-D725-4BA1-91C6-61BEE3CB768C}") // "Other apps" channel
            : Guid.Parse(ConfigurationManager.AppSettings["xconnect.interaction.OnlineChannelId"]);

    }
}