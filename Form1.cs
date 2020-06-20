using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Avdelningsrapport_2
{
    public partial class Form1 : Form
    {
#pragma warning disable IDE0044 
        TcpClient client = new TcpClient(); //initierar en TCP-klient
#pragma warning restore IDE0044 
#pragma warning disable IDE0044 
        int port = 12345; //port att koppla upp sig mot
#pragma warning restore IDE0044 

#pragma warning disable IDE0044 
        List<Book> bookList = new List<Book>();
#pragma warning restore IDE0044 
#pragma warning disable IDE0044 
        List<string> items = new List<string>();
#pragma warning restore IDE0044 
#pragma warning disable IDE0044 
        string[] vektor;
#pragma warning restore IDE0044 

        public Form1()
        {
            InitializeComponent();

            client.NoDelay = true;

            string item;
            List<string[]> vektorList = new List<string[]>();

            if (File.Exists("Texter.txt"))
            {
                StreamReader reader = new StreamReader("Texter.txt", Encoding.Default, true);

                while ((item = reader.ReadLine()) != null)
                    items.Add(item);

                foreach (string a in items)
                {
                    vektor = a.Split(new string[] { "###" }, StringSplitOptions.None);
                    vektorList.Add(vektor);

                    Book book = new Book();
                    bookList.Add(book);
                    book.Title = vektor[0];
                    book.Author = vektor[1];
                    book.Type = vektor[2];
                }
            }
        }

        public async void StartClient()
        {
            try
            {
                IPAddress address = IPAddress.Parse("127.0.0.1"); //ip-adressen vi vill använda för servern (privat ip-adress inom ett LAN)
                await client.ConnectAsync(address, port); //await används för att programmet ska vänta på en tidskrävande process
                Connect.BackColor = Color.Green; //ändrar bakgrundsfärg på Connect-knappen när uppkoppling skett
                Connect.Text = "Connected"; //ändrar text till "Connected"
                Connect.Enabled = false; //stänger av "connect"-knappen efter att anslutning genomförts
            }
            catch (Exception error) 
            { 
                MessageBox.Show(error.Message, Text); 
                return; 
            } //skriver ut ett felmeddelande om uppkoppling inte sker
        }

        public async void StartReader(string message)
        {
            byte[] outData = Encoding.Unicode.GetBytes(message); //datan som skickas från klient till server i bytes

            try
            {
                await client.GetStream().WriteAsync(outData, 0, outData.Length); //skickar data från textfilens början till textfilens slut
            }
            catch(Exception error)
            {
                MessageBox.Show(error.Message, Text);
                return;
            }
        }



        private void Connect_Click(object sender, EventArgs e)
        {
            StartClient(); //startar klienten när man trycker på knappen för att ansluta
        }

        private void LoadList_Click(object sender, EventArgs e)
        {
            ListBox.Items.AddRange(bookList.ToArray()); //skickar vår array med böcker till ListBox
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            MarkObject.Enabled = true; //när vi har läst in böcker till vår ListBox så aktiveras knapparna för att skicka objekten till servern
            SendObjects.Enabled = true;
        }

        private void SendObjects_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < ListBox.Items.Count; i++) //itererar över alla böcker (items) i vår ListBox 
            {
                StartReader(ListBox.Items[i].ToString()); //skickar alla böcker från vår ListBox till servern, från 0 till antalet inlästa böcker
                Thread.Sleep(100); //väntar 100 ms mellan varje bok som den skickar
            }
        }

        private void MarkObject_Click(object sender, EventArgs e)
        {
            if(ListBox.SelectedItems.Count == 1)
            {
                StartReader(ListBox.Text.ToString());
            }
        }
    }
}
