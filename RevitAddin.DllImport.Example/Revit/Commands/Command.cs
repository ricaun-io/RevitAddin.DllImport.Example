using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Runtime.InteropServices;

namespace RevitAddin.DllImport.Example.Revit.Commands
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elementSet)
        {
            UIApplication uiapp = commandData.Application;

            var math = MathCreate();

            Console.WriteLine($"1 + 2 = {MathAdd(math, 1, 2)}");

            System.Windows.MessageBox.Show($"1 + 2 = {MathAdd(math, 1, 2)}");

            return Result.Succeeded;
        }

        [DllImport("CPlusPlus.dll")]
        static extern IntPtr MathCreate();

        [DllImport("CPlusPlus.dll")]
        static extern int MathAdd(IntPtr math, int a, int b);

    }
}
