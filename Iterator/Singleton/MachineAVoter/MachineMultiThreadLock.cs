namespace MachineAVoter
{
    public sealed class MachineMultiThreadLock
    {
        private static MachineMultiThreadLock? _instance;
        private int _totalVotes = 0;

        private static readonly object lockObj = new object();

        private MachineMultiThreadLock()
        {
        }

        public static MachineMultiThreadLock Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (lockObj)
                    {
                        if (_instance == null)
                        {
                            _instance = new MachineMultiThreadLock();
                        }
                    }
                }
                return _instance;
            }
        }

        public string RegisterVote()
        {
            _totalVotes += 1;
            return ("Registered Vote #" + _totalVotes);
        }

        public int TotalVotes
        {
            get
            {
                return _totalVotes;
            }
        }
    }
}
