using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture.Farming
{
    /// <summary>
    /// A base farm animal class.
    /// </summary>
    public class FarmAnimal : ISingable
    {       
        /// <summary>
        /// The farm animal's name.
        /// </summary>
        public string Name { get; protected set; }

        /// <summary>
        /// Creates a new farm animal.
        /// </summary>
        /// <param name="name">The name which the animal goes by.</param>
        public FarmAnimal(string name)
        {
            this.Name = name;
        }

        public void reNameIt(string newName)
        {
            Name = newName; 
        }
        /// <summary>
        /// The noise made when the farm animal makes a sound.
        /// </summary>
        /// <returns></returns>
        public virtual string MakeSoundOnce()
        {
            return "need to implement";
        }

        /// <summary>
        /// The noise made when the farm animal makes its sound twice.
        /// </summary>
        /// <returns></returns>
        public virtual string MakeSoundTwice()
        {
            return "need to implement";
        }


    }
}
