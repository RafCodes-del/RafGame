using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//InsideView1 Is For The House On Map 2
//InsideView2 Is For The Motel
//InsideView3 Is For Inside The Motel/Portal

namespace RafGame_
{
    public partial class Tycoon : Form
    {
        public object Sus { get; private set; }
        
        public Tycoon()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Map2.Hide();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            Map2.Hide();
            InsideView1.Hide();
            InsideView2.Hide();
            InsideView3.Hide();
            InsideView4.Hide();
            Paper.Hide();
            Paper1.Hide();
            Paper2.Hide();
            ExitPaper.Hide();
            Rblx.Hide();
            SunView1.Hide();
            button9.Hide();
            Pg2.Hide();
            Achevements.Hide();
            button10.Hide();
            Tool.Hide();
            label8.Hide();
            Cloudly.Hide();
            button13.Hide();
            ExitTools.Hide();
            tabControl1.Hide();
            button16.Hide();
            Wall1.Hide();

        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found Amogus You Sus";
            SUS.Text = "Among us: Found!";
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void TabPage1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found Amogus You Sus";
            SUS.Text = "Among us: Found!";
        }

        private void PictureBox3_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found Amogus You Sus";
            SUS.Text = "Among us: Found!";
        }

        private void PictureBox6_Click(object sender, EventArgs e)
        {
            InsideView1.Show();
        }

        private void ToMap2_Click(object sender, EventArgs e)
        {
            Map2.Show();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Map2.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            InsideView1.Hide();
        }

        private void PictureBox10_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found Minecraft!";
            Minecraft.Text = "Minecraft: Found!";
        }

        private void PictureBox8_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found Minecraft!";
            Minecraft.Text = "Minecraft: Found!";
        }

        private void PictureBox9_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found Minecraft!";
            Minecraft.Text = "Minecraft: Found!";
        }

        private void PictureBox12_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found Minecraft!";
            Minecraft.Text = "Minecraft: Found!";
        }

        private void PictureBox13_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found Minecraft!";
            Minecraft.Text = "Minecraft: Found!";
        }

        private void PictureBox11_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found Minecraft!";
            Minecraft.Text = "Minecraft: Found!";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            InsideView2.Hide();
        }

        private void PictureBox14_Click(object sender, EventArgs e)
        {
            InsideView2.Show();
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            InsideView3.Show();
        }

        private void PictureBox27_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found Portal!";
            Port.Text = "Portal: Found!";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            InsideView3.Hide();
        }

        private void PictureBox29_Click(object sender, EventArgs e)
        {
            InsideView4.Show();
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            InsideView4.Hide();
        }

        private void Label8_Click(object sender, EventArgs e)
        {

        }

        private void PaperSmall_Click(object sender, EventArgs e)
        {
            Paper.Show();
            Paper2.Show();
            Paper1.Show();
            ExitPaper.Show();
        }

        private void PaperLine_Click(object sender, EventArgs e)
        {
            Paper.Show();
            Paper2.Show();
            Paper1.Show();
            ExitPaper.Show();
        }

        private void PaperLine2_Click(object sender, EventArgs e)
        {
            Paper.Show();
            Paper2.Show();
            Paper1.Show();
            ExitPaper.Show();
        }

        private void ExitPaper_Click(object sender, EventArgs e)
        {
            Paper.Hide();
            Paper2.Hide();
            Paper1.Hide();
            ExitPaper.Hide();
        }

        private void pictureBox37_Click(object sender, EventArgs e)
        {
            SunView1.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Rblx.Show();
            SUS.Hide();
            Minecraft.Hide();
            Port.Hide();
            button7.Hide();
            button9.Show();
            Pg2.Show();
            Pg1.Hide();


        }

        private void button9_Click(object sender, EventArgs e)
        {
            Rblx.Hide();
            SUS.Show();
            Minecraft.Show();
            Port.Show();
            button9.Hide();
            button7.Show();
            Pg1.Show();
            Pg2.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SunView1.Hide();
        }

        private void pictureBox40_Click(object sender, EventArgs e)
        {

        }

        private void Pg2_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void OpenAcheve_Click(object sender, EventArgs e)
        {
            Achevements.Show();
            button10.Show();
            OpenAcheve.Hide();  
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Achevements.Hide();
            OpenAcheve.Show();
            button10.Hide();
        }

        private void pictureBox45_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found A Object!";
            Rblx.Text = "Roblox: Found!";
        }

        private void pictureBox48_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found A Object!";
            Rblx.Text = "Roblox: Found!";
        }

        private void pictureBox40_Click_1(object sender, EventArgs e)
        {
            Notify.Text = "You Found A Object!";
            Rblx.Text = "Roblox: Found!";
        }

        private void pictureBox46_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found A Object!";
            Rblx.Text = "Roblox: Found!";
        }

        private void pictureBox50_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found A Object!";
            Rblx.Text = "Roblox: Found!";
        }

        private void pictureBox47_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found A Object!";
            Rblx.Text = "Roblox: Found!";
        }

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            Notify.Text = "You Found Portal";
            Port.Text = "Portal: Found";
        }

        private void pictureBox38_Click(object sender, EventArgs e)
        {
            Cloudly.Show();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void Tools_Click(object sender, EventArgs e)
        {
            Tool.Show();
            Tools.Hide();
            ExitTools.Show();
        }

        private void ExitTools_Click(object sender, EventArgs e)
        {
            Tool.Hide();
            ExitTools.Hide();
            Tools.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label8.Show();
            button13.Show();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label8.Hide();
            button13.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Cloudly.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            timer1.Start();
            label9.Text = "Producing Money: 1 Per Milisec";
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            

            if (progressBar2.Value < 2000)
            {
                progressBar2.Value += 1;
                TyMoney.Text = progressBar2.Value.ToString() + " :Money";
            }

            else
            {
                timer1.Stop();
                MessageBox.Show("Your Money Banks Full!");
            }
        }

        private void label9_Click(object sender, EventArgs e)
        {
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            tabControl1.Show();
            button15.Hide();
            button16.Show();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            tabControl1.Hide();
            button16.Hide();
            button15.Show();
        }

        private void BuyWall1_Click(object sender, EventArgs e)
        {
            Wall1.Show();
            MessageBox.Show("You Have Complete The Tycoon This Game Is Still In Test So It Only Has Walls");
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        // label1.Text = "You Found Amogus You Sus";
        // Sus.Text = "Amogus: Found!";
    }
}
