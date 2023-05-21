using System;
using FunnyStory;
using System.Windows.Forms;

namespace FunnyStory_Maker
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TextChange(object sender, EventArgs e)
        {
            Story.Sex sex = radio_Sex_Man.Checked ? Story.Sex.Men : Story.Sex.Women;

            if (text_actor.Text != "" && text_lastTime.Text != "" &&
                text_unfinishedThing.Text != "" && text_whyDo.Text != "" &&
                text_whereDo.Text != "" && text_whenDo.Text != "" && text_end.Text != "")
            {
                text_output.Text = Story.ToStringStory(text_actor.Text,
                                                       sex, text_lastTime.Text,
                                                        text_unfinishedThing.Text,
                                                        text_whyDo.Text,
                                                        text_whereDo.Text,
                                                        text_whenDo.Text,
                                                        check_isFinished.Checked,
                                                        text_end.Text);
            }
        }
    }
}
