﻿using System;
using System.Windows.Forms;

namespace VeraCrypt_Mounter
{
    partial class VeraCryptMounter
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VeraCryptMounter));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemClose = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNew = new System.Windows.Forms.ToolStripMenuItem();
            this.driveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.containerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemEditEntry = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.automountToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemMainSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuVersion = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonMount = new System.Windows.Forms.Button();
            this.comboBoxDrives = new System.Windows.Forms.ComboBox();
            this.buttonKeyfileContainerMount = new System.Windows.Forms.Button();
            this.buttonDismount = new System.Windows.Forms.Button();
            this.groupBoxDrive = new System.Windows.Forms.GroupBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ToolStripMenuItemNotifyKeyfilecontainer = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNotifyMount = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNotifyDismount = new System.Windows.Forms.ToolStripMenuItem();
            this.automountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNotifyRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNotifyClose = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBoxKeyfileContainer = new System.Windows.Forms.GroupBox();
            this.buttonKeyfileContainerDismount = new System.Windows.Forms.Button();
            this.groupBoxContainer = new System.Windows.Forms.GroupBox();
            this.comboBoxContainer = new System.Windows.Forms.ComboBox();
            this.buttonDismountContainer = new System.Windows.Forms.Button();
            this.buttonMountContainer = new System.Windows.Forms.Button();
            this.toolTipMain = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripLabelNotification = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
            this.contextMenuStripDrive = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Drive_new = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem_Drive_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showCommandToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripContainer = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem_Container_new = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem_Container_edit = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.groupBoxDrive.SuspendLayout();
            this.contextMenuStrip.SuspendLayout();
            this.groupBoxKeyfileContainer.SuspendLayout();
            this.groupBoxContainer.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.contextMenuStripDrive.SuspendLayout();
            this.contextMenuStripContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile,
            this.ToolStripMenuItemEdit,
            this.toolStripMenuItemSettings,
            this.ToolStripMenuItemHelp});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(525, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile
            // 
            this.ToolStripMenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemClose});
            this.ToolStripMenuItemFile.Name = "ToolStripMenuItemFile";
            this.ToolStripMenuItemFile.Size = new System.Drawing.Size(57, 24);
            this.ToolStripMenuItemFile.Text = "Datei";
            // 
            // ToolStripMenuItemClose
            // 
            this.ToolStripMenuItemClose.Name = "ToolStripMenuItemClose";
            this.ToolStripMenuItemClose.Size = new System.Drawing.Size(142, 26);
            this.ToolStripMenuItemClose.Text = "Beenden";
            this.ToolStripMenuItemClose.Click += new System.EventHandler(this.ToolStripMenuClose_Click);
            // 
            // ToolStripMenuItemEdit
            // 
            this.ToolStripMenuItemEdit.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNew,
            this.ToolStripMenuItemEditEntry,
            this.ToolStripMenuItemRemove,
            this.automountToolStripMenuItem1});
            this.ToolStripMenuItemEdit.Name = "ToolStripMenuItemEdit";
            this.ToolStripMenuItemEdit.Size = new System.Drawing.Size(93, 24);
            this.ToolStripMenuItemEdit.Text = "Bearbeiten";
            // 
            // ToolStripMenuItemNew
            // 
            this.ToolStripMenuItemNew.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.driveToolStripMenuItem,
            this.containerToolStripMenuItem});
            this.ToolStripMenuItemNew.Name = "ToolStripMenuItemNew";
            this.ToolStripMenuItemNew.Size = new System.Drawing.Size(159, 26);
            this.ToolStripMenuItemNew.Text = "Neu";
            // 
            // driveToolStripMenuItem
            // 
            this.driveToolStripMenuItem.Name = "driveToolStripMenuItem";
            this.driveToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.driveToolStripMenuItem.Text = "Drive";
            this.driveToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuDriveNew_Click);
            // 
            // containerToolStripMenuItem
            // 
            this.containerToolStripMenuItem.Name = "containerToolStripMenuItem";
            this.containerToolStripMenuItem.Size = new System.Drawing.Size(148, 26);
            this.containerToolStripMenuItem.Text = "Container";
            this.containerToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuContainerNew_Click);
            // 
            // ToolStripMenuItemEditEntry
            // 
            this.ToolStripMenuItemEditEntry.Name = "ToolStripMenuItemEditEntry";
            this.ToolStripMenuItemEditEntry.Size = new System.Drawing.Size(159, 26);
            this.ToolStripMenuItemEditEntry.Text = "Bearbeiten";
            this.ToolStripMenuItemEditEntry.Click += new System.EventHandler(this.ToolStripMenuEditEntry_Click);
            // 
            // ToolStripMenuItemRemove
            // 
            this.ToolStripMenuItemRemove.Name = "ToolStripMenuItemRemove";
            this.ToolStripMenuItemRemove.Size = new System.Drawing.Size(159, 26);
            this.ToolStripMenuItemRemove.Text = "Löschen";
            this.ToolStripMenuItemRemove.Click += new System.EventHandler(this.ToolStripMenuDelete_Click);
            // 
            // automountToolStripMenuItem1
            // 
            this.automountToolStripMenuItem1.Name = "automountToolStripMenuItem1";
            this.automountToolStripMenuItem1.Size = new System.Drawing.Size(159, 26);
            this.automountToolStripMenuItem1.Text = "Automount";
            this.automountToolStripMenuItem1.Click += new System.EventHandler(this.automountToolStripMenuItem1_Click);
            // 
            // toolStripMenuItemSettings
            // 
            this.toolStripMenuItemSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemMainSettings});
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            this.toolStripMenuItemSettings.Size = new System.Drawing.Size(109, 24);
            this.toolStripMenuItemSettings.Text = "Einstellungen";
            // 
            // ToolStripMenuItemMainSettings
            // 
            this.ToolStripMenuItemMainSettings.Name = "ToolStripMenuItemMainSettings";
            this.ToolStripMenuItemMainSettings.Size = new System.Drawing.Size(212, 26);
            this.ToolStripMenuItemMainSettings.Text = "Grundeinstellungen";
            this.ToolStripMenuItemMainSettings.Click += new System.EventHandler(this.ToolStripMenuMainconfig_Click);
            // 
            // ToolStripMenuItemHelp
            // 
            this.ToolStripMenuItemHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuVersion});
            this.ToolStripMenuItemHelp.Name = "ToolStripMenuItemHelp";
            this.ToolStripMenuItemHelp.Size = new System.Drawing.Size(53, 24);
            this.ToolStripMenuItemHelp.Text = "Hilfe";
            // 
            // toolStripMenuVersion
            // 
            this.toolStripMenuVersion.Name = "toolStripMenuVersion";
            this.toolStripMenuVersion.Size = new System.Drawing.Size(132, 26);
            this.toolStripMenuVersion.Text = "Version";
            this.toolStripMenuVersion.Click += new System.EventHandler(this.ToolStripMenuVersion_Click);
            // 
            // buttonMount
            // 
            this.buttonMount.Location = new System.Drawing.Point(361, 25);
            this.buttonMount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMount.Name = "buttonMount";
            this.buttonMount.Size = new System.Drawing.Size(133, 28);
            this.buttonMount.TabIndex = 3;
            this.buttonMount.Text = "Mount";
            this.buttonMount.UseVisualStyleBackColor = true;
            this.buttonMount.Click += new System.EventHandler(this.ButtonMountDrive_Click);
            // 
            // comboBoxDrives
            // 
            this.comboBoxDrives.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxDrives.FormattingEnabled = true;
            this.comboBoxDrives.Location = new System.Drawing.Point(5, 27);
            this.comboBoxDrives.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Size = new System.Drawing.Size(347, 23);
            this.comboBoxDrives.TabIndex = 1;
            this.comboBoxDrives.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_Laufwerke_DrawItem);
            this.comboBoxDrives.DropDown += new System.EventHandler(this.comboBoxDrives_DropDown);
            this.comboBoxDrives.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.ComboBox_Laufwerke_MeasureItem);
            this.comboBoxDrives.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxDrives_MouseClick);
            // 
            // buttonKeyfileContainerMount
            // 
            this.buttonKeyfileContainerMount.Location = new System.Drawing.Point(25, 20);
            this.buttonKeyfileContainerMount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKeyfileContainerMount.Name = "buttonKeyfileContainerMount";
            this.buttonKeyfileContainerMount.Size = new System.Drawing.Size(224, 30);
            this.buttonKeyfileContainerMount.TabIndex = 11;
            this.buttonKeyfileContainerMount.Text = "Keyfile Kontainer Mount";
            this.buttonKeyfileContainerMount.UseVisualStyleBackColor = true;
            this.buttonKeyfileContainerMount.Click += new System.EventHandler(this.ButtonKeyfileContainerMount_Click);
            // 
            // buttonDismount
            // 
            this.buttonDismount.Location = new System.Drawing.Point(361, 62);
            this.buttonDismount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDismount.Name = "buttonDismount";
            this.buttonDismount.Size = new System.Drawing.Size(133, 28);
            this.buttonDismount.TabIndex = 4;
            this.buttonDismount.Text = "Dismount";
            this.buttonDismount.UseVisualStyleBackColor = true;
            this.buttonDismount.Click += new System.EventHandler(this.ButtonDismountDrive_Click);
            // 
            // groupBoxDrive
            // 
            this.groupBoxDrive.Controls.Add(this.buttonDismount);
            this.groupBoxDrive.Controls.Add(this.comboBoxDrives);
            this.groupBoxDrive.Controls.Add(this.buttonMount);
            this.groupBoxDrive.Location = new System.Drawing.Point(9, 30);
            this.groupBoxDrive.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDrive.Name = "groupBoxDrive";
            this.groupBoxDrive.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxDrive.Size = new System.Drawing.Size(507, 100);
            this.groupBoxDrive.TabIndex = 0;
            this.groupBoxDrive.TabStop = false;
            this.groupBoxDrive.Text = "Laufwerksauswahl";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TrueCrypt Mounter";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNotifyKeyfilecontainer,
            this.automountToolStripMenuItem,
            this.ToolStripMenuItemNotifyRestore,
            this.ToolStripMenuItemNotifyClose});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.Size = new System.Drawing.Size(186, 100);
            // 
            // ToolStripMenuItemNotifyKeyfilecontainer
            // 
            this.ToolStripMenuItemNotifyKeyfilecontainer.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNotifyMount,
            this.ToolStripMenuItemNotifyDismount});
            this.ToolStripMenuItemNotifyKeyfilecontainer.Name = "ToolStripMenuItemNotifyKeyfilecontainer";
            this.ToolStripMenuItemNotifyKeyfilecontainer.Size = new System.Drawing.Size(185, 24);
            this.ToolStripMenuItemNotifyKeyfilecontainer.Text = "Keyfilecontainer";
            // 
            // ToolStripMenuItemNotifyMount
            // 
            this.ToolStripMenuItemNotifyMount.Name = "ToolStripMenuItemNotifyMount";
            this.ToolStripMenuItemNotifyMount.Size = new System.Drawing.Size(148, 26);
            this.ToolStripMenuItemNotifyMount.Text = "Mount";
            this.ToolStripMenuItemNotifyMount.Click += new System.EventHandler(this.ButtonKeyfileContainerMount_Click);
            // 
            // ToolStripMenuItemNotifyDismount
            // 
            this.ToolStripMenuItemNotifyDismount.Name = "ToolStripMenuItemNotifyDismount";
            this.ToolStripMenuItemNotifyDismount.Size = new System.Drawing.Size(148, 26);
            this.ToolStripMenuItemNotifyDismount.Text = "Dismount";
            this.ToolStripMenuItemNotifyDismount.Click += new System.EventHandler(this.ButtonKeyfileContainerDismount_Click);
            // 
            // automountToolStripMenuItem
            // 
            this.automountToolStripMenuItem.Name = "automountToolStripMenuItem";
            this.automountToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.automountToolStripMenuItem.Text = "Automount";
            this.automountToolStripMenuItem.Click += new System.EventHandler(this.automountToolStripMenuItem_Click);
            // 
            // ToolStripMenuItemNotifyRestore
            // 
            this.ToolStripMenuItemNotifyRestore.Name = "ToolStripMenuItemNotifyRestore";
            this.ToolStripMenuItemNotifyRestore.Size = new System.Drawing.Size(185, 24);
            this.ToolStripMenuItemNotifyRestore.Text = "Restore";
            this.ToolStripMenuItemNotifyRestore.Click += new System.EventHandler(this.ContextMenuRestore_Click);
            // 
            // ToolStripMenuItemNotifyClose
            // 
            this.ToolStripMenuItemNotifyClose.Name = "ToolStripMenuItemNotifyClose";
            this.ToolStripMenuItemNotifyClose.Size = new System.Drawing.Size(185, 24);
            this.ToolStripMenuItemNotifyClose.Text = "Close";
            this.ToolStripMenuItemNotifyClose.Click += new System.EventHandler(this.ContextMenuClose_Click);
            // 
            // groupBoxKeyfileContainer
            // 
            this.groupBoxKeyfileContainer.Controls.Add(this.buttonKeyfileContainerDismount);
            this.groupBoxKeyfileContainer.Controls.Add(this.buttonKeyfileContainerMount);
            this.groupBoxKeyfileContainer.Location = new System.Drawing.Point(9, 236);
            this.groupBoxKeyfileContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxKeyfileContainer.Name = "groupBoxKeyfileContainer";
            this.groupBoxKeyfileContainer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxKeyfileContainer.Size = new System.Drawing.Size(533, 64);
            this.groupBoxKeyfileContainer.TabIndex = 10;
            this.groupBoxKeyfileContainer.TabStop = false;
            // 
            // buttonKeyfileContainerDismount
            // 
            this.buttonKeyfileContainerDismount.Location = new System.Drawing.Point(257, 20);
            this.buttonKeyfileContainerDismount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonKeyfileContainerDismount.Name = "buttonKeyfileContainerDismount";
            this.buttonKeyfileContainerDismount.Size = new System.Drawing.Size(224, 30);
            this.buttonKeyfileContainerDismount.TabIndex = 12;
            this.buttonKeyfileContainerDismount.Text = "Keyfile Kontainer Dismount";
            this.buttonKeyfileContainerDismount.UseVisualStyleBackColor = true;
            this.buttonKeyfileContainerDismount.Click += new System.EventHandler(this.ButtonKeyfileContainerDismount_Click);
            // 
            // groupBoxContainer
            // 
            this.groupBoxContainer.Controls.Add(this.comboBoxContainer);
            this.groupBoxContainer.Controls.Add(this.buttonDismountContainer);
            this.groupBoxContainer.Controls.Add(this.buttonMountContainer);
            this.groupBoxContainer.Location = new System.Drawing.Point(9, 129);
            this.groupBoxContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxContainer.Name = "groupBoxContainer";
            this.groupBoxContainer.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBoxContainer.Size = new System.Drawing.Size(507, 100);
            this.groupBoxContainer.TabIndex = 5;
            this.groupBoxContainer.TabStop = false;
            this.groupBoxContainer.Text = "Kontainerauswahl";
            // 
            // comboBoxContainer
            // 
            this.comboBoxContainer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.comboBoxContainer.FormattingEnabled = true;
            this.comboBoxContainer.Location = new System.Drawing.Point(5, 27);
            this.comboBoxContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBoxContainer.Name = "comboBoxContainer";
            this.comboBoxContainer.Size = new System.Drawing.Size(347, 23);
            this.comboBoxContainer.TabIndex = 6;
            this.comboBoxContainer.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBoxKontainerDrawItem);
            this.comboBoxContainer.DropDown += new System.EventHandler(this.comboBoxContainer_DropDown);
            this.comboBoxContainer.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.ComboBoxKontainer_MeasureItem);
            this.comboBoxContainer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.comboBoxContainer_MouseClick);
            // 
            // buttonDismountContainer
            // 
            this.buttonDismountContainer.Location = new System.Drawing.Point(361, 59);
            this.buttonDismountContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonDismountContainer.Name = "buttonDismountContainer";
            this.buttonDismountContainer.Size = new System.Drawing.Size(133, 28);
            this.buttonDismountContainer.TabIndex = 9;
            this.buttonDismountContainer.Text = "Dismount";
            this.buttonDismountContainer.UseVisualStyleBackColor = true;
            this.buttonDismountContainer.Click += new System.EventHandler(this.ButtonDismountContainer_Click);
            // 
            // buttonMountContainer
            // 
            this.buttonMountContainer.Location = new System.Drawing.Point(361, 23);
            this.buttonMountContainer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonMountContainer.Name = "buttonMountContainer";
            this.buttonMountContainer.Size = new System.Drawing.Size(133, 28);
            this.buttonMountContainer.TabIndex = 8;
            this.buttonMountContainer.Text = "Mount";
            this.buttonMountContainer.UseVisualStyleBackColor = true;
            this.buttonMountContainer.Click += new System.EventHandler(this.ButtonMountContainer_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabelNotification,
            this.toolStripProgressBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 309);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(525, 25);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripLabelNotification
            // 
            this.toolStripLabelNotification.Name = "toolStripLabelNotification";
            this.toolStripLabelNotification.Size = new System.Drawing.Size(151, 20);
            this.toolStripLabelNotification.Text = "toolStripStatusLabel1";
            // 
            // toolStripProgressBar
            // 
            this.toolStripProgressBar.Name = "toolStripProgressBar";
            this.toolStripProgressBar.Size = new System.Drawing.Size(520, 20);
            this.toolStripProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.toolStripProgressBar.Visible = false;
            // 
            // contextMenuStripDrive
            // 
            this.contextMenuStripDrive.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripDrive.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Drive_new,
            this.toolStripMenuItem_Drive_edit,
            this.deleteToolStripMenuItem,
            this.showCommandToolStripMenuItem});
            this.contextMenuStripDrive.Name = "contextMenuStripDrive";
            this.contextMenuStripDrive.Size = new System.Drawing.Size(186, 128);
            // 
            // toolStripMenuItem_Drive_new
            // 
            this.toolStripMenuItem_Drive_new.Name = "toolStripMenuItem_Drive_new";
            this.toolStripMenuItem_Drive_new.Size = new System.Drawing.Size(185, 24);
            this.toolStripMenuItem_Drive_new.Text = "New";
            this.toolStripMenuItem_Drive_new.Click += new System.EventHandler(this.ToolStripMenuDriveNew_Click);
            // 
            // toolStripMenuItem_Drive_edit
            // 
            this.toolStripMenuItem_Drive_edit.Name = "toolStripMenuItem_Drive_edit";
            this.toolStripMenuItem_Drive_edit.Size = new System.Drawing.Size(185, 24);
            this.toolStripMenuItem_Drive_edit.Text = "Edit";
            this.toolStripMenuItem_Drive_edit.Click += new System.EventHandler(this.ToolStripMenuEditEntry_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.ToolStripMenuDriveDelete_Click);
            // 
            // showCommandToolStripMenuItem
            // 
            this.showCommandToolStripMenuItem.Name = "showCommandToolStripMenuItem";
            this.showCommandToolStripMenuItem.Size = new System.Drawing.Size(185, 24);
            this.showCommandToolStripMenuItem.Text = "Show command";
            this.showCommandToolStripMenuItem.Click += new System.EventHandler(this.showCommandToolStripMenuItem_Click);
            // 
            // contextMenuStripContainer
            // 
            this.contextMenuStripContainer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripContainer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem_Container_new,
            this.editToolStripMenuItem_Container_edit,
            this.deleteToolStripMenuItem1});
            this.contextMenuStripContainer.Name = "contextMenuStripContainer";
            this.contextMenuStripContainer.Size = new System.Drawing.Size(123, 76);
            // 
            // toolStripMenuItem_Container_new
            // 
            this.toolStripMenuItem_Container_new.Name = "toolStripMenuItem_Container_new";
            this.toolStripMenuItem_Container_new.Size = new System.Drawing.Size(122, 24);
            this.toolStripMenuItem_Container_new.Text = "New";
            this.toolStripMenuItem_Container_new.Click += new System.EventHandler(this.ToolStripMenuContainerNew_Click);
            // 
            // editToolStripMenuItem_Container_edit
            // 
            this.editToolStripMenuItem_Container_edit.Name = "editToolStripMenuItem_Container_edit";
            this.editToolStripMenuItem_Container_edit.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem_Container_edit.Text = "Edit";
            this.editToolStripMenuItem_Container_edit.Click += new System.EventHandler(this.ToolStripMenuEditEntry_Click);
            // 
            // deleteToolStripMenuItem1
            // 
            this.deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            this.deleteToolStripMenuItem1.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem1.Text = "Delete";
            this.deleteToolStripMenuItem1.Click += new System.EventHandler(this.ToolStripMenuContainerDelete_Click);
            // 
            // VeraCryptMounter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(525, 334);
            this.Controls.Add(this.groupBoxDrive);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBoxContainer);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.groupBoxKeyfileContainer);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "VeraCryptMounter";
            this.Text = "VeraCryptMounter";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.VeraCryptMounter_FormClosing);
            this.Shown += new System.EventHandler(this.VeraCryptMounter_Shown);
            this.Resize += new System.EventHandler(this.VeraCryptMounter_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBoxDrive.ResumeLayout(false);
            this.contextMenuStrip.ResumeLayout(false);
            this.groupBoxKeyfileContainer.ResumeLayout(false);
            this.groupBoxContainer.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.contextMenuStripDrive.ResumeLayout(false);
            this.contextMenuStripContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemClose;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemMainSettings;
        private Button buttonMount;
        private ComboBox comboBoxDrives;
        private Button buttonKeyfileContainerMount;
        private ToolStripMenuItem ToolStripMenuItemHelp;
        private ToolStripMenuItem toolStripMenuVersion;
        private ToolStripMenuItem ToolStripMenuItemEdit;
        private ToolStripMenuItem ToolStripMenuItemEditEntry;
        private ToolStripMenuItem ToolStripMenuItemNew;
        private Button buttonDismount;
        private GroupBox groupBoxDrive;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip;
        private ToolStripMenuItem ToolStripMenuItemNotifyRestore;
        private ToolStripMenuItem ToolStripMenuItemNotifyClose;
        private ToolStripMenuItem ToolStripMenuItemRemove;
        private GroupBox groupBoxKeyfileContainer;
        private Button buttonKeyfileContainerDismount;
        private GroupBox groupBoxContainer;
        private ComboBox comboBoxContainer;
        private Button buttonDismountContainer;
        private Button buttonMountContainer;
        private ToolStripMenuItem ToolStripMenuItemNotifyKeyfilecontainer;
        private ToolStripMenuItem ToolStripMenuItemNotifyMount;
        private ToolStripMenuItem ToolStripMenuItemNotifyDismount;
        private ToolTip toolTipMain;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripLabelNotification;
        private ToolStripProgressBar toolStripProgressBar;
        private ToolStripMenuItem driveToolStripMenuItem;
        private ToolStripMenuItem containerToolStripMenuItem;
        private ContextMenuStrip contextMenuStripDrive;
        private ToolStripMenuItem toolStripMenuItem_Drive_edit;
        private ToolStripMenuItem toolStripMenuItem_Drive_new;
        private ContextMenuStrip contextMenuStripContainer;
        private ToolStripMenuItem toolStripMenuItem_Container_new;
        private ToolStripMenuItem editToolStripMenuItem_Container_edit;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private ToolStripMenuItem automountToolStripMenuItem;
        private ToolStripMenuItem automountToolStripMenuItem1;
        private ToolStripMenuItem showCommandToolStripMenuItem;
    }
}

