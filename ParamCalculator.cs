namespace ParamCalculator
{
    public partial class ParamCalculator : Form
    {
        /// <summary>  Сколько добавляется раз в Time времени </summary>
        private int _ScreenNumber = 0;
        internal int ScreenNumber
        {
            get => _ScreenNumber;
            set => _ScreenNumber = value > MaxNumber ? (int)MaxNumber : value < 0 ? 0 : _ScreenNumber = value;
        }

        /// <summary>  Максимальное значение для ScreenNumber </summary>
        internal uint MaxNumber = 10;

        /// <summary>  Сколько добавляется раз в Time времени </summary>
        internal uint Number = 10;

        /// <summary> Раз во сколько секунд будет добавлятся Number к ScreenNumber </summary>
        internal uint Time = 1;

        private System.Windows.Forms.Timer _Timer;

        public ParamCalculator()
        {
            InitializeComponent();

            _Timer = new System.Windows.Forms.Timer();
            _Timer.Tick += AddNumberWhenTimerAlarm;
        }

        #region Buttons

        #region Take/Add Buttons

        private void TakeButton_Click(object sender, EventArgs e) =>
            AddOrTakeScreenNumber(false);

        private void AddButton_Click(object sender, EventArgs e) =>
            AddOrTakeScreenNumber(true);

        private void AddOrTakeScreenNumber(bool isPositiveNumber)
        {
            try
            {
                var num = Convert.ToUInt16(DifferenceNumberTextBox.Text);

                if (num >= MaxNumber)
                    throw new Exception();

                ScreenNumber += isPositiveNumber ? num : -num;
                ScreenNumberLabel.Text = ScreenNumber.ToString();
            }
            catch
            {
                MessageBox.Show("Некорректный ввод!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        #endregion

        private bool timerIsWork;

        private void RunTimerButton_Click(object sender, EventArgs e)
        {
            if (timerIsWork)
            {
                timerIsWork = false;
                _Timer.Stop();
                TimerStatusLabel.Text = "Статус таймера: выключен";
            }
            else
            {
                timerIsWork = true;
                _Timer.Interval = (int)Time * 1000;
                _Timer.Start();
                TimerStatusLabel.Text = "Статус таймера: включён";
            }
        }

        private void AddNumberWhenTimerAlarm(object? myObject, EventArgs myEventArgs)
        {
            ScreenNumber += (int)Number;
            ScreenNumberLabel.Text = ScreenNumber.ToString();
        }

        #endregion

        #region TextBoxes

        private void NumberTextBox_TextChanged(object sender, EventArgs e) =>
            SetTextBoxValue(sender, ref Number);

        private void TimeTextBox_TextChanged(object sender, EventArgs e) =>
            SetTextBoxValue(sender, ref Time);

        private void MaxNumberTextBox_TextChanged(object sender, EventArgs e) =>
            SetTextBoxValue(sender, ref MaxNumber);

        private void SetTextBoxValue(object textBox, ref uint param)
        {
            try
            {
                param = Convert.ToUInt16((textBox as TextBox ?? throw new Exception()).Text);
            }
            catch
            {
                MessageBox.Show("Некорректный ввод!", "Ошибка", MessageBoxButtons.OK);
            }
        }

        #endregion

        #region Easter Eggs

        private byte _CurrentNumberImage = 0;
        public byte CurrentNumberImage
        {
            get => _CurrentNumberImage;
            set => _CurrentNumberImage = (byte)(value <= 3 ? value : 0);
        }

        private void MaxNumberLabel_Click(object sender, EventArgs e)
        {
            switch (CurrentNumberImage)
            {
                case 0:
                    BackgroundImage = Properties.Resources.GagagaCHIII;
                    break;
                case 1:
                    BackgroundImage = Properties.Resources.Stalin;
                    break;
                case 2:
                    BackgroundImage = Properties.Resources.Uganda;
                    break;
                case 3:
                    BackgroundImage = Properties.Resources.Tan;
                    break;
            }
            CurrentNumberImage++;
        }

        #endregion
    }
}