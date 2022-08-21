namespace ParamCalculator
{
    public partial class ParamCalculator : Form
    {
        /// <summary>  Сколько добавляется раз в Time времени </summary>
        internal uint ScreenNumber = 0;

        /// <summary>  Максимальное значение для ScreenNumber </summary>
        internal uint MaxNumber = 10;

        /// <summary>  Сколько добавляется раз в Time времени </summary>
        internal uint Number = 10;

        /// <summary>  Сколько добавить или убавить из ScreenNumber </summary>
        internal uint DifferenceNumber = 0;

        /// <summary> Раз во сколько секунд будет добавлятся Number к ScreenNumber </summary>
        internal uint Time = 10;

        public ParamCalculator()
        {
            InitializeComponent();
        }
    }
}