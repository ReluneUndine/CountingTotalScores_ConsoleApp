using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingTotalScores_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args) // Точка входа, начало кода
        {
            double programmingGrades = 4.25; // Для числового типа с плавающей точкой использую double; пусть = (5+4+3+5)/4 = 4,25 
            Console.WriteLine("Баллы по программированию: " + programmingGrades);

            double mathGrades = 3.75; // Делаю другие баллы по аналогии с Баллами по программированию; пусть = (5+3+3+4)/4 = 3,75
            Console.WriteLine("Баллы по математике: " + mathGrades);

            double physicsGrades = 3.5; // пусть = (2+3+4+5)/4 = 3,5
            Console.WriteLine("Баллы по физике: " + physicsGrades);
            Console.ReadKey(); // Нажмите Enter, чтобы увидеть Общий балл по трем предметам

            double totalScore = programmingGrades + mathGrades + physicsGrades; 

            Console.WriteLine("Общий балл по трем предметам: " + totalScore); // Сумма всех баллов = 11,5
            Console.ReadKey(); // Нажмите Enter, чтобы увидеть Средний балл и Упрощенный средний балл

            uint numberOfScores = 3; // Средний балл = общая сумма баллов / количество предметов
            double averageScore = totalScore / numberOfScores; 
            Console.WriteLine("Средний балл: " + averageScore); // Частное от 11,5 / 3 = 3,83333333333

            string averageScoreFormated = averageScore.ToString("#.###"); // Сделаем так, чтобы показывало максимум 3 цифры после запятой
            Console.WriteLine("Упрощенный средний балл: " + averageScoreFormated);
            Console.ReadKey();
        }
    }
}
