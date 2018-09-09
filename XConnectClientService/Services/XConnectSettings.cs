using System;
using System.Configuration;

namespace XConnectClientServices.Services
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
        public static Guid LoginGoalId = Guid.Parse(ConfigurationManager.AppSettings["xconnect.interaction.LoginGoalId"]);
        public static Guid OnlineGoalId = Guid.Parse(ConfigurationManager.AppSettings["xconnect.interaction.OnlineGoalId"]);
        public static Guid OnlineChannelId = Guid.Parse(ConfigurationManager.AppSettings["xconnect.interaction.OnlineChannelId"]);
        public static Guid OfflineGoalId = Guid.Parse(ConfigurationManager.AppSettings["xconnect.interaction.OfflineGoalId"]);
        public static Guid OfflineChannelId = Guid.Parse(ConfigurationManager.AppSettings["xconnect.interaction.OfflineChannelId"]);

    }
}