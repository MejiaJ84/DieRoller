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
        /// to the new number. 
        /// </summary>
        /// <returns>Returns the new random number</returns>
        public byte Roll()
        {
            // Generate random number
            Random random = new();
            byte newValue = (byte)random.Next(1, 7); // upper bound is exclusive, so it will return a 6 at max
            
            // Set to face value
            FaceValue = newValue;
            
            return FaceValue;
        }


    }
}
