using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.Interface
{
    public interface IWriteNotes
    {
        bool writeNotes(int Id, string notes, string path);
        int FindLastId(string filePath);
        bool editNotesById(int NotesIdForEdit, string newNotes, string path);
        string readNotesById(int NotesIdForRead, string path);
        void readAllNotes(string path);
        bool deleteNotesById(int NotesIdFordelete, string path);
        bool deleteAllNotes(string path);
    }
}
