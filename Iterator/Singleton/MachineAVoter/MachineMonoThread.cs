namespace MachineAVoter
{
    public sealed class MachineMonoThread
    {
        private static MachineMonoThread? _instance;
        private int _totalVotes = 0;

        private MachineMonoThread()
        {
        }

        public static MachineMonoThread Instance
        {
            get
            {
                if (_instance == null)
                {

                    _instance = new MachineMonoThread();
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
