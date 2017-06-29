using System.Diagnostics;
using System.Threading;
using System.Linq;
using ff14bot;
using ff14bot.Helpers;
using ff14bot.Interfaces;
using ff14bot.Managers;
using ff14bot.Objects;
using Newtonsoft.Json;
using System;
using System.IO;
using Quack.Settings;
using System.Configuration;
using System.Runtime.InteropServices;

namespace Quack_
{
    public class Quack : IBotPlugin
    {
        #region Necessary Stuff
        public string Author { get { return "Exmortem"; } }
        public string Description { get { return "Logs out based on settings."; } }
        public Version Version { get { return new Version(0, 0, 1); } }
        public bool Equals(IBotPlugin other)
        {
            throw new NotImplementedException();
        }
        public void OnInitialize()
        {
            settings.Enabled = false;
        }
        public void OnShutdown()
        {

        }
        public void OnEnabled()
        {
            settings.Enabled = false;
        }
        public void OnDisabled()
        {
        }
        public string Name
        {
            get { return "Quack!"; }
        }
        public bool WantButton
        {
            get { return true; }
        }
        public string ButtonText
        {
            get { return "Quack!"; }
        }
        public void OnButtonPress()
        {
            if (_form == null || _form.IsDisposed || _form.Disposing)
                _form = new frmMain();

            _form.ShowDialog();    
        }
        #endregion
        #region Variables
        public static QuackSettings settings = QuackSettings.Instance;
        private frmMain _form;
        #endregion

        public void OnPulse()
        {

            if (settings.Enabled)
            {
                if (DateTime.Now >= settings.TimeEnd)
                {
                    if (Core.Player.InCombat)
                        return;

                    TreeRoot.Stop();

                    if (settings.Teleport)
                    {
                        if (Core.Player.IsMounted)
                        {
                            Thread.Sleep(1000);
                            ActionManager.Dismount();
                            Thread.Sleep(1000);
                        }

                        UInt32 locationId = WorldManager.AvailableLocations
                                            .Where(a => a.Name == settings.TeleportLocation)
                                            .Select(a => a.AetheryteId)
                                            .FirstOrDefault();

                        if (locationId != null)
                        {
                            WorldManager.TeleportById(locationId);
                            Thread.Sleep(20000);
                        }
                    }

                    if (settings.Logout)
                    {
                        Logging.Write("[Quack!] Closing FFXIV.");
                        Process ffxiv = Core.Memory.Process;
                        ffxiv.Kill();
                    }

                }
            }

        }
    } 
}

#region Settings
namespace Quack.Settings
{
    public class QuackSettings : JsonSettings
    {
        [JsonIgnore]
        private static QuackSettings _instance;
        public static QuackSettings Instance { get { return _instance ?? (_instance = new QuackSettings("QuackSettings")); } }
        public QuackSettings(string filename) : base(Path.Combine(CharacterSettingsDirectory, "Quack.json")) { }

        [Setting]
        public bool Enabled { get; set; }

        #region Time Settings
        [Setting]
        public int HoursElapsed { get; set; }
        [Setting]
        public int MinutesElapsed { get; set; }
        [Setting]
        public DateTime TimeEnd { get; set; }
        [Setting]
        public DateTime TimeStart { get; set; }
        #endregion
        #region Action Settings
        [Setting]
        public bool Teleport { get; set; }
        [Setting]
        public string TeleportLocation { get; set; }
        [Setting]
        public bool Logout { get; set; }
        #endregion
    }
}
#endregion

