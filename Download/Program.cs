using System;
using System.IO;
using System.Collections;
using System.Net;

public class Download
{
    public static void Main(string[] args)
    {
        //directory path
        string workspaceDir = @"D:\Workspace";
        string dataDir = $@"{workspaceDir}\Data";
        string dailyDir = $@"{dataDir}\Daily";
        string indexDir = $@"{dataDir}\Index";
        string foDir = $@"{dataDir}\FnO";
        string fososDir = $@"{dataDir}\FO_sos";
        string niftyDir = $@"{dataDir}\Nifty\Broad";

        //call checkDirectory
        checkDirectory(workspaceDir);
        checkDirectory(dataDir);
        checkDirectory(dailyDir);
        checkDirectory(indexDir);
        checkDirectory(foDir);
        checkDirectory(fososDir);
        checkDirectory(niftyDir);
        Console.WriteLine();

        // get date
        string dateTime = DateTime.Now.ToString("ddMMyyyy");
        Console.WriteLine(dateTime);
        Console.WriteLine();

        // uri and output path
        // Nifty 50
        string downloadnifty50Url = "https://archives.nseindia.com/content/indices/ind_nifty50list.csv";
        string destinationnifty50Path = @"D:\\Workspace\Data\Nifty\Broad\ind_nifty50list.csv";

        // Nifty Next 50
        string downloadniftynext50Url = "https://archives.nseindia.com/content/indices/ind_niftynext50list.csv";
        string destinationniftynext50Path = @"D:\\Workspace\Data\Nifty\Broad\ind_niftynext50list.csv";

        // NIfty 100
        string downloadnifty100Url = "https://archives.nseindia.com/content/indices/ind_nifty100list.csv";
        string destinationnifty100Path = @"D:\\Workspace\Data\Nifty\Broad\ind_nifty100list.csv";

        // NIfty 200
        string downloadnifty200Url = "https://archives.nseindia.com/content/indices/ind_nifty200list.csv";
        string destinationnifty200Path = @"D:\\Workspace\Data\Nifty\Broad\ind_nifty200list.csv";

        // NIfty 500
        string downloadnifty500Url = "https://archives.nseindia.com/content/indices/ind_nifty500list.csv";
        string destinationnifty500Path = @"D:\\Workspace\Data\Nifty\Broad\ind_nifty500list.csv";

        // SecBhavdata
        string downloadsecbhavdataUrl = "https://archives.nseindia.com/products/content/sec_bhavdata_full_" + dateTime + ".csv";
        string destinationsecbhavdataPath = @"D:\\Workspace\Data\Daily\sec_bhavdata_full_" + dateTime + ".csv";

        // Index
        string downloadindexUrl = "https://archives.nseindia.com/content/indices/ind_close_all_" + dateTime + ".csv";
        string destinationindexPath = @"D:\\Workspace\Data\Index\ind_close_all_" + dateTime + ".csv";

        // FNO
        string downloadfnoUrl = "https://archives.nseindia.com/archives/fo/mkt/fo" + dateTime + ".zip";
        string destinationfnoPath = @"D:\\Workspace\Data\FnO\fo" + dateTime + ".zip";

        // Fo_sos
        string downloadfososUrl = "https://archives.nseindia.com/content/fo/sos_scheme.xls";
        string destinationfososPath = @"D:\\Workspace\Data\FO_sos\sos_scheme.xls";

        //call DownloadFile
        DownloadFile(downloadnifty50Url, destinationnifty50Path);
        DownloadFile(downloadniftynext50Url, destinationniftynext50Path);
        DownloadFile(downloadnifty100Url, destinationnifty100Path);
        DownloadFile(downloadnifty200Url, destinationnifty200Path);
        DownloadFile(downloadnifty500Url, destinationnifty500Path);
        DownloadFile(downloadsecbhavdataUrl, destinationsecbhavdataPath);
        DownloadFile(downloadindexUrl, destinationindexPath);
        DownloadFile(downloadfnoUrl, destinationfnoPath);
        DownloadFile(downloadfososUrl, destinationfososPath);

    }
    
    // create function to check directory
    public static void checkDirectory(string path)
    {
        if (!Directory.Exists(path))
        {
            Console.WriteLine($"Directory absent: {path}");
            Directory.CreateDirectory(path);
        }

        else
        {
            Console.WriteLine($"Directory exists: {path}");
        }
    }
    // create function to download file
    public static void DownloadFile(string url, string outPath)
    {
        Console.WriteLine($"Download {url}");
        // Create a new WebClient instance.
        WebClient webClient = new WebClient();
        webClient.DownloadFile(url, outPath);
        Console.WriteLine($"Download Completed: {outPath}");
        Console.WriteLine();
    }
}
