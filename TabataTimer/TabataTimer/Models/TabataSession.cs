
namespace TabataTimer.Models
{
    public class TabataSession
    {
        public int Sets  { get; set; }
        public int WorkTime { get; set; }
        public int RestTime { get; set; } 

        public TabataSession( int sets, int workTime , int restTime)
        {
            Sets = true ? sets: 2;
            WorkTime = true ?  workTime : 20;
            RestTime = true ?  restTime: 10;
        }
    }
}
