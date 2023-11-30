namespace ChalengeApp_21c
{   //
    public class Statistics
    {
        public float Min { get; set; }

        public float Max { get; set; }

        public float Sum { get; private set; }
        public int Count { get; private set; }

        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }

        public char AverageLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var average when average >= 800:

                        return 'A';

                    case var average when average >= 600:
                        return 'B';

                    case var average when average >= 400:
                        return 'C';

                    case var average when average >= 200:
                        return 'D';

                    default:
                        return 'E';
                }
            }
        }
        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);
        }
    }
}
