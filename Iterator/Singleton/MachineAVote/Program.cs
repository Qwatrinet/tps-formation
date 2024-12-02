using MachineAVoter;

namespace MachineAVote
{
    internal class Program
    {

        public static void TestMonoThread()
        {
            MachineMonoThread vm1 = MachineMonoThread.Instance;
            MachineMonoThread vm2 = MachineMonoThread.Instance;
            MachineMonoThread vm3 = MachineMonoThread.Instance;

            Console.WriteLine(vm1.RegisterVote());
            Console.WriteLine(vm2.RegisterVote());
            Console.WriteLine(vm3.RegisterVote());

            Console.WriteLine("\nTotal Number: " + vm1.TotalVotes);
        }

        public static void TestMultiThreadWithMono()
        {
            IEnumerable<int> numbers = Enumerable.Range(0, 10);

            Parallel.ForEach(numbers, i =>
            {
                MachineMonoThread vm = MachineMonoThread.Instance;
                Console.WriteLine(vm.RegisterVote());
            });

            Console.WriteLine(MachineMonoThread.Instance.TotalVotes);
        }

        public static void TestMultiThreadWithLazy()
        {
            IEnumerable<int> numbers = Enumerable.Range(0, 10);

            Parallel.ForEach(numbers, i =>
            {
                MachineMultiThreadLazy vm = MachineMultiThreadLazy.Instance;
                Console.WriteLine(vm.RegisterVote());
            });

            Console.WriteLine(MachineMultiThreadLazy.Instance.TotalVotes);
        }

        public static void TestMultiThreadWithLock()
        {
            IEnumerable<int> numbers = Enumerable.Range(0, 10);

            Parallel.ForEach(numbers, i =>
            {
                MachineMultiThreadLock vm = MachineMultiThreadLock.Instance;
                Console.WriteLine(vm.RegisterVote());
            });

            Console.WriteLine(MachineMultiThreadLock.Instance.TotalVotes);
        }


        static void Main(string[] args)
        {
            TestMultiThreadWithLock();
        }

    }
}
