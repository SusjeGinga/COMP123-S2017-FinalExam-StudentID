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
 * Version:     1.2 - Finish ScoreBoard
 */

namespace COMP123_S2017_FinalExam_StudentID
{
    class ScoreBoard
    {
        // PRIVATE INSTANCE VARIABLES ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        private TextBox _finalScoreTextBox;
        private int _score;
        private TextBox _scoreTextBox;
        private int _time;
        private TextBox _timeTextBox;
        // PUBLIC PROPERTIES +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
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
        public int Score
        {

            get
            {
                return this._score;
            }

            set
            {
                this._score = Convert.ToInt32(ScoreTextBox.Text) + Convert.ToInt32(FinalScoreTextBox.Text);
            }
        }
        public TextBox ScoreTextBox
        {

            get
            {
                return this._scoreTextBox;
            }

            set
            {
                this._scoreTextBox = value;
            }
        }
        public int Time
        {

            get
            {
                return this._time;
            }

            set
            {
                this._time = Convert.ToInt32(TimeTextBox.Text);
            }
        }
        public TextBox TimeTextBox
        {

            get
            {
                return this._timeTextBox;
            }

            set
            {
                this._timeTextBox = value;
            }
        }
        /// <summary>
        /// This is the constructor
        /// </summary>
        /// <param name="scoreTextBox"></param>
        /// <param name="timeTextBox"></param>
        /// <param name="finalScoreTextBox"></param>
        // CONSTRUCTORS ++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public ScoreBoard(TextBox scoreTextBox, TextBox timeTextBox, TextBox finalScoreTextBox)
        {
            this.ScoreTextBox = scoreTextBox;
            this.TimeTextBox = timeTextBox;
            this.FinalScoreTextBox = finalScoreTextBox;
        }
        /// <summary>
        /// This is the Update Time method
        /// </summary>
        // PUBLIC METHODS +++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++
        public void UpdateTime()
        {
            Time = Convert.ToInt32(TimeTextBox.Text) - 1;
            TimeTextBox.Text = Convert.ToString(Time);
        }
    }
}
