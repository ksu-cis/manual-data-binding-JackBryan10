/* Filename: Note.cs
 * Author: Nathan Bean
 * Modified by: Jack Walter
 * Purpose: A class representing a note
 */
using System;

namespace ManualDataBinding.Data
{
    /// <summary>
    /// A class representing a note
    /// </summary>
    public class Note
    {
        /// <summary>
        /// Event Handler for the note
        /// </summary>
        public event EventHandler NoteChangedEvent;

        /// <summary>
        /// Private backing variable for the title
        /// </summary>
        private string title = DateTime.Now.ToString();

        /// <summary>
        /// The title of the Note
        /// </summary>
        public string Title 
        {
            get { return title; }
            set 
            {
                if(title == value) { return; }
                title = value;
                NoteChangedEvent?.Invoke(this, new EventArgs());
            }
        }

        /// <summary>
        /// Private backing variable for the body
        /// </summary>
        private string body = "";

        /// <summary>
        /// The text of the note
        /// </summary>
        public string Body
        {
            get { return body; }
            set
            {
                if (body == value) { return; }
                body = value;
                NoteChangedEvent?.Invoke(this, new EventArgs());
            }
        }
    }
}
