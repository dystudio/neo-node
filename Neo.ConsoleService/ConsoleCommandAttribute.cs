using System;
using System.Diagnostics;
using System.Linq;

namespace Neo.ConsoleService
{
    [DebuggerDisplay("Verbs={string.Join(' ',Verbs)}")]
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public class ConsoleCommandAttribute : Attribute
    {
        /// <summary>
        /// Verbs
        /// </summary>
        public string[] Verbs { get; }

        /// <summary>
        /// Category
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// Description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="verbs">Verbs</param>
        public ConsoleCommandAttribute(string verbs)
        {
            Verbs = verbs.Split(' ', StringSplitOptions.RemoveEmptyEntries).Select(u => u.ToLowerInvariant()).ToArray();
        }
    }
}
