namespace Practice
{
    public class RadiatorCalculator
    {
        public double q1;
        public double q2;
        public double q3;
        public double q4;
        public double q5;
        public double q6;
        public double q7;
        public double roomArea;

        public RadiatorCalculator()
        {

        }
        public void CalculateWindowType(int typeIdentifier)
        {
            switch (typeIdentifier)
            {
                case 0:
                    q1 = 1.27d;
                    break;
                case 1:
                    q1 = 1d;
                    break;

                case 2:
                    q1 = 0.85d;
                    break;
            }
        }
        public void CalculateOuterWallCount(int wallCount)
        {
            q2 = 1 + (wallCount + 1d) * 0.1d;
        }
        public void CalculateOuterWallType(int typeIdentifier)
        {
            switch (typeIdentifier)
            {
                case 0:
                    q3 = 1.27d;
                    break;
                case 1:
                    q3 = 1d;
                    break;

                case 2:
                    q3 = 0.85d;
                    break;
            }
        }
        public void CalculateRoomAboveType(int typeIdentifier)
        {
            q4 = 0.7d + (typeIdentifier + 1d) * 0.1d;
        }
        public void CalculateMinStreetTemperature(double minTemperature)
        {
            q5 = 0.04d * (-minTemperature + 10) - 0.1d;
        }
        public void CalculateWindowToRoomAreaRatio(double roomArea, double windowArea)
        {
            this.roomArea = roomArea;
            double areasRatio = windowArea / roomArea;
            switch (areasRatio)
            {
                case < 0.1d:
                    q6 = 0.7d;
                    break;
                case > 1.1d:
                    q6 = 1.8d;
                    break;
                default:
                    q6 = areasRatio + 0.6d;
                    break;
            };
        }
        public void CalculateRoomHeight(double height)
        {
            switch (height)
            {
                case < 2.5d:
                    q7 = 1;
                    break;
                case > 5.5d:
                    q7 = 1.35;
                    break;
                default:
                    q7 =0.75d + 0.1d * height;
                    break;
            }
        }
        public double GetHeatPower()
        {
            return 100 * roomArea * q1 * q2 * q3 * q4 * q5 * q6 * q7;
        }
    }
}
