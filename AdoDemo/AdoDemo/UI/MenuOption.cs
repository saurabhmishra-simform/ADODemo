using AdoDemo.Enums;
using AdoDemo.Interfaces;
using AdoDemo.Querys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDemo.UI
{
    public class MenuOption : IMenuOption
    {
        static readonly IInsertData insertData = new InsertData();
        static readonly IUpdateData updateData = new UpdateData();
        static readonly IDeleteData deleteData = new DeleteData();
        static readonly IDisplayData displayData = new DisplayData();

        public void SelectMenu()
        {
            int choice = 0;
            do
            {
                Console.WriteLine("\n\t\t--------Select Option-----------");
                Console.WriteLine("\t\t1.Insert Record");
                Console.WriteLine("\t\t2.Update Record");
                Console.WriteLine("\t\t3.Delete Record");
                Console.WriteLine("\t\t4.Display Record");
                Console.WriteLine("\t\t0.Exit");
                UserInput:
                Console.Write("\nOption: ");
                try
                {
                    choice = Convert.ToInt32(Console.ReadLine());

                    Options option = (Options)choice;
                    switch (option)
                    {
                        case Options.insert:
                            insertData.InputEmployeeData();
                            insertData.InsertRecord();
                            break;
                        case Options.update:
                            updateData.GetUpdateData();
                            updateData.UpdateRecord();
                            break;
                        case Options.delete:
                            deleteData.GetDeleteId();
                            deleteData.DeleteRecord();
                            break;
                        case Options.display:
                            displayData.DisplayRecord();
                            break;
                        case Options.exit:
                            Environment.Exit(choice);
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input format!");
                    goto UserInput;
                }
                catch (Exception)
                {
                    Console.WriteLine("\nSome exception found");
                    goto UserInput;
                }
            } while (choice != 0);
        }
    }
}
