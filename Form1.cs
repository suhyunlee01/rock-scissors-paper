using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 닷넷_연습_가위바위보_앱_제작
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rk_Click(object sender, EventArgs e)
        {
            My.Text = "";
            RSP res = new RSP("바위✊");
            string mytextbox = res.MyText();
            My.Text = mytextbox;

            Random random = new Random();
            int randNum = random.Next(1, 4);

            switch (randNum)
            {
                case 1:
                    Com.Text = "";
                    Com.Text = "가위✌️";
                    break;
                case 2:
                    Com.Text = "";
                    Com.Text = "바위✊";
                    break;
                case 3:
                    Com.Text = "";
                    Com.Text = "보✋";
                    break;
            }

            if (Com.Text == "가위✌️")
            {
                Res.Text = "이겼습니다.😄";
            }
            else if (Com.Text == "바위✊")
            {
                Res.Text = "비겼습니다.😐";
            }
            else
            {
                Res.Text = "졌습니다.😥";
            }
        }

        private void sr_Click(object sender, EventArgs e)
        {
            My.Text = "";
            RSP res = new RSP("가위✌️");
            string mytextbox = res.MyText();
            My.Text = mytextbox;

            Random random = new Random();
            int randNum = random.Next(1, 4);
            switch (randNum)
            {
                case 1:
                    Com.Text = "";
                    Com.Text = "가위✌️";
                    break;
                case 2:
                    Com.Text = "";
                    Com.Text = "바위✊";
                    break;
                case 3:
                    Com.Text = "";
                    Com.Text = "보✋";
                    break;
            }

            if (Com.Text == "가위✌️")
            {
                Res.Text = "비겼습니다.😐";
            }
            else if (Com.Text == "바위✊")
            {
                Res.Text = "졌습니다.😥";
            }
            else
            {
                Res.Text = "이겼습니다.😄";
            }
        }

        private void pr_Click(object sender, EventArgs e)
        {
            My.Text = "";
            RSP res = new RSP("보✋");
            string mytextbox = res.MyText();
            My.Text = mytextbox;

            Random random = new Random();
            int randNum = random.Next(1, 4);

            switch (randNum)
            {
                case 1:
                    Com.Text = "";
                    Com.Text = "가위✌️";
                    break;
                case 2:
                    Com.Text = "";
                    Com.Text = "바위✊";
                    break;
                case 3:
                    Com.Text = "";
                    Com.Text = "보✋";
                    break;
            }

            if (Com.Text == "가위✌️")
            {
                Res.Text = "졌습니다.😥";
            }
            else if (Com.Text == "바위✊")
            {
                Res.Text = "이겼습니다.😄";
            }
            else
            {
                Res.Text = "비겼습니다.😐";
            }
        }
    }

    class RSP
    {
        private string MyRes;

        public RSP(string a)
        {
            MyRes = a;
        }
        public string MyText()
        {
            return MyRes;
        }
    }
}
