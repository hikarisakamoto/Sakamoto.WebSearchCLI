using System.Diagnostics;

var url = "https://www.google.com"; // The URL to open

var browser = string.Empty;

var psi = new ProcessStartInfo
{
    FileName = "powershell.exe",
    Arguments = $"-Command \"Start-Process {browser} '{url}'\"",
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