using System;

namespace VeraCrypt_Mounter
{
    /// <summary>
    /// Exception if drivletter is used
    /// </summary>
    public class DrivletterUsedException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public DrivletterUsedException()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public DrivletterUsedException(string message) : base (message)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        /// <param name="inner"></param>
        public DrivletterUsedException(string message, Exception inner) : base (message, inner)
        {

        }
    }
}
