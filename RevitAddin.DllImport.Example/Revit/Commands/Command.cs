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

            var math = new CPlusPlus.Math();
            Console.WriteLine(math.Add(1, 2));

            Console.WriteLine($"1 + 2 = {math.Add(1, 2)}");

            System.Windows.MessageBox.Show($"1 + 2 = {math.Add(1, 2)}");

            return Result.Succeeded;
        }
    }
}
