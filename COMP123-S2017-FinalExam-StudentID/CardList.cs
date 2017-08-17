using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name:        Hoang Giang, Le
 * ID:          300922977
 * Date:        August 17th 2017
 * Description: This is the abstract superclass CardList
 * Version:     1.0 - Added comments
 */


namespace COMP123_S2017_FinalExam_StudentID
{
    public abstract class CardList : List<Card>
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor.
        /// </summary>
        public CardList()
        {
            this._initialize();
        }

        // PRIVATE METHODS
        protected abstract void _initialize();

        // PUBLIC METHODS
    }
}