using GTranslatorAPI;
namespace translator
{
    public partial class Form1 : Form
    {
        private string[]? LanguagesList;
        private string[]? LanguagesList2;

        private GTranslatorAPIClient translatorAPIClient = new GTranslatorAPIClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async void TranslateButton_Clicked(object sender, EventArgs e)
        {

            Enabled = false; 

            var Translation = await translatorAPIClient.TranslateAsync((Languages)comboBoxSourceLang.SelectedIndex, (Languages)comboBoxOutLang.SelectedIndex, SourceTextBox.Text);

            OutputTextBox.Text = Translation.TranslatedText;

            Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

           
            LanguagesList = Enum.GetNames(typeof(Languages));

            LanguagesList2 = Enum.GetNames(typeof(Languages));


            comboBoxSourceLang.DataSource = LanguagesList;

            comboBoxOutLang.DataSource = LanguagesList2;

            comboBoxSourceLang.SelectedIndex = (int)Languages.en;
            comboBoxOutLang.SelectedIndex = (int)Languages.ar;


        }
    }
}
