// ProxyChecker v1.0
// This application checks the validity of proxy servers by testing their connectivity.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProxyChecker
{
    public partial class Form1 : Form
    {
        // Placeholder text for the proxy list TextBox
        private string proxyListPlaceHldr = "8.211.200.183:8080";

        public Form1()
        {
            InitializeComponent();

            // Set placeholder text for the proxy list TextBox
            totalProxyList.Text = proxyListPlaceHldr;
            totalProxyList.ForeColor = Color.Gray;

            // Attach event handlers to manage placeholder behavior
            totalProxyList.GotFocus += RemovePlaceholder;
            totalProxyList.LostFocus += SetPlaceholder;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Form load event - currently not used but can be used for initialization
        }

        private async void checkBtn_Click(object sender, EventArgs e)
        {
            // Clear previous results before starting a new check
            workingProxyList.Text = "";
            badProxyList.Text = "";
            progressBar1.Value = 0;

            // Disable the button while checking proxies to prevent multiple clicks
            checkBtn.Enabled = false;

            // Split the input proxy list into an array of proxies
            string[] proxies = totalProxyList.Text.Split(new[] { '\n', '\r' },
                StringSplitOptions.RemoveEmptyEntries);

            // Set progress bar properties
            progressBar1.Minimum = 0;
            progressBar1.Maximum = proxies.Length;

            int currentProgress = 0;
            foreach (string proxy in proxies)
            {
                if (string.IsNullOrWhiteSpace(proxy)) continue; // Skip empty lines

                // Check if the proxy is working
                bool isWorking = await TestProxyAsync(proxy.Trim());

                if (isWorking)
                {
                    workingProxyList.AppendText(proxy + Environment.NewLine); // Add to working list
                }
                else
                {
                    badProxyList.AppendText(proxy + Environment.NewLine); // Add to bad list
                }

                // Update progress bar
                currentProgress++;
                progressBar1.Value = currentProgress;
            }

            // Re-enable the button after completion
            checkBtn.Enabled = true;

            MessageBox.Show("Proxy Checking Complete");
        }

        private async Task<bool> TestProxyAsync(string proxy)
        {
            try
            {
                // Split the proxy into IP and port
                string[] parts = proxy.Split(':');
                if (parts.Length != 2) return false;

                string ip = parts[0];
                int port = int.Parse(parts[1]);

                // Configure HttpClient with proxy
                var handler = new HttpClientHandler
                {
                    Proxy = new System.Net.WebProxy(ip, port),
                    UseProxy = true,
                };

                using (var client = new HttpClient(handler))
                {
                    // Set timeout to 5 seconds to avoid long delays
                    client.Timeout = TimeSpan.FromSeconds(5);

                    // Attempt to make a GET request to Google
                    var response = await client.GetAsync("http://www.google.com");
                    return response.IsSuccessStatusCode; // Returns true if the request succeeds
                }
            }
            catch (Exception)
            {
                return false; // Return false if an error occurs
            }
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            // Remove placeholder text when the user focuses on the TextBox
            if (totalProxyList.Text == proxyListPlaceHldr)
            {
                totalProxyList.Text = "";
                totalProxyList.ForeColor = Color.Black;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            // Restore placeholder text if the TextBox is empty when focus is lost
            if (string.IsNullOrWhiteSpace(totalProxyList.Text))
            {
                totalProxyList.Text = proxyListPlaceHldr;
                totalProxyList.ForeColor = Color.Gray;
            }
        }

        private void copyBtn_Click(object sender, EventArgs e)
        {
            // Copy working proxies to clipboard
            if (!string.IsNullOrEmpty(workingProxyList.Text))
            {
                Clipboard.SetText(workingProxyList.Text);
            }
        }
    }
}
