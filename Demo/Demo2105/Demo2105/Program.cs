int workerThread;
int portThread;

ThreadPool.GetMaxThreads(out workerThread, out portThread);
Console.WriteLine("\nMaximum worker threads: \t{0}" + "\nMaximum completion port threads: {1}", workerThread, portThread);
Console.ReadKey();