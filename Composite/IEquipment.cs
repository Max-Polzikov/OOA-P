namespace Composite
{
    public interface IEquipment
    {
        string Name { get; }

        double Power();           
        decimal NetPrice();        
        decimal DiscountPrice();   
        void Add(IEquipment e);
        void Remove(IEquipment e);
    }
}
