namespace ChalengeApp_21c
{
    public abstract class TimePersonBase : ITimePerson
    {
        public delegate void GradeAddedDelegate(object sender, EventArgs args);

        public abstract event GradeAddedDelegate GradeAdded;
        public TimePersonBase(string name, string surname)//
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(double grade);

        public abstract void AddGrade(long grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(string grade);

        public abstract Statistics GetStatistics();

        public abstract void AddGrade(char grade);
        //{
          //  throw new NotImplementedException();
        //}
    }
}
