using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MathGame.Models
{
    internal class AdditionScore : ScoreBase
    {
        
        internal AdditionScore(int number1, int number2, int answer, int userAnswer, bool correct): base(number1, number2, answer, userAnswer, correct)
        {
        
        }
    }
}