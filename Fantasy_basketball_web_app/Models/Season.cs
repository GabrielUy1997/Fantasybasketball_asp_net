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

        public void LoadSeason(nbaStatsEntities _reterive)
        {
            IList<Stats> Players;

            Players = new List<Stats>();
            string BestPick = "";
            int MostPoints = 0;
            int index = 0;
            int totalPoints = 0;
            string input = "all";
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
                default:
                    break;

            }
            _Players.Add(new Stats() { ID = _index.ToString(), Name = _BestPick, Pts = _MostPoints.ToString() });
            _BestPick = "";
            _MostPoints = 0;
            _index = 0;
            _totalPoints = 0;
        }
    };

    
}