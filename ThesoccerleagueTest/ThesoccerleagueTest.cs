
using NUnit.Framework;
using Thesoccerleague.Models;

namespace ThesoccerleagueTest
{
    public class ThesoccerleagueTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void LeagueTest()
        {
            int id = 5;
            string name = "Italy Serie A";
            string country = "Italian";

            var league = new League();
            league.LeagueId = id;
            league.LeagueName = name;
            league.LeagueCountry = country;

            Assert.AreEqual(id, league.LeagueId);
            Assert.AreEqual("Italian", league.LeagueCountry);

        }

        [Test]
        public void TeamTest()
        {
            int id = 5;
            string name = "Chelsea";
            string founded = "1905";
            int leagueId = 1;

            var team = new Team();
            team.TeamId = id;
            team.TeamName = name;
            team.TeamFounded = founded;
            team.LeagueId = leagueId;

            Assert.AreEqual(id, team.TeamId);
            Assert.AreEqual("Chelsea", team.TeamName);
            Assert.AreEqual(founded, team.TeamFounded);

        }

        [Test]
        public void PlayerTest()
        {
            int id = 2;
            string name = "Neymar Jr";
            int teamId = 20;

            var player = new Player();
            player.PlayerId = id;
            player.PlayerName = name;
            player.TeamId = teamId;

            Assert.AreEqual(id, player.PlayerId);
            Assert.AreEqual("Neymar Jr", player.PlayerName);

        }
    }
}