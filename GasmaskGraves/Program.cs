﻿using System;
using EloBuddy;
using EloBuddy.SDK.Events;
using EloBuddy.SDK.Rendering;
using SharpDX;
using System.Net;

namespace GasmaskGraves
{
    public static class Program
    {
        // Change this line to the champion you want to make the addon for,
        // watch out for the case being correct!
        public const string ChampName = "Graves";

        public static void Main(string[] args)
        {
            // Wait till the loading screen has passed
            Loading.OnLoadingComplete += OnLoadingComplete;
        }

        private static void OnLoadingComplete(EventArgs args)
        {
            // Verify the champion we made this addon for
            if (Player.Instance.ChampionName != ChampName)
            {
                // Champion is not the one we made this addon for,
                // therefore we return
                return;
            }

            //Version Check
            string currentVersion = "0.1";
            Chat.Print("GasmaskGraves Version: " + currentVersion + " - LOADED.");
            Chat.Print("Checking online version..");
            if (new WebClient().DownloadString("https://raw.githubusercontent.com/princessGasmask/ELOBUDDY/master/GasmaskGraves/version.txt") != currentVersion)
                Chat.Print("Old GasmaskGraves version!");
            else
                Chat.Print("You have the last version of GasmaskGraves addon.");

            // Initialize the classes that we need
            Config.Initialize();
            SpellManager.Initialize();
            ModeManager.Initialize();

            // Listen to events we need
            Drawing.OnDraw += OnDraw;
        }

        private static void OnDraw(EventArgs args)
        {
            // Draw range circles of our spells
            Circle.Draw(Color.Red, SpellManager.Q.Range, Player.Instance.Position);
            // TODO: Uncomment if you want those enabled aswell, but remember to enable them
            // TODO: in the SpellManager aswell, otherwise you will get a NullReferenceException
            //Circle.Draw(Color.Red, SpellManager.W.Range, Player.Instance.Position);
            Circle.Draw(Color.Red, SpellManager.E.Range, Player.Instance.Position);
            Circle.Draw(Color.Red, SpellManager.R.Range, Player.Instance.Position);
        }
    }
}

