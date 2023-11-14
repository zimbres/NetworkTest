namespace NetworkTest;

public partial class MainWindow : Form
{
    private readonly ConnService _connService = new();
    private readonly List<TestResult> testResults = new();
    private Logs _logs;
    public MainWindow()
    {
        InitializeComponent();
    }

    private void ButtonGoClick(object sender, EventArgs e)
    {
        portStatus.ResetText();
        pingResult.ResetText();
        pingTime.ResetText();
        gateway.ResetText();
        ipAddress.ResetText();
        button1.Enabled = false;
        button1.Text = "Wait!";
        var thread = new Thread(GetData);
        thread.Start();
    }

    private void UpdateUI(TestResult result)
    {
        if (InvokeRequired)
        {
            Invoke(new Action(() => UpdateUI(result)));
            return;
        }

        testResults.Add(result);
        pingResult.Text = result.PingStatus;
        pingResult.BackColor = Color.LightGreen;
        if (result.PingStatus != "Success") pingResult.BackColor = Color.LightPink;
        if (result.PortStatus == "Failed to connect") portStatus.BackColor = Color.LightPink;
        if (result.PortStatus == "Successful connection") portStatus.BackColor = Color.LightGreen;
        pingTime.Text = result.PingTime;
        gateway.Text = string.Join(" / ", result.Gateways);
        portStatus.Text = result.PortStatus;
        if (!address.Text.IsValidIPv4()) ipAddress.Text = $"IP: {result.IP}";

        button1.Text = "Go";
        button1.Enabled = true;
    }

    private void GetData()
    {
        var result = _connService.CheckConn(address.Text, port.Text);

        UpdateUI(result);
    }

    private void OpenLogsWindow(object sender, EventArgs e)
    {
        if (_logs == null || _logs.IsDisposed)
        {
            _logs = new Logs(testResults);
            _logs.Show();
        }
        else
        {
            _logs.BringToFront();
        }
    }

    private void MainWindow_Load(object sender, EventArgs e)
    {
        version.Text = VersionService.GetVersion();
    }

    private void ShowAbout(object sender, EventArgs e)
    {
        MessageBox.Show($"Developed and maintained by Marcio ZIMBRES\nApp version: {VersionService.GetVersion()}");
    }
}
