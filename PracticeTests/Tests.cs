using Practice;
namespace PracticeTests
{
    public class Tests
    {
        [Fact]
        public void Q1Tests()
        {
            int[] nums = { 0, 1, 2 };
            double[] res = { 1.27d, 1.0d, 0.85d };
            RadiatorCalculator calc = new RadiatorCalculator();
            for (int i = 0; i < nums.Length; i++)
            {
                calc.CalculateWindowType(nums[i]);
                Assert.Equal(res[i], Math.Round(calc.q1, 2));
            }}
        [Fact]
        public void Q2Tests()
        {
            int[] nums = { 0, 1, 2, 3 };
            double[] res = { 1.1d, 1.2d, 1.3d, 1.4d };
            RadiatorCalculator calc = new RadiatorCalculator();
            for (int i = 0; i < nums.Length; i++)
            {
                calc.CalculateOuterWallCount(nums[i]);
                Assert.Equal(res[i], Math.Round(calc.q2, 2));
            }
        }
        [Fact]
        public void Q3Tests()
        {
            int[] nums = { 0, 1, 2 };
            double[] res = { 1.27d, 1.0d, 0.85d };
            RadiatorCalculator calc = new RadiatorCalculator();
            for (int i = 0; i < nums.Length; i++)
            {
                calc.CalculateOuterWallType(nums[i]);
                Assert.Equal(res[i], Math.Round(calc.q3, 2));
            }
        }
        [Fact]
        public void Q4Tests()
        {
            int[] nums = { 0, 1, 2, 3 };
            double[] res = { 0.8d, 0.9d, 1.0d, 1.1d };
            RadiatorCalculator calc = new RadiatorCalculator();
            for (int i = 0; i < nums.Length; i++)
            {
                calc.CalculateRoomAboveType(nums[i]);
                Assert.Equal(res[i], Math.Round(calc.q4,2));
            }
        }
        [Fact]
        public void Q5Tests()
        {
            int[] nums = { -10, -20, -30, -40 };
            double[] res = { 0.7d, 1.1d, 1.5d, 1.9d };
            RadiatorCalculator calc = new RadiatorCalculator();
            for (int i = 0; i < nums.Length; i++)
            {
                calc.CalculateMinStreetTemperature(nums[i]);
                Assert.Equal(res[i], Math.Round(calc.q5, 2));
            }
        }
        [Fact]
        public void Q6Tests()
        {
            int[] roomAreas = { 100, 100, 100, 100 };
            int[] windowAreas = { 10, 30, 50, 70 };
            double[] res = { 0.7d, 0.9d, 1.1d, 1.3d };
            RadiatorCalculator calc = new RadiatorCalculator();
            for (int i = 0; i < roomAreas.Length; i++)
            {
                calc.CalculateWindowToRoomAreaRatio(roomAreas[i], windowAreas[i]);
                Assert.Equal(res[i], Math.Round(calc.q6, 2));
            }
        }
        [Fact]
        public void Q7Tests()
        {
            double[] nums = { 2.5d, 3.5d, 5.5d, 6.5d };
            double[] res = { 1.0d, 1.1d, 1.3d, 1.35d };
            RadiatorCalculator calc = new RadiatorCalculator();
            for (int i = 0; i < nums.Length; i++)
            {
                calc.CalculateRoomHeight(nums[i]);
                Assert.Equal(res[i], Math.Round(calc.q7, 2));
            }
        }
    }
}