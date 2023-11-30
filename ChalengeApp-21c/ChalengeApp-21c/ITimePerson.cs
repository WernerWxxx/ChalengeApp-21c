using static ChalengeApp_21c.TimePersonBase;

namespace ChalengeApp_21c
{
    public interface ITimePerson
    {
        string Name { get; }

        string Surname { get; }

        void AddGrade(float grade);

        void Calculation();

        void AddGrade(double grade);

        void AddGrade(long grade);

        void AddGrade(int grade);

        void AddGrade(char grade);

        void AddGrade(string grade);

        event GradeAddedDelegate GradeAdded;
        Statistics GetStatistics();
        
    }
}
