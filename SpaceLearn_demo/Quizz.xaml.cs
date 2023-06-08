using System;
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
using System.Windows.Shapes;

namespace SpaceLearn_demo
{
    /// <summary>
    /// Interaction logic for Quizz.xaml
    /// </summary>
    public partial class Quizz : Window
    {
        public Quizz()
        {
            InitializeComponent();
            StartGame();
            NextQuestion();
        }

        List<int> questionNumbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, };

        int qNum = 0;
        int i;
        int score;

        private void checkAnswer(object sender, RoutedEventArgs e)
        {
            Button senderButton = sender as Button;

            if (senderButton.Tag.ToString() == "1")
            {
                score++;
            }

            if (qNum < 0)
            {
                qNum = 0;
            }
            else
            {
                qNum++;
            }

            questionNum.Content = "Question number: " + qNum;

            if (qNum == 10)
            {
                MessageBoxResult result = MessageBox.Show("Your score is " + score + "/10", "RESULT", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            else
            {
                NextQuestion();
            }
        }
        private void RestartGame()
        {
            score = 0;
            qNum = -1;
            i = 0;
            StartGame();

        }

        private void NextQuestion()
        {
            if (qNum < questionNumbers.Count)
            {
                i = questionNumbers[qNum];
            }
            else
            {
                RestartGame();
            }

            foreach (var x in QuizCanvas.Children.OfType<Button>())
            {
                x.Tag = "0";
            }

            switch (i)
            {
                case 1:

                    questionText.Text = "Akú teplotu má povrch slnka";

                    ans1.Content = "5526°C";
                    ans2.Content = "2154°C";
                    ans3.Content = "4856°C";
                    ans4.Content = "7300°C";

                    ans1.Tag = "1";

                    break;
            }

            switch (i)
            {
                case 2:

                    questionText.Text = "Koľko percent slnečnej sústavy zaberá slnko";

                    ans1.Content = "90%";
                    ans2.Content = "53%";
                    ans3.Content = "99%";
                    ans4.Content = "2%";

                    ans3.Tag = "1";

                    break;
            }

            switch (i)
            {
                case 3:

                    questionText.Text = "Čo je Slnečná(hviezdna) koróna";

                    ans1.Content = "Lúče hviezdy";
                    ans2.Content = "Prúdy chrliace zo slnka";
                    ans3.Content = "Vrstva atmosféry hviezdy";
                    ans4.Content = "Odraz slnečných lúčov od iných planét";

                    ans3.Tag = "1";

                    break;
            }

            switch (i)
            {
                case 4:

                    questionText.Text = "Vzdialenosť medzi slnkom a zemou je";

                    ans1.Content = "1 000 000km";
                    ans2.Content = "1AU";
                    ans3.Content = "12 455 264km";
                    ans4.Content = "1ly";

                    ans2.Tag = "1";

                    break;
            }

            switch (i)
            {
                case 5:

                    questionText.Text = "Je Merkúr najmenšia planéta slnečnej sústavy";

                    ans1.Content = "Áno";
                    ans2.Content = "Áno";
                    ans3.Content = "Nie";
                    ans4.Content = "Nie";

                    ans1.Tag = "1";
                    ans2.Tag = "1";

                    break;
            }

            switch (i)
            {
                case 6:

                    questionText.Text = "Kolko planét má slnečná sústava";

                    ans1.Content = "4";
                    ans2.Content = "8";
                    ans3.Content = "6";
                    ans4.Content = "9";

                    ans2.Tag = "1";

                    break;
            }

            switch (i)
            {
                case 7:

                    questionText.Text = "Ktoré tvrdenie o Merkúre je pravdivé";

                    ans1.Content = "Je to malá kamenná planéta s atmosférou";
                    ans2.Content = "Je to veľká vodnatá planéta s atmosférou";
                    ans3.Content = "Je to veľká kamenná planéta bez atmosféry";
                    ans4.Content = "Je to malá kamenná planéta bez afmosféry";

                    ans4.Tag = "1";

                    break;
            }

            switch (i)
            {
                case 8:

                    questionText.Text = "Čo sa nachádza na konci slnečnej sústavy ";

                    ans1.Content = "Kuiperov pás";
                    ans2.Content = "Pásmo asteroidov";
                    ans3.Content = "Nič";
                    ans4.Content = "Iná hviezda";

                    ans1.Tag = "1";

                    break;
            }

            switch (i)
            {
                case 9:

                    questionText.Text = "Ako sa nazýva dráha po ktorej sa pohybujú planéty okolo hviezdy(centra sústavy)";

                    ans1.Content = "Trať";
                    ans2.Content = "Kružnica";
                    ans3.Content = "Obežná dráha";
                    ans4.Content = "Trajektória";

                    ans3.Tag = "1";

                    break;
            }

            switch (i)
            {
                case 10:

                    questionText.Text = "Pôsobia planéty navzájom na seba gravitáciou\r\n";

                    ans1.Content = "Áno";
                    ans2.Content = "Áno";
                    ans3.Content = "Nie";
                    ans4.Content = "Nie";

                    ans1.Tag = "1";
                    ans2.Tag = "1";

                    break;
            }

        }

        private void StartGame()
        {
            var randomList = questionNumbers.OrderBy(a => Guid.NewGuid()).ToList();

            questionNumbers = randomList;
        }
    }

    }
