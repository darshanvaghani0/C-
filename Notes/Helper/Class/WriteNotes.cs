using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Helper.Interface;

namespace Helper.Class
{
    public class WriteNotes : IWriteNotes
    {
        public bool writeNotes(int Id, string notes, string path)
        {

            try
            {
                using (StreamWriter sw = File.AppendText(path))
                {

                    sw.WriteLine($"{Id}: {notes}");
                    return true;
                }
            }
            catch(Exception ex)
            {
                ErrorHelp.ErrorPrint(ex.Message + " From writeNotes Method");
                throw;
                
            }
        }

        public int FindLastId(string FilePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(FilePath);

                int id = 0;

                foreach (string line in lines)
                {
                    string[] data = line.Split(':');

                    id = Convert.ToInt32(data[0]);

                }
                return id;
            }
            catch (Exception ex)
            {
                ErrorHelp.ErrorPrint(ex.Message+ " From FindLastId Method");
                throw;
                
            }
        }

        public bool editNotesById(int NotesIdForEdit, string newNotes, string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);

                int id = 0;
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (string line in lines)
                    {
                        string[] data = line.Split(':');

                        id = Convert.ToInt32(data[0]);

                        if (id == NotesIdForEdit)
                        {
                            sw.WriteLine($"{NotesIdForEdit}: {newNotes}");
                            
                        }
                        else
                        {
                            sw.WriteLine($"{id}:{data[1]}");
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                ErrorHelp.ErrorPrint(ex.Message + " From editNotesById Method");
                throw;

            }
        }

        public string readNotesById(int NotesIdForRead, string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);

                int id = 0;

                foreach (string line in lines)
                {
                    string[] data = line.Split(':');

                    id = Convert.ToInt32(data[0]);

                    if (id == NotesIdForRead)
                    {
                        return data[1];
                    }
                }

                return "NOT Found";
            }
            catch (Exception ex)
            {
                ErrorHelp.ErrorPrint(ex.Message + " From readNotesById Method");
                throw;

            }
        }
        public void readAllNotes(string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);
                MyPrinter.Print("+------------------------------------------+");
                MyPrinter.Print("|            Your All Notes                |");
                MyPrinter.Print("+------------------------------------------+");
                foreach (string line in lines)
                {
                    int length = line.Length;
                    Console.Write("|  " + line); 
                    for (int i = 0;i < 40-length; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write("|");
                    MyPrinter.Print("");
                }
                MyPrinter.Print("+------------------------------------------+");

            }
            catch (Exception ex)
            {
                ErrorHelp.ErrorPrint(ex.Message + " From readAllNotes Method");
                throw;

            }


        }
        public bool deleteNotesById(int NotesIdFordelete, string path)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);

                int id = 0;
                using (StreamWriter sw = new StreamWriter(path))
                {
                    foreach (string line in lines)
                    {
                        string[] data = line.Split(':');

                        id = Convert.ToInt32(data[0]);

                        if (id == NotesIdFordelete)
                        {
                            sw.WriteLine($"{NotesIdFordelete}: DELETED Note");
                            
                        }
                        else
                        {
                            sw.WriteLine($"{id}:{data[1]}");
                        }
                    }
                }

                return true;
            }
            catch (Exception ex)
            {
                ErrorHelp.ErrorPrint(ex.Message + " From deleteNotesById Method");
                throw;

            }
        }
        public bool deleteAllNotes(string path)
        {
            try
            {
                File.WriteAllText(path, string.Empty);
                return true;
            }
            catch (Exception ex)
            {
                ErrorHelp.ErrorPrint(ex.Message + " From deleteAllNotes Method");
                throw;

            }
        }
    }
}
