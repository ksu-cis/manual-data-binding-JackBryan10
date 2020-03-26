/* Filename: MainWindow.xaml.cs
 * Author: Nathan Bean
 * Modified by: Jack Walter
 * Purpose: Interaction logic for MainWindow.xaml
 */

using System.Windows;
using ManualDataBinding.Data;

namespace ManualDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Note to edit within the window
        /// </summary>
        private Note note = new Note();

        /// <summary>
        /// Contstructor for the MainWindow partial class
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            Editor.Note = note;
        }

        /// <summary>
        /// Event handler for creating a new Note
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">The event args</param>
        public void OnNewNote(object sender, RoutedEventArgs e) 
        {
            note = new Note();
            Editor.Note = note;
        }

        /// <summary>
        /// Event handler for clearing the note
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">the event args</param>
        public void OnClearNote(object sender, RoutedEventArgs e) 
        {
            note.Body = "";
        }

        /// <summary>
        /// Event handler for mutulating the note
        /// </summary>
        /// <param name="sender">The button clicked</param>
        /// <param name="e">the event args</param>
        public void OnMutateNote(object sender, RoutedEventArgs e) 
        {
            note.Title = "Gandalf & Frodo";
            note.Body = "So do all who live to see such times, but that is not for them to decide.  " +
                "All you have to decide is what to do with the time given you.";
        }
    }
}
