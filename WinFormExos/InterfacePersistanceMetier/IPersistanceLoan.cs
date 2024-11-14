
namespace InterfacePersistanceMetier
{
    public interface IPersistanceLoan
    {
        public void Add(StructLoan sClassMetier);
        public void Update(StructLoan sClassMetier);
        public StructLoan Load(int idToDisplay);
    }

}
