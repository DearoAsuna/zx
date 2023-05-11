using System;


namespace DiInterfers
{
    public interface IPhone
    {
        void Call();

        void Init231233(IPower iPower);
        IMicroPhone MinMicroPhone { set; get; }

        IPower Power { set; get; }
    }
}
