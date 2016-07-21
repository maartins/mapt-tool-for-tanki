using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapTool {
    public static class Prompt {
        public static string ShowDialog(string text, string caption) {
            Form prompt = new Form() {
                Width = 250,
                Height = 125,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                Text = caption,
                StartPosition = FormStartPosition.CenterParent
            };
            Label textLabel = new Label() { Left = 15, Top = 15, Text = text };
            TextBox textBox = new TextBox() { Left = 18, Top = 35, Width = 200 };
            textBox.KeyPress += (sender, e) => { e.Handled = !(char.IsLetter(e.KeyChar) || char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back); };
            Button confirmation = new Button() { Text = "Ok", Left = 15, Width = 50, Top = 60, DialogResult = DialogResult.OK };
            confirmation.Click += (sender, e) => { prompt.Close(); };
            prompt.Controls.Add(textBox);
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            prompt.AcceptButton = confirmation;

            return prompt.ShowDialog() == DialogResult.OK ? textBox.Text : "";
        }
    }
}
