using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace Practic2
{
    public partial class Form1 : Form
    {
        int imgIndex;
        City city;
        List<City> cities = new List<City>();
        public void AddCities()
        {
            cities.Add(new City("Kiyiv", "https://kmr.gov.ua/", @"../../../Resources/kyiv.jpg", @"../../../Resources/kyiv2.jpg"));
            cities.Add(new City("Lwiw", "https://city-adm.lviv.ua/", @"../../../Resources/lviv.jpg", @"../../../Resources/lviv2.jpg", @"../../../Resources/lviv3.jpg"));
            cities.Add(new City("Rivne", "http://www.city-adm.rv.ua/", @"../../../Resources/rivne.jpg", @"../../../Resources/rivne2.jpg", @"../../../Resources/rivne3.jpg"));
        }
        public Form1()
        {
            InitializeComponent();
            AddCities();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.citiesComboBox.DataSource= (from el in cities select el.Name).ToArray();
          
        }

        private void citiesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            city = cities.Find(e => e.Name == citiesComboBox.SelectedItem.ToString());
            //var city = (from el in cities where el.Name == this.citiesComboBox.SelectedItem.ToString() select el) as City;
            imgIndex = 0;
            Image img = Image.FromFile(city.PhotosUrls[0]);
            this.pictureBox1.BackgroundImage = img;
            this.cityUrl.Text = city.URL;
        }

        private void cityUrl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("explorer.exe",this.city.URL);
            //ProcessStartInfo startInfo = new ProcessStartInfo();
            //startInfo.FileName = "chrome,ex";
            //startInfo.Arguments = "/SERVER hellowword";
            //startInfo.WorkingDirectory = @"C:\Temp";
            //startInfo.WindowStyle = ProcessWindowStyle.Maximized;
            //startInfo.ErrorDialog = true;
            //Process process = Process.Start(startInfo);
            //Process.Start("chrome.exe",cityUrl.Text);
        }

        private void nextImageBtn_Click(object sender, EventArgs e)
        {
            if (imgIndex+1 >= city.PhotosUrls.Count)
            {
                this.pictureBox1.BackgroundImage = Image.FromFile(city.PhotosUrls[0]);
                imgIndex = 0;
                return;
            }
            this.pictureBox1.BackgroundImage = Image.FromFile(city.PhotosUrls[++imgIndex]);
        }

        private void prevBtn_Click(object sender, EventArgs e)
        {
            if (imgIndex-1 < 0)
            {
                this.pictureBox1.BackgroundImage = Image.FromFile(city.PhotosUrls[city.PhotosUrls.Count-1]);
                imgIndex = city.PhotosUrls.Count - 1;
                return;
            }
            this.pictureBox1.BackgroundImage = Image.FromFile(city.PhotosUrls[--imgIndex]);
        }
    }
}
