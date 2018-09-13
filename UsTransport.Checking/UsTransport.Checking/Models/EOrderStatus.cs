namespace UsTransport.Checking.Models
{
    public enum EOrderStatus
    {
    
        New = 0,
        PickedUp = 1,
        RejectPickup = 6,

        SendToVN = 2,
        WrongItem = 7,
        ProhibitedItem = 8,
        RejectSendToVN = 9,

        Good = 10,
        Damage = 11,
        Lost = 12,

        Delivering = 3,
        Delivered = 4,
        Failed = 5,


    
    }
}