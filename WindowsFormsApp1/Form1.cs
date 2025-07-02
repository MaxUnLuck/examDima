using System;
using System.Windows.Forms;

namespace RockPaperScissors
{
    // Основной класс формы для игры "Камень, Ножницы, Бумага"
    partial class MainForm : Form
    {
        // Приватное поле для хранения экземпляра игры
        private Game game;

        // Конструктор главной формы
        public MainForm()
        {
            // Инициализация компонентов формы (автогенерируемый код)
            InitializeComponent();
            // Получение экземпляра игры через Singleton
            game = Game.GetSingleton();
            // Первоначальное обновление интерфейса
            UpdateInterface();
        }

        // Метод для обновления состояния интерфейса
        private void UpdateInterface()
        {
            // Обновление текста счета игрока и компьютера
            lblScore.Text = $"Вы: {game.UserWins} - Компьютер: {game.ComputerWins}";
            // Обновление счетчика раундов
            lblRound.Text = $"Раунд: {game.RoundsPlayed}";
            // Проверка условия завершения игры (3 победы)
            if (game.IsGameOver)
            {
                // Определение победителя матча
                string winner = game.UserWins >= 3 ? "Вы выиграли матч!" : "Компьютер выиграл матч!";
                // Установка текста результата игры
                lblResult.Text = $"{winner} Счёт: {game.UserWins}-{game.ComputerWins}";
                // Блокировка кнопок выбора после окончания игры
                btnRock.Enabled = btnScissors.Enabled = btnPaper.Enabled = false;
                // Активация кнопки "Новая игра"
                btnNewGame.Enabled = true;
            }
        }

        // Основной метод обработки выбора игрока
        private void MakeChoice(string choice)
        {
            // Получение результата раунда (выбор компьютера и результат)
            (string computerChoice, string result) roundResult = game.PlayRound(choice);
            // Отображение выбора компьютера или сообщения об ошибке
            lblComputerChoice.Text = roundResult.computerChoice != null ? $"Компьютер выбрал: {roundResult.computerChoice}" : roundResult.result;
            // Отображение результата раунда (если не сообщение об ошибке)
            lblRoundResult.Text = roundResult.computerChoice != null ? roundResult.result : "";
            // Обновление интерфейса после хода
            UpdateInterface();
        }

        // Обработчик события нажатия кнопки "Камень"
        private void btnRock_Click(object sender, EventArgs e)
        {
            // Вызов метода обработки выбора с параметром "Камень"
            MakeChoice("Камень");
        }

        // Обработчик события нажатия кнопки "Ножницы"
        private void btnScissors_Click(object sender, EventArgs e)
        {
            // Вызов метода обработки выбора с параметром "Ножницы"
            MakeChoice("Ножницы");
        }

        // Обработчик события нажатия кнопки "Бумага"
        private void btnPaper_Click(object sender, EventArgs e)
        {
            // Вызов метода обработки выбора с параметром "Бумага"
            MakeChoice("Бумага");
        }

        // Обработчик события нажатия кнопки "Новая игра"
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            // Сброс состояния игры
            game.ResetGame();
            // Сброс текста о выборе компьютера
            lblComputerChoice.Text = "Компьютер выбрал:";
            // Очистка результата раунда
            lblRoundResult.Text = "";
            // Очистка общего результата игры
            lblResult.Text = "";
            // Восстановление доступности кнопок выбора
            btnRock.Enabled = true;
            btnScissors.Enabled = true;
            btnPaper.Enabled = true;
            // Деактивация кнопки новой игры
            btnNewGame.Enabled = false;
            // Обновление интерфейса
            UpdateInterface();
        }
    }
}