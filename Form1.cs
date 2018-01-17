using System;
using System.Drawing;
using System.Text;
using System.Drawing.Imaging;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Reflection;
using Tesseract;
using System.Net;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Diagnostics;

namespace translator
{


    public partial class Form1 : Form
    {
        Rectangle rect;

        private int rectSourceX = 0;
        private int rectSourceY = 0;
        private int rectDestX = 0;
        private int rectDestY = 0;
        private bool fullScreen = false;
        private int languageType = 0;   //0 = 영어 , 1 = 일어

        event KeyboardHooker.HookedKeyboardUserEventHandler HookedKeyboardNofity;

        private long Form1_HookedKeyboardNofity(int iKeyWhatHappened, int vkCode)
        {
            long lResult = 0;

            if (fullScreen == true && vkCode == 49 && iKeyWhatHappened == 32) //ALT + 1
            {
                lResult = 0;

                if ((rectDestX - rectSourceX) >= 1 && (rectDestY - rectSourceY) >= 1)
                    StartTrans();
            }
            else if (vkCode == 50 && iKeyWhatHappened == 32) //ALT + 2
            {
                WindowVisible(1);


                lResult = 0;
                
            }
            else if (fullScreen == true && vkCode == 51 && iKeyWhatHappened == 32) //ALT + 3
            {
                translatedText.Visible = false;

                explainLabel6.Visible = false;
                explainLabel7.Visible = false;
                lResult = 0;
                this.TransparencyKey = Color.Transparent;
            }
            else if (vkCode == 52 && iKeyWhatHappened == 32) //ALT + 4
            {
                lResult = 0;
                translatedText.Text = "";
                this.Refresh();
            }
            else if (vkCode == 53 && iKeyWhatHappened == 32) //ALT + 5
            {
                WindowVisible(2);

                this.Opacity = 1;
                this.TransparencyKey = Color.Olive;

                lResult = 0;
                translatedText.Text = "글자 예시";
                this.Refresh();
            }
            else
            {
                lResult = 0;
            }
            return lResult;
        }

        private void WindowVisible(int flag)
        {
            if (flag == 1)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                this.WindowState = FormWindowState.Maximized;
                this.TopMost = true;

                translatedText.Visible = false;

                explainLabel0.Visible = false;
                explainLabel1.Visible = false;
                explainLabel2.Visible = false;
                explainLabel3.Visible = false;
                explainLabel4.Visible = false;
                explainLabel5.Visible = false;
                explainLabel6.Visible = true;
                explainLabel7.Visible = true;
                explainLabel6.Location = new Point(Screen.AllScreens[0].Bounds.Width - 150, 50);
                explainLabel7.Location = new Point(Screen.AllScreens[0].Bounds.Width - 150, 70);

                videoLabel0.Visible = false;
                videoLabel1.Visible = false;
                copyrightLabel0.Visible = false;
                titleLabel.Visible = false;
                versionLabel.Visible = false;

                optionBox.Visible = false;
                optionLabel0.Visible = false;
                optionLabel1.Visible = false;
                optionLabel2.Visible = false;
                optionLabel3.Visible = false;


                engButton.Visible = false;
                japButton.Visible = false;

                this.Opacity = 0.5;
                this.TransparencyKey = Color.Olive;

                fullScreen = true;
            }
            else if (flag == 2)
            {
                this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
                this.WindowState = FormWindowState.Normal;
                this.TopMost = false;

                translatedText.Visible = true;

                explainLabel0.Visible = true;
                explainLabel1.Visible = true;
                explainLabel2.Visible = true;
                explainLabel3.Visible = true;
                explainLabel4.Visible = true;
                explainLabel5.Visible = true;
                explainLabel6.Visible = true;
                explainLabel7.Visible = true;
                explainLabel6.Location = new Point(10, 292);
                explainLabel7.Location = new Point(10, 318);

                videoLabel0.Visible = true;
                videoLabel1.Visible = true;
                copyrightLabel0.Visible = true;
                titleLabel.Visible = true;
                versionLabel.Visible = true;

                optionBox.Visible = true;
                optionLabel0.Visible = true;
                optionLabel1.Visible = true;
                optionLabel2.Visible = true;
                optionLabel3.Visible = true;

                engButton.Visible = true;
                japButton.Visible = true;

                fullScreen = false;
            }
        }



        public Form1()
        {
            InitializeComponent();

            sizeChangeCombo.SelectedItem = 12;

            MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            FormClosing += new FormClosingEventHandler(Form1_FormClosing);
            HookedKeyboardNofity += new KeyboardHooker.HookedKeyboardUserEventHandler(Form1_HookedKeyboardNofity);
            videoLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.VideoLabel1_LinkClicked);
            sizeChangeCombo.SelectedIndexChanged += new System.EventHandler(this.SizeChangeCombo_SelectedIndexChanged);
            colorChangeCombo.SelectedIndexChanged += new System.EventHandler(this.ColorChangeCombo_SelectedIndexChanged);
            backColorChangeCombo.SelectedIndexChanged += new System.EventHandler(this.BackColorChangeCombo_SelectedIndexChanged);
            
            KeyboardHooker.Hook(HookedKeyboardNofity);

        }
        

        private void StartTrans()
        {
            string randomFileName = System.IO.Directory.GetCurrentDirectory() + "/captureImg.png";
            CaptureImage(randomFileName);

            string dataPath = System.IO.Directory.GetCurrentDirectory();
            string language = @"eng";

            if (languageType == 0)
                language = @"eng";
            else if (languageType == 1)
                language = @"jpn";


            string textPicked;
            using (var api = new TessBaseAPI(dataPath, language))
            {
                api.Process(randomFileName, true);
                textPicked = api.GetUTF8Text();

            }
            if (textPicked != "")
            {
                string url = "https://openapi.naver.com/v1/papago/n2mt";
                string query = textPicked;
                byte[] byteDataParams = Encoding.UTF8.GetBytes("source=en&target=ko&text=" + query);

                if (languageType == 0)
                {
                    url = "https://openapi.naver.com/v1/papago/n2mt";
                    byteDataParams = Encoding.UTF8.GetBytes("source=en&target=ko&text=" + query);
                }
                else if (languageType == 1)
                {
                    url = "https://openapi.naver.com/v1/language/translate";
                    byteDataParams = Encoding.UTF8.GetBytes("source=ja&target=ko&text=" + query);
                }

                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Headers.Add("X-Naver-Client-Id", "API KEY");  //API KEY
                request.Headers.Add("X-Naver-Client-Secret", "Secret Key"); //Sectret KEY
                request.Method = "POST";
                request.ContentType = "application/x-www-form-urlencoded";
                request.ContentLength = byteDataParams.Length;
                Stream st = request.GetRequestStream();
                st.Write(byteDataParams, 0, byteDataParams.Length);
                st.Close();

                try
                {
                    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                    Stream stream = response.GetResponseStream();
                    StreamReader reader = new StreamReader(stream, Encoding.UTF8);
                    string textTrans = reader.ReadToEnd();
                    stream.Close();
                    response.Close();
                    reader.Close();


                    JObject jo = JObject.Parse(textTrans);
                    JToken idToken = jo["message"]["result"]["translatedText"];
                    String realText = (String)idToken;

                    translatedText.Location = new Point(rectSourceX, rectDestY);
                    translatedText.Text = realText;
                    translatedText.Visible = true;
                }

                catch
                {
                    translatedText.Visible = true;
                    translatedText.Location = new Point(rectSourceX, rectDestY);
                    translatedText.Text = "번역할 언어가 없습니다. 다시 선택하세요-번역 에러";
                }
            }
            else
            {
                translatedText.Visible = true;
                translatedText.Location = new Point(rectSourceX, rectDestY);
                translatedText.Text = "번역할 언어가 없습니다. 다시 선택하세요-인식 에러";
            }

        }

        private void SizeChangeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            translatedText.Font = new Font(translatedText.Font.Name, float.Parse(sizeChangeCombo.SelectedItem.ToString()), translatedText.Font.Style);
        }

        private void BackColorChangeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color br = Color.Black;

            if (backColorChangeCombo.SelectedItem.ToString() == "빨간색")
                br = Color.Red;

            else if (backColorChangeCombo.SelectedItem.ToString() == "초록색")
                br = Color.Green;

            else if (backColorChangeCombo.SelectedItem.ToString() == "파란색")
                br = Color.Blue;

            else if (backColorChangeCombo.SelectedItem.ToString() == "노란색")
                br = Color.Yellow;

            else if (backColorChangeCombo.SelectedItem.ToString() == "하얀색")
                br = Color.White;

            else
                br = Color.Black;

            translatedText.BackColor = br;

        }


        private void ColorChangeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Color br = Color.Black;

            if(colorChangeCombo.SelectedItem.ToString() == "빨간색")
                br = Color.Red;

            else if (colorChangeCombo.SelectedItem.ToString() == "초록색")
                br = Color.Green;

            else if (colorChangeCombo.SelectedItem.ToString() == "파란색")
                br = Color.Blue;

            else if (colorChangeCombo.SelectedItem.ToString() == "노란색")
                br = Color.Yellow;

            else if (colorChangeCombo.SelectedItem.ToString() == "하얀색")
                br = Color.White;

            else
                br = Color.Black;


            translatedText.ForeColor = br;
        }

        private void VideoLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url;
            if (e.Link.LinkData != null)
                url = e.Link.LinkData.ToString();
            else
                url = videoLabel1.Text.Substring(e.Link.Start, e.Link.Length);

            if (!url.Contains("://"))
                url = "http://" + url;

            var si = new ProcessStartInfo(url);
            Process.Start(si);
            videoLabel1.LinkVisited = true;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            rectDestX = e.X;
            rectDestY = e.Y;
            using (Graphics g = this.CreateGraphics())
            {
                Pen pen = new Pen(Color.Red, 2);

                g.DrawRectangle(pen, rect);

                pen.Dispose();
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            rect = new Rectangle(e.X, e.Y, 0, 0);
            rectSourceX = e.X;
            rectSourceY = e.Y;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                rect = new Rectangle(rect.Left, rect.Top, e.X - rect.Left, e.Y - rect.Top);
            }
        }

        private void CaptureImage(string fileName)
        {
            Bitmap captureBitmap = new Bitmap(rectDestX - rectSourceX, rectDestY - rectSourceY, PixelFormat.Format32bppArgb);
            Rectangle captureRectangle = Screen.AllScreens[0].Bounds;
            Graphics captureGraphics = Graphics.FromImage(captureBitmap);
            captureGraphics.CopyFromScreen(rectSourceX, rectSourceY, 0, 0, captureRectangle.Size);
            captureBitmap.Save(fileName);
            captureBitmap.Dispose();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            KeyboardHooker.UnHook();
        }

        private void engButton_Click(object sender, EventArgs e)
        {
            languageType = 0;
            this.engButton.BackColor = SystemColors.ActiveCaption;
            this.japButton.BackColor = Color.White;
        }

        private void japButton_Click(object sender, EventArgs e)
        {
            languageType = 1;
            this.japButton.BackColor = SystemColors.ActiveCaption;
            this.engButton.BackColor = Color.White;

        }
        
    }

    public class KeyboardHooker
    {
        // 후킹된 키보드 이벤트를 처리할 이벤트 핸들러
        private delegate long HookedKeyboardEventHandler(int nCode, int wParam, IntPtr lParam);

        
        public delegate long HookedKeyboardUserEventHandler(int iKeyWhatHappened, int vkCode);

        private const int WH_KEYBOARD_LL = 13;
        private static long m_hDllKbdHook;
        private static KBDLLHOOKSTRUCT m_KbDllHs = new KBDLLHOOKSTRUCT();
        private static IntPtr m_LastWindowHWnd;
        public static IntPtr m_CurrentWindowHWnd;

        private static HookedKeyboardEventHandler m_LlKbEh = new HookedKeyboardEventHandler(HookedKeyboardProc);

        private static HookedKeyboardUserEventHandler m_fpCallbkProc = null;



      
        private struct KBDLLHOOKSTRUCT
        {
            #region vkCode
            #endregion
            public int vkCode;
            #region scanCode
            /// <summary>
            /// Specifies a hardware scan code for the key. 
            /// </summary>
            #endregion
            public int scanCode;
            #region flags
            #endregion
            public int flags;
            #region time
            /// <summary>
            /// Specifies the time stamp for this message. 
            /// </summary>
            #endregion
            public int time;
            #region dwExtraInfo
            /// <summary>
            /// Specifies extra information associated with the message. 
            /// </summary>
            #endregion
            public IntPtr dwExtraInfo;

            #region ToString()
            /// <summary>
            /// Creates a string representing the values of all the variables of an instance of this structure.
            /// </summary>
            /// <returns>A string</returns>
            #endregion
            public override string ToString()
            {
                string temp = "KBDLLHOOKSTRUCT\r\n";
                temp += "vkCode: " + vkCode.ToString() + "\r\n";
                temp += "scanCode: " + scanCode.ToString() + "\r\n";
                temp += "flags: " + flags.ToString() + "\r\n";
                temp += "time: " + time.ToString() + "\r\n";
                return temp;
            }
        }
        
        [DllImport(@"kernel32.dll", CharSet = CharSet.Auto)]
        private static extern void CopyMemory(ref KBDLLHOOKSTRUCT pDest, IntPtr pSource, long cb);

        #region GetForegroundWindow Documentation
        /// <summary>
        /// The GetForegroundWindow function returns a handle to the foreground window (the window with which the user is currently working).
        /// The system assigns a slightly higher priority to the thread that creates the foreground window than it does to other threads. 
        /// </summary>
        /// <remarks>
        /// <para>
        /// See <a href="ms-help://MS.VSCC/MS.MSDNVS/winui/windows_4f5j.htm">GetForegroundWindow</a><BR/>
        /// </para>
        /// <para>
        /// <code>
        /// [C++]
        /// HWND GetForegroundWindow(VOID);
        /// </code>
        /// </para>
        /// </remarks>
        #endregion
        [DllImport(@"user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr GetForegroundWindow();

        #region GetAsyncKeyState
        /// <summary>
        /// The GetAsyncKeyState function determines whether a key is up or down at the time the function is called,
        /// and whether the key was pressed after a previous call to GetAsyncKeyState. 
        /// </summary>
        /// <remarks>
        /// <para>
        /// See <a href="ms-help://MS.VSCC/MS.MSDNVS/winui/keybinpt_1x0l.htm">GetAsyncKeyState</a><BR/>
        /// </para>
        /// <para>
        /// <code>
        /// [C++]
        ///	SHORT GetAsyncKeyState(
        ///		int vKey   // virtual-key code
        ///		);
        /// </code>
        /// </para>
        /// </remarks>
        #endregion
        [DllImport(@"user32.dll", CharSet = CharSet.Auto)]
        private static extern uint GetAsyncKeyState(int vKey);

        #region CallNextHookEx Documentation
        /// <summary>
        /// The CallNextHookEx function passes the hook information to the next hook procedure in the current hook chain.
        /// A hook procedure can call this function either before or after processing the hook information. 
        /// </summary>
        /// <remarks>
        /// <para>
        /// See <a href="ms-help://MS.VSCC/MS.MSDNVS/winui/hooks_57aw.htm">CallNextHookEx</a><BR/>
        /// </para>
        /// <para>
        /// <code>
        /// [C++]
        /// LRESULT CallNextHookEx(
        ///    HHOOK hhk,      // handle to current hook
        ///    int nCode,      // hook code passed to hook procedure
        ///    WPARAM wParam,  // value passed to hook procedure
        ///    LPARAM lParam   // value passed to hook procedure
        ///    );
        /// </code>
        /// </para>
        /// </remarks>
        #endregion
        [DllImport(@"user32.dll", CharSet = CharSet.Auto)]
        private static extern long CallNextHookEx(long hHook, long nCode, long wParam, IntPtr lParam);

        #region SetWindowsHookEx Documentation
        /// <summary>
        /// The SetWindowsHookEx function installs an application-defined hook procedure into a hook chain.
        /// You would install a hook procedure to monitor the system for certain types of events.
        /// These events are associated either with a specific thread or with all threads in the same
        /// desktop as the calling thread. 
        /// </summary>
        /// <remarks>
        /// <para>
        /// See <a href="ms-help://MS.VSCC/MS.MSDNVS/winui/hooks_7vaw.htm">SetWindowsHookEx</a><BR/>
        /// </para>
        /// <para>
        /// <code>
        /// [C++]
        ///  HHOOK SetWindowsHookEx(
        ///		int idHook,        // hook type
        ///		HOOKPROC lpfn,     // hook procedure
        ///		HINSTANCE hMod,    // handle to application instance
        ///		DWORD dwThreadId   // thread identifier
        ///		);
        /// </code>
        /// </para>
        /// </remarks>
        #endregion
        [DllImport(@"user32.dll", CharSet = CharSet.Auto)]
        private static extern long SetWindowsHookEx(int idHook, HookedKeyboardEventHandler lpfn, long hmod, int dwThreadId);

        #region UnhookWindowsEx Documentation
        /// <summary>
        /// The UnhookWindowsHookEx function removes a hook procedure installed in a hook chain by the SetWindowsHookEx function. 
        /// </summary>
        /// <remarks>
        /// <para>
        /// See <a href="ms-help://MS.VSCC/MS.MSDNVS/winui/hooks_6fy0.htm">UnhookWindowsHookEx</a><BR/>
        /// </para>
        /// <para>
        /// <code>
        /// [C++]
        /// BOOL UnhookWindowsHookEx(
        ///    HHOOK hhk   // handle to hook procedure
        ///    );
        /// </code>
        /// </para>
        /// </remarks>
        #endregion
        [DllImport(@"user32.dll", CharSet = CharSet.Auto)]
        private static extern long UnhookWindowsHookEx(long hHook);


        private const int HC_ACTION = 0;
        private static long HookedKeyboardProc(int nCode, int wParam, IntPtr lParam)
        {
            long lResult = 0;

            if (nCode == HC_ACTION) //LowLevelKeyboardProc
            {
                unsafe
                {
                    CopyMemory(ref m_KbDllHs, lParam, sizeof(KBDLLHOOKSTRUCT));
                }

                m_CurrentWindowHWnd = GetForegroundWindow();

                if (m_CurrentWindowHWnd != m_LastWindowHWnd)
                    m_LastWindowHWnd = m_CurrentWindowHWnd;

                if (m_fpCallbkProc != null)
                {
                    lResult = m_fpCallbkProc(m_KbDllHs.flags, m_KbDllHs.vkCode);
                }

            }
            else if (nCode < 0)
            {
                #region MSDN Documentation on return conditions
                // "If nCode is less than zero, the hook procedure must pass the message to the 
                // CallNextHookEx function without further processing and should return the value 
                // returned by CallNextHookEx. "
                // ...
                // "If nCode is greater than or equal to zero, and the hook procedure did not 
                // process the message, it is highly recommended that you call CallNextHookEx 
                // and return the value it returns;"
                #endregion
                return CallNextHookEx(m_hDllKbdHook, nCode, wParam, lParam);
            }

            return lResult;
        }

        // 후킹 시작
        public static bool Hook(HookedKeyboardUserEventHandler callBackEventHandler)
        {
            bool bResult = true;
            m_hDllKbdHook = SetWindowsHookEx(
                (int)WH_KEYBOARD_LL,
                m_LlKbEh,
                Marshal.GetHINSTANCE(Assembly.GetExecutingAssembly().GetModules()[0]).ToInt32(),
                0);

            if (m_hDllKbdHook == 0)
            {
                bResult = false;
            }

            KeyboardHooker.m_fpCallbkProc = callBackEventHandler;

            return bResult;
        }

        public static void UnHook()
        {
            UnhookWindowsHookEx(m_hDllKbdHook);
        }

    }

}
