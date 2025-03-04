// See https://aka.ms/new-console-template for more information

using System.Xml.Linq;
using Task1;
// добавление нового студента 
Student tom = new Student("Tom", "Jenkins", "PZPI-19");
Student bom = new Student("Bom", "Tenkins", "PZPI-19");
Student kom = new Student("Kom", "Penkins", "PZPI-19");
tom.Print();
bom.Print();
kom.Print();


// создание журнала оценок для студента
List<int> JenkinsMarks = new List<int>() { 75, 60, 60, 89, 90 };


// Вывод оценок
Console.Write("Оценки:");
foreach (int num in JenkinsMarks)
{
    Console.Write($"\t {num}");
}

//Добавление оценки
void AddMark(int Mark)
{
    if (Mark >= 0 && Mark <= 100)
    {
        JenkinsMarks.Add(Mark);
    }
}



//AverageMark
double AverageMark(List<int> jenkinsMarks)
{

    double sum = 0;

    if (JenkinsMarks.Count == 0)
    {
        Console.WriteLine("0");
    }

    for (int i = 0; i < JenkinsMarks.Count; i++)
    {
        sum += JenkinsMarks[i];
    }
    double AvgMark = sum / JenkinsMarks.Count;

    Console.WriteLine($"\nAverage mark is {AvgMark}");
    return AvgMark;
}
AverageMark(JenkinsMarks);

//Student is bad
BadStudent(JenkinsMarks);
void BadStudent(List<int> JenkinsMarks)
{
    double avg = AverageMark(JenkinsMarks); 
    if (avg < 60)

    {
        Console.WriteLine("Student is bad");
    }
    else
    {
        Console.WriteLine("Student is good");
    }
}
{

    }