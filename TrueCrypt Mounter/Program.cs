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
using System.Management;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

namespace VeraCrypt_Mounter
{


    internal class Program
    {
        private static string[] _driveliste;

        public string[] Drivelist
        {
            get { return _driveliste; }
            set { _driveliste = value; }
        }


        /// <summary>
        /// Der Haupteinstiegspunkt für die Anwendung.
        /// </summary>
        [STAThread]
        private static void Main()
        {
           

            bool createdNew;
            using (var mutex = new Mutex(true, "VeraCryptMounter", out createdNew))
            {
                if (createdNew)
                {               
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    
                    //show password form to decrypt config
                    var dialogBoxPassword = new Password();
                    var result = dialogBoxPassword.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        Application.Run(new VeraCryptMounter());
                    }
                    else
                    {
                        Application.Exit();
                    }
                }
                else
                {
                    Process current = Process.GetCurrentProcess();
                    foreach (Process process in Process.GetProcessesByName(current.ProcessName))
                    {
                        if (process.Id != current.Id)
                        {
                            if (!NativeMethods.SetForegroundWindow(process.MainWindowHandle))
                                throw new System.ComponentModel.Win32Exception();
                            break;
                        }
                    }
                }
            }
        }       
    }
    internal static class NativeMethods
    {
        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        internal static extern bool SetForegroundWindow(IntPtr hWnd);
    }
}