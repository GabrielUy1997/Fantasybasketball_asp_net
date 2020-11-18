using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace Fantasy_basketball_web_app.Models
{
    public class Season
    {
        public string SeasonSelected { get; set; }
        public IList<Stats> PlayerList { get; set; }
        public IList<string> WeekWinners { get; set; }
        public IList<LeagueTeam> Teams { get; set; }
        public IList<int> Week { get; set; }
        public IList<int> MatchupType1 { get; set; }
        public IList<int> MatchupType2 { get; set; }
        public IList<int> MatchupType22 { get; set; }
        public IList<int> MatchupType3 { get; set; }
        public IList<int> MatchupType4 { get; set; }
        private int MatchUp;


        public void LoadSeason(nbaStatsEntities _reterive)
        {
            IList<Stats> Players;
            Human player1 = new Human("Player");
            CPU cpu1 = new CPU("CPU1");
            CPU cpu2 = new CPU("CPU2");
            CPU cpu3 = new CPU("CPU3");
            string BestPick = "";
            int MostPoints = 0;
            int index = 0;
            int totalPoints = 0;
            string input = "all";

            Players = new List<Stats>();
            WeekWinners = new List<string>(19);
            Teams = new List<LeagueTeam>(4);
            Week = new List<int>(20);
            MatchUp = 0;
            for(int i = 1; i <= 20; i++)
            {
                Week.Add(i);
            }
            MatchupType1 = new List<int> { 0, 1, 2, 3 };
            MatchupType2 = new List<int> { 0, 2, 1, 3 };
            MatchupType22 = new List<int> { 0, 2, 1, 3 };
            MatchupType3 = new List<int> { 0, 3, 2, 1 };
            MatchupType4 = new List<int> { 0, 2, 3, 1 };

            
            for (int i = 0; i < 30; i++)
            {
                this.FetchPlayers(_reterive, this.SeasonSelected, BestPick, MostPoints, index, totalPoints, input, Players);
               
            }
            PlayerList = Players;
        }

        private void FetchPlayers(nbaStatsEntities __reterive, string SelectedSeason, string _BestPick, int _MostPoints, int _index, int _totalPoints, string _input, IList<Stats> _Players)
        {
            switch (SelectedSeason)
            {
                case "2018-2019":
                    foreach (var item in __reterive.C2018_2019)
                    {

                        _index++;
                        _totalPoints = Int32.Parse(item.PTS);
                        if (_input == "all")
                        {
                            //This calls the IEquatable.Equals method
                            // of the Stats class, which checks the Name for equality. https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.find?view=net-5.0
                            if (_totalPoints > _MostPoints && _Players.Contains(new Stats { Name = item.Player.Split('\\')[0], Pts = "" }) != true)
                            {
                                _MostPoints = _totalPoints;
                                _BestPick = item.Player.Split('\\')[0];
                            }
                        }

                    }
                    break;
                case "2017-2018":
                    foreach (var item in __reterive.C2017_2018)
                    {

                        _index++;
                        _totalPoints = Int32.Parse(item.PTS);
                        if (_input == "all")
                        {
                            //This calls the IEquatable.Equals method
                            // of the Stats class, which checks the Name for equality. https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.find?view=net-5.0
                            if (_totalPoints > _MostPoints && _Players.Contains(new Stats { Name = item.Player.Split('\\')[0], Pts = "" }) != true)
                            {
                                _MostPoints = _totalPoints;
                                _BestPick = item.Player.Split('\\')[0];
                            }
                        }

                    }
                    break;
                case "2016-2015":
                    foreach (var item in __reterive.C2015_2016)
                    {

                        _index++;
                        _totalPoints = Int32.Parse(item.PTS);
                        if (_input == "all")
                        {
                            //This calls the IEquatable.Equals method
                            // of the Stats class, which checks the Name for equality. https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.find?view=net-5.0
                            if (_totalPoints > _MostPoints && _Players.Contains(new Stats { Name = item.Player.Split('\\')[0], Pts = "" }) != true)
                            {
                                _MostPoints = _totalPoints;
                                _BestPick = item.Player.Split('\\')[0];
                            }
                        }

                    }
                    break;
                case "2014-2015":
                    foreach (var item in __reterive.C2014_2015)
                    {

                        _index++;
                        _totalPoints = Int32.Parse(item.PTS);
                        if (_input == "all")
                        {
                            //This calls the IEquatable.Equals method
                            // of the Stats class, which checks the Name for equality. https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.find?view=net-5.0
                            if (_totalPoints > _MostPoints && _Players.Contains(new Stats { Name = item.Player.Split('\\')[0], Pts = "" }) != true)
                            {
                                _MostPoints = _totalPoints;
                                _BestPick = item.Player.Split('\\')[0];
                            }
                        }

                    }
                    break;
                case "2013-2014":
                    foreach (var item in __reterive.C2013_2014)
                    {

                        _index++;
                        _totalPoints = Int32.Parse(item.PTS);
                        if (_input == "all")
                        {
                            //This calls the IEquatable.Equals method
                            // of the Stats class, which checks the Name for equality. https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.find?view=net-5.0
                            if (_totalPoints > _MostPoints && _Players.Contains(new Stats { Name = item.Player.Split('\\')[0], Pts = "" }) != true)
                            {
                                _MostPoints = _totalPoints;
                                _BestPick = item.Player.Split('\\')[0];
                            }
                        }

                    }
                    break;
                case "2012-2013":
                    foreach (var item in __reterive.C2012_2013)
                    {

                        _index++;
                        _totalPoints = Int32.Parse(item.PTS);
                        if (_input == "all")
                        {
                            //This calls the IEquatable.Equals method
                            // of the Stats class, which checks the Name for equality. https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.find?view=net-5.0
                            if (_totalPoints > _MostPoints && _Players.Contains(new Stats { Name = item.Player.Split('\\')[0], Pts = "" }) != true)
                            {
                                _MostPoints = _totalPoints;
                                _BestPick = item.Player.Split('\\')[0];
                            }
                        }

                    }
                    break;
                case "2011-2012":
                    foreach (var item in __reterive.C2011_2012)
                    {

                        _index++;
                        _totalPoints = Int32.Parse(item.PTS);
                        if (_input == "all")
                        {
                            //This calls the IEquatable.Equals method
                            // of the Stats class, which checks the Name for equality. https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.find?view=net-5.0
                            if (_totalPoints > _MostPoints && _Players.Contains(new Stats { Name = item.Player.Split('\\')[0], Pts = "" }) != true)
                            {
                                _MostPoints = _totalPoints;
                                _BestPick = item.Player.Split('\\')[0];
                            }
                        }

                    }
                    break;
                case "2010-2011":
                    foreach (var item in __reterive.C2010_2011)
                    {

                        _index++;
                        _totalPoints = Int32.Parse(item.PTS);
                        if (_input == "all")
                        {
                            //This calls the IEquatable.Equals method
                            // of the Stats class, which checks the Name for equality. https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.find?view=net-5.0
                            if (_totalPoints > _MostPoints && _Players.Contains(new Stats { Name = item.Player.Split('\\')[0], Pts = "" }) != true)
                            {
                                _MostPoints = _totalPoints;
                                _BestPick = item.Player.Split('\\')[0];
                            }
                        }

                    }
                    break;
                default:
                    break;

            }
            
            _Players.Add(new Stats() { ID = _index.ToString(), Name = _BestPick, Pts = _MostPoints.ToString() });
            _BestPick = "";
            _MostPoints = 0;
            _index = 0;
            _totalPoints = 0;
        }
         

        //todo
        private int ComputerTeamDraft(LeagueTeam a_team)
        {

            return 0;
        }
    };

    
}