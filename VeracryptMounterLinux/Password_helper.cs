﻿using System;
using System.IO;

namespace VeracryptMounterLinux
{
    static class Password_helper
    {
        private static string _password;
        private static string _confDir;

        public static string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        private static void CheckConfDir()
        {
            _confDir = string.Format("{0}\\TRM.config", System.IO.Directory.GetCurrentDirectory());
            if (!File.Exists(string.Format(_confDir)))
                return;
            try
            {
                using (FileStream fs = File.Create(Path.Combine(System.IO.Directory.GetCurrentDirectory(), Path.GetRandomFileName()), 1, FileOptions.DeleteOnClose))
                { }
            }
            catch
            {
                //TODO If config is not writable then exit 
                
                //_confDir = string.Format("{0}\\TRM.config", Application.LocalUserAppDataPath);
            }
        }
        public static bool Check_password()
        {

            CheckConfDir();
      
            var conf = new Config();
            conf.XmlPathName = string.Format(_confDir);
            Console.WriteLine(_confDir);
            conf.GroupName = null;
            if (conf.HasEntry(ConfigTrm.Mainconfig.Section,ConfigTrm.Mainconfig.Passwordtest))
            {
                Console.WriteLine(conf.GetValue(ConfigTrm.Mainconfig.Section, ConfigTrm.Mainconfig.Passwordtest, "baum"));
                if (conf.GetValue(ConfigTrm.Mainconfig.Section, ConfigTrm.Mainconfig.Passwordtest, "").Equals("Waldmann"))
                    return true;
            }
            return false;
        }

        public static bool Check_password(string password)
        {
            if (string.IsNullOrEmpty(password))
                return false;

            if (password.Equals(_password))
            {
                password = null;
                return true;
            }
            password = null;
            return false;
        }

        /// <summary>
        /// Change the master password for the encryption of the config
        /// </summary>
        /// <param name="newPassword"></param>
        /// <exception cref="ArgumentNullException">Throws if passwort is null or empty</exception>
        public static void ChangePassword(string newPassword)
        {
            if (string.IsNullOrEmpty(newPassword))
                throw new ArgumentNullException("new password is null or empty");

            CheckConfDir();

            var conf = new Config();
            conf.XmlPathName = string.Format(_confDir);
            conf.GroupName = null;

            string[] sections = conf.GetSectionNames();

            foreach (string section in sections)
            {
                if (!string.Equals(section, "configSections"))
                {
                    string[] entrys = conf.GetEntryNames(section);
                    foreach (string entry in entrys)
                    {
                        var vars = conf.GetValue(section, entry);
                        var oldpw = _password;
                        _password = newPassword;
                        conf.SetValue(section, entry, vars);
                        _password = oldpw;
                    }
                }
                    
                
            }

        }

    }
}
