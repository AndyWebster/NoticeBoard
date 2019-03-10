using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticeBoard.Models
{
    public interface INoteRepository
    {
        IEnumerable<Note> GetAllNotes();

        Note GetNoteById(int NoteId);

        void AddNote(Note note);
    }
}
