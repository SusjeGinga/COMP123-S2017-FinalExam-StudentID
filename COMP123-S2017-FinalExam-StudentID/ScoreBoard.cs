using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Name:        Hoang Giang, Le
 * ID:          300922977
 * Date:        August 17th 2017
 * Description: This is the ScoreBoard
 * Version:     1.1 - Create ScoreBoard
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    class ScoreBoard
    {
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;
        public TextBox FinalScoreTextBox
        {

            get
            {
                return this._finalScoreTextBox;
            }

            set
            {
                this._finalScoreTextBox = value;
            }
        }
        public int FinalScoreTextBox
        {

            get
            {
                return this._finalScoreTextBox;
            }

            set
            {
                this._finalScoreTextBox = value;
            }
        }
    }
}
