namespace MultiThreadingExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BtnTimeConsuming.Enabled = false;
            BtnPrintNumber.Enabled = false;

            //DoTimeConsumingWork();

            Thread WorkWithoutObstructionThread = new Thread(DoTimeConsumingWork);
            WorkWithoutObstructionThread.Start();

            BtnTimeConsuming.Enabled = true;
            BtnPrintNumber.Enabled = true;

        }

        private void DoTimeConsumingWork()
        {
            Thread.Sleep(5000);
        }

        private void BtnPrintNumber_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < 10; i++)
            {
                List_Of_Numbers.Items.Add(i);
               
            }
        }
    }
}

//Process is what O.S uses to facilitate the execution of program by providing the resource required.Each
// process has a unique process id assocoated with it.In order to run or facilitate the visual studio 
//program execution we need a process called MSBuild.exe.

//Thread is a light weight process.A process has atleast one thread which is commonly called as main thread which
// actually executes the application code.