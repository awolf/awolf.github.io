using Microsoft.Azure;
using Microsoft.ServiceBus;
using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ActionCenter_MessageBus_Spike
{
    class Program
    {
        static void Main(string[] args)
        {

            string connectionString = CloudConfigurationManager.GetSetting("Microsoft.ServiceBus.ConnectionString");

            var namespaceManager = NamespaceManager.CreateFromConnectionString(connectionString);

            if (!namespaceManager.TopicExists("courses-receiving"))
            {
                Console.WriteLine("courses-receiving exists");
            }

            if (!namespaceManager.SubscriptionExists("courses-receiving", "stem-sub"))
            {
                SubscriptionDescription srcSubscription = new SubscriptionDescription("courses-receiving", "stem-sub");
                srcSubscription.ForwardTo = "stem-program";
                SqlFilter ProgramFilter1 = new SqlFilter("Program = 'STEM'");
                namespaceManager.CreateSubscription(srcSubscription, ProgramFilter1);
            }
            else {
                Console.WriteLine("finger-print subscription1 exists");
            }

            if (!namespaceManager.SubscriptionExists("courses-receiving", "edu-sub"))
            {
                SubscriptionDescription srcSubscription = new SubscriptionDescription("courses-receiving", "edu-sub");
                srcSubscription.ForwardTo = "edu-program";
                SqlFilter ProgramFilter2 = new SqlFilter("Program = 'EDU'");
                namespaceManager.CreateSubscription(srcSubscription, ProgramFilter2);
            }
            else
            {
                Console.WriteLine("finger-print subscription2 exists");
            }

            Console.WriteLine("Sending Course Message");

            TopicClient Client = TopicClient.CreateFromConnectionString(connectionString, "courses-receiving");

            BrokeredMessage bm1 = new BrokeredMessage();
            bm1.Properties["StudentName"] = "Adam";
            bm1.Properties["Program"] = "STEM";
            Client.Send(bm1);

            BrokeredMessage bm2 = new BrokeredMessage();
            bm2.Properties["StudentName"] = "Charlie";
            bm2.Properties["Program"] = "STEM";
            Client.Send(bm2);
        }
    }
}
