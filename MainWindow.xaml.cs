﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MatchGame
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            SetUpGame();
        }

        private void SetUpGame()
        {
            List<string> animalEmoji = new List<string>()                                       // Создаёт список из восьми пар эмодзи
            {
                "🦝", "🦝",
                "🐷", "🐷",
                "🦄", "🦄",
                "👽", "👽",
                "🐸", "🐸",
                "🐪", "🐪",
                "🦕", "🦕",
                "🦔", "🦔",
            };

            Random random = new Random();                                                       // Создаёт новый генератор случайных чисел

            foreach(TextBlock textBlock in mainGrid.Children.OfType<TextBlock>())               // Находит каждый элемент TextBlock в сетке и повторяет следующие команды для каждого элемента
            {
                int index = random.Next(animalEmoji.Count);                                     // Выбирает случайное число от 0 до колличества эмодзи в списке и назначает ему имя index
                string nextEmoji = animalEmoji[index];                                          // Использет случайное число с именем index для получения случайного эмодзи из списка
                textBlock.Text = nextEmoji;                                                     // Обновляет TextBlock случайным эмодзи из списка
                animalEmoji.RemoveAt(index);                                                    // Удаляет сулчайный эмодзи из списка 
            }
        }
    }
}
