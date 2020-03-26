/* Filename: NoteEditor.xaml.cs
 * Author: Nathan Bean
 * Modified by: Jack Walter
 * Purpose: Interaction logic for NoteEditor.xaml
 */

using System;
using System.Windows.Controls;
using ManualDataBinding.Data;

namespace ManualDataBinding.UI
{
    /// <summary>
    /// Interaction logic for NoteEditor.xaml
    /// </summary>
    public partial class NoteEditor : UserControl
    {
        /// <summary>
        /// Private backing variable for the note
        /// </summary>
        private Note note;

        /// <summary>
        /// This is the note that will be edited by this control
        /// </summary>
        public Note Note
        {
            get { return note; }
            set
            {
                if (note != null) note.NoteChangedEvent -= OnNoteChanged;
                note = value;
                if (note != null)
                {
                    note.NoteChangedEvent += OnNoteChanged;
                    OnNoteChanged(note, new EventArgs());
                }
            }
        }

        /// <summary>
        /// Constructor for the NoteEditor Class
        /// </summary>
        public NoteEditor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Event listener for when the note is modified
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnNoteChanged(object sender, EventArgs e)
        {
            if (Note == null) { return; }

            Title.Text = Note.Title;
            Body.Text = Note.Body;
        }

        /// <summary>
        /// Event Listener for when the Title text has changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnTitleChanged(object sender, TextChangedEventArgs e) 
        {
            Note.Title = Title.Text;
        }

        /// <summary>
        /// Event Listener for when the Body text has changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnBodyChanged(object sender, TextChangedEventArgs e)
        {
            Note.Body = Body.Text;
        }
    }
}
