using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticeBoard.Models
{
    public class MockNoteRepository : INoteRepository
    {
        public List<Note> _notes;

        public MockNoteRepository()
        {
            if (_notes == null)
            {
                InitializeNotes();
            }
        }
        public void AddNote(Note note)
        {

        }

        public void InitializeNotes()
        {
            DateTime _date = DateTime.Now;
            _notes = new List<Note>
            {
                new Note { Id = 1, Title = "Instructions", Content = "Feel free to make a note for all the world to see!", Date = _date },
                new Note { Id = 2, Title = "Instructions", Content = "Feel free to make a note for all the world to see!", Date = _date },
                new Note { Id = 3, Title = "Instructions", Content = "Feel free to make a note for all the world to see!", Date = _date },
                new Note { Id = 4, Title = "Instructions", Content = "Feel free to make a note for all the world to see!", Date = _date }
            };
        }

        public IEnumerable<Note> GetAllNotes()
        {
            return _notes;
        }

        public Note GetNoteById(int noteId)
        {
            return _notes.FirstOrDefault(n => n.Id == noteId);
        }



    }
}
