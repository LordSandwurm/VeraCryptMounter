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
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace VeraCrypt_Mounter
{
    /// <summary>
    /// Form for container config.
    /// </summary>
    public partial class NewContainer : Form
    {
        private readonly Config _config = new Config();
        private readonly List<string> _driveletters = new List<string>();
        private readonly List<string> _useddriveletters = new List<string>();
        private const string LanguageRegion = "NewContainer";
        private readonly string _language;
        private string _oldName;
        private object[] _hashes = { "", "sha512", "sha256", "whirlpool", "ripemd160", "streebog"
        };
        private string _password = "";
        private string _pim = "";
        private string _pnpid;
        private string _partnummber;

        /// <summary>
        /// Constructor for creating a new container.
        /// </summary>
        public NewContainer()
        {
            InitializeComponent();
            _config = Singleton<ConfigManager>.Instance.Init(_config);
            _language = _config.GetValue(ConfigTrm.Mainconfig.Section, ConfigTrm.Mainconfig.Language, "");
            LanguageFill();
            NewKontainer();
        }

        /// <summary>
        /// Constructor for editing a container.
        /// </summary>
        /// <param name="description"></param>
        public NewContainer(string description)
        {
            InitializeComponent();
            _config = Singleton<ConfigManager>.Instance.Init(_config);
            _language = _config.GetValue(ConfigTrm.Mainconfig.Section, ConfigTrm.Mainconfig.Language, "");
            LanguageFill();
            if (string.IsNullOrEmpty(description))
                Close();
            NewKontainerEdit(description);
        }

        /// <summary>
        /// Set the languagestrings for the controls.
        /// </summary>
        private void LanguageFill()
        {
            try
            {
                Text = LanguagePool.GetInstance().GetString(LanguageRegion, "Form", _language);
                groupBoxDescription.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "groupBoxDescription", _language);
                groupBoxPath.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "groupBoxPath", _language);
                groupBoxKyfilename.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "groupBoxKyfilename", _language);
                
                groupBoxDriveletter.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "groupBoxDriveletter", _language);
                groupBoxMountoptions.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "groupBoxMountoptions", _language);
                checkBoxNoKeyfile.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "checkBoxNoKeyfile", _language);
                
                checkBoxRemovable.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "checkBoxRemovable", _language);
                checkBoxReadonly.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "checkBoxReadonly", _language);
                buttonOk.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "buttonOk", _language);
                buttonClose.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "buttonClose", _language);
                buttonOpenContainer.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "buttonOpenContainer", _language);
                
                checkBoxAutomountUsb.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "checkBoxAutomountUsb", _language);
                checkBoxAutomountStart.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "checkBoxAutomountStart", _language);
                groupBoxHash.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "groupBoxHash", _language);
                groupBoxSavePassword.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "groupBoxSavePassword", _language);
                buttonSavePassword.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "buttonSavePassword", _language);
                buttonShowPassword.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "buttonShowPassword", _language);
                checkBoxPassword.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "checkBoxPassword", _language);
                //.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "", _language);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
            
        }

        /// <summary>
        /// Fill all controls with information for creating a new container.
        /// </summary>
        private void NewKontainer()
        {
            foreach (string element in DrivelettersHelper.GetDriveletters())
                _driveletters.Add(element);
            foreach (string elemnt in DrivelettersHelper.GetUsedDriveletter())
                _useddriveletters.Add(elemnt);

            comboBoxHash.Items.AddRange(_hashes);

            comboBoxDriveletter.DataSource = _driveletters;

            buttonShowPassword.Enabled = false;
        }

        /// <summary>
        /// Fill all controls for editing a container.
        /// </summary>
        /// <param name="description"></param>
        private void NewKontainerEdit(string description)
        {
            _oldName = description;
            string path = _config.GetValue(description, ConfigTrm.Container.Kontainerpath, "");
            textBoxDescription.Text = description;
            comboBoxHash.Items.AddRange(new object[] { "", "sha512", "sha256", "wirlpool", "ripemd160", "streebog" });
            comboBoxHash.SelectedItem = _config.GetValue(description, ConfigTrm.Container.Hash, "");
            checkBoxNoKeyfile.Checked = _config.GetValue(description, ConfigTrm.Container.Nokeyfile, false);
            
            textBoxKontainer.Text = path;
            textBoxKeyfile.Text = _config.GetValue(description, ConfigTrm.Container.Keyfile, "");
            checkBoxReadonly.Checked = _config.GetValue(description, ConfigTrm.Container.Readonly, false);
            checkBoxRemovable.Checked = _config.GetValue(description, ConfigTrm.Container.Removable, false);
            checkBoxAutomountStart.Checked = _config.GetValue(description, ConfigTrm.Container.Automountstart, false);
            checkBoxAutomountUsb.Checked = _config.GetValue(description, ConfigTrm.Container.Automountusb, false);
            checkBoxTrueCrypt.Checked = _config.GetValue(description, ConfigTrm.Container.Truecrypt, false);
            checkBoxPim.Checked = _config.GetValue(description, ConfigTrm.Container.Pimuse, false);
            _password = _config.GetValue(description, ConfigTrm.Drive.Password, "");
            _pim = _config.GetValue(description, ConfigTrm.Drive.Pim, "");

            foreach (string element in DrivelettersHelper.GetDriveletters())
                _driveletters.Add(element);
            foreach (string elemnt in DrivelettersHelper.GetUsedDriveletter())
                _useddriveletters.Add(elemnt);

            comboBoxDriveletter.DataSource = _driveletters;

            comboBoxDriveletter.SelectedItem = _config.GetValue(description, ConfigTrm.Container.Driveletter, "");

            WmiDriveInfo wmiinfo = new WmiDriveInfo();

            // TODO Automatisch ermitteln der PNPID für den pfad FEHLERBEHANDLUNG
            _pnpid = _config.GetValue(description, ConfigTrm.Container.Pnpid, "");
            _partnummber = _config.GetValue(description, ConfigTrm.Container.Partnummber, "");

            if ( !string.IsNullOrEmpty(_pnpid) || !string.IsNullOrEmpty(_partnummber))
            {
                string driveletterFromPath = "";
                try
                {
                    driveletterFromPath = Path.GetPathRoot(@path);
                    driveletterFromPath = driveletterFromPath.Replace(@"\", "");
                    string[] pnpandin = wmiinfo.GetPNPidfromDriveletter(driveletterFromPath);
                    textBoxSelectedDrive.Text = pnpandin[0] + " Partition: " + pnpandin[1];
                }
                catch (Exception)
                {
                    textBoxSelectedDrive.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "MessageDriveNotConnected", _language);
                }
                
            }

            if (string.IsNullOrEmpty(_password))
                buttonShowPassword.Enabled = false;


        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            openFileDialogKontainer.ShowDialog();
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void checkBoxNoKeyfile_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNoKeyfile.Checked)
            {
                textBoxKeyfile.Enabled = false;
            }
            else
            {
                textBoxKeyfile.Enabled = true;
            }
        }

        private void openFileDialogKontainerFileOK(object sender, CancelEventArgs e)
        {
            WmiDriveInfo wmiinfo = new WmiDriveInfo();
            string path = null;
            string driveletterFromPath = null;

            path = textBoxKontainer.Text = openFileDialogKontainer.FileName;

            try
            {
                driveletterFromPath = Path.GetPathRoot(@path);
                driveletterFromPath = driveletterFromPath.Replace(@"\", "");
                string[] pnpandin = wmiinfo.GetPNPidfromDriveletter(driveletterFromPath);
                textBoxSelectedDrive.Text = pnpandin[0] + " Partition: " + pnpandin[1];
            }
            catch (Exception)
            {
                textBoxSelectedDrive.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "MessageDriveNotConnected", _language);
                checkBoxAutomountUsb.Checked = false;
                checkBoxAutomountUsb.Enabled = false;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            string description = textBoxDescription.Text;
            string driveletterFromPath = "";
            string keyfile = textBoxKeyfile.Text;
            string usedriveletter = DrivelettersHelper.IsDrivletterUsedByConfig(comboBoxDriveletter.SelectedItem.ToString());
            WmiDriveInfo wmiinfo = new WmiDriveInfo();

            try
            {
                if (checkBoxPim.Checked)
                {
                    if (string.IsNullOrEmpty(_pim) && !string.IsNullOrEmpty(_password))
                        throw new Exception(LanguagePool.GetInstance().GetString(LanguageRegion, "MessagePimNotSet", _language));
                }
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                buttonSavePassword_Click(this, e);
            }

            try
            {
                if (usedriveletter != null && usedriveletter != description)
                    throw new Exception(LanguagePool.GetInstance().GetString(LanguageRegion, "MessageDrivletterIsUsed", _language) + usedriveletter);
            }
            catch (Exception ex)
            {
                DialogResult res = MessageBox.Show(ex.Message, "", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                if (res == DialogResult.Abort)
                {
                    return;
                }
                if (res == DialogResult.Retry)
                {
                    buttonOk_Click(sender, e);
                    return;
                }

            }

            try
            {

                if (string.IsNullOrEmpty(description))
                {
                    throw new Exception(LanguagePool.GetInstance().GetString(LanguageRegion, "MessageDescriptionNullorEmpty", _language));
                }

                if (_oldName != null)
                    if (description != _oldName)
                        _config.RemoveSection(_oldName);

                

                if (!checkBoxNoKeyfile.Checked)
                {
                    _config.SetValue(description, ConfigTrm.Container.Keyfile, keyfile);

                }

                driveletterFromPath = Path.GetPathRoot(@textBoxKontainer.Text);
                driveletterFromPath = driveletterFromPath.Replace(@"\", "");
                string[] pnpandin = wmiinfo.GetPNPidfromDriveletter(driveletterFromPath);

                //if no pnpdeviceid is found set to nothing
                if (pnpandin == null)
                {
                    pnpandin = new string[2];
                    pnpandin[0] = "";
                    pnpandin[1] = "";
                }

                textBoxSelectedDrive.Text = pnpandin[0] + " Partition: " + pnpandin[1];

                if (checkBoxAutomountUsb.Checked)
                {
                    
                }

                string hash = (comboBoxHash.SelectedItem == null) ? "" : comboBoxHash.SelectedItem.ToString();

                _config.SetValue(description, ConfigTrm.Container.Type, ConfigTrm.Container.Typename);
                _config.SetValue(description, ConfigTrm.Container.Kontainerpath, textBoxKontainer.Text);
                _config.SetValue(description, ConfigTrm.Container.Driveletter, comboBoxDriveletter.SelectedItem.ToString());
                _config.SetValue(description, ConfigTrm.Container.Readonly, checkBoxReadonly.Checked);
                _config.SetValue(description, ConfigTrm.Container.Removable, checkBoxRemovable.Checked); 
                _config.SetValue(description, ConfigTrm.Container.Nokeyfile, checkBoxNoKeyfile.Checked);
                _config.SetValue(description, ConfigTrm.Container.Automountstart, checkBoxAutomountStart.Checked);
                _config.SetValue(description, ConfigTrm.Container.Automountusb, checkBoxAutomountUsb.Checked);
                _config.SetValue(description, ConfigTrm.Container.Pimuse, checkBoxPim.Checked);
                _config.SetValue(description, ConfigTrm.Container.Truecrypt, checkBoxTrueCrypt.Checked);
                _config.SetValue(description, ConfigTrm.Container.Hash, hash);
                _config.SetValue(description, ConfigTrm.Container.Pnpid, pnpandin[0]);
                _config.SetValue(description, ConfigTrm.Container.Partnummber, pnpandin[1]);

                if (!string.IsNullOrEmpty(_password))
                {
                    _config.SetValue(description, ConfigTrm.Container.Password, _password);
                    _config.SetValue(description, ConfigTrm.Container.Pim, _pim);
                }

                if (checkBoxPassword.Checked)
                {
                    _config.SetValue(description, ConfigTrm.Container.Password, "");
                    _config.SetValue(description, ConfigTrm.Container.Pim, "");
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            _password = null;
            _pim = null;
            Close();
        }

        private void ComboBoxDriveletter_MeasureItem(object sender,
                                                     MeasureItemEventArgs e)
        {
            // ItemHeight shout be font size + 4 
            e.ItemHeight = 12;
            //e.ItemWidth = 120;
        }

        // You must handle the DrawItem event for owner-drawn combo boxes.  
        // This event handler changes the color, size and font of an 
        // item based on its position in the array.
        private void ComboBoxDriveletter_DrawItem(object sender,
                                                  DrawItemEventArgs e)
        {
            Font myFont;

            float size = 8;
            const FontStyle fstyle = FontStyle.Regular;
            string fontname = comboBoxDriveletter.Font.Name;
            //FontFamily family = FontFamily.GenericSansSerif;
            Brush brush = Brushes.Black;

            if (_useddriveletters.Contains(_driveletters[e.Index]))
                brush = Brushes.Red;

            // Draw the background of the item.
            e.DrawBackground();

            // Draw each string in the array, using a different size, color,
            // and font for each item.
            myFont = new Font(fontname, size, fstyle);
            e.Graphics.DrawString(_driveletters[e.Index], myFont, brush, e.Bounds.X, e.Bounds.Y);

            // Draw the focus rectangle if the mouse hovers over an item.
            e.DrawFocusRectangle();
        }

        private void checkBoxTrueCrypt_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTrueCrypt.Checked)
            {
                checkBoxPim.Enabled = false;
                checkBoxPim.Checked = false;
            }
            else
                checkBoxPim.Enabled = true;
        }

        private void comboBoxHash_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxHash.DroppedDown = true;
        }

        private void buttonSavePassword_Click(object sender, EventArgs e)
        {
            
            Passwordinput pw = new Passwordinput(ConfigTrm.Container.Typename, checkBoxPim.Checked);
            DialogResult res = pw.ShowDialog();
            if (res == DialogResult.OK)
            {
                _password = pw._password;
                _pim = pw._pim;
                buttonShowPassword.Enabled = true;
            }
            pw._password = null;
            pw._pim = null;
            pw.Dispose();
        }

        private void comboBoxDriveletter_MouseClick(object sender, MouseEventArgs e)
        {
            comboBoxDriveletter.DroppedDown = true;
        }

        private void buttonSelectDrive_Click(object sender, EventArgs e)
        {
            SelectPartition sp = new SelectPartition();
            DialogResult res = sp.ShowDialog();
            if (res == DialogResult.OK)
            {
                _pnpid = sp._pNPDeviceID;
                _partnummber = sp._partnummber;
                textBoxSelectedDrive.Text = sp._diskmodel + " Partition: " + sp._partnummber;
            }
        }

        private void checkBoxPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPassword.Checked)
            {
                buttonSavePassword.Enabled = buttonShowPassword.Enabled = false;
            }
            else
            {
                buttonSavePassword.Enabled = true;

                if (!string.IsNullOrEmpty(_password))
                    buttonShowPassword.Enabled = true;
            }
        }

        private void buttonShowPassword_Click(object sender, EventArgs e)
        {
            Passwordinput pin = new Passwordinput();
            DialogResult res = pin.ShowDialog();
            if (res == DialogResult.OK)
            {
                if (Password_helper.Check_password(pin._password))
                {
                    Passwordinput pinshow = new Passwordinput("drive", checkBoxPim.Checked, _password, _pim);
                    pinshow.ShowDialog();
                }
                else
                {
                    DialogResult wrongres = MessageBox.Show(this, LanguagePool.GetInstance().GetString(LanguageRegion, "MessageMasterPasswordWrong", _language), "", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (wrongres == DialogResult.Retry)
                        buttonShowPassword_Click(sender, e);
                }
            }
        }

        private void buttonSelectKeyfile_Click(object sender, EventArgs e)
        {
            openFileDialogKeyfile.ShowDialog();
        }

        private void openFileDialogKeyfile_FileOk(object sender, CancelEventArgs e)
        {
            textBoxKeyfile.Text = openFileDialogKeyfile.FileName;
        }
    }
}