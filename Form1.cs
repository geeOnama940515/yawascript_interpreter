namespace yawascript_interpreter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            codeRichTextBox.Focus();
        }

        private void UpdateLineNumbers()
        {
            // Get the lines from the code RichTextBox
            string[] lines = codeRichTextBox.Lines;

            // Update the line numbers TextBox
            lineNumbersTextBox.Clear();
            for (int i = 1; i <= lines.Length; i++)
            {
                lineNumbersTextBox.AppendText(i + Environment.NewLine);
            }
        }

        private void codeRichTextBox_TextChanged(object sender, EventArgs e)
        {
            UpdateLineNumbers();
        }

        private void codeRichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                // Update line numbers when Enter key is pressed
                UpdateLineNumbers();
            }
        }
    }
}