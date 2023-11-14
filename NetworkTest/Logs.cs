namespace NetworkTest;

public partial class Logs : Form
{
    private readonly List<TestResult> _testResult;
    public Logs(List<TestResult> testResults)
    {
        _testResult = testResults;
        InitializeComponent();
    }

    private void Logs_Load(object sender, EventArgs e)
    {
        dataGridView1.DataSource = _testResult;
    }

    private void ExportToCsv()
    {
        try
        {
            string tempFilePath = Path.Combine(Path.GetTempPath(), "TestResults.csv");
            using (StreamWriter sw = new(tempFilePath, false, Encoding.UTF8))
            {
                sw.WriteLine($"DateTime,Gateways,Address,IP,PingTime,PingStatus,Port,PortStatus,LogHash");

                foreach (var result in _testResult)
                {
                    string line = $"{result.DateTime},{string.Join(" / ", result.Gateways)},{result.Address},{result.IP},{result.PingTime},{result.PingStatus},{result.Port},{result.PortStatus}";
                    string csvLine = $"{line},{line.HashLog()}";
                    sw.WriteLine(csvLine);
                }
            }
            Process.Start(new ProcessStartInfo
            {
                FileName = tempFilePath,
                UseShellExecute = true
            });
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error exporting data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void ExportToolStripMenuItem_Click(object sender, EventArgs e)
    {
        ExportToCsv();
    }
}
