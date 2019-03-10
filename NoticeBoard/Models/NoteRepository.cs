using NoticeBoard.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoticeBoard.Models
{
    public class NoteRepository : INoteRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public NoteRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public IEnumerable<Note> GetAllNotes()
        {
            return _applicationDbContext.Notes;
        }

        public Note GetNoteById(int NoteId)
        {
            return _applicationDbContext.Notes.FirstOrDefault(n => n.Id == NoteId);
        }

        public void AddNote(Note note)
        {
            note.Date = DateTime.Now;
            _applicationDbContext.Notes.Add(note);
            _applicationDbContext.SaveChanges();
        }
    }
}
