namespace RentalSystem.Models
{
    public interface IContractable
    {
        bool IsEligible { get; }

        void MakeContract();
    }
}
