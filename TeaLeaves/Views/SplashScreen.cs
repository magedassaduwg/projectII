namespace TeaLeaves.Views
{
    /// <summary>
    /// Splash screen to show while loading messages
    /// </summary>
    public partial class SplashScreen : Form
    {
        private delegate void CloseDelegate();
        private static SplashScreen splashForm;

        /// <summary>
        /// Constructor to initialize components
        /// </summary>
        public SplashScreen()
        {
            InitializeComponent();
        }

        static public void ShowSplashScreen(Point startupLocation, Size formSize)
        {
            if (splashForm != null) return;
            splashForm = new SplashScreen();
            splashForm.Size = formSize;
            splashForm.Location = startupLocation;
            Thread thread = new Thread(new ThreadStart(SplashScreen.ShowForm));
            thread.IsBackground = true;
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        static private void ShowForm()
        {
            if (splashForm != null) Application.Run(splashForm);
        }

        static public void CloseForm()
        {
            splashForm?.Invoke(new CloseDelegate(SplashScreen.CloseFormInternal));
        }

        static private void CloseFormInternal()
        {
            if (splashForm != null)
            {
                splashForm.Close();
                splashForm = null;
            };
        }
    }
}
