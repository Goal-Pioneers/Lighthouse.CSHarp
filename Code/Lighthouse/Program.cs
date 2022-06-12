/**
  * 
  */
using System;


namespace Lighthouse
{
    class Program
    {
        /**
         * Entry function. Function which starts the entire process
         */
        static void Main( string[] arguments )
        {
            Singleton.Initialise();
            Singleton.Parameters( arguments );
            Singleton.Execute();
            Singleton.GarbageCollection();
        }


        // Variables
        private static Program singleton = null;


        /*
         * 
         */ 
        public void Parameters( string[] arguments )
        {

        }


        /**
         * 
         */
        public void Initialise()
        {
            Console.WriteLine( "initialise" );
        }


        /**
         * 
         */
        public void Execute()
        {
            Console.WriteLine( "execution" );
        }


        /**
         * 
         */
        public void GarbageCollection()
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

