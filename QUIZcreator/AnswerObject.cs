using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QUIZcreator
{
    public partial class AnswerObject : UserControl
    {
        public AnswerObject()
        {
            InitializeComponent();
        }
        public string AnswerText
        {
            get
            {
                return textBoxAnswer.Text;
            }
            set
            {
                textBoxAnswer.Text = value;
            }
        }

        public bool AnswerChecked
        {
            get
            {
                return checkBoxAnswer.Checked;
            }
            set
            {
                checkBoxAnswer.Checked = value;
            }
        }

        private void checkBoxAnswer_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(checkBoxAnswer,
                          "Specify if the answer is correct.");
        }

        private void textBoxAnswer_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(textBoxAnswer,
                          "Insert answer text in there.");
        }
    }
}
