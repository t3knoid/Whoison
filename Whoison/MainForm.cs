using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Externals
{
    public partial class MainForm : Form
    {
        IDictionary<string, string> Status = new Dictionary<string, string>()
        {
            {"WTSActive", "A user is logged on to the WinStation."},
            {"WTSConnected", "The WinStation is connected to the client."},
            {"WTSConnectQuery", "The WinStation is in the process of connecting to the client."},
            {"WTSShadow", "The WinStation is shadowing another WinStation."},
            {"WTSDisconnected", "The WinStation is active but the client is disconnected."},
            {"WTSIdle", "The WinStation is waiting for a client to connect."},
            {"WTSListen", "The WinStation is listening for a connection. A listener session waits for requests for new client connections. No user is logged on a listener session. A listener session cannot be reset, shadowed, or changed to a regular client session."},
            {"WTSReset", "The WinStation is being reset."},
            {"WTSDown",	"The WinStation is down due to an error."},
            {"WTSInit", "The WinStation is initializing."}
        };
        public MainForm()
        {
            InitializeComponent();
        }

        public static IntPtr OpenServer(String Name)
        {
            IntPtr server = Externals.WTSOpenServer(Name);
            return server;
        }
        public static void CloseServer(IntPtr ServerHandle)
        {
            Externals.WTSCloseServer(ServerHandle);
        }
        private List<String> GetLoggedUsers(String ServerName)
        {
            IntPtr serverHandle = IntPtr.Zero;
            List<String> resultList = new List<string>();
            serverHandle = OpenServer(ServerName);

            try
            {
                IntPtr SessionInfoPtr = IntPtr.Zero;
                IntPtr userPtr = IntPtr.Zero;
                IntPtr connectStatePtr = IntPtr.Zero;
                Int32 sessionCount = 0;
                Int32 retVal = Externals.WTSEnumerateSessions(serverHandle, 0, 1, ref SessionInfoPtr, ref sessionCount);
                Int32 dataSize = Marshal.SizeOf(typeof(Externals.WTS_SESSION_INFO));
                IntPtr currentSession = SessionInfoPtr;
                uint bytes = 0;

                if (retVal != 0)
                {
                    for (int i = 0; i < sessionCount; i++)
                    {
                        Externals.WTS_SESSION_INFO si = (Externals.WTS_SESSION_INFO)Marshal.PtrToStructure((System.IntPtr)currentSession, typeof(Externals.WTS_SESSION_INFO));
                        currentSession += dataSize;

                        if (si.pWinStationName.StartsWith("RDP-Tcp#"))
                        {
                            Externals.WTSQuerySessionInformation(serverHandle, si.SessionID, Externals.WTS_INFO_CLASS.WTSUserName, out userPtr, out bytes);
                            Externals.WTSQuerySessionInformation(serverHandle, si.SessionID, Externals.WTS_INFO_CLASS.WTSConnectState, out connectStatePtr, out bytes);
                            if (si.State == Externals.WTS_CONNECTSTATE_CLASS.WTSActive)
                            {
                                resultList.Add(Marshal.PtrToStringAnsi(userPtr));
                            }
                        }
                    }

                    Externals.WTSFreeMemory(SessionInfoPtr);
                }
            }
            finally
            {
                CloseServer(serverHandle);
            }

            return resultList;
        }

        private void btShowUsers_Click(object sender, EventArgs e)
        {
            List<String> users = GetLoggedUsers("localhost");
            tbUserList.Clear();
            tbUserList.Text = String.Join(Environment.NewLine, users);
        }
    }
}
