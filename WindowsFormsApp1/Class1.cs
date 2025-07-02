using System;

namespace RockPaperScissors
{
    // Основной класс игры, реализующий логику "Камень-Ножницы-Бумага"
    // Использует паттерн Singleton для обеспечения единственного экземпляра
    public class Game
    {
        // Единственный экземпляр класса, инициализируется при первом обращении
        private static Game Singleton = new Game();
        // Счетчик побед игрока
        private int _userWins;
        // Счетчик побед компьютера
        private int _computerWins;
        // Счетчик сыгранных раундов
        private int _roundsPlayed;
        // Свойство для получения количества побед игрока
        public int UserWins
        {
            get { return _userWins; }
        }
        // Свойство для получения количества побед компьютера
        public int ComputerWins
        {
            get { return _computerWins; }
        }
        // Свойство для получения количества сыгранных раундов
        public int RoundsPlayed
        {
            get { return _roundsPlayed; }
        }
        // Свойство проверки окончания игры (достижение 3 побед)
        public bool IsGameOver
        {
            get { return _userWins >= 3 || _computerWins >= 3; }
        }
        // Приватный конструктор (часть реализации Singleton)
        private Game()
        {
            ResetGame();
        }
        // Метод для получения единственного экземпляра класса
        public static Game GetSingleton()
        {
            return Singleton;
        }
        // Сброс состояния игры к начальным значениям
        public void ResetGame()
        {
            _userWins = 0;
            _computerWins = 0;
            _roundsPlayed = 0;
        }
        // Основной метод для проведения одного раунда игры
        public (string computerChoice, string result) PlayRound(string userChoice)
        {
            // Увеличение счетчика раундов
            _roundsPlayed++;
            // Получение случайного выбора компьютера
            string computerChoice = GetComputerChoice();
            // Определение победителя раунда
            string result = DetermineWinner(userChoice, computerChoice);
            return (computerChoice, result);
        }
        // Метод получения случайного выбора компьютера
        private string GetComputerChoice()
        {
            string[] choices = { "Камень", "Ножницы", "Бумага" };
            return choices[new Random().Next(choices.Length)];
        }
        // Метод определения победителя в раунде
        private string DetermineWinner(string userChoice, string computerChoice)
        {
            // Проверка на ничью
            if (userChoice == computerChoice)
                return "Ничья!";

            // Проверка условий победы игрока
            bool userWins = (userChoice == "Камень" && computerChoice == "Ножницы") ||
                          (userChoice == "Ножницы" && computerChoice == "Бумага") ||
                          (userChoice == "Бумага" && computerChoice == "Камень");
            // Обновление счетчиков побед
            if (userWins) _userWins++;
            else _computerWins++;
            // Возврат результата раунда
            return userWins ? "Вы победили!" : "Вы проиграли!";
        }
    }
}