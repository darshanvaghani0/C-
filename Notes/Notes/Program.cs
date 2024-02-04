using Helper.Class;
using Helper.Method;


namespace Notes

{
    public class Program
    {

        public static void Main(string[] args)
        {


            MyPrinter.Print("Hello!! Welcome To Notes Editer");

            try
            {

                bool flag = true;

                while (flag)
                {

                    List<NotesData> list = new List<NotesData>();

                    MyPrinter.Print("+----------------------------+");
                    MyPrinter.Print("|   1 For ADD NOTES          |");
                    MyPrinter.Print("|   2 For EDIT NOTES         |");
                    MyPrinter.Print("|   3 For READ NOTES         |");
                    MyPrinter.Print("|   4 For READ ALL NOTES     |");
                    MyPrinter.Print("|   5 For DELETE NOTES       |");
                    MyPrinter.Print("|   6 For DELETE ALL NOTES   |");
                    MyPrinter.Print("|   7 For EXIT               |");
                    MyPrinter.Print("+----------------------------+");

                    MyPrinter.Print("Enter your Choise(1-7):");
                    int Choise = Convert.ToInt32(Console.ReadLine());
                    WriteNotes writeNotes = new WriteNotes();
                    string path = "D:\\Downloads\\Week 1\\Week 1\\Practice\\Notes\\Notes File\\Notes.txt";
                    if (!File.Exists(path))
                    {
                        File.Create(path).Close();
                    }
                    switch (Choise)
                    {

                        case 1:

                            MyPrinter.Print("Enter Your Note:");
                            string notes = Console.ReadLine();
                            int Id = writeNotes.FindLastId(path);

                            bool writed = writeNotes.writeNotes(Id + 1, notes, path);
                            if (writed)
                            {
                                MyPrinter.Print("+-----------------------------------------+");
                                MyPrinter.Print("|    Write Successfully                   |");
                                MyPrinter.Print("+-----------------------------------------+");
                            }
                            else
                            {
                                MyPrinter.Print("+-----------------------------------------+");
                                MyPrinter.Print("|    Error                                |");
                                MyPrinter.Print("+-----------------------------------------+");


                            }
                            break;
                        case 2:
                            int Id1 = writeNotes.FindLastId(path);
                            if (Id1.Equals(0))
                            {
                                MyPrinter.Print("+------------------------------------------+");
                                MyPrinter.Print("|     Your Notes List is Empty             |");
                                MyPrinter.Print("+------------------------------------------+");
                            }
                            else
                            {
                                MyPrinter.Print("Enter Your Notes number for Edit from:");
                                writeNotes.readAllNotes(path);
                                int NotesIdForEdit = Convert.ToInt32(Console.ReadLine());
                                MyPrinter.Print("Enter Your Edited Note:");
                                string newNotes = Console.ReadLine();

                                bool Edited = writeNotes.editNotesById(NotesIdForEdit, newNotes, path);
                                if (Edited)
                                {
                                    MyPrinter.Print("+-----------------------------------------+");
                                    MyPrinter.Print("|    Edit Successfully                    |");
                                    MyPrinter.Print("+-----------------------------------------+");

                                }
                                else
                                {
                                    MyPrinter.Print("+-----------------------------------------+");
                                    MyPrinter.Print("|    Error                                |");
                                    MyPrinter.Print("+-----------------------------------------+");

                                }
                            }

                            break;
                        case 3:
                            int LId = writeNotes.FindLastId(path);
                            if (LId.Equals(0))
                            {
                                MyPrinter.Print("+------------------------------------------+");
                                MyPrinter.Print("|     Your Notes List is Empty             |");
                                MyPrinter.Print("+------------------------------------------+");
                            }
                            else
                            {
                                MyPrinter.Print($"Enter Your Notes number from 1 to {LId} for Read:");
                                int NotesIdForRead = Convert.ToInt32(Console.ReadLine());
                                string resultNote = writeNotes.readNotesById(NotesIdForRead, path);


                                MyPrinter.Print("+------------------------------------------+");
                                MyPrinter.Print("|            Your Note                     |");
                                MyPrinter.Print("+------------------------------------------+");

                                int length = resultNote.Length;
                                Console.Write($"| {NotesIdForRead}:" + resultNote);
                                for (int i = 0; i < 39 - length; i++)
                                {
                                    Console.Write(" ");
                                }
                                Console.Write("|");
                                MyPrinter.Print("");

                                MyPrinter.Print("+------------------------------------------+");
                            }

                            break;
                        case 4:
                            int LId1 = writeNotes.FindLastId(path);
                            if (LId1.Equals(0))
                            {
                                MyPrinter.Print("+------------------------------------------+");
                                MyPrinter.Print("|     Your Notes List is Empty             |");
                                MyPrinter.Print("+------------------------------------------+");
                            }
                            else
                            {
                                writeNotes.readAllNotes(path);
                            }
                            

                            break;
                        case 5:
                            int LId2 = writeNotes.FindLastId(path);
                            if (LId2.Equals(0))
                            {
                                MyPrinter.Print("+------------------------------------------+");
                                MyPrinter.Print("|     Your Notes List is Empty             |");
                                MyPrinter.Print("+------------------------------------------+");
                            }
                            else
                            {
                                MyPrinter.Print("Enter Your Notes number for Delete from:");
                                writeNotes.readAllNotes(path);
                                int NotesIdFordelete = Convert.ToInt32(Console.ReadLine());


                                bool Deleted = writeNotes.deleteNotesById(NotesIdFordelete, path);
                                if (Deleted)
                                {
                                    MyPrinter.Print("+-----------------------------------------+");
                                    MyPrinter.Print("|    Delete Successfully                  |");
                                    MyPrinter.Print("+-----------------------------------------+");

                                }
                                else
                                {
                                    MyPrinter.Print("+-----------------------------------------+");
                                    MyPrinter.Print("|    Error                                |");
                                    MyPrinter.Print("+-----------------------------------------+");


                                }
                            }
                            
                            break;
                        case 6:
                            int LId3 = writeNotes.FindLastId(path);
                            if (LId3.Equals(0))
                            {
                                MyPrinter.Print("+------------------------------------------+");
                                MyPrinter.Print("|     Your Notes List is Empty             |");
                                MyPrinter.Print("+------------------------------------------+");
                            }
                            else
                            {
                                bool DeleteAll = writeNotes.deleteAllNotes(path);
                                if (DeleteAll)
                                {
                                    MyPrinter.Print("+-----------------------------------------+");
                                    MyPrinter.Print("|    Delete Successfully                  |");
                                    MyPrinter.Print("+-----------------------------------------+");

                                }
                                else
                                {
                                    MyPrinter.Print("+-----------------------------------------+");
                                    MyPrinter.Print("|    Error                                |");
                                    MyPrinter.Print("+-----------------------------------------+");


                                }
                            }
                            
                            break;
                        case 7:
                            MyPrinter.Print("+-----------------------------------------+");
                            MyPrinter.Print("|    Visit Again!!                        |");
                            MyPrinter.Print("+-----------------------------------------+");
                            flag = false;
                            break;

                        default:
                            MyPrinter.Print("+----------------------------+");
                            MyPrinter.Print("|    Enter valid choise(1-7) |");
                            MyPrinter.Print("+----------------------------+");
                            break;
                    }

                }

            }

            catch (Exception ex)
            {

                ErrorHelp.ErrorPrint(ex.Message + "From Main Method");
            }
        }

    }
}
