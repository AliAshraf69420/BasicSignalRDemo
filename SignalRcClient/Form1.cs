using Microsoft.AspNetCore.SignalR.Client;

namespace SignalRcClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var connection = new HubConnectionBuilder()
            .WithUrl("https://localhost:7243/hub/streaming")
            .Build();
        }
    }
}
