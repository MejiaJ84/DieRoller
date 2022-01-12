using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DieRoller
{
    /// <summary>
    /// Represents a single six sided die (1-6)
    /// </summary>
    public class Die
    {
        private static readonly Random _random; // static random member, so Random isnt constructed every time roll is called

        static Die()
        {
            _random = new Random();
        }

        /// <summary>
        /// Creates the die and rolls it to 
        /// generate a random number
        /// </summary>
        public Die()
        {
            Roll();
        }

        /// <summary>
        /// The current face up value of the die.
        /// </summary>
        public byte FaceValue { get; private set; } // set is private so facevalue can't be change by user

        /// <summary>
        /// True if the die is currently held
        /// </summary>
        public bool IsHeld { get; set; }

        
        /// <summary>
        /// Rolls the die and sets the <see cref="FaceValue"/>
        /// to the new number if the die is not currently held.
        /// </summary>
        /// <returns>Returns the new random number i.e <see cref="FaceValue"/></returns>
        public byte Roll()
        {
            if (!IsHeld)
            {
                // Generate random number
                byte newValue = (byte)_random.Next(1, 7); // upper bound is exclusive, so it will return a 6 at max
            
                // Set to face value
                FaceValue = newValue;
            
                
            }

            return FaceValue;
        }


    }
}
