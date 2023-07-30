namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Invalid grade value");
            }
        }
        
        public override void AddGrade(double grade)
        {
            var doubleToFloat = (float)grade;
            this.AddGrade(doubleToFloat);
        }

        public override void AddGrade(int grade)
        {
            var intToFloat = (float)grade;
            this.AddGrade(intToFloat);
        }

        public override void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.AddGrade(100);
                    break;
                case 'B':
                case 'b':
                    this.AddGrade(80);
                    break;
                case 'C':
                case 'c':
                    this.AddGrade(60);
                    break;
                case 'D':
                case 'd':
                    this.AddGrade(40);
                    break;
                case 'E':
                case 'e':
                    this.AddGrade(20);
                    break;
                default:
                    throw new Exception("Wrong Letter");
            }
        }
    
        public override void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("String is not float");
            }
        }

        public override Statistics GetStatistics()
        {
            var result = new Statistics();

            if(File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var lineCounter = 0;
                    var line = reader.ReadLine();

                    result.Average = 0;
                    result.Max = float.MinValue;
                    result.Min = float.MaxValue;

                    while (line != null)
                    {
                        var number = float.Parse(line);
                        
                        result.Max = Math.Max(result.Max, number);
                        result.Min = Math.Min(result.Min, number);
                        result.Average += number;
                        lineCounter++;

                        line = reader.ReadLine();
                    }

                    result.Average /= lineCounter;
                    
                    switch (result.Average)
                    {
                        case var average when average >= 80:
                            result.AverageLetter = 'A';
                            break;
                        case var average when average >= 60:
                            result.AverageLetter = 'B';
                            break;
                        case var average when average >= 40:
                            result.AverageLetter = 'C';
                            break;
                        case var average when average >= 20:
                            result.AverageLetter = 'D';
                            break;
                        default:
                            result.AverageLetter = 'E';
                            break;
                    }
                }
            }
            return result;
        }
    }
}
