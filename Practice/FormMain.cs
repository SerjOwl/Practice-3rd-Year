namespace Practice
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            InitializeTable();
            AnswerLabel.Text = string.Empty;
        }
        private void InitializeTable()
        {
            WindowGridView.Rows.Clear(); WindowGridView.Columns.Clear();
            WindowGridView.ColumnCount = 2;
            WindowGridView.Columns[0].HeaderCell.Value = "Высота";
            WindowGridView.Columns[1].HeaderCell.Value = "Ширина";
            WindowGridView.RowCount = (int)WindowCountNUD.Value;
            InitializeRowHeaders();
            WindowGridView.Rows[0].Cells[0].Value = 1;
            WindowGridView.Rows[0].Cells[1].Value = 1;
        }
        private void InitializeRowHeaders()
        {
            WindowGridView.RowHeadersWidth = 80;
            for (int i = 0; i < WindowGridView.Rows.Count; i++)
                WindowGridView.Rows[i].HeaderCell.Value = "Окно " + (i + 1).ToString();
        }

        private void WindowCountNUD_ValueChanged(object sender, EventArgs e)
        {
            WindowGridView.RowCount = (int)WindowCountNUD.Value;
            InitializeRowHeaders();
        }
        private double GetWindowArea()
        {
            double windowArea = 0;
            for (int i = 0; i < WindowGridView.Rows.Count; i++)
            {
                windowArea += Convert.ToDouble(WindowGridView.Rows[i].Cells[0].Value) * Convert.ToDouble(WindowGridView.Rows[i].Cells[1].Value);
            }
            return windowArea;
        }
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            RadiatorCalculator calc = new();
            calc.CalculateWindowType(WindowTypeCB.SelectedIndex);
            calc.CalculateOuterWallCount(OuterWallCountCB.SelectedIndex);
            calc.CalculateOuterWallType(OuterWallTypeCB.SelectedIndex);
            calc.CalculateRoomAboveType(RoomAboveTypeCB.SelectedIndex);
            calc.CalculateMinStreetTemperature((double)MinStreetTempNUD.Value);
            calc.CalculateWindowToRoomAreaRatio((double)RoomAreaNUD.Value, GetWindowArea());
            calc.CalculateRoomHeight((double)RoomHeightNUD.Value);

            AnswerLabel.Text = $"{String.Format("{0:0.00}", calc.GetHeatPower())} Ватт";

            //string testText = $"{calc.q1}\n{calc.q2}\n{calc.q3}\n{calc.q4}\n{calc.q5}\n{calc.q6}\n{calc.q7}\n";
            //MessageBox.Show(testText);
        }
    }
}
