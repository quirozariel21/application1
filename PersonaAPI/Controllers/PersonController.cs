using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Models;
using Confluent.Kafka;

namespace Controllers{
    public class PersonController : ControllerBase{

        [Route("api/persona")]
        [HttpPost]
        public IActionResult Index([FromBody] Persona persona){
            Console.WriteLine($"publish.... {persona.ToString()}");
            var conf = new ProducerConfig { BootstrapServers = "localhost:9092"};

            Action<DeliveryReportResult<Null, string>> handler = r =>             
                Console.WriteLine(!r.Error.IsError
                ?$"Delivered message to {r.TopicPartitionOffset}"
                :$"Delivered Error: {r.Error.Reason}");

            using(var p = new Producer<Null, string>(conf))
            {                                            
                p.BeginProduce("test-topic", new Message<Null, string>{Value = persona.ToString()}, handler);
                
                // wait for up tp 10 seconds for any inflight messages to be delivered
                p.Flush(TimeSpan.FromSeconds(10));
            } 
            return Ok();
        }
    }
}