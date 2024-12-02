namespace MachineAVoter
{
    public class MachineMultiThreadEager
    {
        private static readonly MachineMultiThreadEager _instance = new MachineMultiThreadEager();
        private int _totalVotes = 0;

        static MachineMultiThreadEager()
        {
        }

        private MachineMultiThreadEager()
        {
        }

        public static MachineMultiThreadEager Instance
        {
            get
            {
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
