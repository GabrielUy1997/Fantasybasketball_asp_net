using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Fantasy_basketball_web_app.Models
{
    public class LeagueTeam
    {
        public IList<Stats> Team { get; set; }
        public double[][] PlayersScores;
        public double[][] WeeklyScores;
        public string[][] WeeklyStatLines;
        public Double WeekScore;
        protected int NumPlayers;
        protected Boolean IsHuman;
        protected String TeamName;
        protected int Wins;
        protected int Losses;
        protected int Guards;
        protected int Forwards;
        protected int Center;

        public LeagueTeam()
        {
            Team = new List<Stats>(5);

            PlayersScores = new double[5][];
            PlayersScores[0] = new double[7];
            PlayersScores[1] = new double[7];
            PlayersScores[2] = new double[7];
            PlayersScores[3] = new double[7];
            PlayersScores[4] = new double[7];
            WeeklyScores = new double[5][];
            WeeklyScores[0] = new double[19];
            WeeklyScores[1] = new double[19];
            WeeklyScores[2] = new double[19];
            WeeklyScores[3] = new double[19];
            WeeklyScores[4] = new double[19];
            WeeklyStatLines = new string[5][];
            WeeklyStatLines[0] = new string[19];
            WeeklyStatLines[1] = new string[19];
            WeeklyStatLines[2] = new string[19];
            WeeklyStatLines[3] = new string[19];
            WeeklyStatLines[4] = new string[19];
            NumPlayers = 0;
            WeekScore = 0;
            Wins = 0;
            Losses = 0;
            Guards = 0;
            Forwards = 0;
            Center = 0;
        }
    }

    class Human : LeagueTeam
    {
        public Human(String Name)
        {
            TeamName = Name;
            IsHuman = true;
        }
    }

    class CPU : LeagueTeam
    {
        public CPU(String Name)
        {
            TeamName = Name;
            IsHuman = false;
        }
    }
}