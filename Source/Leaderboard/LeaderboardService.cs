using System;
using System.Linq;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Microsoft.Xbox.Services.Leaderboard
{
    public class LeaderboardService
    {

        public Task<LeaderboardResult> GetLeaderboardAsync(string serviceConfigurationId, string leaderboardName, string xuid, string socialGroup, uint skipToRank, uint maxItems)
        {
            throw new NotImplementedException();
        }

        public Task<LeaderboardResult> GetLeaderboardAsync(string serviceConfigurationId, string leaderboardName, string xuid, string socialGroup, uint maxItems)
        {
            throw new NotImplementedException();
        }

        public Task<LeaderboardResult> GetLeaderboardAsync(string serviceConfigurationId, string leaderboardName, uint skipToRank, uint maxItems)
        {
            throw new NotImplementedException();
        }

        public Task<LeaderboardResult> GetLeaderboardAsync(string serviceConfigurationId, string leaderboardName)
        {
            throw new NotImplementedException();
        }

        public Task<LeaderboardResult> GetLeaderboardWithAdditionalColumnsAsync(string serviceConfigurationId, string leaderboardName, string xuid, string socialGroup, uint skipToRank, string[] additionalColumns, uint maxItems)
        {
            throw new NotImplementedException();
        }

        public Task<LeaderboardResult> GetLeaderboardWithAdditionalColumnsAsync(string serviceConfigurationId, string leaderboardName, uint skipToRank, string[] additionalColumns, uint maxItems)
        {
            throw new NotImplementedException();
        }

        public Task<LeaderboardResult> GetLeaderboardWithAdditionalColumnsAsync(string serviceConfigurationId, string leaderboardName, string xuid, string socialGroup, string[] additionalColumns, uint maxItems)
        {
            throw new NotImplementedException();
        }

        public Task<LeaderboardResult> GetLeaderboardWithAdditionalColumnsAsync(string serviceConfigurationId, string leaderboardName, string[] additionalColumns)
        {
            throw new NotImplementedException();
        }

        public Task<LeaderboardResult> GetLeaderboardWithSkipToUserAsync(string serviceConfigurationId, string leaderboardName, string xuid, string socialGroup, string skipToXboxUserId, uint maxItems)
        {
            throw new NotImplementedException();
        }

        public Task<LeaderboardResult> GetLeaderboardWithSkipToUserAsync(string serviceConfigurationId, string leaderboardName, string skipToXboxUserId, uint maxItems)
        {
            throw new NotImplementedException();
        }

        public Task<LeaderboardResult> GetLeaderboardWithSkipToUserWithAdditionalColumnsAsync(string serviceConfigurationId, string leaderboardName, string xuid, string socialGroup, string skipToXboxUserId, string[] additionalColumns, uint maxItems)
        {
            throw new NotImplementedException();
        }

        public Task<LeaderboardResult> GetLeaderboardWithSkipToUserWithAdditionalColumnsAsync(string serviceConfigurationId, string leaderboardName, string skipToXboxUserId, string[] additionalColumns, uint maxItems)
        {
            throw new NotImplementedException();
        }

        public Task<LeaderboardResult> GetLeaderboardForSocialGroupAsync(string xboxUserId, string serviceConfigurationId, string statisticName, string socialGroup, string sortOrder, uint maxItems)
        {
            throw new NotImplementedException();
        }

        public Task<LeaderboardResult> GetLeaderboardForSocialGroupAsync(string xboxUserId, string serviceConfigurationId, string statisticName, string socialGroup, uint maxItems)
        {
            throw new NotImplementedException();
        }

        public Task<LeaderboardResult> GetLeaderboardForSocialGroupWithSkipToRankAsync(string xboxUserId, string serviceConfigurationId, string statisticName, string socialGroup, uint skipToRank, string sortOrder, uint maxItems)
        {
            throw new NotImplementedException();
        }

        public Task<LeaderboardResult> GetLeaderboardForSocialGroupWithSkipToUserAsync(string xboxUserId, string serviceConfigurationId, string statisticName, string socialGroup, string skipToXboxUserId, string sortOrder, uint maxItems)
        {
            throw new NotImplementedException();
        }

    }
}