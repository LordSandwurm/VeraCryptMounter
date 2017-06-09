using System;
using System.Drawing;
using System.Windows.Forms;

namespace VeraCrypt_Mounter
{
    public partial class ShowCommandWindow : Form
    {

        private readonly Config _config = new Config();
        private const string LanguageRegion = "ShowCommandWindow";
        private string _language;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        public ShowCommandWindow(string text)
        {
            if (string.IsNullOrEmpty(text))
                throw new ArgumentNullException();
            // Get Singelton for config
            _config = Singleton<ConfigManager>.Instance.Init(_config);
            InitializeComponent();
            richTextBoxCommand.Text = text;
            LanguageFill();
        }

        /// <summary>
        /// Set all controllelements to the selected language if the language is changed.
        /// </summary>
        private void LanguageFill()
        {

            _language = _config.GetValue(ConfigTrm.Mainconfig.Section, ConfigTrm.Mainconfig.Language, "");
            try
            {
                // Fill the controls with text.
                buttonOk.Text = LanguagePool.GetInstance().GetString(LanguageRegion, "buttonDismount", _language);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void richTextBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                ContextMenu contextMenu = new System.Windows.Forms.ContextMenu();

                MenuItem menuItem = new MenuItem("Copy");
                menuItem.Click += new EventHandler(CopyAction);
                contextMenu.MenuItems.Add(menuItem);


                richTextBoxCommand.ContextMenu = contextMenu;
            }
        }

        void CopyAction(object sender, EventArgs e)
        {
            
            Clipboard.SetData(DataFormats.Rtf, richTextBoxCommand.SelectedRtf);
            Clipboard.Clear();
        }

   
    }
}
