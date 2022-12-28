using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstCsProject
{
    internal class TestWalk
    {
        public static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            pessoa.walk();
            pessoa.tellAboutYourself("Fernando", 47);
            pessoa.findAnswerFor(10, 10);
            pessoa.workoutForOneHour();
            pessoa.doingPushUps(); 
            pessoa.drawHalfPyramid();
        }
    }
}
