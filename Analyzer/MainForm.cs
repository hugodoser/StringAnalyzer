using System;
using System.Windows.Forms;

namespace Analyzer
{
    public partial class MainForm : Form
    {
        private const string NewLineString = "\n";

        public MainForm()
        {
            InitializeComponent();
        }

        private void buttonAnalyze_Click(object sender, EventArgs e)
        {
            richTextBoxIdentifiers.Clear();
            richTextBoxTypes.Clear();
            richTextBoxSizes.Clear();
            richTextBoxError.Clear();

            var stringInput = textBoxInput.Text.ToUpper();
            var test = Analyzer.Test(stringInput);

            foreach (var item in Analyzer.ListOfIdentifiers)
            {
                richTextBoxIdentifiers.Text += item;
                richTextBoxIdentifiers.Text += NewLineString;
            }
            Analyzer.ListOfIdentifiers.Clear();

            foreach (var item in Analyzer.ListOfTypes)
            {
                richTextBoxTypes.Text += item;
                richTextBoxTypes.Text += NewLineString;
            }
            Analyzer.ListOfTypes.Clear();

            foreach (var item in Analyzer.ListOfSizes)
            {
                richTextBoxSizes.Text += item;
                richTextBoxSizes.Text += NewLineString;
            }
            Analyzer.ListOfSizes.Clear();

            if (test.ErrorPosition == 0)
                richTextBoxError.Text = test.ErrorMessage;
            else
            {
                richTextBoxError.Text = (test.ErrorPosition + 1).ToString() + NewLineString + test.ErrorMessage;

                textBoxInput.Focus();
                textBoxInput.Select(test.ErrorPosition, 0);
                textBoxInput.ScrollToCaret();
            }
        }
    }
}