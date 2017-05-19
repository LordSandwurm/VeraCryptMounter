﻿/***
 * <VeraCryptMounter. Programm to use Truecrypt drives and containers easier.>
 * Copyright (C) <2009>  <Rafael Grothmann>
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>.
 * **/
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace VeraCrypt_Mounter
{
    internal static class Mount
    {
        private const char Quote = '\u0022';
        //private const string Wipechache = " /w ";
        //private const string Cache = " /c ";
        //private const string Explore = " /e ";
        private const string Beep = " /b ";
        private const string DismountString = " /d ";
        private const string Force = " /f ";
        private const string Keyfile = " /k ";
        private const string Letter = " /l ";
        private const string Mountoption = " /m ";
        private const string MountoptionReadonly = "ro";
        private const string MountoptionRemovable = "rm";
        private const string Password = " /p ";
        private const string Quit = " /q ";
        private const string Silent = " /s ";
        private const string Volume = " /v ";
        private const string Pim = " /pim ";
        private const string Truecrypt = " /tc ";
        private const string Hash = " /hash ";
        private static readonly Config _config = new Config();
        private static readonly ProcessStartInfo Tc = new ProcessStartInfo();
        private static readonly Process Tcprocess = new Process();

        static Mount()
        {
            _config = Singleton<ConfigManager>.Instance.Init(_config);
        }

        /// <summary>
        /// Mount a Drive. Call veracrypt process and try to mount.
        /// </summary>
        /// <param name="partition"></param>
        /// <param name="driveletter"></param>
        /// <param name="keyfile"></param>
        /// <param name="password"></param>
        /// <param name="silent"></param>
        /// <param name="beep"></param>
        /// <param name="force"></param>
        /// <param name="readOnly"></param>
        /// <param name="removable"></param>
        /// <param name="pim"></param>
        /// <param name="hash"></param>
        /// <param name="tc"></param>
        /// <param name="showarguments">shows the argument string. Did not mount!</param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        internal static int MountDrive(string[] partition, string driveletter, string keyfile, string password, bool silent,
                                          bool beep, bool force, bool readOnly, bool removable, string pim, string hash, bool tc, bool showarguments = false)
        {
            int output = 1;
            const string status = "Die Vareable ist null oder leer:";
            try
            {
                if (partition.Length <= 0)
                {
                    throw new Exception(status + "(partition)");
                }
                if (string.IsNullOrEmpty(driveletter))
                {
                    throw new Exception(status + "(driveletter)");
                }

                if (!DrivelettersHelper.IsDriveletterFree(driveletter))
                {
                    throw new Exception("Laufwerksbuchstabe ist belegt");
                }
                if (!string.IsNullOrEmpty(keyfile))
                {
                    if (!File.Exists(keyfile))
                    {
                        throw new Exception("Keyfile nicht vorhanden");
                    }
                }
                //if (!File.Exists(Tc.FileName))
                //{
                //    throw new Exception("TrueCrypt.exe nicht vorhanden");
                //}
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 2;
            }

            string argumentstring = Letter + driveletter + Password + password +
                                    Quit;

            if (!string.IsNullOrEmpty(keyfile))
                argumentstring += Keyfile + Quote + keyfile + Quote;
            if (!string.IsNullOrEmpty(pim))
                argumentstring += Pim + Quote + pim + Quote;
            if (!string.IsNullOrEmpty(hash))
                argumentstring += Hash + Quote + hash + Quote;
            if (silent)
                argumentstring += Silent;
            if (beep)
                argumentstring += Beep;
            if (force)
                argumentstring += Force;
            if (removable)
                argumentstring += Mountoption + MountoptionRemovable;
            if (readOnly)
                argumentstring += Mountoption + MountoptionReadonly;
            if (tc)
                argumentstring += Truecrypt;         
# if DEBUG
            DialogResult result = MessageBox.Show(Tc.Arguments, "Mountstring", MessageBoxButtons.RetryCancel);
            if (result == DialogResult.Cancel)
                return 2;
#endif
            

            if (showarguments)
            {
                foreach (string pa in partition)
                {
                    string path = Volume + pa;
                    
                }
            }
            else
            {
                foreach (string pa in partition)
                {
                    string path = Volume + pa;
                    output = ProcessMount(argumentstring, path);
                }
            }       
            return output;

        }
        /// <summary>
        /// Mount the container for the keyfiles.
        /// </summary>
        /// <param name="path"></param>
        /// <param name="driveletter"></param>
        /// <param name="silent"></param>
        /// <param name="beep"></param>
        /// <param name="force"></param>
        /// <param name="readOnly"></param>
        /// <param name="removable"></param>
        /// <param name="hash"></param>
        /// <param name="pim"></param>
        /// <returns></returns>
        public static int MountKeyfileContainer(string path, string driveletter, bool silent, bool beep, bool force,
                                                bool readOnly, bool removable, string hash, bool pim)
        {
            int output;
            const string status = "Die Vareable ist null oder leer:";
            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    throw new Exception(status + "(path)");
                }

                if (string.IsNullOrEmpty(driveletter))
                {
                    throw new Exception(status + "(driveletter)");
                }
                if (!DrivelettersHelper.IsDriveletterFree(driveletter))
                {
                    throw new Exception("Laufwerksbuchstabe ist belegt");
                }
                //if (!File.Exists(Tc.FileName))
                //{
                //    throw new Exception("TrueCrypt.exe nicht vorhanden");
                //}
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 2;
            }

            string argumentstring = Volume + path + Letter + driveletter + Quit;

            if (!string.IsNullOrEmpty(hash))
                argumentstring += Hash + Quote + hash + Quote;
            if (pim)
                argumentstring += Pim + Quote + "0" + Quote; 
            if (silent)
                argumentstring += Silent;
            if (beep)
                argumentstring += Beep;
            if (force)
                argumentstring += Force;
            if (readOnly)
                argumentstring += Mountoption + MountoptionReadonly;
            if (removable)
                argumentstring += Mountoption + MountoptionRemovable;
# if DEBUG
            DialogResult result = MessageBox.Show(argumentstring, "Mountstring", MessageBoxButtons.RetryCancel);
            if (result == DialogResult.Cancel)
                return 2;
#endif
            output = ProcessMount(argumentstring);
            return output;
        }
        /// <summary>
        /// Dissmount a drive or a kontainer.
        /// </summary>
        /// <param name="driveletter"></param>
        /// <param name="silent"></param>
        /// <param name="beep"></param>
        /// <param name="force"></param>
        /// <returns></returns>
        public static int Dismount(string driveletter, bool silent, bool beep, bool force)
        {
            int output;
            const string status = "Die Vareable ist null oder leer:";
            try
            {
                if (string.IsNullOrEmpty(driveletter))
                {
                    throw new Exception(status + "(driveletter)");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 1;
            }

            string argumentstring = DismountString + driveletter + Quit;

            if (silent)
                argumentstring += Silent;
            if (beep)
                argumentstring += Beep;
            if (force)
                argumentstring += Force;
# if DEBUG
            DialogResult result = MessageBox.Show(argumentstring, "Mountstring", MessageBoxButtons.RetryCancel);
            if (result == DialogResult.Cancel)
                return 2;
#endif
            output = ProcessMount(argumentstring);
            return output;
        }

        /// <summary>
        /// Mount a kontainer. Call veracrypt process and try to mount kontainer
        /// </summary>
        /// <param name="path"></param>
        /// <param name="driveletter"></param>
        /// <param name="keyfile"></param>
        /// <param name="password"></param>
        /// <param name="silent"></param>
        /// <param name="beep"></param>
        /// <param name="force"></param>
        /// <param name="readOnly"></param>
        /// <param name="removable"></param>
        /// <param name="tc"></param>
        /// <param name="pim"></param>
        /// <param name="hash"></param>
        /// <param name="showarguments"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public static int MountContainer(string path, string driveletter, string keyfile, string password, bool silent,
                                         bool beep, bool force, bool readOnly, bool removable, bool tc, string pim, string hash, bool showarguments = false)
        {
            int output = 2;
            const string status = "Die Vareable ist null oder leer:";
            try
            {
                if (string.IsNullOrEmpty(path))
                {
                    throw new Exception(status + "(path)");
                }

                if (string.IsNullOrEmpty(driveletter))
                {
                    throw new Exception(status + "(driveletter)");
                }
                if (!DrivelettersHelper.IsDriveletterFree(driveletter))
                {
                    throw new Exception("Laufwerksbuchstabe ist belegt");
                }
                //if (!File.Exists(Tc.FileName))
                //{
                //    throw new Exception("TrueCrypt.exe nicht vorhanden");
                //}
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 2;
            }
            string argumentstring = Volume + path + Letter + driveletter + Password + password + Quit;

            if (!string.IsNullOrEmpty(keyfile))
                argumentstring += Keyfile + Quote + keyfile + Quote;
            if (!string.IsNullOrEmpty(pim))
                argumentstring += Pim + Quote + pim + Quote;
            if (!string.IsNullOrEmpty(hash))
                argumentstring += Hash + Quote + hash + Quote;
            if (silent)
                argumentstring += Silent;
            if (beep)
                argumentstring += Beep;
            if (force)
                argumentstring += Force;
            if (readOnly)
                argumentstring += Mountoption + MountoptionReadonly;
            if (removable)
                argumentstring += Mountoption + MountoptionRemovable;
            if (tc)
                argumentstring += Truecrypt;

# if DEBUG
            DialogResult result = MessageBox.Show(argumentstring, "Mountstring", MessageBoxButtons.RetryCancel);
            if (result == DialogResult.Cancel)
                return 2;
            //Clipboard.SetDataObject(argumentstring, true);
#endif
            output = ProcessMount(argumentstring);
            return output;
        }
        /// <summary>
        /// Process veracrypt exe 
        /// </summary>
        /// <param name="argumentstring"></param>
        /// <param name="path"></param>
        /// <returns></returns>
        private static int ProcessMount(string argumentstring, string path = "")
        {
            int ret = 1;
            Tc.FileName = _config.GetValue(ConfigTrm.Mainconfig.Section, ConfigTrm.Mainconfig.Truecryptpath, "");
            Tc.RedirectStandardOutput = true;
            Tc.UseShellExecute = false;

            Tc.Arguments = path + argumentstring;
            try
            {
                Tcprocess.StartInfo = Tc;
                Tcprocess.Start();
                Tcprocess.WaitForExit();
                ret = Tcprocess.ExitCode;
                Tcprocess.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return 1;
            }
            return ret;
        }
    }
}