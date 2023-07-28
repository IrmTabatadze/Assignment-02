using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture
{
    public class CancellableTask
    {
        public Task CreateCancellabelTask(CancellationToken cancellationToken)
        {
            return Task.Factory.StartNew(() => CancellabelWork(cancellationToken), cancellationToken);
        }
        public void CancellabelWork(CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
            {

                Console.WriteLine("Cancellation was requested before start");
                cancellationToken.ThrowIfCancellationRequested();
            }

            for (int i = 0; i < 3; i++)
            {
                Thread.Sleep(1000);
                if (cancellationToken.IsCancellationRequested)
                {
                    Console.WriteLine($"Cancellation was requested at #{i}");
                    cancellationToken.ThrowIfCancellationRequested();
                }

                Console.WriteLine($"{i} iteration was successful");
            }
        }
    }
}
