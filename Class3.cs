using System;
namespace lesson_7
{
	class Cars
	{
		


		private int speedNow;

		public int SpeedNow//מתודה שמצויאה את המהירות או מגדירה 
		{
			get { return speedNow; }
			set { speedNow = value; }
		}


		private int speedUp;

		public int SpeedUp//מתודה שמעלה את המהירות ב1 קמ''ש
		{
			get { return speedNow + 1; }
			set { speedUp = value; }

		}
		public int SpeedDown
		{
			get { return speedNow - 1; }//מתודה שמורידה את המהירות ב1 קמ''ש
		}
		public void StopCar()// פונקציה האחראית על עצירת רכב
		{
			this.speedNow = 0;
		
		}

		

	}
}
	