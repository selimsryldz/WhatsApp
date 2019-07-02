using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        IWebDriver driver = new ChromeDriver();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


            driver.Navigate().GoToUrl("https://web.whatsapp.com/");



        }

        private void yolla_Click(object sender, EventArgs e)
        {
            driver.FindElement(By.ClassName("_35EW6")).Click();
            textBox.Clear();
        }



        private void textBox_TextChanged(object sender, EventArgs e)
        {
            //var element = driver.FindElement(By.ClassName("_2S1VP"));
            //element.Clear();
            //element.SendKeys(textBox.Text);
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            var element = driver.FindElement(By.ClassName("_2S1VP"));
            element.SendKeys(e.KeyChar.ToString());

        }

        private void button1_Click(object sender, EventArgs e)
        {
            individuals.Items.Clear();



            //sohbetteki isimleri sıralayıp sol tarafa yazdırıyor
            var individuallist = driver.FindElements(By.ClassName("_25Ooe")).ToList();
            var selim = individuallist[individuallist.Count - 1];
            List<IWebElement> yedekList = new List<IWebElement>();
            var sayac = individuallist.Count - 1;
            yedekList.Add(individuallist[0]);
            for (int i = 1; i < individuallist.Count - 1; i++)
            {
                yedekList.Add(individuallist[sayac]);
                sayac--;
            }
            foreach (var item in yedekList)
            {

                individuals.Items.Add(item.Text);
            }



        }

        private void individuals_Click(object sender, EventArgs e)
        {

            listBox1.Items.Clear();

            //sohbet isimlerine sıralı bir şekilde basılmasını sağlıyor
            var individuallist = driver.FindElements(By.ClassName("_25Ooe")).ToList();
            var selim = individuallist[individuallist.Count - 1];
            List<IWebElement> yedekList = new List<IWebElement>();
            var sayac = individuallist.Count - 1;
            yedekList.Add(individuallist[0]);
            for (int i = 1; i < individuallist.Count - 1; i++)
            {
                yedekList.Add(individuallist[sayac]);
                sayac--;
            }
            var tikla = yedekList[individuals.SelectedIndex];
            tikla.Click();





            //sohbetin başlığını gösteriyor
            var baslik = driver.FindElement(By.ClassName("_3XrHh"));
            text.Text = baslik.Text;

            System.Threading.Thread.Sleep(2000);

            //mesajları alıp listboxa basıyor
            var messagelist = driver.FindElements(By.ClassName("vW7d1")).ToList();

            foreach (var item in messagelist)
            {
                var melo = item.FindElement(By.TagName("div"));
                var selo = melo.GetAttribute("class");
                var a = selo.Contains("message-out");
                var b = selo.Contains("message-in");
                if (a)
                {
                    listBox1.Items.Add("--------------------");
                    listBox1.Items.Add(item.Text);
                    listBox1.Items.Add("");

                }
                if(b)
                {
                    listBox1.Items.Add(item.Text);
                    listBox1.Items.Add("");
                }
            }

           
            
              


        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == System.Windows.Forms.Keys.Enter)
            {
                driver.FindElement(By.ClassName("_35EW6")).Click();
                textBox.Clear();
            }
        }

      
    }
}
