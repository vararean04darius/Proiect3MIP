using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace ClassLibrary1
{
   
    public class TraceHandler
    {
        FileStream file;
        
        public TraceHandler()
        {
            file = new FileStream("testLog.txt", FileMode.OpenOrCreate | FileMode.Append);
            TextWriterTraceListener traceListener = new TextWriterTraceListener(file);
            Trace.Listeners.Add(traceListener);
            Trace.AutoFlush = true;
        }
       
        public void ScriereFisier (string mesaj)
        {
            Task.Run(() => ScriereFisierAsync(mesaj));
            
        }

        private async void ScriereFisierAsync(string mesaj)
        {
            await Task.Run(
                () =>
                {
                    Trace.WriteLine(DateTime.Now.ToString("MM\\/dd\\/yyyy h\\:mm:ss::fff tt") + "    " + mesaj);
                }
                );
           
        }
    }

}
