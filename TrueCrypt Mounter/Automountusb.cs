﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace VeraCrypt_Mounter
{
    public static class Automountusb
    {
        private static Config _config = new Config();

        public static void MountUsb(string device)
        {
            string test = device;
            int ven = test.IndexOf("VEN_");
            ven = ven + 4;
            int prod = test.IndexOf("PROD_");
            prod = prod + 5;
            int venend = test.IndexOf("&", ven);
            int prodend = test.IndexOf("&", prod);
            string vend = test.Substring(ven, venend - ven);
            string produ = test.Substring(prod, prodend - prod);
            //TODO extract device info from string to get wmi info 
            
            //WmiDriveInfo info = new WmiDriveInfo();
            //info.

        }

        /// <summary>
        /// Get list of drives which have the automount label.
        /// </summary>
        /// <returns>List of drives</returns>
        private static List<string> GetAutoDrives()
        {
            List<string> drives = new List<string>();

            string[] sections = _config.GetSectionNames();

            foreach (string section in sections)
            {
                if (_config.GetValue(section, ConfigTrm.Mainconfig.Type, "") == "Drive")
                {
                    if (_config.GetValue(section, ConfigTrm.Container.Automountusb, false))
                    {
                        drives.Add(section);
                    }
                }
            }
            return drives;
        }

        /// <summary>
        /// Get list of containers which have the automount label.
        /// </summary>
        /// <returns>List of containers</returns>
        private static List<string> GetAutoContainers()
        {
            List<string> containers = new List<string>();

            string[] sections = _config.GetSectionNames();

            foreach (string section in sections)
            {
                if (_config.GetValue(section, ConfigTrm.Mainconfig.Type, "") == "Container")
                {
                    if (_config.GetValue(section, ConfigTrm.Drive.Automountusb, false))
                    {
                        containers.Add(section);
                    }
                }
            }
            return containers;
        }

    }
}

