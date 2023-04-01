namespace factorymethod
{
    public class FileName
    {
        public FileName()
        {
            var home1 = new Home_1();
            var home2 = new Home_2();
        }
    }

    public class DoorFactory
    {
        public static string Create_door()
        {
            return "Door Created";
        }
    }

    public class Home_1
    {
        public Home_1()
        {
            var result = DoorFactory.Create_door();
           
        }
    }

    public class Home_2
    {
        public Home_2()
        {
            var result = DoorFactory.Create_door();
           
        }
    }
}
