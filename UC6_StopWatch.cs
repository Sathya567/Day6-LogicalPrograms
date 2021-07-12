using System;
using System.Collections.Generic;
using System.Text;

namespace Day6Assignment
{
    class UC6_StopWatch
    {
		long StartTimer;
		long StopTimer;
		public void stopwatches()
		{

			Console.WriteLine("Press '1' to start time: ");
			StartTimer = long.Parse(Console.ReadLine());
			Console.WriteLine("Start Time is: " + StartTimer);
			StartTimer = StartTimer * 60 * 60 * 1000;

			Console.WriteLine("press '2' to stop time: ");
			StopTimer = long.Parse(Console.ReadLine());
			Console.WriteLine("Stop Time is: " + StopTimer);
			StopTimer = StopTimer * 60 * 60 * 1000;
			long elapsed = StopTimer - StartTimer;
			Console.WriteLine("total elapsed time(in millisecond) is :" + elapsed);
		}
	}
}
    
