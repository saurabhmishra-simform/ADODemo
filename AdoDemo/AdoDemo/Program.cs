using AdoDemo.Enums;
using AdoDemo.Interfaces;
using AdoDemo.Querys;
using AdoDemo.UI;
using System.Data.SqlClient;

namespace AdoDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMenuOption menuOption = new MenuOption();
            menuOption.SelectMenu();
        }
    }
}