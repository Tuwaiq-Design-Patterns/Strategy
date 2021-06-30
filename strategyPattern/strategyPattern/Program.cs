using System;

namespace strategyPattern
{


    public interface ISocialMediaStrategy
    {
        public void connectTo(String friendName);
    }


    public class SocialMediaContext
    {
        ISocialMediaStrategy smStrategy;

        public void setSocialmediaStrategy(ISocialMediaStrategy smStrategy)
        {
            this.smStrategy = smStrategy;
        }

        public void connect(String name)
        {
            smStrategy.connectTo(name);
        }
    }




    public class FacebookStrategy : ISocialMediaStrategy
    {


    public void connectTo(String friendName)
    {
        Console.WriteLine("Connecting with " + friendName + " through Facebook");
    }
   }


    public class GooglePlusStrategy : ISocialMediaStrategy
    {


    public void connectTo(String friendName)
    {
            Console.WriteLine("Connecting with " + friendName + " through GooglePlus");
    }
}


    public class TwitterStrategy : ISocialMediaStrategy
    {


    public void connectTo(String friendName)
    {
            Console.WriteLine("Connecting with " + friendName + " through Twitter");
    }
}


    public class OrkutStrategy : ISocialMediaStrategy
    {


    public void connectTo(String friendName)
    {
            Console.WriteLine("Connecting with " + friendName + " through Orkut [not possible though :)]");
    }
}



class Program
    {
        static void Main(string[] args)
        {
            // Creating social Media Connect Object for connecting with friend by
            // any social media strategy.
            SocialMediaContext context = new SocialMediaContext();

            // Setting Facebook strategy.
            context.setSocialmediaStrategy(new FacebookStrategy());
            context.connect("Lokesh");

            Console.WriteLine("====================");

            // Setting Twitter strategy.
            context.setSocialmediaStrategy(new TwitterStrategy());
            context.connect("Lokesh");

            Console.WriteLine("====================");

            // Setting GooglePlus strategy.
            context.setSocialmediaStrategy(new GooglePlusStrategy());
            context.connect("Lokesh");

            Console.WriteLine("====================");

            // Setting Orkut strategy.
            context.setSocialmediaStrategy(new OrkutStrategy());
            context.connect("Lokesh");
        }
    }
}
