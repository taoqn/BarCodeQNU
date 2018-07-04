using BarcodeQNU.Layout;
using BarcodeQNU.Model;
using System;
using System.Drawing;
using System.Drawing.Printing;
using System.Printing;

namespace BarcodeQNU.Tools
{
    public class CodePrinter
    {
        private const float _X = 2,_Y = 0;
        private const int _Width = 405, _Height = 60;

        private PrinterSet printerSet;
        private PrintDocument PrintDoc;

        public event PrintEventHandler CodePrinter_EndPrint;

        public CodePrinter(PrinterSet set)
        {
            PrintDoc = new PrintDocument();
            printerSet = set;

            InitializeComponent();
        }

        void InitializeComponent()
        {
            PrintDoc.PrinterSettings = printerSet.PrinterSettings;
            PrintDoc.PrinterSettings.Copies = printerSet.BarCode.Count;
            PrintDoc.DefaultPageSettings.Landscape = printerSet.Landscape.Value;
            PrintDoc.DefaultPageSettings.PaperSize = new PaperSize("QNU", _Width, _Height);
            //
            PrintDoc.PrintPage += PrintDoc_PrintPage;
            PrintDoc.EndPrint += PrintDoc_EndPrint;
        }

        public void Print() => PrintDoc.Print();

        private void PrintDoc_PrintPage(object sender, PrintPageEventArgs e)
        {
            try
            {
                Image img = printerSet.BarCode.LayoutPaper.GetImage();

                if (printerSet.BarCode.LayoutPaper.GetObjectType().Name.Equals(typeof(LayoutCode39).Name) || printerSet.BarCode.LayoutPaper.GetObjectType().Name.Equals(typeof(LayoutCode39Extended).Name))
                {
                    float _X_39 = 5;
                    int _Width_39 = 400;
                    SizeF sizeF = new SizeF(92, 60);
                    e.Graphics.DrawImage(printerSet.BarCode.LayoutPaper.GetImage(), new RectangleF(SetHorizontalAlignment(0, (_Width_39 / 4) + _X_39, img), sizeF));
                    e.Graphics.DrawImage(printerSet.BarCode.LayoutPaper.GetImage(), new RectangleF(SetHorizontalAlignment((_Width_39 / 4) + _X_39, ((_Width_39 * 2) / 4) + _X_39, img), sizeF));
                    e.Graphics.DrawImage(printerSet.BarCode.LayoutPaper.GetImage(), new RectangleF(SetHorizontalAlignment(((_Width_39 * 2) / 4) + _X_39, ((_Width_39 * 3) / 4) + _X_39, img), sizeF));
                    e.Graphics.DrawImage(printerSet.BarCode.LayoutPaper.GetImage(), new RectangleF(SetHorizontalAlignment(((_Width_39 * 3) / 4) + _X_39, _Width_39 + _X_39 - 10, img), sizeF));
                }
                else
                {
                    e.Graphics.DrawImage(printerSet.BarCode.LayoutPaper.GetImage(), SetHorizontalAlignment(0, (_Width / 4) + _X, img));
                    e.Graphics.DrawImage(printerSet.BarCode.LayoutPaper.GetImage(), SetHorizontalAlignment((_Width / 4) + _X, ((_Width * 2) / 4) + _X, img));
                    e.Graphics.DrawImage(printerSet.BarCode.LayoutPaper.GetImage(), SetHorizontalAlignment(((_Width * 2) / 4) + _X, ((_Width * 3) / 4) + _X, img));
                    e.Graphics.DrawImage(printerSet.BarCode.LayoutPaper.GetImage(), SetHorizontalAlignment(((_Width * 3) / 4) + _X, _Width + _X - 11, img));
                }
            }
            catch { }
        }

        PointF SetHorizontalAlignment(float from_X_width, float to_X_width, Image img)
        {
            PointF point = new PointF();
            //switch (printerSet.Horizontal.Value)
            //{
            //    case HorizontalAlignment.Left:
            //        point.X = from_X_width;
            //        break;
            //    case HorizontalAlignment.Stretch:
            point.X = (to_X_width + from_X_width - img.Width) / 2;
            //        break;
            //    case HorizontalAlignment.Right:
            //        point.X = to_X_width - img.Width;
            //        break;
            //}
            point.Y = _Y;
            return point;
        }

        internal static void SpotTroubleUsingJobAttributes(PrintSystemJobInfo theJob)
        {
            if ((theJob.JobStatus & PrintJobStatus.Blocked) == PrintJobStatus.Blocked)
            {
                Console.WriteLine("The job is blocked.");
            }
            if (((theJob.JobStatus & PrintJobStatus.Completed) == PrintJobStatus.Completed)
                ||
                ((theJob.JobStatus & PrintJobStatus.Printed) == PrintJobStatus.Printed))
            {
                Console.WriteLine("The job has finished. Have user recheck all output bins and be sure the correct printer is being checked.");
            }
            if (((theJob.JobStatus & PrintJobStatus.Deleted) == PrintJobStatus.Deleted)
                ||
                ((theJob.JobStatus & PrintJobStatus.Deleting) == PrintJobStatus.Deleting))
            {
                Console.WriteLine("The user or someone with administration rights to the queue has deleted the job. It must be resubmitted.");
            }
            if ((theJob.JobStatus & PrintJobStatus.Error) == PrintJobStatus.Error)
            {
                Console.WriteLine("The job has errored.");
            }
            if ((theJob.JobStatus & PrintJobStatus.Offline) == PrintJobStatus.Offline)
            {
                Console.WriteLine("The printer is offline. Have user put it online with printer front panel.");
            }
            if ((theJob.JobStatus & PrintJobStatus.PaperOut) == PrintJobStatus.PaperOut)
            {
                Console.WriteLine("The printer is out of paper of the size required by the job. Have user add paper.");
            }

            if (((theJob.JobStatus & PrintJobStatus.Paused) == PrintJobStatus.Paused)
                ||
                ((theJob.HostingPrintQueue.QueueStatus & PrintQueueStatus.Paused) == PrintQueueStatus.Paused))
            {
                HandlePausedJob(theJob);
            }

            if ((theJob.JobStatus & PrintJobStatus.Printing) == PrintJobStatus.Printing)
            {
                Console.WriteLine("The job is printing now.");
            }
            if ((theJob.JobStatus & PrintJobStatus.Spooling) == PrintJobStatus.Spooling)
            {
                Console.WriteLine("The job is spooling now.");
            }
            if ((theJob.JobStatus & PrintJobStatus.UserIntervention) == PrintJobStatus.UserIntervention)
            {
                Console.WriteLine("The printer needs human intervention.");
            }
        }

        internal static void HandlePausedJob(PrintSystemJobInfo theJob)
        {
            Console.WriteLine("The user or someone with administrative rights to the queue" +
                 "\nhas paused the job or queue." +
                 "\nResume the queue? (Has no effect if queue is not paused.)" +
                 "\nEnter \"Y\" to resume, otherwise press return: ");
            String resume = Console.ReadLine();
            if (resume == "Y")
            {
                theJob.HostingPrintQueue.Resume();
                Console.WriteLine("Does user want to resume print job or cancel it?" + "\nEnter \"Y\" to resume (any other key cancels the print job): ");
                String userDecision = Console.ReadLine();
                if (userDecision == "Y")
                {
                    theJob.Resume();
                }
                else
                {
                    theJob.Cancel();
                }
            }
        }

        private void PrintDoc_EndPrint(object sender, PrintEventArgs e)
        {
            CodePrinter_EndPrint?.Invoke(sender, e);
            PrintDoc.Dispose();
        }

    }
}