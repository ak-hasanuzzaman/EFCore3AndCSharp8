using System;

namespace Events
{

    #region Enample 1
    /* Enample 1
class TrainSignal
{
   public event Action TrainsAComing;
   public void HereComesATrain()
   {
       // OtherLogic
       if (TrainsAComing != null)
           TrainsAComing();

   }

}
class Car
{
   public Car(TrainSignal trainSignal)
   {
       trainSignal.TrainsAComing += StopTheCar;

   }

   private void StopTheCar()
   {
       Console.WriteLine("Screetch");
   }
}

class Program
{
   static void Main(string[] args)
   {
       TrainSignal trainSignal = new TrainSignal();
       new Car(trainSignal);


       //trainSignal.TrainsAComing();
       //Console.WriteLine();
       //trainSignal.TrainsAComing();
       //Console.WriteLine();
       trainSignal.TrainsAComing += TrainSignal_TrainsAComing;

       trainSignal.HereComesATrain();

       Console.ReadLine();
   }

   private static void TrainSignal_TrainsAComing()
   {
       Console.WriteLine("Signal notified");
   }
}*/

    #endregion

    #region Example 2
    /* // Example 2
         

    //using System;
    //using System.IO;

    //namespace Akadia.SimpleEvent
    //{
    //    ========= Publisher of the Event ============== 
    //    public class MyClass
    //    {
    //        // Define a delegate named LogHandler, which will encapsulate
    //        // any method that takes a string as the parameter and returns no value
    //        public delegate void LogHandler(string message);

    //        // Define an Event based on the above Delegate
    //        public event LogHandler Log;

    //        // Instead of having the Process() function take a delegate
    //        // as a parameter, we've declared a Log event. Call the Event,
    //        // using the OnXXXX Method, where XXXX is the name of the Event.
    //        public void Process()
    //        {
    //            OnLog("Process() begin");
    //            OnLog("Process() end");
    //        }

    //        // By Default, create an OnXXXX Method, to call the Event
    //        protected void OnLog(string message)
    //        {
    //            if (Log != null)
    //            {
    //                Log(message);
    //            }
    //        }
    //    }

    //    // The FileLogger class merely encapsulates the file I/O
    //    public class FileLogger
    //    {
    //        FileStream fileStream;
    //        StreamWriter streamWriter;

    //        // Constructor
    //        public FileLogger(string filename)
    //        {
    //            fileStream = new FileStream(filename, FileMode.Create);
    //            streamWriter = new StreamWriter(fileStream);
    //        }

    //        // Member Function which is used in the Delegate
    //        public void Logger(string s)
    //        {
    //            streamWriter.WriteLine(s);
    //        }

    //        public void Close()
    //        {
    //            streamWriter.Close();
    //            fileStream.Close();
    //        }
    //    }

    //     ========= Subscriber of the Event ============== 
    //    // It's now easier and cleaner to merely add instances
    //    // of the delegate to the event, instead of having to
    //    // manage things ourselves
    //    public class TestApplication
    //    {
    //        static void Logger(string s)
    //        {
    //            Console.WriteLine(s);
    //        }

    //        static void Main(string[] args)
    //        {
    //            FileLogger fl = new FileLogger("process.log");
    //            MyClass myClass = new MyClass();

    //            // Subscribe the Functions Logger and fl.Logger
    //            myClass.Log += new MyClass.LogHandler(Logger);
    //            myClass.Log += new MyClass.LogHandler(fl.Logger);

    //            // The Event will now be triggered in the Process() Method
    //            myClass.Process();

    //            fl.Close();
    //        }
    //    }
    //} */
    #endregion

    class MyClass
    {

        private static void Main(string[] args)
        {
            var video = new Video() { Title = "V1" };
            var videoEncoder = new VideoEncoder(); // Publisher
            var mailService = new MailService();
            var smsService = new SmsService();

            videoEncoder.VideoEncoded += mailService.OnVideoEncoder;
            videoEncoder.VideoEncoded += smsService.OnVideoEncoder;
            videoEncoder.Encode(video);
            Console.ReadLine();
        }

    }

    public class MailService
    {
        public void OnVideoEncoder(object sender, VideoEventArgs args)
        {
            Console.WriteLine($"{args.Video.Title} Sending an email...");
        }
    }

    public class SmsService
    {
        public void OnVideoEncoder(object sender, VideoEventArgs args)
        {
            Console.WriteLine($"{args.Video.Title} Sending a sms...");
        }
    }
}

