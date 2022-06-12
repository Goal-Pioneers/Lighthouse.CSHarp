/**
  * 
  */
using System;


namespace Lighthouse
{
    class Program
    {
        /**
         * 
         */
        static void Main( string[] arguments )
        {
            Singleton.initialise();
            Singleton.execute();
            Singleton.garbageCollection();
        }

        // Variables
        private static Program singleton = null;


        /**
         * 
         */
        public void initialise()
        {
            Console.WriteLine( "initialise" );
        }


        /**
         * 
         */
        public void execute()
        {
            Console.WriteLine( "execution" );
        }


        /**
         * 
         */
        public void garbageCollection()
        {
            Console.WriteLine( "cleaning system" );
        }


        // Accessors
        /**
         * 
         */
        public static Program Singleton
        {
            get
            {
                if ( singleton == null )
                {
                    Singleton = new Program();
                }

                return singleton;
            }
            set
            {
                singleton = value;
            }
        }
    }
}

