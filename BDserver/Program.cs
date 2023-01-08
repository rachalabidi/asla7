
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Tcp;

namespace BDserver
{
    class Program
    {
        static void Main(string[] args)
        {
                TcpChannel ch = new TcpChannel(8085);
                ChannelServices.RegisterChannel(ch);


                RemotingConfiguration.RegisterWellKnownServiceType(typeof(Connection.connection), "obj",
                                                               WellKnownObjectMode.Singleton);
            
                //SingleCall
                Console.Write("Le serveur est prêt.....");
                Console.Read();
            }
    }
}
