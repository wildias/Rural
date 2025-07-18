using System;
using System.Windows.Forms;

namespace RCAGPC.TelaEspera
{
    public partial class WaitForm : DevExpress.XtraWaitForm.WaitForm
    {
        
        public WaitForm()
        {
            InitializeComponent();
            this.progressPanel1.AutoHeight = true;

            var inicio = DateTime.Now;

            var timer = new Timer();

            timer.Interval = 1000;

            timer.Tick += (ss, e) =>
            {
                var d = DateTime.Now - inicio;

                var h = d.Hours.ToString().PadLeft(2, '0');
                var m = d.Minutes.ToString().PadLeft(2, '0');
                var s = d.Seconds.ToString().PadLeft(2, '0');

                labelTimer.Text = $"{h}:{m}:{s}";
                
            };

            timer.Start();
            
            labelTimer.Visible = true;
            
        }

        #region Overrides
        protected override void OnActivated(EventArgs e)
        {
            Application.DoEvents();
            base.OnActivated(e);
        }
        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.progressPanel1.Caption = caption;
        }

        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.progressPanel1.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        
    }
}