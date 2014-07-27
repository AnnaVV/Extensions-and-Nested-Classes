using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Book
{
    class Book
    {
        private List<Notes> _notes = new List<Notes>();

        public void AddNote(string noteText)
        {
            this._notes.Add(new Notes(noteText));
        }

        class Notes
        {
            private string _noteText;

            public Notes(string text)
            {
                this._noteText = text;
            }
        }
    }
}
