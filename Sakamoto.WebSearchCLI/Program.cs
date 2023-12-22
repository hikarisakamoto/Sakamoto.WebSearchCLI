using System.Diagnostics;

var url = "https://www.google.com"; // The URL to open

var psi = new ProcessStartInfo
{
    FileName = "powershell.exe",
    Arguments = $"-Command \"Start-Process msedge '{url}'\"",
    UseShellExecute = false,
    CreateNoWindow = true // Prevents opening an additional PowerShell window
};

try
{
    Process.Start(psi);
}
catch (Exception ex)
{
    Console.WriteLine("An error occurred: " + ex.Message);
}