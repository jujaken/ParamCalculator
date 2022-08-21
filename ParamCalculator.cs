namespace ParamCalculator
{
    public partial class ParamCalculator : Form
    {
        /// <summary>  Сколько добавляется раз в Time времени </summary>
        internal int ScreenNumber = 0;

        /// <summary>  Максимальное значение для ScreenNumber </summary>
        internal uint MaxNumber = 10;

        /// <summary>  Сколько добавляется раз в Time времени </summary>
        internal uint Number = 10;

        /// <summary> Раз во сколько секунд будет добавлятся Number к ScreenNumber </summary>
        internal uint Time = 10;

        public ParamCalculator()
        {
            InitializeComponent();
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

        private void RunTimerButton_Click(object sender, EventArgs e)
        {

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
    }
}