namespace MachineAVoter
{
    public sealed class MachineMultiThreadLazy
    {
        private static readonly Lazy<MachineMultiThreadLazy> _instance = new Lazy<MachineMultiThreadLazy>(() => new MachineMultiThreadLazy());
        private int _totalVotes = 0;

        private MachineMultiThreadLazy()
        {
        }
        public static MachineMultiThreadLazy Instance
        {
            get
            {
                return _instance.Value;
            }
        }
        public string RegisterVote()
        {
            _totalVotes += 1;
            return "Registered Vote #" + _totalVotes;
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
